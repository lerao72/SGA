using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BC
{
    /// <summary>
    /// Este fichero contiene FormSelectorGrid que proporcionar la interfaz visual y 
    /// luego Selector que actuará como clase padre para distintos selectores simplemente
    /// teniendo que redefinir los procedimientos cargarGrid y seleccionar (que deberán 
    /// colocarse como override)
    /// </summary>
    
    public partial class FormSelectorGrid : Form
    {
        public DataGridView _grid { get { return grid; } }
        public Button _b_seleccionar { get { return b_seleccionar; } }
        public Button _b_filtro { get { return b_filtro; } }
        public TextBox _tb_filtro { get { return tb_filtro; } }
        public Timer _t_filtro { get { return t_filtro; } }

        public FormSelectorGrid()
        {
            InitializeComponent();
        }

        private void FormSelectorGrid_Shown(object sender, EventArgs e)
        {
            tb_filtro.Focus();
        }

        private void miExportarACSV_Click(object sender, EventArgs e)
        {
            BC.Comun.guardaCSV_From_DataGridView(grid, this.Text + ".csv");
        }

        private void l_resumen_numFilas_TextChanged(object sender, EventArgs e)
        {
            l_resumen_numFilas.Visible = l_resumen_numFilas.Text != "l_numFilas";
        }

    } // end class



    public class Selector
    {
        protected FormSelectorGrid w = new FormSelectorGrid();

        public int form_porcAncho = 50;
        public int form_porcAlto = 30;

        public string form_Text = "";

        public bool form_usarFiltroFecha = false;
        public DateTimePicker form_filtro_dtp_desde
        {
            get { return w.dtp_f_desde; }
            set { w.dtp_f_desde = value; }
        }
        public DateTimePicker form_filtro_dtp_hasta
        {
            get { return w.dtp_f_hasta; }
            set { w.dtp_f_hasta = value; }
        }
        public CheckBox form_filtro_cb_usar_filtro_fecha
        {
            get { return w.cb_usar_filtro_fecha; }
            set { w.cb_usar_filtro_fecha = value; }
        }

        public bool form_usarFiltroComboA = false;
        public bool form_usarFiltroComboB = false;
        public string form_filtroComboA_titulo
        {
            get { return w.l_f_comboA.Text; }
            set { w.l_f_comboA.Text = value; }
        }
        public string form_filtroComboB_titulo
        {
            get { return w.l_f_comboB.Text; }
            set { w.l_f_comboB.Text = value; }
        }
        public ComboBox form_filtroComboA_cb
        {
            get { return w.cb_f_combo1; }
            set { w.cb_f_combo1 = value; }
        }
        public ComboBox form_filtroComboB_cb
        {
            get { return w.cb_f_combo2; }
            set { w.cb_f_combo2 = value; }
        }

        public bool form_mostrarPanelResumen = false;
        public Label form_label_resumen_numFilas
        {
            get { return w.l_resumen_numFilas; }
            set { w.l_resumen_numFilas = value; }
        }
        public Label form_label_resumen_suma_titulo
        {
            get { return w.l_resumen_suma_titulo; }
            set { w.l_resumen_suma_titulo = value; }
        }
        public Label form_label_resumen_suma_valor
        {
            get { return w.l_resumen_suma_valor; }
            set { w.l_resumen_suma_valor = value; }
        }

        private Comun.DelegadoInterfazComun eventoIC;



        public void Show()
        {
            //w = new FormSelectorGrid();
            w.Text = form_Text;

            if (form_usarFiltroFecha)
                w.tlp_fitroFecha.Visible = true;

            w.Load += new EventHandler(w_Load);
            w.FormClosed += new FormClosedEventHandler(w_FormClosed);
            w.tb_filtro.TextChanged += new EventHandler(tb_filtro_TextChanged);
            w.t_filtro.Tick += new EventHandler(t_filtro_Tick);
            w.b_seleccionar.Click += new EventHandler(b_seleccionar_Click);
            w.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(grid_CellDoubleClick);
            w.b_filtro.Click += new EventHandler(b_filtro_Click);

            if (form_usarFiltroFecha)
            {
                w.tlp_fitroFecha.Visible = true;

                w.dtp_f_desde.ValueChanged += new EventHandler(dtp_f_fecha_ValueChanged);
                w.dtp_f_hasta.ValueChanged += new EventHandler(dtp_f_fecha_ValueChanged);
                w.cb_usar_filtro_fecha.CheckedChanged += new EventHandler(b_filtro_Click);
            }
            if (form_usarFiltroComboA)
            {
                w.tlp_f_comboA.Visible = true;
                w.cb_f_combo1.SelectedIndexChanged += new EventHandler(b_filtro_Click);
            }

            if (form_usarFiltroComboB)
            {
                w.tlp_f_comboB.Visible = true;
                w.cb_f_combo2.SelectedIndexChanged += new EventHandler(b_filtro_Click);
            }

            if (form_mostrarPanelResumen)
                w.tlp_resumen.Visible = true;

            eventoIC = new Comun.DelegadoInterfazComun(Comun_EnvioAInterfazComun);
            BC.Comun.EnvioAInterfazComun += eventoIC;

            w.ShowDialog();
        }

        void dtp_f_fecha_ValueChanged(object sender, EventArgs e)
        {
            if (w.cb_usar_filtro_fecha.Checked)
                b_filtro_Click(null, null);
        }

        private void w_Load(object sender, EventArgs e)
        {
            cargarGrid();
            BC.Comun.Form_ajustaTamanioYCentraForm(w, form_porcAncho, form_porcAlto);
        }

        private void w_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { BC.Comun.EnvioAInterfazComun -= eventoIC; }
            catch { ;}
        }

        private void Comun_EnvioAInterfazComun(string strSolicitud, object parametro)
        {
            try { EventoInterfazComunDetectado(strSolicitud, parametro); }
            catch { ;}
        }

        private void b_filtro_Click(object sender, EventArgs e)
        {
            w.t_filtro.Enabled = false;
            _teclaPulsada = false;
            cargarGrid();
        }

        private void b_seleccionar_Click(object sender, EventArgs e)
        {
            seleccionar();
        }

        private void grid_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            seleccionar();
        }

        private bool _teclaPulsada = false;
        private void t_filtro_Tick(object sender, EventArgs e)
        {
            if (!_cargandoGrid)
            {
                if (!_teclaPulsada)
                {
                    w.t_filtro.Enabled = false;

                    string txtFiltro = w.tb_filtro.Text.Trim();
                    ////if (txtFiltro.Length < 5)
                    ////    BC.Comun.grid_buscadorEnGridPorPosicionamiento(txtFiltro, w.grid);
                    ////else
                        cargarGrid();
                }
                _teclaPulsada = false;
            }
        }

        private void tb_filtro_TextChanged(object sender, EventArgs e)
        {
            _teclaPulsada = true;
            w.t_filtro.Enabled = true;
        }






        #region Procedimientos

        public bool _cargandoGrid = false;
        public virtual void cargarGrid()
        {
            ;
        }

        public virtual void seleccionar()
        {
            ;
        }

        public virtual void EventoInterfazComunDetectado(string strSolicitud, object parametro)
        {
            ;
        }

        #endregion

    }

} // end namespace
