using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BC;
using LT48;

namespace MVC.Recordatorios
{
    public partial class FormRecordatorio : Form
    {
        private bool _editando = true;
        private BC.Varios.Recordatorio _recordatorio;



        public FormRecordatorio(BC.Varios.Recordatorio recordatorio)
        {
            InitializeComponent();
            _recordatorio = recordatorio;
            BC.Comun.GeneraEnvioAInterfazComun("FormRecordatorio_FormCreado", _recordatorio);
        }



        #region Procedimientos

        private void swichEditMode()
        {
            _editando = !_editando;

            b_cancelar.Visible = _editando && _recordatorio._datoCargado;
            b_borrar.Enabled = !_editando;
            if (_editando)
            {
                b_editar.Text = "Guardar";
                b_editar.Image = MVC.Properties.Resources.save16_h;

                dtp_fecha.Focus();
            }
            else
            {
                b_editar.Text = "Editar";
                b_editar.Image = MVC.Properties.Resources.edit_square16_h_c;
            }

            bool ro = !_editando;
            dtp_fecha.Enabled = _editando;
            cb_todoElDia.AutoCheck = _editando;
            nud_hora.ReadOnly = ro;
            nud_minutos.ReadOnly = ro;
            nud_hora.Increment = _editando ? 1 : 0;
            nud_minutos.Increment = _editando ? 1 : 0;
            tb_tarea.ReadOnly = ro;
        }

        private void instanceToForm()
        {
            l_tipo_vinculado.Text = BC.Varios.Recordatorio.getTipoAsString(_recordatorio.getTipoVinculado());

            BC.Varios.Recordatorio.Tipo _tipoAux;
            try { _tipoAux = (BC.Varios.Recordatorio.Tipo)_recordatorio.getTipoVinculado(); }
            catch { _tipoAux = BC.Varios.Recordatorio.Tipo.Agenda; }

            switch (_tipoAux)
            {
                case BC.Varios.Recordatorio.Tipo.Agenda:
                    l_detalleVinculado.Text = "";
                    break;

                case BC.Varios.Recordatorio.Tipo.Contacto:
                    l_detalleVinculado.Text = BC.Contactos.Contactos.getRazonSocialDe(_recordatorio.getIdVinculado());
                    break;
            }

            dtp_fecha.Value = _recordatorio.getFechaAsDateTime();
            if (_recordatorio.getHora() == "")
                cb_todoElDia.Checked = true;
            else
            {
                nud_hora.Value = _recordatorio.getHora_hora();
                nud_minutos.Value = _recordatorio.getHora_minutos();
            }
            tb_tarea.Text = _recordatorio.getTarea();

            b_borrar.Visible = _recordatorio._datoCargado;
            b_posponer.Visible = _recordatorio._datoCargado;
        }

        private void formToInstance()
        {
            _recordatorio.setFecha(dtp_fecha.Value);
            if (cb_todoElDia.Checked)
                _recordatorio.setHora("");
            else
                _recordatorio.setHora((int)nud_hora.Value, (int)nud_minutos.Value);
            _recordatorio.setTarea(tb_tarea.Text);
        }
        
        #endregion






        private void FormRecordatorio_Load(object sender, EventArgs e)
        {
            instanceToForm();
            _editando = _recordatorio._datoCargado;
            swichEditMode();
        }



        private void tb_X_Enter(object sender, EventArgs e)
        {
            Color colorPoner = _editando ? Color.Cyan : Color.White;

            if (sender.GetType() == typeof(TextBox))
                ((TextBox)sender).BackColor = colorPoner;
            else if (sender.GetType() == typeof(CheckBox))
                ((CheckBox)sender).BackColor = colorPoner;
            else if (sender.GetType() == typeof(NumericUpDown))
                ((NumericUpDown)sender).BackColor = colorPoner;
        }

        private void tb_X_Leave(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
                ((TextBox)sender).BackColor = Color.White;
            else if (sender.GetType() == typeof(CheckBox))
                ((CheckBox)sender).BackColor = Color.White;
            else if (sender.GetType() == typeof(NumericUpDown))
                ((NumericUpDown)sender).BackColor = Color.White;
        }



        private void b_editar_Click(object sender, EventArgs e)
        {
            if (_editando)
            {
                formToInstance();

                bool esNuevo = !_recordatorio._datoCargado;

                _recordatorio.guarda();

                if (_recordatorio.getFecha() == DateTime.Now.ToString("yyyyMMdd"))
                    //BC.Varios.Recordatorio.recargarAgendaHoy();
                    BC.Varios.Recordatorio.aniadeAgendaHoy(_recordatorio);

                swichEditMode();
            }
            else if (_recordatorio != null) // && _recordatorio._datoCargado)
                swichEditMode();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            instanceToForm();
            swichEditMode();
        }

        private void b_posponer_Click(object sender, EventArgs e)
        {
            DateTime momentoAux = _recordatorio.getFechaAsDateTime();
            int hora, minutos;
            if (_recordatorio.getHora()!="")
            {
                hora = _recordatorio.getHora_hora();
                minutos = _recordatorio.getHora_minutos();
            }
            else
            {
                hora = 0;
                minutos = 0;
            }
            momentoAux = new DateTime(momentoAux.Year, momentoAux.Month, momentoAux.Day, hora, minutos, 0);

            FormVariasOpciones w = new FormVariasOpciones("Indique cuando desea volver a mostrar el aviso");
            if (_recordatorio.getHora() != "")
            {
                w.addOpcion(0, "5 minutos");
                w.addOpcion(1, "15 minutos");
                w.addOpcion(2, "30 minutos");
                w.addSeparador();
                w.addOpcion(3, "1 hora");
                w.addOpcion(4, "2 horas");
                w.addSeparador();
            }
            w.addOpcion(10, "1 día");
            w.addOpcion(11, "2 días");
            w.addSeparador();
            w.addOpcion(12, "1 semana");
            w.addOpcion(13, "2 semanas");
            w.addSeparador();
            w.addOpcion(14, "1 mes");

            if (w.ShowDialog() == DialogResult.OK)
            {
                switch (w.getSelectedValue())
                {
                    case 0: momentoAux = momentoAux.AddMinutes(5); break;
                    case 1: momentoAux = momentoAux.AddMinutes(15); break;
                    case 2: momentoAux = momentoAux.AddMinutes(30); break;

                    case 3: momentoAux = momentoAux.AddHours(1); break;
                    case 4: momentoAux = momentoAux.AddHours(2); break;

                    case 10: momentoAux = momentoAux.AddDays(1); break;
                    case 11: momentoAux = momentoAux.AddDays(2); break;

                    case 12: momentoAux = momentoAux.AddDays(7); break;
                    case 13: momentoAux = momentoAux.AddDays(14); break;

                    case 14: momentoAux = momentoAux.AddMonths(1); break;
                }
                _recordatorio.setFecha(momentoAux);
                _recordatorio.setHora(momentoAux.Hour, momentoAux.Minute);
                _recordatorio.guarda();

                instanceToForm();

                if (momentoAux.ToString("yyyyMMdd") == DateTime.Now.ToString("yyyyMMdd"))
                    //BC.Varios.Recordatorio.recargarAgendaHoy();
                    BC.Varios.Recordatorio.aniadeAgendaHoy(_recordatorio);
            }
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            if (BC.Comun.preguntaSiNo("¿Realmente desea eliminar este recordatorio?", "Recordatorios") == DialogResult.Yes)
            {
                _recordatorio.borra();
                BC.Comun.GeneraEnvioAInterfazComun("recordatorio_borrado", null);

                //if (_recordatorio.getFecha() == DateTime.Now.ToString("yyyyMMdd"))
                //    BC.Varios.Recordatorio.recargarAgendaHoy();

                this.Close();
            }
        }

        private void FormRecordatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            BC.Comun.GeneraEnvioAInterfazComun("FormRecordatorio_FormClosed", _recordatorio);
        }

        private void cb_todoElDia_CheckedChanged(object sender, EventArgs e)
        {
            p_hora.Visible = !cb_todoElDia.Checked;

            if (p_hora.Visible && (int)nud_hora.Value == 0 && (int)nud_minutos.Value == 0)
            {
                DateTime ahora = DateTime.Now;
                nud_hora.Value = ahora.Hour;
                nud_minutos.Value = ahora.Minute;
            }
        }

    } // end class
} // end namespace
