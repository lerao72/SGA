using System;
using System.Collections.Generic;
using System.Text;
using LT48;
using System.Data;
using System.Windows.Forms;

namespace BC.Varios
{
    public class SelectorDeRecordatorios : Selector
    {
        public delegate void DelegadoRecordatorioSeleccionado(Recordatorio recordatorioSeleccionado);
        public event DelegadoRecordatorioSeleccionado RecordatorioSeleccionado;

        /// <summary>
        /// Condicidión adicional que ha de ser del tipo " and idContacto not in (select idContacto from condición)"
        /// </summary>
        public string sqlCondNotIn = "";

        public bool form_mostrarOpcionDeNuevoRecordatorio = true;
        public bool form_cerrarTrasSeleccionar = false;

        public int form_filtrarATipo_tipo = -1;
        public int form_filtrarATipo_idVinculado = -1;

        private bool eventoFormatingCreado = false;


        
        /// <summary>
        /// No llamar: procedimiento interno
        /// </summary>
        public override void cargarGrid()
        {
            _cargandoGrid = true;

            if (!eventoFormatingCreado)
            {
                w.grid.CellFormatting +=new DataGridViewCellFormattingEventHandler(grid_CellFormatting);
                eventoFormatingCreado = true;
            }

            try
            {
                string txtFiltro = w.tb_filtro.Text.Trim();
                txtFiltro = LT48.Conversiones.quitarComillas(txtFiltro);

                string sql = "select idRecordatorio, fecha, tarea from t_recordatorio";
                string woa = " where";
                if (form_filtrarATipo_tipo != -1)
                {
                    sql += woa + " tipoVinculado=" + form_filtrarATipo_tipo;
                    sql += " and idVinculado=" + form_filtrarATipo_idVinculado;
                    woa = " and";
                }
                if (txtFiltro != "")
                {
                    sql += woa + " tarea like '%" + txtFiltro + "%'";
                    woa = " and";
                }
                if (w.cb_usar_filtro_fecha.Checked)
                {
                    sql += woa + " (fecha>='" + w.dtp_f_desde.Value.ToString("yyyyMMdd") + "'";
                    sql += " and fecha<='" + w.dtp_f_hasta.Value.ToString("yyyyMMdd") + "')";
                    woa = " and";
                }
                if (sqlCondNotIn != "")
                    sql += sqlCondNotIn;

                sql += " order by fecha asc, hora asc";

                DataTable t;
                try { t = DB.getDataTable_CCP(sql); }
                catch (Exception ex) { Log.log("SelectorDeRecordatorios.cargarGrid.Exception: " + ex.Message); t = null; }

                if (t != null)
                {
                    if (form_mostrarOpcionDeNuevoRecordatorio)
                    {
                        object[] nuevo = { -1, "", "Nuevo apunte de agenda" };

                        t.Columns["idRecordatorio"].AllowDBNull = true;

                        t.Rows.InsertAt(t.NewRow(), 0);
                        t.Rows[0].ItemArray = nuevo;
                    }

                    w.grid.DataSource = t;

                    try { w.grid.Columns["idRecordatorio"].Visible = false; }
                    catch { ;}

                    BC.Comun.grid_tituloAnchoColumna(w.grid, "fecha", "Fecha", 100, Comun.AlineacionColumna.Centro);
                    BC.Comun.grid_tituloColumna(w.grid, "tarea", "Tarea");

                    if (w.grid.Rows.Count > 0)
                        w.grid.CurrentCell = w.grid.Rows[0].Cells["tarea"];
                }
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
                    if (e.Value.ToString() != "" && e.Value.ToString().IndexOf("/") < 0)
                        e.Value = Conversiones.fechaUniversal_to_fechaESP(e.Value);
                    else
                    {
                        fila.DefaultCellStyle.Font = new System.Drawing.Font(grid.DefaultCellStyle.Font, System.Drawing.FontStyle.Bold);
                        fila.DefaultCellStyle.ForeColor = System.Drawing.Color.Green;
                        fila.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.PaleGreen;
                    }
                }// if (nombreColumna == "fecha"
            } // if (fila != null
        }

        /// <summary>
        /// No llamar: procedimiento interno
        /// </summary>
        public override void seleccionar()
        {
            if (w.grid.CurrentRow != null)
            {
                Int32 idRecordatorio = LT48.Conversiones.toIntWN(w.grid.CurrentRow.Cells["idRecordatorio"].Value);
                Recordatorio recordatorio = new Recordatorio(idRecordatorio);

                if (form_filtrarATipo_tipo != -1)
                {
                    recordatorio.setTipoVinculado(form_filtrarATipo_tipo);
                    recordatorio.setIdVinculado(form_filtrarATipo_idVinculado);
                }

                try { RecordatorioSeleccionado(recordatorio); }
                catch { ;}

                if (form_cerrarTrasSeleccionar)
                    w.Close();
            }
        }

        public override void EventoInterfazComunDetectado(string strSolicitud, object parametro)
        {
            if (strSolicitud == "FormRecordatorio_FormClosed")
            {
                cargarGrid();
                bool encontrado = false;
                Int32 i = 0;
                Int32 numFilas = w.grid.Rows.Count;
                while (i < numFilas && !encontrado)
                {
                    encontrado = Conversiones.toInt(w.grid.Rows[i].Cells["idRecordatorio"].Value) == ((Recordatorio)parametro).getIdRecordatorio();
                    if (!encontrado)
                        i++;
                }
                if (encontrado)
                    try { w.grid.CurrentCell = w.grid.Rows[i].Cells["tarea"]; }
                    catch { ;}
            }

        }






        public static void FormSelectorDeRecordatoriosGenerico_Show()
        {
            BC.Varios.SelectorDeRecordatorios w = new BC.Varios.SelectorDeRecordatorios();
            w.form_usarFiltroFecha = true;
            w.form_porcAlto = 50;
            w.form_porcAncho = 80;
            w.RecordatorioSeleccionado += new BC.Varios.SelectorDeRecordatorios.DelegadoRecordatorioSeleccionado(w_RecordatorioSeleccionado);

            w.Show();
        }

        public static void FormSelectorDeRecordatoriosContactos_Show(Int32 idContacto)
        {
            BC.Varios.SelectorDeRecordatorios w = new BC.Varios.SelectorDeRecordatorios();
            w.form_usarFiltroFecha = true;
            w.form_porcAlto = 50;
            w.form_porcAncho = 80;

            w.form_filtrarATipo_tipo = (int)BC.Varios.Recordatorio.Tipo.Contacto;
            w.form_filtrarATipo_idVinculado = idContacto;
            
            w.RecordatorioSeleccionado += new BC.Varios.SelectorDeRecordatorios.DelegadoRecordatorioSeleccionado(w_RecordatorioSeleccionado);

            w.Show();
        }

        static void w_RecordatorioSeleccionado(BC.Varios.Recordatorio recordatorioSeleccionado)
        {
            BC.Comun.GeneraEnvioAInterfazComun("abrir_recordatorio", recordatorioSeleccionado);
        }

    } // end class
}
