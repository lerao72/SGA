using System;
using System.Collections.Generic;
using System.Text;
using BC;
using LT48;
using System.Data;
using System.Windows.Forms;

namespace BC.Compras
{
    public class SelectorDePagosContacto : Selector
    {
        public delegate void DelegadoPagoSeleccionado(Pago pagoSeleccionado);
        public event DelegadoPagoSeleccionado PagoSeleccionado;

        /// <summary>
        /// Cuando idContactoFiltrar es -1, muestra los nombres de los contactos
        /// </summary>
        public Int32 idContactoFiltrar = -1;
        public bool form_mostrarOpcionDeNuevoPago = true;
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

                string sql = "select a.idPago, a.fechaPrevista, a.fechaReal, a.tipo, a.descripcion, a.importe";
                
                // Añado el if para poder utilizar el selector como genérico.
                if (idContactoFiltrar != -1)
                    sql += " from t_pago a where a.idContacto=" + idContactoFiltrar;
                else
                    sql += ", b.razonSocial from t_pago a left join t_contactos b on a.idContacto=b.idContacto where a.idContacto<>-1";

                if (txtFiltro != "")
                {
                    string sqlCond2 = ""; // " and observaciones like '%" + txtFiltro + "%'";

                    if (txtFiltro != "")
                    {
                        sqlCond2 = " and (a.descripcion like '%" + txtFiltro + "%'";
                        if (idContactoFiltrar == -1)
                            sqlCond2 += " or b.razonSocial like '%" + txtFiltro + "%'";
                        sqlCond2 += ")";
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
                        sql += " and a.fechaReal<>''";
                    else
                        sql += " and a.fechaReal=''";
                }

                sql += " order by a.fechaPrevista asc, a.idPago asc";

                DataTable t;
                try { t = DB.getDataTable_CCP(sql); }
                catch (Exception ex) { Log.log("SelectorDePagosAContacto.cargarGrid.Exception: " + ex.Message); t = null; }

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

                if (form_mostrarOpcionDeNuevoPago)
                {
                    object[] nuevo = { -1, "??/??/????", "", "", "", 0.0 };

                    t.Columns["idPago"].AllowDBNull = true;
                                        
                    t.Rows.InsertAt(t.NewRow(), 0);
                    t.Rows[0].ItemArray = nuevo;
                }

                w.grid.DataSource = t;

                string[] columnasOcultar = { "idPago", "fechaReal" };
                foreach (string columnaOcultar in columnasOcultar)
                    try { w.grid.Columns[columnaOcultar].Visible = false; }
                    catch { ;}

                BC.Comun.grid_tituloAnchoColumna(w.grid, "fechaPrevista", "Fecha", 100, Comun.AlineacionColumna.Centro);
                BC.Comun.grid_tituloAnchoColumna(w.grid, "tipo", "Tipo", 100, Comun.AlineacionColumna.Izquierda);
                BC.Comun.grid_tituloColumna(w.grid, "descripcion", "Pago", Comun.AlineacionColumna.Izquierda);
                BC.Comun.grid_tituloAnchoColumna(w.grid, "importe", "Importe", 100, Comun.AlineacionColumna.Derecha);
                if (idContactoFiltrar == -1)
                {
                    BC.Comun.grid_tituloColumna(w.grid, "razonSocial", "Contacto", Comun.AlineacionColumna.Izquierda);
                    w.grid.Columns["razonSocial"].DisplayIndex = 2;
                }

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
                        e.Value = "Nuevo pago";
                        fila.DefaultCellStyle.Font = new System.Drawing.Font(grid.DefaultCellStyle.Font, System.Drawing.FontStyle.Bold);
                        fila.DefaultCellStyle.ForeColor = System.Drawing.Color.Green;
                        fila.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.PaleGreen;
                    }
                    if (fila.Cells["fechaReal"].Value.ToString() != "")
                        fila.DefaultCellStyle.Font = new System.Drawing.Font(grid.Font, System.Drawing.FontStyle.Strikeout);
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
                Int32 idPago = LT48.Conversiones.toIntWN(w.grid.CurrentRow.Cells["idPago"].Value);
                Pago pago = new Pago(idPago);
                if (pago.getIdContacto() == -1)
                    pago.setIdContacto(idContactoFiltrar);
                try { PagoSeleccionado(pago); }
                catch { ;}

                if (form_cerrarTrasSeleccionar)
                    w.Close();
            }
        }

        public override void EventoInterfazComunDetectado(string strSolicitud, object parametro)
        {
            if (strSolicitud == "FormPago_FormClosed")
            {
                cargarGrid();
                bool encontrado = false;
                Int32 i = 0;
                Int32 numFilas = w.grid.Rows.Count;
                while (i < numFilas && !encontrado)
                {
                    encontrado = Conversiones.toInt(w.grid.Rows[i].Cells["idPago"].Value) == ((Pago)parametro).getIdPago();
                    if (!encontrado)
                        i++;
                }
                if (encontrado)
                    try { w.grid.CurrentCell = w.grid.Rows[i].Cells["fechaPrevista"]; }
                    catch { ;}
            }
        }






        public static void FormSelectorDePagosGenerico_Show()
        {
            BC.Compras.SelectorDePagosContacto wpc = new BC.Compras.SelectorDePagosContacto();
            wpc.idContactoFiltrar = -1;
            wpc.form_mostrarOpcionDeNuevoPago = false;
            wpc.PagoSeleccionado += new BC.Compras.SelectorDePagosContacto.DelegadoPagoSeleccionado(wpc_PagoSeleccionado);
            wpc.form_porcAlto = 80;
            wpc.form_porcAncho = 90;
            wpc.form_Text = "Pagos al contacto";

            wpc.form_usarFiltroFecha = true;
            DateTime esteMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            wpc.form_filtro_dtp_desde.Value = esteMes;
            wpc.form_filtro_dtp_hasta.Value = esteMes.AddMonths(1);
            wpc.form_filtro_cb_usar_filtro_fecha.Checked = true;

            wpc.form_usarFiltroComboA = true;
            wpc.form_filtroComboA_titulo = "Pagados:";
            wpc.form_filtroComboA_cb.Items.Add("Cualquiera");
            wpc.form_filtroComboA_cb.Items.Add("Si");
            wpc.form_filtroComboA_cb.Items.Add("No");
            wpc.form_filtroComboA_cb.Text = "No";

            wpc.Show();
        }

        static void wpc_PagoSeleccionado(BC.Compras.Pago pagoSeleccionado)
        {
            BC.Comun.GeneraEnvioAInterfazComun("abrir_pago", pagoSeleccionado);
        }

    } // end class
} // end namespace
