using System;
using System.Collections.Generic;
using System.Text;
using BC;
using LT48;
using System.Data;
using System.Windows.Forms;

namespace BC.Ventas
{
    public class SelectorDeFacturasDeContacto : Selector
    {
        public delegate void DelegadoFacturaSeleccionada(Factura facturaSeleccionada);
        public event DelegadoFacturaSeleccionada FacturaSeleccionada;

        public Int32 idContactoFiltrar = -1;
        public bool form_mostrarOpcionDeNuevaFactura = true;
        public bool form_cerrarTrasSeleccionar = false;
        
        public bool eventoFormatingCreado = false;



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

                string sql = "select a.idFactura, a.fecha, a.anio, a.numero, a.pvp";
                if (idContactoFiltrar != -1)
                    sql += " from t_factura a where idContacto=" + idContactoFiltrar;
                else
                    sql += ", b.razonSocial from t_factura a left join t_contactos b on a.idContacto=b.idContacto where a.idContacto<>-1";

                if (txtFiltro != "")
                {
                    string sqlCond2 = ""; // " and observaciones like '%" + txtFiltro + "%'";

                    if (txtFiltro.IndexOf("/") > 0)
                    {
                        string[] separador = { "/" };
                        string[] partesNumFactura = txtFiltro.Split(separador, StringSplitOptions.RemoveEmptyEntries);
                        if (partesNumFactura.Length == 2)
                        {
                            string strAnio = partesNumFactura[0].Trim();
                            string strNumero = partesNumFactura[1].Trim();
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
                catch (Exception ex) { Log.log("SelectorDeFacturasDeContacto.cargarGrid.Exception: " + ex.Message); t = null; }

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

                if (form_mostrarOpcionDeNuevaFactura)
                {
                    object[] nuevo = { -1, "??/??/????", 0, 0, 0.0 };

                    t.Columns["idFactura"].AllowDBNull = true;
                    t.Columns["anio"].AllowDBNull = true;
                    t.Columns["numero"].AllowDBNull = true;

                    t.Rows.InsertAt(t.NewRow(), 0);
                    t.Rows[0].ItemArray = nuevo;
                }

                w.grid.DataSource = t;

                string[] columnasOcultar = { "idFactura" };
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
            catch { ;}
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
                        e.Value = "Nueva factura";
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
                Int32 idFactura = LT48.Conversiones.toIntWN(w.grid.CurrentRow.Cells["idFactura"].Value);
                Factura factura = new Factura(idFactura);
                if (factura.getIdContacto() == -1)
                    factura.setIdContacto(idContactoFiltrar);
                try { FacturaSeleccionada(factura); }
                catch { ;}

                if (form_cerrarTrasSeleccionar)
                    w.Close();
            }
        }

        public override void EventoInterfazComunDetectado(string strSolicitud, object parametro)
        {
            if (strSolicitud == "FormFactura_FormClosed")
            {
                cargarGrid();
                bool encontrado = false;
                Int32 i = 0;
                Int32 numFilas = w.grid.Rows.Count;
                while (i < numFilas && !encontrado)
                {
                    encontrado = Conversiones.toInt(w.grid.Rows[i].Cells["idFactura"].Value) == ((Factura)parametro).getIdFactura();
                    if (!encontrado)
                        i++;
                }
                if (encontrado)
                    try { w.grid.CurrentCell = w.grid.Rows[i].Cells["fecha"]; }
                    catch { ;}
            }
        }






        public static void FormSelectorDeFacturas_Show()
        {
            BC.Ventas.SelectorDeFacturasDeContacto wf = new BC.Ventas.SelectorDeFacturasDeContacto();
            wf.idContactoFiltrar = -1;
            wf.FacturaSeleccionada += new BC.Ventas.SelectorDeFacturasDeContacto.DelegadoFacturaSeleccionada(wf_FacturaSeleccionada);
            wf.form_porcAlto = 80;
            wf.form_porcAncho = 80;
            wf.form_mostrarOpcionDeNuevaFactura = false;
            wf.form_Text = "Facturas";
            wf.Show();
        }

        static void wf_FacturaSeleccionada(BC.Ventas.Factura facturaSeleccionada)
        {
            BC.Comun.GeneraEnvioAInterfazComun("abrir_factura", facturaSeleccionada);
        }

    } // end class
} // end namespace
