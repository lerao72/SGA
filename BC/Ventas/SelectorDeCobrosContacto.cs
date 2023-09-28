using System;
using System.Collections.Generic;
using System.Text;
using BC;
using LT48;
using System.Data;
using System.Windows.Forms;

namespace BC.Ventas
{
    public class SelectorDeCobrosContacto : Selector
    {
        public delegate void DelegadoCobroSeleccionado(Cobro cobroSeleccionado);
        public event DelegadoCobroSeleccionado CobroSeleccionado;

        /// <summary>
        /// Cuando idContactoFiltrar es -1, muestra los nombres de los contactos
        /// </summary>
        public Int32 idContactoFiltrar = -1;
        public Int32 idFacturaFiltrar = -1;
        public bool form_mostrarOpcionDeNuevoCobro = true;
        public bool form_cerrarTrasSeleccionar = false;
        
        private bool eventoFormatingCreado = false;



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

                string sql = "select a.idCobro, a.fechaPrevista, a.fechaReal, a.descripcion, a.importe";
                sql += ", c.anio, c.numero";
                
                // Añado el if para poder utilizar el selector como genérico.
                if (idContactoFiltrar != -1)
                    sql += " from t_cobro a left join t_factura c on a.idFactura=c.idFactura where a.idContacto=" + idContactoFiltrar;
                else
                {
                    sql += ", b.razonSocial from (t_cobro a left join t_factura c on a.idFactura=c.idFactura)";
                    sql += " left join t_contactos b on a.idContacto=b.idContacto where a.idContacto<>-1";
                }

                if (idFacturaFiltrar != -1)
                    sql += " and a.idFactura=" + idFacturaFiltrar;

                if (txtFiltro != "")
                {
                    string sqlCond2 = ""; // " and observaciones like '%" + txtFiltro + "%'";

                    if (txtFiltro != "")
                    {
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
                                    sqlCond2 = " and c.anio=" + strAnio;
                                    sqlCond2 += " and c.numero=" + strNumero;
                                }
                            } // if (partesNumFactura...
                        }
                        else if (LT48.Conversiones.esInt(txtFiltro))
                        {
                            sqlCond2 = " and (c.anio=" + txtFiltro;
                            sqlCond2 += " or c.numero=" + txtFiltro + ")";
                        }
                        else
                        {
                            sqlCond2 = " and (a.descripcion like '%" + txtFiltro + "%'";
                            if (idContactoFiltrar == -1)
                                sqlCond2 += " or b.razonSocial like '%" + txtFiltro + "%'";
                            sqlCond2 += ")";
                        }
                    }
                    sql += sqlCond2;
                }

                if (form_usarFiltroFecha && w.cb_usar_filtro_fecha.Checked)
                {
                    sql += " and a.fechaPrevista>='" + w.dtp_f_desde.Value.ToString("yyyyMMdd") + "'";
                    sql += " and a.fechaPrevista<='" + w.dtp_f_hasta.Value.ToString("yyyyMMdd") + "'";
                }

                if (form_usarFiltroComboA && w.cb_f_combo1.Text != "Cualquiera")
                {
                    if (w.cb_f_combo1.Text == "Si")
                        sql += " and a.fechaReal<>'' and a.fechaReal<>'IMPAGO'";
                    else if (w.cb_f_combo1.Text.ToUpper() == "IMPAGOS")
                        sql += " and a.fechaReal='IMPAGO'";
                    else
                        sql += " and a.fechaReal=''";
                }

                sql += " order by a.fechaPrevista asc, a.idCobro asc";

                DataTable t;
                try { t = DB.getDataTable_CCP(sql); }
                catch (Exception ex) { Log.log("SelectorDeCobrosContacto.cargarGrid.Exception: " + ex.Message); t = null; }

                double suma = 0.0;
                Int32 numFilas = 0;
                if (t != null)
                {
                    int ordFechaPrevista = t.Columns["fechaPrevista"].Ordinal;
                    int ordImporte = t.Columns["importe"].Ordinal;
                    try { t.Columns[ordFechaPrevista].MaxLength = 10; }
                    catch { ;}
                    foreach (DataRow r in t.Rows)
                    {
                        object[] o = r.ItemArray;
                        o[ordFechaPrevista] = LT48.Conversiones.fechaUniversal_to_fechaESP(o[ordFechaPrevista]);
                        r.ItemArray = o;
                        suma += Conversiones.toDouble(o[ordImporte]);
                    }
                    numFilas = t.Rows.Count;
                }

                if (form_mostrarOpcionDeNuevoCobro)
                {
                    object[] nuevo = { -1, "??/??/????", "", "", 0.0, 0, 0 };

                    t.Columns["idCobro"].AllowDBNull = true;

                    t.Rows.InsertAt(t.NewRow(), 0);
                    t.Rows[0].ItemArray = nuevo;
                }

                t.Columns.Add("numFactura", typeof(string));

                w.grid.DataSource = t;

                string[] columnasOcultar = { "idCobro", "fechaReal", "anio", "numero" };
                foreach (string columnaOcultar in columnasOcultar)
                    try { w.grid.Columns[columnaOcultar].Visible = false; }
                    catch { ;}

                BC.Comun.grid_tituloAnchoColumna(w.grid, "fechaPrevista", "Fecha", 100, Comun.AlineacionColumna.Centro);
                BC.Comun.grid_tituloAnchoColumna(w.grid, "tipo", "Tipo", 100, Comun.AlineacionColumna.Izquierda);
                BC.Comun.grid_tituloColumna(w.grid, "descripcion", "Descripcion", Comun.AlineacionColumna.Izquierda);
                BC.Comun.grid_tituloAnchoColumna(w.grid, "importe", "Importe", 100, Comun.AlineacionColumna.Derecha);
                if (idContactoFiltrar == -1)
                {
                    BC.Comun.grid_tituloColumna(w.grid, "razonSocial", "Contacto", Comun.AlineacionColumna.Izquierda);
                    w.grid.Columns["razonSocial"].DisplayIndex = 2;
                }
                BC.Comun.grid_tituloAnchoColumna(w.grid, "numFactura", "Factura", 100, Comun.AlineacionColumna.Centro);
                w.grid.Columns["numFactura"].DisplayIndex = 2;

                if (w.grid.Rows.Count > 0)
                    w.grid.CurrentCell = w.grid.Rows[0].Cells["fechaPrevista"];

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
                if (nombreColumna == "fechaPrevista")
                {
                    if (e.Value.ToString() == "??/??/????")
                    {
                        e.Value = "Nuevo cobro";
                        fila.DefaultCellStyle.Font = new System.Drawing.Font(grid.DefaultCellStyle.Font, System.Drawing.FontStyle.Bold);
                        fila.DefaultCellStyle.ForeColor = System.Drawing.Color.Green;
                        fila.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.PaleGreen;
                    }
                    if (fila.Cells["fechaReal"].Value.ToString() != "" && fila.Cells["fechaReal"].Value.ToString() != "IMPAGO")
                        fila.DefaultCellStyle.Font = new System.Drawing.Font(grid.Font, System.Drawing.FontStyle.Strikeout);

                    if (fila.Cells["fechaReal"].Value.ToString() == "IMPAGO")
                    {
                        fila.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                        fila.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (nombreColumna == "numFactura")
                {
                    if (e.Value.ToString() == "")
                        e.Value = fila.Cells["anio"].Value.ToString() + "/" + fila.Cells["numero"].Value.ToString();
                }
                else if (nombreColumna == "importe")
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
                Int32 idCobro = LT48.Conversiones.toIntWN(w.grid.CurrentRow.Cells["idCobro"].Value);
                Cobro cobro = new Cobro(idCobro);
                if (cobro.getIdContacto() == -1)
                    cobro.setIdContacto(idContactoFiltrar);
                try { CobroSeleccionado(cobro); }
                catch { ;}

                if (form_cerrarTrasSeleccionar)
                    w.Close();
            }
        }

        public override void EventoInterfazComunDetectado(string strSolicitud, object parametro)
        {
            if (strSolicitud == "FormCobro_FormClosed")
            {
                cargarGrid();
                bool encontrado = false;
                Int32 i = 0;
                Int32 numFilas = w.grid.Rows.Count;
                while (i < numFilas && !encontrado)
                {
                    encontrado = Conversiones.toInt(w.grid.Rows[i].Cells["idCobro"].Value) == ((Cobro)parametro).getIdCobro();
                    if (!encontrado)
                        i++;
                }
                if (encontrado)
                    try { w.grid.CurrentCell = w.grid.Rows[i].Cells["fechaPrevista"]; }
                    catch { ;}
            }
        }






        public static void FormSelectorDeCobrosGenerico_Show()
        {
            BC.Ventas.SelectorDeCobrosContacto wcc = new BC.Ventas.SelectorDeCobrosContacto();
            wcc.idContactoFiltrar = -1;
            wcc.form_mostrarOpcionDeNuevoCobro = false;
            wcc.CobroSeleccionado += new BC.Ventas.SelectorDeCobrosContacto.DelegadoCobroSeleccionado(wcc_CobroSeleccionado);
            wcc.form_porcAlto = 80;
            wcc.form_porcAncho = 90;
            wcc.form_Text = "Cobros del contacto";

            wcc.form_usarFiltroFecha = true;
            DateTime esteMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            wcc.form_filtro_dtp_desde.Value = esteMes;
            wcc.form_filtro_dtp_hasta.Value = esteMes.AddMonths(1);
            wcc.form_filtro_cb_usar_filtro_fecha.Checked = true;

            wcc.form_usarFiltroComboA = true;
            wcc.form_filtroComboA_titulo = "Cobrados:";
            wcc.form_filtroComboA_cb.Items.Add("Cualquiera");
            wcc.form_filtroComboA_cb.Items.Add("Si");
            wcc.form_filtroComboA_cb.Items.Add("No");
            wcc.form_filtroComboA_cb.Items.Add("Impagos");
            wcc.form_filtroComboA_cb.Text = "No";

            wcc.Show();
        }

        static void wcc_CobroSeleccionado(BC.Ventas.Cobro cobroSeleccionado)
        {
            BC.Comun.GeneraEnvioAInterfazComun("abrir_cobro", cobroSeleccionado);
        }

    } // end class
} // end namespace
