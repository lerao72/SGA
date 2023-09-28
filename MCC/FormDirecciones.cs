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
    public partial class FormDirecciones : Form
    {
        private bool _editando = true;
        private BC.Contactos.Direcciones _direccion;

        private Int32 _idContacto = -1;

        private static AutoCompleteStringCollection ac_cp = null;
        private static AutoCompleteStringCollection ac_localidad = null;
        private static AutoCompleteStringCollection ac_provincia = null;
        private static AutoCompleteStringCollection ac_pais = null;



        public FormDirecciones(Int32 idContacto)
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
            tb_cp.ReadOnly = ro;
            tb_localidad.ReadOnly = ro;
            tb_provincia.ReadOnly = ro;
            tb_pais.ReadOnly = ro;
            tb_direccion.ReadOnly = ro;

            b_tipo.Visible = _editando;
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
            try { t = BC.Contactos.Direcciones.getDataTable(_idContacto); }
            catch (Exception ex) { Log.log("FormDirecciones.cargarGrid_do.Exception: " + ex.Message); t = BC.Contactos.Direcciones.getDataTableVacia(); }

            if (t != null)
            {
                grid.DataSource = t;

                string[] columnasOcultar = { "idDireccion", "idContacto", "tipo", "provincia", "pais", "datoCargado" };
                foreach (string columnaOcultar in columnasOcultar)
                    try { grid.Columns[columnaOcultar].Visible = false; }
                    catch { ;}

                BC.Comun.grid_tituloAnchoColumna(grid, "cp", "C.Postal", 50);
                BC.Comun.grid_tituloColumna(grid, "localidad", "Localidad");
                //BC.Comun.grid_tituloColumna(grid, "provincia", "Provincia");
                //BC.Comun.grid_tituloColumna(grid, "pais", "Pais");
                BC.Comun.grid_tituloColumna(grid, "direccion", "Dirección");


                if (grid.Rows.Count > 0)
                    grid.CurrentCell = grid.Rows[0].Cells["direccion"];
            }
        }

        private void instanceToForm()
        {
            tb_tipo.Text = BC.Contactos.Direcciones.getTipoAsString(_direccion.getTipo());
            tb_cp.Text = _direccion.getCp();
            tb_localidad.Text = _direccion.getLocalidad();
            tb_provincia.Text = _direccion.getProvincia();
            tb_pais.Text = _direccion.getPais();
            tb_direccion.Text = _direccion.getDireccion();
        }

        private void formToInstance()
        {
            _direccion.setTipo(tb_tipo.Text);
            _direccion.setCp(tb_cp.Text);
            _direccion.setLocalidad(tb_localidad.Text.Trim());
            _direccion.setProvincia(tb_provincia.Text.Trim());
            _direccion.setPais(tb_pais.Text.Trim());
            _direccion.setDireccion(tb_direccion.Text.Trim());
        }



        private void cargarSugerencias()
        {
            cargarSugerencias_cp();
            cargarSugerencias_localidad();
            cargarSugerencias_provincia();
            cargarSugerencias_pais();
        }

        private AutoCompleteStringCollection cargarSugerenciasSub(string sql, TextBox tb, AutoCompleteStringCollection ac)
        {
            if (ac != null)
                tb.AutoCompleteCustomSource = ac;
            else
            {
                DataTable t;
                try { t = DB.getDataTable_CCP(sql); }
                catch { t = null; }

                string old = "";
                if (t != null)
                    foreach (DataRow r in t.Rows)
                    {
                        string nuevo = r.ItemArray[0].ToString().Trim();
                        if (nuevo.ToLower() != old.ToLower())
                            tb.AutoCompleteCustomSource.Add(nuevo);
                        old = nuevo;
                    }
            }
            return tb.AutoCompleteCustomSource;
        }
        
        private void cargarSugerencias_cp()
        {
            string sql = "select distinct cp from t_direcciones order by cp asc";
            cargarSugerenciasSub(sql, tb_cp, ac_cp);
        }
        
        private void cargarSugerencias_localidad()
        {
            string sql = "select distinct localidad from t_direcciones order by localidad asc";
            cargarSugerenciasSub(sql, tb_localidad, ac_localidad);
        }

        private void cargarSugerencias_provincia()
        {
            string sql = "select distinct provincia from t_direcciones order by provincia asc";
            cargarSugerenciasSub(sql, tb_provincia, ac_provincia);
        }

        private void cargarSugerencias_pais()
        {
            string sql = "select distinct pais from t_direcciones order by pais asc";
            cargarSugerenciasSub(sql, tb_pais, ac_pais);
        }

        #endregion



        private void FormDirecciones_Load(object sender, EventArgs e)
        {
            //BC.Comun.Form_ajustaTamanioYCentraForm(this, 90, 75);

            swichEditMode();
            cargarSugerencias();
            cargarGrid();
        }



        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_editando && grid.CurrentRow != null)
            {
                _direccion = new BC.Contactos.Direcciones(BC.Comun.dataGridViewRowToObjectV(grid.CurrentRow));
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
                if (nombreColumna == "direccion")
                {
                    int valorTipo = BC.Contactos.Direcciones.getTipoAsIntFromObject(fila.Cells["tipo"].Value);
                    try { fila.DefaultCellStyle.BackColor = BC.Contactos.Direcciones.v_color_tipo[valorTipo]; }
                    catch { ;}
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

        private void tb_cp_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            
            tb.BackColor = Color.White;

            if (_editando)
            {
                string sql = "select localidad, provincia, pais from t_direcciones where cp='" + tb.Text.Trim() + "'";
                DataTable t;
                try { t = DB.getDataTable_CCP(sql); }
                catch (Exception ex) { Log.log("FormDirecciones.tb_cp_Leave.Exception: " + ex.Message); t = null; }

                if (t != null && t.Rows.Count > 0)
                {
                    tb_localidad.Text = t.Rows[0].ItemArray[0].ToString();
                    tb_provincia.Text = t.Rows[0].ItemArray[1].ToString();
                    tb_pais.Text = t.Rows[0].ItemArray[2].ToString();
                }
            } // if (_editando)
        }


        
        private void b_tipo_Click(object sender, EventArgs e)
        {
            if (_editando)
            {
                Int32 nuevoValor = BC.Contactos.Direcciones.FormVariasOpcionesTipo(_direccion.getTipo());
                tb_tipo.Text = BC.Contactos.Direcciones.getTipoAsString(nuevoValor);
            }
        }



        private void b_nuevo_Click(object sender, EventArgs e)
        {
            _direccion = new BC.Contactos.Direcciones();
            _direccion.setIdContacto(_idContacto);
            instanceToForm();
            swichEditMode();
        }

        private void b_editar_Click(object sender, EventArgs e)
        {
            if (_editando)
            {
                formToInstance();

                bool esNuevo = !_direccion._datoCargado;

                _direccion.guarda();

                if (esNuevo)
                {
                    ((DataTable)grid.DataSource).Rows.Add(_direccion.getInstanciaLikeARow());
                    grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells["cp"];
                }
                else
                    BC.Comun.setDataGridViewRowFromObjectV(_direccion.getInstanciaLikeARow(), grid.CurrentRow);

                swichEditMode();
            }
            else if (_direccion != null)
                swichEditMode();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            instanceToForm();
            swichEditMode();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            if (BC.Comun.preguntaSiNo("¿Realmente quiere borrar esta dirección?", "Direcciones") == DialogResult.Yes)
            {
                _direccion.borra();
                cargarGrid();

                if (grid.Rows.Count == 0)
                {
                    _direccion= new BC.Contactos.Direcciones();
                    _direccion.setIdContacto(_idContacto);
                    instanceToForm();
                }
            }
        }

    } // end class
} // end namespace
