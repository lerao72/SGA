using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BC;
using LT48;

namespace MCC
{
    public partial class FormDatosContacto : Form
    {
        private bool _editando = true;
        private BC.Contactos.DatosContacto _datoContacto;

        private Int32 _idContacto = -1;

        private bool _esTelefono = true;

        
        
        public FormDatosContacto(Int32 idContacto)
        {
            InitializeComponent();
            _idContacto = idContacto;
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
            tb_dato.ReadOnly = ro;
            tb_nombre.ReadOnly = ro;
            tb_cargo.ReadOnly = ro;
            tb_observaciones.ReadOnly = ro;
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

            string str_rb_checked = _esTelefono ? rb_tipo_telefono.Text :
    (rb_tipo_email.Checked ? rb_tipo_email.Text : rb_tipo_web.Text);
            Int32 tipoP = BC.Contactos.DatosContacto.getTipoAsInt(str_rb_checked);
            
            DataTable t;
            try { t = BC.Contactos.DatosContacto.getDataTable(_idContacto, tipoP); }
            catch (Exception ex) { Log.log("FormDatosContacto.cargarGrid_do.Exception: " + ex.Message); t = BC.Contactos.Direcciones.getDataTableVacia(); }

            if (t != null)
            {
                grid.DataSource = t;

                string[] columnasOcultar = { "idDatoContacto", "idContacto", "observaciones", "datoCargado" };
                foreach (string columnaOcultar in columnasOcultar)
                    try { grid.Columns[columnaOcultar].Visible = false; }
                    catch { ;}

                BC.Comun.grid_tituloAnchoColumna(grid, "tipo", "Tipo", 75);
                BC.Comun.grid_tituloColumna(grid, "dato", str_rb_checked);
                BC.Comun.grid_tituloColumna(grid, "nombre", "Nombre");
                BC.Comun.grid_tituloColumna(grid, "cargo", "Cargo");

                if (grid.Rows.Count > 0)
                    grid.CurrentCell = grid.Rows[0].Cells["dato"];
            }
        }

        private void instanceToForm()
        {
            tb_dato.Text = _esTelefono ? formateaTelefono(_datoContacto.getDato()) : _datoContacto.getDato();
            tb_nombre.Text = _datoContacto.getNombre();
            tb_cargo.Text = _datoContacto.getCargo();
            tb_observaciones.Text = _datoContacto.getObservaciones();
        }

        private void formToInstance()
        {
            if (!_esTelefono)
                _datoContacto.setDato(tb_dato.Text.Trim());
            else
                _datoContacto.setDato(tb_dato.Text.Trim().Replace(" ", "").Replace("-", ""));

            _datoContacto.setNombre(tb_nombre.Text.Trim());
            _datoContacto.setCargo(tb_cargo.Text.Trim());
            _datoContacto.setObservaciones(tb_observaciones.Text.Trim());
        }



        private void posicionarseEnGrid()
        {
            string fTrim = tb_f_1.Text.Trim();
            if (fTrim != "")
                BC.Comun.grid_buscadorEnGridPorPosicionamiento(fTrim, grid);
        }

        #endregion




        private void FormDatosContacto_Load(object sender, EventArgs e)
        {
            swichEditMode();
            cargarGrid();
        }



        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_editando && grid.CurrentRow != null)
            {
                _datoContacto = new BC.Contactos.DatosContacto(BC.Comun.dataGridViewRowToObjectV(grid.CurrentRow));
                instanceToForm();
                b_borrar.Visible = true;
                b_enviar_email.Enabled = b_enviar_email.Visible;
            }            
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (_esTelefono)
            {
                DataGridViewRow fila = grid.Rows[e.RowIndex];
                string nombreColumna = grid.Columns[e.ColumnIndex].Name;

                if (fila != null)
                {
                    if (nombreColumna == "nombre")
                    {
                        int valorTipo = BC.Contactos.DatosContacto.getTipoAsInt(fila.Cells["tipo"].Value.ToString());
                        if (valorTipo == (Int32)BC.Contactos.DatosContacto.Tipo.telefono)
                            try { fila.Cells["dato"].Value = formateaTelefono(fila.Cells["dato"].Value.ToString()); }
                            catch { ;}
                    }
                }
            }
        }
        private string formateaTelefono(string valor)
        {
            if (valor.IndexOf(" ") < 0)
            {
                string resultado = "";
                int tamanio = valor.Length;

                if (tamanio > 3)
                {
                    resultado += valor.Substring(0, 3);
                    if (tamanio > 6)
                    {
                        resultado += " " + valor.Substring(3, 3);

                        if (tamanio > 9)
                        {
                            resultado += " " + valor.Substring(6, 3);

                            // Independientemente del tamaño, si llegamos aquí ya ponemos el resto
                            resultado += " " + valor.Substring(9);
                        }
                        else
                            resultado += " " + valor.Substring(6);
                    }
                    else
                        resultado += " " + valor.Substring(3);
                }
                else
                    resultado += valor;

                return resultado;
            }
            else
                return valor;
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
            string str_rb_checked = _esTelefono ? rb_tipo_telefono.Text :
                (rb_tipo_email.Checked ? rb_tipo_email.Text : rb_tipo_web.Text);
            string str_pregunta = rb_tipo_web.Checked ? "Va crear una nueva web" :
                "Va a crear un nuevo " + str_rb_checked;
            str_pregunta += ". ¿Es correcto?";

            if (BC.Comun.preguntaSiNo(str_pregunta, "Datos de contacto") == DialogResult.Yes)
            {

                _datoContacto = new BC.Contactos.DatosContacto();
                _datoContacto.setIdContacto(_idContacto);
                _datoContacto.setTipo(str_rb_checked);

                instanceToForm();
                swichEditMode();
            }
        }

        private void b_editar_Click(object sender, EventArgs e)
        {
            if (_editando)
            {
                formToInstance();

                bool esNuevo = !_datoContacto._datoCargado;

                _datoContacto.guarda();

                if (esNuevo)
                {
                    ((DataTable)grid.DataSource).Rows.Add(_datoContacto.getInstanciaLikeARow());
                    grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells["dato"];
                }
                else
                    BC.Comun.setDataGridViewRowFromObjectV(_datoContacto.getInstanciaLikeARow(), grid.CurrentRow);

                swichEditMode();
            }
            else if (_datoContacto != null)
                swichEditMode();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            instanceToForm();
            swichEditMode();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            if (BC.Comun.preguntaSiNo("¿Realmente quiere borrar este dato de contacto?", "Datos de contacto") == DialogResult.Yes)
            {
                _datoContacto.borra();
                cargarGrid();

                if (grid.Rows.Count == 0)
                {
                    _datoContacto = new BC.Contactos.DatosContacto();
                    _datoContacto.setIdContacto(_idContacto);

                    string str_rb_checked = _esTelefono ? rb_tipo_telefono.Text :
    (rb_tipo_email.Checked ? rb_tipo_email.Text : rb_tipo_web.Text);
                    _datoContacto.setTipo(str_rb_checked);

                    instanceToForm();
                }
            }
        }



        private void rb_tipo_X_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            rb.BackColor = rb.Checked ? Color.Lime : Color.White;

            b_enviar_email.Enabled = false;
            b_enviar_email.Visible = rb_tipo_email.Checked;

            t_CheckedChanged.Enabled = true;
        }

        private void t_CheckedChanged_Tick(object sender, EventArgs e)
        {
            t_CheckedChanged.Enabled = false;

            _esTelefono = rb_tipo_telefono.Checked;

            l_tipo.Text = _esTelefono ? "Teléfono:" :
                (rb_tipo_email.Checked ? "e-mail:" : "Web:");

            _datoContacto = new BC.Contactos.DatosContacto();
            _datoContacto.setTipo(l_tipo.Text.Replace(":", ""));

            instanceToForm();

            cargarGrid();
        }



        private bool _teclaPulsada = false;
        private void tb_f_1_TextChanged(object sender, EventArgs e)
        {
            _teclaPulsada = true;
            t_filtro.Enabled = true;
        }

        private void t_filtro_Tick(object sender, EventArgs e)
        {
            if (_teclaPulsada)
            {
                t_filtro.Enabled = false;
                posicionarseEnGrid();
            }
            _teclaPulsada = false;
        }

        private void b_f_search_Click(object sender, EventArgs e)
        {
            t_filtro.Enabled = false;
            _teclaPulsada = false;
            posicionarseEnGrid();
        }

        private void b_enviar_email_Click(object sender, EventArgs e)
        {
            try { System.Diagnostics.Process.Start("mailto:" + _datoContacto.getDato()); }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Es posible que no haya especificado una aplicación de correo por defecto en su ordenador.\r\n"); 
                Log.log("FormDatosContacto.b_enviar_email_click.Exception: " + ex.Message);
            }
        }

    } // end class
} // end namespace
