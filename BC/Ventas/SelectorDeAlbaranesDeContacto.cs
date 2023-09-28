using System;
using System.Collections.Generic;
using System.Text;
using BC;
using LT48;
using System.Data;
using System.Windows.Forms;

namespace BC.Ventas
{
    public class SelectorDeAlbaranesDeContacto : Selector
    {
        public delegate void DelegadoAlbaranSeleccionado(Albaran albaranSeleccionado);
        public event DelegadoAlbaranSeleccionado AlbaranSeleccionado;

        public Int32 idContactoFiltrar = -1;
        public bool mostrarSoloNoFacturados = false;
        public bool mostrarOpcionDeNuevoAlbaran = true;
        
        public bool eventoFormatingCreado = false;

        public bool form_cerrarTrasSeleccionar = false;



        /// <summary>
        /// No llamar: procedimiento interno
        /// </summary>
        public override void cargarGrid()
        {
            if (!eventoFormatingCreado)
            {
                w.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(grid_CellFormatting);
                eventoFormatingCreado = true;
            }
            _cargandoGrid = true;
            try
            {
                string txtFiltro = w.tb_filtro.Text.Trim();
                txtFiltro = LT48.Conversiones.quitarComillas(txtFiltro);

                string sql = "select a.idAlbaran, a.fecha, a.anio, a.numero, a.pvp, a.idFactura";
                sql += idContactoFiltrar != -1 ?
                    " from t_albaran a where a.idContacto=" + idContactoFiltrar :
                    ", b.razonSocial from t_albaran a left join t_contactos b on a.idContacto=b.idContacto where a.idContacto<>-1";

                if (mostrarSoloNoFacturados)
                    sql += " and a.idFactura=-1";
                if (txtFiltro != "")
                {
                    string sqlCond2 = ""; // " and observaciones like '%" + txtFiltro + "%'";

                    if (txtFiltro.IndexOf("/") > 0)
                    {
                        string[] separador = { "/" };
                        string[] partesNumAlbaran = txtFiltro.Split(separador, StringSplitOptions.RemoveEmptyEntries);
                        if (partesNumAlbaran.Length == 2)
                        {
                            string strAnio = partesNumAlbaran[0].Trim();
                            string strNumero = partesNumAlbaran[1].Trim();
                            if (LT48.Conversiones.esInt(strAnio) && LT48.Conversiones.esInt(strNumero))
                            {
                                sqlCond2 = " and a.anio=" + strAnio;
                                sqlCond2 += " and a.numero=" + strNumero;
                            }
                        }
                    }
                    else if (LT48.Conversiones.esInt(txtFiltro))
                    {
                        sqlCond2 = " and (a.anio=" + txtFiltro;
                        sqlCond2 += " or a.numero=" + txtFiltro;
                        sqlCond2 += ")";
                    }
                    else
                        sqlCond2 = " and b.razonSocial like '%" + txtFiltro + "%'";

                    sql += sqlCond2;
                }
                sql += " order by a.fecha desc, a.anio desc, a.numero desc";

                DataTable t;
                try { t = DB.getDataTable_CCP(sql); }
                catch (Exception ex) { Log.log("SelectorDeAlbaranesDeContacto.cargarGrid.Exception: " + ex.Message); t = null; }

                double suma = 0.0;
                Int32 numFilas = 0;
                if (t != null)
                {
                    int ordFecha = t.Columns["fecha"].Ordinal;
                    int ordImporte = t.Columns["pvp"].Ordinal;
                    t.Columns[ordFecha].MaxLength = 10;
                    foreach (DataRow r in t.Rows)
                    {
                        object[] o = r.ItemArray;
                        o[ordFecha] = LT48.Conversiones.fechaUniversal_to_fechaESP(o[ordFecha]);
                        r.ItemArray = o;
                        suma += Conversiones.toDouble(o[ordImporte]);
                    }
                    numFilas = t.Rows.Count;
                }

                if (mostrarOpcionDeNuevoAlbaran)
                {
                    object[] nuevo = { -1, "??/??/????", 0, 0, 0.0, -1 };

                    t.Columns["idAlbaran"].AllowDBNull = true;
                    t.Columns["anio"].AllowDBNull = true;
                    t.Columns["numero"].AllowDBNull = true;

                    t.Rows.InsertAt(t.NewRow(), 0);
                    t.Rows[0].ItemArray = nuevo;
                    //DataRow rNuevo = t.Rows.Add(nuevo);
                }

                w.grid.DataSource = t;

                string[] columnasOcultar = { "idAlbaran", "idFactura" };
                foreach (string columnaOcultar in columnasOcultar)
                    try { w.grid.Columns[columnaOcultar].Visible = false; }
                    catch { ;}

                BC.Comun.grid_tituloAnchoColumna(w.grid, "fecha", "Fecha", 100, Comun.AlineacionColumna.Centro);
                BC.Comun.grid_tituloAnchoColumna(w.grid, "anio", "Año", 75, Comun.AlineacionColumna.Derecha);
                BC.Comun.grid_tituloAnchoColumna(w.grid, "numero", "Num", 75, Comun.AlineacionColumna.Izquierda);
                if (idContactoFiltrar == -1)
                {
                    BC.Comun.grid_tituloAnchoColumna(w.grid, "pvp", "Importe", 100, Comun.AlineacionColumna.Derecha);
                    BC.Comun.grid_tituloColumna(w.grid, "razonSocial", "Contacto", Comun.AlineacionColumna.Izquierda);
                    w.grid.Columns["razonSocial"].DisplayIndex = 2;
                }
                else
                    BC.Comun.grid_tituloColumna(w.grid, "pvp", "Importe", Comun.AlineacionColumna.Derecha);

                if (w.grid.Rows.Count > 0)
                    w.grid.CurrentCell = w.grid.Rows[0].Cells["fecha"];

                w.tlp_resumen.Visible = true;
                w.l_resumen_numFilas.Text = numFilas + " filas";
                w.l_resumen_suma_titulo.Visible = true;
                w.l_resumen_suma_valor.Visible = true;
                w.l_resumen_suma_valor.Text = BC.Comun.currency_getValorFormateadoAsString(suma);
            }
            catch (Exception ex) { Log.log("SelectorDeAlbaranesDelContacto.cargarGrid.Exception: " + ex.Message); }
            _cargandoGrid = false;
        }

        void grid_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            DataGridViewRow fila = (DataGridViewRow)grid.Rows[e.RowIndex];
            string nombreColumna = grid.Columns[e.ColumnIndex].Name;
            if (fila != null)
            {
                if (nombreColumna == "fecha")
                {
                    if (e.Value.ToString() == "??/??/????")
                    {
                        e.Value = "Nuevo albarán";
                        fila.DefaultCellStyle.Font = new System.Drawing.Font(grid.DefaultCellStyle.Font, System.Drawing.FontStyle.Bold);
                        fila.DefaultCellStyle.ForeColor = System.Drawing.Color.Green;
                        fila.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.PaleGreen;
                    }
                }
                else if (nombreColumna == "pvp")
                    e.Value = BC.Comun.currency_getValorFormateadoAsString(Conversiones.toDouble(e.Value));
            }
        }

        /// <summary>
        /// No llamar: procedimiento interno
        /// </summary>
        public override void seleccionar()
        {
            if (w.grid.CurrentRow != null)
            {
                Int32 idAlbaran = LT48.Conversiones.toIntWN(w.grid.CurrentRow.Cells["idAlbaran"].Value);
                Albaran albaran = new Albaran(idAlbaran);
                if (albaran.getIdContacto() == -1)
                    albaran.setIdContacto(idContactoFiltrar);
                try { AlbaranSeleccionado(albaran); }
                catch { ;}

                if (form_cerrarTrasSeleccionar)
                    w.Close();
            }
        }

        public override void EventoInterfazComunDetectado(string strSolicitud, object parametro)
        {
            if (strSolicitud == "FormAlbaran_FormClosed")
            {
                cargarGrid();
                bool encontrado = false;
                Int32 i = 0;
                Int32 numFilas = w.grid.Rows.Count;
                while (i < numFilas && !encontrado)
                {
                    encontrado = Conversiones.toInt(w.grid.Rows[i].Cells["idAlbaran"].Value) == ((Albaran)parametro).getIdAlbaran();
                    if (!encontrado)
                        i++;
                }
                if (encontrado)
                    try { w.grid.CurrentCell = w.grid.Rows[i].Cells["fecha"]; }
                    catch { ;}
            }
        }






        public static void FormSelectorDeAlbaranes_Show()
        {
            BC.Ventas.SelectorDeAlbaranesDeContacto ws = new BC.Ventas.SelectorDeAlbaranesDeContacto();
            ws.idContactoFiltrar = -1;
            ws.AlbaranSeleccionado += new BC.Ventas.SelectorDeAlbaranesDeContacto.DelegadoAlbaranSeleccionado(ws_AlbaranSeleccionado);
            ws.form_porcAlto = 80;
            ws.form_porcAncho = 80;
            ws.mostrarOpcionDeNuevoAlbaran = false;
            ws.form_Text = "Albaranes del contacto";
            ws.Show();
        }

        static void ws_AlbaranSeleccionado(BC.Ventas.Albaran albaranSeleccionado)
        {
            BC.Comun.GeneraEnvioAInterfazComun("abrir_albaran", albaranSeleccionado);
        }

    } // end class
} // end namespace
