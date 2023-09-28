using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BC;
using LT48;

namespace MAC
{
    public partial class FormProveedorDeArticulo : Form
    {
        private bool _editando = true;
        private BC.Articulos.ProveedorDeArticulo _pa;

        //private Int32 _idArticulo = -1;
        private BC.Articulos.Articulos _articulo;

        //private Int32 _idContacto = -1;
        private string _codigoContactoSeleccionado = "";
        private string _codigoContactoSeleccionadoAux = "";
        private string _razonSocialContactoSeleccionado = "";



        public FormProveedorDeArticulo(BC.Articulos.Articulos articuloP)
        {
            InitializeComponent();
            _articulo = articuloP;
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
                b_editar.Image = MAC.Properties.Resources.save16_h;
            }
            else
            {
                b_editar.Text = "Editar";
                b_editar.Image = MAC.Properties.Resources.edit_square16_h_c;
            }

            p_grid.Enabled = !_editando;

            bool ro = !_editando;

            b_contacto.Visible = _editando && !_pa._datoCargado;
            tb_precio.ReadOnly = ro;
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
            string sql = "select a.idContacto, b.codigo, b.razonSocial, a.precio from t_proveedorDeArticulo a";
            sql += " left join t_contactos b on a.idContacto=b.idContacto where a.idArticulo=" + _articulo.getIdArticulo();
            string filtro1 = tb_f_1.Text.Trim();
            if (filtro1 != "")
                sql += " where b.razonSocial like '%" + filtro1 + "%' or b.codigo='" + filtro1 + "'";
            sql += " order by b.razonSocial asc";

            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("FormProveedorDeArticulo.cargarGrid_do.Exception: " + ex.Message); t = null; }

            if (t != null)
            {
                grid.DataSource = t;

                string[] columnasOcultar = { "idContacto" };
                foreach (string columnaOcultar in columnasOcultar)
                    try { grid.Columns[columnaOcultar].Visible = false; }
                    catch { ;}

                BC.Comun.grid_tituloAnchoColumna(grid, "codigo", "#", 50);
                BC.Comun.grid_tituloColumna(grid, "razonSocial", "Contacto");
                BC.Comun.grid_tituloAnchoColumna(grid, "precio", "Precio", 100, BC.Comun.AlineacionColumna.Derecha);


                if (grid.Rows.Count > 0)
                    grid.CurrentCell = grid.Rows[0].Cells["razonSocial"];

                calcularMaxMinPromedio();
            }
        }

        private void instanceToForm()
        {
            tb_contacto.Text = _razonSocialContactoSeleccionado;
            tb_precio.Text = BC.Comun.currency_getValorFormateadoAsString(_pa.getPrecio());
            tb_observaciones.Text = _pa.getObservaciones();
        }

        private void formToInstance()
        {
            //_pa.setIdArticulo(_idArticulo);
            //_pa.setIdContacto(Conversiones.toInt(tb_contacto.Tag));

            _codigoContactoSeleccionado = _codigoContactoSeleccionadoAux;
            _razonSocialContactoSeleccionado = tb_contacto.Text;

            _pa.setPrecio(BC.Comun.currency_getValorFormateadoAsDouble(tb_precio.Text));
            _pa.setObservaciones(tb_observaciones.Text);
        }



        private double pvpMax;
        private double pvpMin;
        private double pvpPromedio;
        private void calcularMaxMinPromedio()
        {
            pvpMax = 0.0;
            pvpMin = 0.0;
            pvpPromedio = 0.0;

            double suma = 0.0;
            double numElementos = 0;

            foreach (DataGridViewRow r in grid.Rows)
            {
                double importeFila = Conversiones.toDouble(r.Cells["precio"].Value);
                if (importeFila != 0.0)
                {
                    suma += importeFila;
                    numElementos++;
                }
                if (importeFila > pvpMax)
                    pvpMax = importeFila;

                if (pvpMin == 0.0)
                    pvpMin = importeFila;
                else if (importeFila < pvpMin)
                    pvpMin = importeFila;
            }

            pvpPromedio = numElementos == 0 ? 0.0 : suma / (double)numElementos;

            tb_precioMedio.Text = BC.Comun.currency_getValorFormateadoAsString(pvpPromedio);
        }

        #endregion



        private void FormProveedorDeArticulo_Load(object sender, EventArgs e)
        {
            swichEditMode();
            cargarGrid();
        }



        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_editando && grid.CurrentRow != null)
            {
                DataGridViewRow fila = grid.Rows[e.RowIndex];
                if (fila != null)
                {
                    _codigoContactoSeleccionado = fila.Cells["codigo"].Value.ToString();
                    _codigoContactoSeleccionadoAux = _codigoContactoSeleccionado;
                    _razonSocialContactoSeleccionado = fila.Cells["razonSocial"].Value.ToString();

                    Int32 idContacto = Conversiones.toInt(grid.Rows[e.RowIndex].Cells["idContacto"].Value);

                    _pa = new BC.Articulos.ProveedorDeArticulo(_articulo.getIdArticulo(), idContacto);
                    instanceToForm();
                    b_borrar.Visible = true;
                } // if (fila != null)
            } // if (_!_editando...
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow fila = grid.Rows[e.RowIndex];
            string nombreColumna = grid.Columns[e.ColumnIndex].Name;

            if (fila != null)
            {
                if (nombreColumna == "precio")
                    e.Value = BC.Comun.currency_getValorFormateadoAsString(Conversiones.toDouble(e.Value));
            }
        }



        private void b_contacto_Click(object sender, EventArgs e)
        {
            if (_editando && !_pa._datoCargado)
            {
                BC.Contactos.SelectorDeContactos w = new BC.Contactos.SelectorDeContactos();
                w.sqlCondNotIn = " and esProveedor='s' and idContacto not in (select idContacto from t_proveedorDeArticulo where idArticulo=" + _articulo.getIdArticulo() + ")";
                w.ContactoSeleccionado += new BC.Contactos.SelectorDeContactos.DelegadoContactoSeleccionado(w_ContactoSeleccionado);
                w.Show();
            }
        }

        void w_ContactoSeleccionado(BC.Contactos.Contactos contactoSeleccionado)
        {
            _codigoContactoSeleccionadoAux = contactoSeleccionado.getCodigo();
            tb_contacto.Text = contactoSeleccionado.getRazonSocial();
            _pa.setIdContacto(contactoSeleccionado.getIdContacto());
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
            {
                TextBox tb = (TextBox)sender;
                tb.BackColor = Color.White;

                if (tb.Name == "tb_precio")
                    tb.Text = BC.Comun.currency_getValorFormateadoAsString(BC.Comun.currency_getValorDoubleFromString(tb.Text));
            }
            else if (sender.GetType() == typeof(CheckBox))
                ((CheckBox)sender).BackColor = Color.White;
        }



        private void b_nuevo_Click(object sender, EventArgs e)
        {
            _pa = new BC.Articulos.ProveedorDeArticulo();
            _pa.setIdArticulo(_articulo.getIdArticulo());
            _pa.setIdContacto(-1);

            _razonSocialContactoSeleccionado = "";
            _codigoContactoSeleccionado = "";

            instanceToForm();
            swichEditMode();
            b_contacto_Click(null, null);
        }

        private void b_editar_Click(object sender, EventArgs e)
        {
            if (_editando)
            {
                formToInstance();

                if (_pa.getIdContacto() != -1)
                {

                    bool esNuevo = !_pa._datoCargado;

                    _pa.guarda();

                    object[] v_row = { _pa.getIdContacto(), _codigoContactoSeleccionado, _razonSocialContactoSeleccionado, _pa.getPrecio() };
                    if (esNuevo)
                    {
                        ((DataTable)grid.DataSource).Rows.Add(v_row);
                        grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells["razonSocial"];
                    }
                    else
                        BC.Comun.setDataGridViewRowFromObjectV(v_row, grid.CurrentRow);

                    swichEditMode();

                    calcularMaxMinPromedio();
                    string msg = "";
                    if (_articulo.getPrecioCompra() != pvpMax &&
                        _articulo.getPrecioCompra() != pvpMin &&
                        _articulo.getPrecioCompra() != pvpPromedio)
                        msg = "El precio de compra actual del artículo no tiene relación con ninguno de los precios actuales.\r\n";

                    msg += "Precio de compra actual = " + BC.Comun.currency_getValorFormateadoAsString(_articulo.getPrecioCompra()) + "\r\n\r\n";
                    msg += "Precio mínimo = " + BC.Comun.currency_getValorFormateadoAsString(pvpMin) + "\r\n";
                    msg += "Precio máximo = " + BC.Comun.currency_getValorFormateadoAsString(pvpMax) + "\r\n";
                    msg += "Precio promedio = " + BC.Comun.currency_getValorFormateadoAsString(pvpPromedio) + "\r\n\r\n";
                    msg += "¿Desea actualizar automáticamente el precio del artículo a alguno de estos valores?";

                    if (BC.Comun.preguntaSiNo(msg, "Artículo") == DialogResult.Yes)
                    {
                        FormVariasOpciones w = new FormVariasOpciones("Indique el precio a tomar");
                        w.addOpcion(0, "Mínimo (" + BC.Comun.currency_getValorFormateadoAsString(pvpMin) + ")");
                        w.addOpcion(1, "Máximo (" + BC.Comun.currency_getValorFormateadoAsString(pvpMax) + ")");
                        w.addOpcion(2, "Promedio (" + BC.Comun.currency_getValorFormateadoAsString(pvpPromedio) + ")");

                        if (w.ShowDialog() == DialogResult.OK)
                        {
                            switch (w.getSelectedValue())
                            {
                                case 0:
                                    _articulo.setPrecioCompra(pvpMin);
                                    break;

                                case 1:
                                    _articulo.setPrecioCompra(pvpMax);
                                    break;

                                case 2:
                                    _articulo.setPrecioCompra(pvpPromedio);
                                    break;
                            }
                            _articulo.guarda();
                        } // if (w.showDialog()...
                    } // if (BC.Comun.preguntaSiNo...                    

                } // if (_pa.getIdContacto()
                else
                    System.Windows.Forms.MessageBox.Show("Ha de especificar un proveedor primero", "Proveedores de artículo");
            }
            else if (_pa != null)
                swichEditMode();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            instanceToForm();
            swichEditMode();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            if (BC.Comun.preguntaSiNo("¿Realmente quiere borrar este proveedor?", "Proveedores de artículo") == DialogResult.Yes)
            {
                _pa.borra();
                cargarGrid();

                if (grid.Rows.Count == 0)
                {
                    _pa = new BC.Articulos.ProveedorDeArticulo();
                    _pa.setIdArticulo(_articulo.getIdArticulo());

                    _razonSocialContactoSeleccionado = "";
                    _codigoContactoSeleccionado = "";

                    instanceToForm();
                }
            } // if (BC.Comun.preguntaSiNo...
        }

    } // end class
} // end namespace
