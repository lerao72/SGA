using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LT48;

namespace MCC
{
    public partial class FormCuentas : Form
    {
        private bool _editando = true;
        private BC.Contactos.Cuentas _cuenta;

        private Int32 _idContacto = -1;



        public FormCuentas(Int32 idContactoP)
        {
            InitializeComponent();
            _idContacto = idContactoP;
        }



        #region Procedimientos

        private void swichEditMode()
        {
            _editando = !_editando;

            b_nuevo.Enabled = !_editando;
            b_borrar.Enabled = !_editando;
            b_cancelar.Visible = _editando;
            if (_editando)
            {
                b_editar.Text = "Guardar";
                b_editar.Image = MCC.Properties.Resources.save16_h;
            }
            else
            {
                b_editar.Text = "Editar";
                b_editar.Image = MCC.Properties.Resources.edit_square16_h_c;
            }

            p_grid.Enabled = !_editando;

            bool ro = !_editando;
            tb_banco.ReadOnly = ro;
            
            tb_cuenta.ReadOnly = ro;

            tb_IBAN_ES_IBAN.ReadOnly = ro;
            tb_IBAN_ES_Entidad.ReadOnly = ro;
            tb_IBAN_ES_Oficina.ReadOnly = ro;
            tb_IBAN_ES_DC.ReadOnly = ro;
            tb_IBAN_ES_NoCuenta.ReadOnly = ro;

            tb_swift.ReadOnly = ro;
        }

        //private bool _cargandoGrid = false;
        private void cargarGrid()
        {
            //_cargandoGrid = true;
            try { cargarGrid_do(); }
            catch { ;}
            //_cargandoGrid = false;
        }
        private void cargarGrid_do()
        {
            //string sql = "select idContacto, codigo, razonsocial, activo, visible from t_contactos";
            //string filtro1 = tb_f_1.Text.Trim();
            //if (filtro1 != "")
            //    sql += " where razonSocial like '%" + filtro1 + "%' or codigo='" + filtro1 + "'";
            //sql += " order by razonSocial asc";

            DataTable t;
            try { t = BC.Contactos.Cuentas.getDataTable(_idContacto); }
            catch (Exception ex) { Log.log("FormCuentas.cargarGrid_do.Exception: " + ex.Message); t = BC.Contactos.Direcciones.getDataTableVacia(); }

            if (t != null)
            {
                grid.DataSource = t;

                string[] columnasOcultar = { "idCuenta", "idContacto", "swift", "pago", "cobro", "datoCargado" };
                foreach (string columnaOcultar in columnasOcultar)
                    try { grid.Columns[columnaOcultar].Visible = false; }
                    catch { ;}

                BC.Comun.grid_tituloColumna(grid, "banco", "Banco");
                BC.Comun.grid_tituloColumna(grid, "iban", "Cuenta");


                if (grid.Rows.Count > 0)
                    grid.CurrentCell = grid.Rows[0].Cells["iban"];
            }
        }

        private void instanceToForm()
        {
            tb_banco.Text = _cuenta.getBanco();

            bool esESP = _cuenta.getIban().Length >= 2 && _cuenta.getIban().Substring(0, 2).ToUpper() == "ES";
            tb_cuenta.Visible = !esESP;
            p_IBAN_ES.Visible = esESP;

            tb_cuenta.Text = BC.Contactos.Cuentas.getNumCuentaFormateado(_cuenta.getIban());

            // La posición 0: IBAN (o 0000 si había 20 dígitos)
            // La posición 1: Entidad
            // La posición 2: Oficina
            // La posición 3: DC
            // La posición 4: Nº de cuenta.
            string[] partes = BC.Contactos.Cuentas.getPartesDeNoCuentaES(_cuenta.getIban());
            tb_IBAN_ES_IBAN.Text = partes[0];
            tb_IBAN_ES_Entidad.Text = partes[1];
            tb_IBAN_ES_Oficina.Text = partes[2];
            tb_IBAN_ES_DC.Text = partes[3];
            tb_IBAN_ES_NoCuenta.Text = partes[4];

            tb_swift.Text = _cuenta.getSwift();

            cb_pago.Checked = _cuenta.getPago();
            cb_cobro.Checked = _cuenta.getCobro();
        }

        private void formToInstance()
        {
            _cuenta.setBanco(tb_banco.Text.Trim());
            formToInstance_cuenta();
            _cuenta.setSwift(tb_swift.Text.Trim());

            _cuenta.setPago(cb_pago.Checked);
            _cuenta.setCobro(cb_cobro.Checked);
        }
        private void formToInstance_cuenta()
        {
            if (p_IBAN_ES.Visible)
            {
                string aux_iban = tb_IBAN_ES_IBAN.Text.Trim();
                aux_iban += tb_IBAN_ES_Entidad.Text.Trim();
                aux_iban += tb_IBAN_ES_Oficina.Text.Trim();
                aux_iban += tb_IBAN_ES_DC.Text.Trim();
                aux_iban += tb_IBAN_ES_NoCuenta.Text.Trim();

                _cuenta.setIban(aux_iban);
            }
            else
                _cuenta.setIban(tb_cuenta.Text);
        }

        #endregion


        
        private void FormCuentas_Load(object sender, EventArgs e)
        {
            swichEditMode();
            cargarGrid();
        }



        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_editando && grid.CurrentRow != null)
            {
                _cuenta = new BC.Contactos.Cuentas(BC.Comun.dataGridViewRowToObjectV(grid.CurrentRow));
                instanceToForm();
                b_borrar.Visible = true;
            }
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow fila = grid.Rows[e.RowIndex];
            string nombreColumna = grid.Columns[e.ColumnIndex].Name;

            if (fila != null)
            {
                if (nombreColumna == "banco")
                {
                    string valorCuenta = fila.Cells["iban"].Value.ToString();
                    fila.Cells["iban"].Value = BC.Contactos.Cuentas.getNumCuentaFormateado(valorCuenta);

                    bool esPago = (bool)fila.Cells["pago"].Value;
                    if (esPago)
                        fila.DefaultCellStyle.Font = new Font(grid.DefaultCellStyle.Font, FontStyle.Bold);
                    else
                        fila.DefaultCellStyle.Font = grid.DefaultCellStyle.Font;
                }
            }
        }



        private void tb_X_Enter(object sender, EventArgs e)
        {
            Color colorPoner = _editando ? Color.Cyan : Color.White;

            if (sender.GetType() == typeof(TextBox))
                ((TextBox)sender).BackColor = colorPoner;
            else if (sender.GetType() == typeof(ComboBox))
                ((CheckBox)sender).BackColor = colorPoner;

        }

        private void tb_X_Leave(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
                ((TextBox)sender).BackColor = Color.White;
            else if (sender.GetType() == typeof(CheckBox))
                ((CheckBox)sender).BackColor = Color.White;
        }



        private void b_nuevo_Click(object sender, EventArgs e)
        {
            _cuenta = new BC.Contactos.Cuentas();
            _cuenta.setIdContacto(_idContacto);

            BC.FormVariasOpciones w = new BC.FormVariasOpciones("La nueva cuenta es española");
            w.addOpcion(0, "Si");
            w.addOpcion(1, "No");

            if (w.ShowDialog() == DialogResult.OK && w.getSelectedValue() == 0)
                _cuenta.setIban("ES______________________");

            instanceToForm();
            swichEditMode();
        }

        private void b_editar_Click(object sender, EventArgs e)
        {
            if (_editando)
            {
                formToInstance();

                bool esNuevo = !_cuenta._datoCargado;

                if (BC.Contactos.Cuentas.cuentaCorrienteOIBANCorrectos(_cuenta.getIban()) ||
                    BC.Comun.preguntaSiNo("La cuenta no parece correcta. ¿Desea guardar de todos modos?", "Cuentas bancarias") == DialogResult.Yes)
                {
                    _cuenta.guarda();

                    if (esNuevo)
                    {
                        ((DataTable)grid.DataSource).Rows.Add(_cuenta.getInstanciaLikeARow());
                        grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells["banco"];
                    }
                    else
                        BC.Comun.setDataGridViewRowFromObjectV(_cuenta.getInstanciaLikeARow(), grid.CurrentRow);

                    swichEditMode();
                } // if (BC.Contactos.Cuentas.cuentacorrienteOIBANCorrectos....
            }
            else if (_cuenta != null)
                swichEditMode();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            instanceToForm();
            swichEditMode();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            if (BC.Comun.preguntaSiNo("¿Realmente quiere borrar esta cuenta?", "Cuentas bancarias") == DialogResult.Yes)
            {
                _cuenta.borra();
                cargarGrid();

                if (grid.Rows.Count == 0)
                {
                    _cuenta = new BC.Contactos.Cuentas();
                    _cuenta.setIdContacto(_idContacto);
                    instanceToForm();
                }
            }
        }


    } // end class
} // end namespace
