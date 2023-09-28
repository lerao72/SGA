using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LT48;

namespace MAC
{
    public partial class FormFamiliasArticulos : Form
    {
        private bool _editando = true;
        private BC.Articulos.FamiliasArticulos _familia = new BC.Articulos.FamiliasArticulos();

        public FormFamiliasArticulos()
        {
            InitializeComponent();
        }






        #region Procedimientos

        private void swichEditMode()
        {
            _editando = !_editando;

            b_nuevo.Enabled = !_editando;
            b_cancelar.Visible = _editando;
            if (_editando)
            {
                b_editar.Text = "Guardar";
                b_editar.Image = MAC.Properties.Resources.save16_h;

                tb_nombre.Focus();
            }
            else
            {
                b_editar.Text = "Editar";
                b_editar.Image = MAC.Properties.Resources.edit_square16_h_c;
            }

            grid.Enabled = !_editando;

            bool ro = !_editando;
            tb_nombre.ReadOnly = ro;
        }

        private bool _cargandoGrid = false;
        private void cargarGrid()
        {
            _cargandoGrid = true;
            try { cargarGrid_do(); }
            catch { ;}
            _cargandoGrid = false;
        }
        private void cargarGrid_do()
        {
            string sql = "select idFamiliaArticulo, nombre from t_familiasArticulos";
            sql += " order by nombre asc";

            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("FormFamiliasArticulos.cargarGrid_do.Exception: " + ex.Message); t = null; }

            if (t != null)
            {
                grid.DataSource = t;

                try { grid.Columns["idFamiliaArticulo"].Visible = false; }
                catch { ;}

                BC.Comun.grid_tituloColumna(grid, "nombre", "Familia");

                if (grid.Rows.Count > 0)
                    grid.CurrentCell = grid.Rows[0].Cells["nombre"];
            }
        }

        private void instanceToForm()
        {
            tb_nombre.Text = _familia.getNombre();
        }

        private void formToInstance()
        {
            _familia.setNombre(tb_nombre.Text);
        }

        #endregion






        private void FormFamiliasArticulos_Load(object sender, EventArgs e)
        {
            swichEditMode();
            cargarGrid();
        }



        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_editando && grid.CurrentRow != null)
            {
                Int32 idFamiliaCargar = Conversiones.toInt(grid.CurrentRow.Cells["idFamiliaArticulo"].Value);
                _familia = new BC.Articulos.FamiliasArticulos(idFamiliaCargar);
                instanceToForm();
            }
        }



        private void tb_X_Enter(object sender, EventArgs e)
        {
            Color colorPoner = _editando ? Color.Cyan : Color.White;

            if (sender.GetType() == typeof(TextBox))
                ((TextBox)sender).BackColor = colorPoner;
            else if (sender.GetType() == typeof(CheckBox))
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
            _familia = new BC.Articulos.FamiliasArticulos();
            instanceToForm();
            swichEditMode();
        }

        private void b_editar_Click(object sender, EventArgs e)
        {
            if (_editando)
            {
                formToInstance();

                bool esNuevo = !_familia._datoCargado;

                _familia.guarda();

                // idFamiliaArticulo, nombre
                object[] o = { _familia.getIdFamiliaArticulo(),
                           _familia.getNombre() };

                if (esNuevo)
                {
                    ((DataTable)grid.DataSource).Rows.Add(o);
                    grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells["nombre"];
                }
                else
                    BC.Comun.setDataGridViewRowFromObjectV(o, grid.CurrentRow);

                swichEditMode();
            }
            else if (_familia != null && _familia._datoCargado)
                swichEditMode();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            instanceToForm();
            swichEditMode();
        }

    } // end class
} // end namespace
