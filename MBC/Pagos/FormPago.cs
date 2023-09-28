using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BC;
using LT48;

namespace MBC.Pagos
{
    public partial class FormPago : Form
    {
        public BC.Compras.Pago _pago;

        public FormPago(BC.Compras.Pago pago)
        {
            InitializeComponent();
            _pago = pago;
        }






        #region Procedimientos

        private bool _instanciando = false;
        private void instanceToForm()
        {
            _instanciando = true;
            tb_contacto.Text = BC.Contactos.Contactos.getRazonSocialDe(_pago.getIdContacto());
            dtp_fechaPrevista.Value = _pago.getFechaPrevistaAsDateTime();
            cb_pagado.Checked = _pago.getFechaReal() != "";
            // El dtp_fechaReal no hace falta instanciarlo, porque si es true, el propio evento mostrará el valor
            tb_tipo.Text = _pago.getTipo();
            tb_descripcion.Text = _pago.getDescripcion();
            tb_importe.Text = BC.Comun.currency_getValorFormateadoAsString(_pago.getImporte());
            cb_autoPagable.Checked = _pago.getAutopagable();
            cb_persistente.Checked = _pago.getPersistente();

            b_borrar.Visible = _pago._datoCargado;
            instanceToForm_repeticiones();
        }

        private BC.Compras.Pago[] v_pagosSerie;
        private bool v_pagosSerie_iniciado = false;
        private Int32 indiceActual = -1;
        private void instanceToForm_repeticiones()
        {
            if (!v_pagosSerie_iniciado)
            {
                if (_pago.getSerie() != -1)
                    v_pagosSerie = BC.Compras.Pago.getPagosDeSerie(_pago.getSerie());
                else
                    v_pagosSerie = null;

                v_pagosSerie_iniciado = true;
            }

            instanceToForm_repeticiones_refrescar(-1);
        }
        private void instanceToForm_repeticiones_refrescar(Int32 indiceSiSeConoceSiNoMenosUno)
        {
            if (v_pagosSerie != null)
            {
                tlp_serie.Visible = true;

                Int32 numElementos = v_pagosSerie.Length;
                indiceActual = indiceSiSeConoceSiNoMenosUno == -1 ?
                    BC.Compras.Pago.getIndiceDe(_pago, v_pagosSerie) :
                    indiceSiSeConoceSiNoMenosUno;

                bool haciaAtrasPermitido = indiceActual > 0;
                bool haciaDelantePermitido = indiceActual < numElementos - 1;

                b_repeticiones.Visible = indiceActual == numElementos - 1;

                b_serie_first.Enabled = haciaAtrasPermitido;
                b_serie_prev.Enabled = haciaAtrasPermitido;
                b_serie_next.Enabled = haciaDelantePermitido;
                b_serie_last.Enabled = haciaDelantePermitido;
            }
            else
                b_repeticiones.Visible = _pago._datoCargado && _pago.getSerie() == -1;
        }

        private void formToInstance()
        {
            _pago.setFechaPrevista(dtp_fechaPrevista.Value);
            if (cb_pagado.Checked)
                _pago.setFechaReal(dtp_fechaReal.Value);
            else
                _pago.setFechaReal("");
            _pago.setTipo(tb_tipo.Text);
            _pago.setDescripcion(tb_descripcion.Text);
            _pago.setImporte(BC.Comun.currency_getValorFormateadoAsDouble(tb_importe.Text));
            _pago.setAutopagable(cb_autoPagable.Checked);
            _pago.setPersistente(cb_persistente.Checked);
        }

        private void cargarTiposSugeridos()
        {
            DataTable t = BC.Compras.Pago.getDataTableTiposSugeridos(false);
            foreach (DataRow r in t.Rows)
                tb_tipo.AutoCompleteCustomSource.Add(r.ItemArray[0].ToString());
        }

        #endregion






        private void FormPago_Load(object sender, EventArgs e)
        {
            cargarTiposSugeridos();
            instanceToForm();
        }

        private void b_contacto_Click(object sender, EventArgs e)
        {
            ;
        }

        private void cb_pagado_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_pagado.Checked)
            {
                if (!_instanciando)
                    _pago.setFechaReal(DateTime.Now);
                cb_pagado.Text = "Pagado el día: ";
                dtp_fechaReal.Value = _pago.getFechaRealAsDateTime();
                dtp_fechaReal.Visible = true;
            }
            else
            {
                _pago.setFechaReal("");
                cb_pagado.Text = "Pagado";
                dtp_fechaReal.Visible = false;
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
            _pago.guarda();

            b_borrar.Visible = _pago._datoCargado;
            instanceToForm_repeticiones();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            if (_pago.getSerie() == -1)
            {
                if (BC.Comun.preguntaSiNo("¿Realmente quiere eliminar este pago?", "Pagos a contacto") == DialogResult.Yes)
                {
                    _pago.borra();
                    this.Close();
                }
            }
            else
            {
                FormVariasOpciones w = new FormVariasOpciones("Indique opción");
                w.addOpcion(0, "Borrar solo este pago");
                w.addSeparador();
                w.addOpcion(1, "Borrar los pagos anteriores");
                w.addOpcion(2, "Borrar este y los pagos anteriores");
                w.addSeparador();
                w.addOpcion(3, "Borrar los pagos posteriores");
                w.addOpcion(4, "Borrar este y los pagos posteriores");
                w.addSeparador();
                w.addOpcion(5, "Borrar todos los pagos de esta serie");

                if (w.ShowDialog() == DialogResult.OK)
                {

                    switch (w.getSelectedValue())
                    {
                        case 0:
                            _pago.borra();
                            break;


                        case 1:
                        case 2:
                            BC.Compras.Pago.borraSerie_anteriorA(_pago, w.getSelectedValue() == 2);
                            break;

                        case 3:
                        case 4:
                            BC.Compras.Pago.borraSerie_posteriorA(_pago, w.getSelectedValue() == 4);
                            break;

                        case 5:
                            BC.Compras.Pago.borraSerie_toda(_pago);
                            break;
                    }
                    this.Close();
                } // if (w.ShowDialog()...
            }

        }



        private void b_repeticiones_Click(object sender, EventArgs e)
        {
            new FormHacerRepeticionesDePago(_pago).ShowDialog();
            v_pagosSerie_iniciado = false;
            instanceToForm();
        }

        private void b_serie_first_Click(object sender, EventArgs e)
        {
            indiceActual = 0;
            _pago = v_pagosSerie[indiceActual];
            instanceToForm();
        }

        private void b_serie_prev_Click(object sender, EventArgs e)
        {
            indiceActual--;
            _pago = v_pagosSerie[indiceActual];
            instanceToForm();
        }

        private void b_serie_next_Click(object sender, EventArgs e)
        {
            indiceActual++;
            _pago = v_pagosSerie[indiceActual];
            instanceToForm();
        }

        private void b_serie_last_Click(object sender, EventArgs e)
        {
            indiceActual = v_pagosSerie.Length - 1;
            _pago = v_pagosSerie[indiceActual];
            instanceToForm();
        }

        private void FormPago_FormClosed(object sender, FormClosedEventArgs e)
        {
            BC.Comun.GeneraEnvioAInterfazComun("FormPago_FormClosed", _pago);
        }

    } // end class
} // end namespace
