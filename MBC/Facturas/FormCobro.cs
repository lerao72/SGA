using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MBC.Facturas
{
    public partial class FormCobro : Form
    {
        public BC.Ventas.Cobro _cobro;
        public BC.Ventas.Factura _factura;



        public FormCobro(BC.Ventas.Cobro cobro)
        {
            InitializeComponent();
            _cobro = cobro;
            _factura = new BC.Ventas.Factura(_cobro.getIdFactura());
        }

        public FormCobro(BC.Ventas.Cobro cobro, BC.Ventas.Factura factura)
        {
            InitializeComponent();
            _cobro = cobro;
            _factura = factura;
        }






        #region Procedimientos

        private bool _instanciando = false;
        private void instanceToForm()
        {
            _instanciando = true;
            tb_contacto.Text = BC.Contactos.Contactos.getRazonSocialDe(_cobro.getIdContacto());
            dtp_fechaPrevista.Value = _cobro.getFechaPrevistaAsDateTime();
            cb_cobrado.Checked = _cobro.getFechaReal() != "" && _cobro.getFechaReal() != "IMPAGO";
            cb_impago.Checked = _cobro.getFechaReal() == "IMPAGO";
            // El dtp_fechaReal no hace falta instanciarlo, porque si es true, el propio evento mostrará el valor
            tb_factura.Text = _factura.getAnio() + "/" + _factura.getNumero();
            tb_descripcion.Text = _cobro.getDescripcion();
            tb_importe.Text = BC.Comun.currency_getValorFormateadoAsString(_cobro.getImporte());

            b_borrar.Visible = _cobro._datoCargado;

            _instanciando = false;
        }

        private void formToInstance()
        {
            _cobro.setFechaPrevista(dtp_fechaPrevista.Value);
            if (cb_cobrado.Checked)
                _cobro.setFechaReal(dtp_fechaReal.Value);
            else if (cb_impago.Checked)
                _cobro.setFechaReal("IMPAGO");
            else
                _cobro.setFechaReal("");
            _cobro.setDescripcion(tb_descripcion.Text);
            _cobro.setImporte(BC.Comun.currency_getValorFormateadoAsDouble(tb_importe.Text));
        }

        #endregion






        private void FormCobro_Load(object sender, EventArgs e)
        {
            instanceToForm();
        }

        private void b_contacto_Click(object sender, EventArgs e)
        {
            ;
        }

        private void cb_cobrado_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_cobrado.Checked)
            {
                if (!_instanciando)
                    _cobro.setFechaReal(DateTime.Now);
                cb_cobrado.Text = "Cobrado el día: ";
                dtp_fechaReal.Value = _cobro.getFechaRealAsDateTime();
                dtp_fechaReal.Visible = true;
                cb_impago.Visible = false;
            }
            else
            {
                if (!cb_impago.Checked)
                    _cobro.setFechaReal("");
                cb_impago.Visible = true;

                cb_cobrado.Text = "Cobrado";
                dtp_fechaReal.Visible = false;
            }
        }

        private void cb_impago_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_impago.Checked)
            {
                if (!_instanciando)
                    _cobro.setFechaReal("IMPAGO");
                cb_cobrado.Checked = false;
                cb_cobrado.Enabled = false;
                dtp_fechaReal.Visible = false;
            }
            else
            {
                if (!_instanciando)
                    _cobro.setFechaReal("");
                cb_cobrado.Enabled = true;
            }
        }

        private void tb_X_Enter(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
                ((TextBox)sender).BackColor = Color.Cyan;
            else if (sender.GetType() == typeof(CheckBox))
                ((CheckBox)sender).BackColor = Color.Cyan;
        }

        private void tb_X_Leave(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                TextBox tb = (TextBox)sender;
                tb.BackColor = Color.White;

                if (tb.Name == "tb_importe")
                    tb.Text = BC.Comun.currency_getValorFormateadoAsString(BC.Comun.currency_getValorDoubleFromString(tb.Text));
            }
            else if (sender.GetType() == typeof(CheckBox))
                ((CheckBox)sender).BackColor = Color.White;
        }

        private void b_guardar_Click(object sender, EventArgs e)
        {
            formToInstance();
            _cobro.guarda();

            this.Close();
            //b_borrar.Visible = _cobro._datoCargado;
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            if (BC.Comun.preguntaSiNo("¿Realmente quiere eliminar este cobro?", "Cobros de contacto") == DialogResult.Yes)
            {
                _cobro.borra();
                this.Close();
            }
        }



        private void FormCobro_FormClosed(object sender, FormClosedEventArgs e)
        {
            BC.Comun.GeneraEnvioAInterfazComun("FormCobro_FormClosed", _cobro);
        }

        private void t_topMost_Tick(object sender, EventArgs e)
        {
            t_topMost.Enabled = false;
            TopMost = false;
        }

    } // end class
} // end namespace
