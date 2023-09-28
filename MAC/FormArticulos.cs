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
    public partial class FormArticulos : Form
    {
        private bool _editando = true;
        private BC.Articulos.Articulos _articulo = new BC.Articulos.Articulos();

        public FormArticulos()
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

                tb_codigo.Focus();
            }
            else
            {
                b_editar.Text = "Editar";
                b_editar.Image = MAC.Properties.Resources.edit_square16_h_c;
            }

            p_left.Enabled = !_editando;

            bool ro = !_editando;
            tb_codigo.ReadOnly = ro;
            tb_referencia.ReadOnly = ro;
            tb_nombre.ReadOnly = ro;
            tb_descripcion.ReadOnly = ro;
            tb_observaciones.ReadOnly = ro;
            tb_precioT1.ReadOnly = ro;
            tb_precioT2.ReadOnly = ro;
            tb_precioT3.ReadOnly = ro;
            tb_precioCompra.ReadOnly = ro;
            tb_IVA.ReadOnly = ro;
            tb_stock.ReadOnly = ro;
            tb_stockMin.ReadOnly = ro;

            cb_soloCompra.AutoCheck = _editando;
            cb_soloVenta.AutoCheck = _editando;

            cb_activo.AutoCheck = _editando;
            cb_visible.AutoCheck = _editando;

            b_add_familia.Visible = _editando;
            b_remove_familia.Visible = _editando;

            tlp_botones.Enabled = !_editando;
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
            string sql = "select idArticulo, codigo, nombre, activo, visible from t_articulos";
            string filtro1 = tb_f_1.Text.Trim();
            if (filtro1 != "")
                sql += " where nombre like '%" + filtro1 + "%' or codigo='" + filtro1 + "'";
            sql += " order by nombre asc";

            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("FormArticulos.cargarGrid_do.Exception: " + ex.Message); t = null; }

            if (t != null)
            {
                grid.DataSource = t;

                string[] columnasOcultar = { "idArticulo", "activo", "visible" };
                foreach (string columnaOcultar in columnasOcultar)
                    try { grid.Columns[columnaOcultar].Visible = false; }
                    catch { ;}

                BC.Comun.grid_tituloAnchoColumna(grid, "codigo", "#", 50);
                BC.Comun.grid_tituloColumna(grid, "nombre", "Artículo");

                if (grid.Rows.Count > 0)
                    grid.CurrentCell = grid.Rows[0].Cells["nombre"];
            }
        }

        private void instanceToForm()
        {
            tb_idArticulo.Text = _articulo.getIdArticulo() >= 0 ? _articulo.getIdArticulo().ToString() : "";
            tb_codigo.Text = _articulo.getCodigo();
            tb_referencia.Text = _articulo.getReferencia();
            tb_nombre.Text = _articulo.getNombre();
            tb_descripcion.Text = _articulo.getDescripcion();
            tb_observaciones.Text = _articulo.getObservaciones();

            tb_precioT1.Text = BC.Comun.currency_getValorFormateadoAsString(_articulo.getPrecioT1());
            tb_precioT2.Text = BC.Comun.currency_getValorFormateadoAsString(_articulo.getPrecioT2());
            tb_precioT3.Text = BC.Comun.currency_getValorFormateadoAsString(_articulo.getPrecioT3());
            tb_precioCompra.Text = BC.Comun.currency_getValorFormateadoAsString(_articulo.getPrecioCompra());
            tb_IVA.Text = _articulo.getIVA().ToString("0");

            tb_stock.Text = _articulo.getStock().ToString("0.#");
            tb_stockMin.Text = _articulo.getStockMin().ToString("0.#");

            tb_familias.Text = BC.Articulos.Articulos.getNombresFamiliasDeArticulo(_articulo.getIdArticulo());

            cb_soloCompra.Checked = _articulo.getSoloCompra();
            cb_soloVenta.Checked = _articulo.getSoloVenta();
            cb_activo.Checked = _articulo.getActivo();
            cb_visible.Checked = _articulo.getVisible();
        }

        private void formToInstance()
        {
            _articulo.setCodigo(tb_codigo.Text.Trim());
            _articulo.setReferencia(tb_referencia.Text.Trim());
            _articulo.setNombre(tb_nombre.Text);
            _articulo.setDescripcion(tb_descripcion.Text);
            _articulo.setObservaciones(tb_observaciones.Text);
            _articulo.setPrecioT1(BC.Comun.currency_getValorFormateadoAsDouble(tb_precioT1.Text.Trim()));
            _articulo.setPrecioT2(BC.Comun.currency_getValorFormateadoAsDouble(tb_precioT2.Text.Trim()));
            _articulo.setPrecioT3(BC.Comun.currency_getValorFormateadoAsDouble(tb_precioT3.Text.Trim()));
            _articulo.setPrecioCompra(BC.Comun.currency_getValorFormateadoAsDouble(tb_precioCompra.Text.Trim()));
            _articulo.setIVA(Conversiones.toDouble(tb_IVA.Text.Trim()));

            _articulo.setStock(Conversiones.toDouble(tb_stock.Text));
            _articulo.setStockMin(Conversiones.toDouble(tb_stockMin.Text));

            _articulo.setSoloCompra(cb_soloCompra.Checked);
            _articulo.setSoloVenta(cb_soloVenta.Checked);

            _articulo.setActivo(cb_activo.Checked);
            _articulo.setVisible(cb_visible.Checked);
        }

        private bool comprobarDatosCorrectos()
        {
            bool aux = true;
            bool hayCodigoRepetido = false;

            string codigoCheck = tb_codigo.Text.Trim();
            string referenciaCheck = tb_referencia.Text.Trim();

            if (codigoCheck != "" || referenciaCheck != "")
            {
                string or = "";
                string sql = "select codigo, referencia, nombre from t_articulos where idArticulo<>" + _articulo.getIdArticulo();               
                sql += " and (";

                if (codigoCheck != "")
                {
                    sql += "codigo='" + codigoCheck + "'";
                    or = " or ";
                }
                if (referenciaCheck != "")
                    sql += or + "referencia='" + referenciaCheck + "'";

                sql += ")";

                DataTable t;
                try { t = DB.getDataTable_CCP(sql); }
                catch (Exception ex) { Log.log("FormArticulos.comprobarDatosCorrectos.Exception: " + ex.Message); t = null; }

                if (t != null && t.Rows.Count > 0)
                {
                    string msg = "Se han encontrado los siguientes errores:\r\n";
                    Int32 cuenta = 0;
                    Int32 maxMostrar = Math.Min(10, t.Rows.Count);
                    while (cuenta < maxMostrar)
                    {
                        DataRow r = t.Rows[cuenta];

                        string cod_found = r.ItemArray[0].ToString();
                        string ref_found = r.ItemArray[1].ToString();
                        string nombre_found = r.ItemArray[2].ToString();

                        string y = " tiene";
                        msg += " - " + nombre_found;
                        if (codigoCheck != "" && cod_found == codigoCheck)
                        {
                            msg += " tiene el mismo código";
                            y = " y";
                            hayCodigoRepetido = true;
                            aux = false;
                        }

                        if (referenciaCheck != "" && ref_found == referenciaCheck)
                            msg += y + " la misma referencia";

                        msg += "\r\n";

                        cuenta++;
                    } // whlile

                    if (cuenta < t.Rows.Count)
                        msg += "...";

                    if (!hayCodigoRepetido)
                    {
                        msg += "¿Es esto correcto?";
                        if (BC.Comun.preguntaSiNo(msg, "Artículos") == DialogResult.No)
                            aux = false;
                    }
                    else
                        System.Windows.Forms.MessageBox.Show(msg + "\r\nIndique otro código para poder guardar", "Artículos");

                } // if (t != null && t.Rows.Count > 0)
            } // if (codigoCheck != "" || referenciaCheck != "")
            return aux;
        }

        private void comprobarDatosCorrectos_precios()
        {
            double pvpT1 = BC.Comun.currency_getValorFormateadoAsDouble(tb_precioT1.Text);
            double pvpT2 = BC.Comun.currency_getValorFormateadoAsDouble(tb_precioT2.Text);
            double pvpT3 = BC.Comun.currency_getValorFormateadoAsDouble(tb_precioT3.Text);

            if (pvpT1 != 0.0 && (pvpT2 == 0.0 || pvpT3 == 0.0) && DateTime.Now.ToString("yyyyMMdd") == _articulo.getFechaCrea())
            {
                string msg = "No ha especificado el precio de ";
                string nide = "";
                if (pvpT2 == 0.0)
                {
                    msg += " Tarifa 2";
                    nide = " ni de";
                }
                if (pvpT3 == 0)
                    msg += nide + " Tarifa 3";

                msg += ".\r\n¿Quiere copiar los valores de la Tarifa 1 en estas dos tarifas?";

                if (BC.Comun.preguntaSiNo(msg, "Artículos") == DialogResult.Yes)
                {
                    if (pvpT2 == 0.0)
                        tb_precioT2.Text = tb_precioT1.Text;

                    if (pvpT3 == 0.0)
                        tb_precioT3.Text = tb_precioT1.Text;
                }
            }
        }

        #endregion






        private void FormArticulos_Load(object sender, EventArgs e)
        {
            tlp_observaciones.Visible = false;
            tlp_precios.Visible = false;
            tlp_stock.Visible = false;

            swichEditMode();
            cargarGrid();
        }



        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_editando && grid.CurrentRow != null)
            {
                Int32 idArticuloCargar = Conversiones.toIntWN(grid.CurrentRow.Cells["idArticulo"].Value);
                _articulo = new BC.Articulos.Articulos(idArticuloCargar);
                instanceToForm();
            }
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow fila = grid.Rows[e.RowIndex];
            string nombreColumna = grid.Columns[e.ColumnIndex].Name;

            if (fila != null)
            {
                if (nombreColumna == "nombre")
                {
                    bool valorActivo = fila.Cells["activo"].Value.ToString() == "s";
                    bool valorVisible = fila.Cells["visible"].Value.ToString() == "s";

                    fila.DefaultCellStyle.Font = valorActivo ? grid.DefaultCellStyle.Font : new Font(grid.DefaultCellStyle.Font, FontStyle.Strikeout);
                    fila.DefaultCellStyle.ForeColor = valorVisible ? Color.Black : Color.Silver;
                    fila.DefaultCellStyle.SelectionForeColor = valorVisible ? grid.DefaultCellStyle.SelectionForeColor : Color.Silver;
                }
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
            {
                TextBox tb = (TextBox)sender;
                tb.BackColor = Color.White;

                if (tb.Name == "tb_precioT1" || tb.Name == "tb_precioT2" ||
                    tb.Name == "tb_precioT3" || tb.Name == "tb_precioCompra")
                    tb.Text = BC.Comun.currency_getValorFormateadoAsString(BC.Comun.currency_getValorDoubleFromString(tb.Text));

                if (tb.Name == "tb_stock" || tb.Name == "tb_stockMin")
                    tb.Text = Conversiones.toDouble(tb.Text).ToString("0.#");
            }
            else if (sender.GetType() == typeof(CheckBox))
                ((CheckBox)sender).BackColor = Color.White;
        }


        
        private bool _teclaPulsada = false;
        private void tb_f_1_TextChanged(object sender, EventArgs e)
        {
            _teclaPulsada = true;
            t_filtro.Enabled = true;
        }

        private void t_filtro_Tick(object sender, EventArgs e)
        {
            if (!_cargandoGrid)
            {
                if (!_teclaPulsada)
                {
                    t_filtro.Enabled = false;

                    if (!BC.Comun.grid_buscadorEnGridPorPosicionamiento(tb_f_1.Text, grid))
                        cargarGrid();
                }
                _teclaPulsada = false;
            }
        }

        private void b_f_search_Click(object sender, EventArgs e)
        {
            if (!_cargandoGrid)
            {
                t_filtro.Enabled = false;
                cargarGrid();

                grid.Focus();
            }
        }

        private void b_f_alt_Click(object sender, EventArgs e)
        {
            t_filtro_2.Visible = !t_filtro_2.Visible;
        }



        private void b_nuevo_Click(object sender, EventArgs e)
        {
            _articulo = new BC.Articulos.Articulos();
            instanceToForm();
            swichEditMode();
        }

        private void b_editar_Click(object sender, EventArgs e)
        {
            if (_editando)
            {
                if (comprobarDatosCorrectos())
                {
                    comprobarDatosCorrectos_precios();

                    formToInstance();

                    bool esNuevo = !_articulo._datoCargado;

                    _articulo.guarda();

                    // idArticulo, codigo, nombre, activo, visible
                    object[] o = { _articulo.getIdArticulo(),
                           _articulo.getCodigo(),
                           _articulo.getNombre(),
                           _articulo.getActivo() ? "s" : "n",
                           _articulo.getVisible() ? "s" : "n" };

                    if (esNuevo)
                    {
                        ((DataTable)grid.DataSource).Rows.Add(o);
                        grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells["nombre"];
                    }
                    else
                        BC.Comun.setDataGridViewRowFromObjectV(o, grid.CurrentRow);

                    swichEditMode();
                } // if (comprobarDatosCorrectos)
            } // if (_editando)
            else if (_articulo != null && _articulo._datoCargado)
                swichEditMode();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            instanceToForm();
            swichEditMode();
        }



        private void cb_X_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            cb.Text = cb.Checked ? "Si" : "No";
        }



        private void FormArticulos_Activated(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void FormArticulos_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.FromKnownColor(KnownColor.Control);
        }



        private void b_observaciones_Click(object sender, EventArgs e)
        {
            tlp_observaciones.Visible = !tlp_observaciones.Visible;
        }

        private void b_tarifas_Click(object sender, EventArgs e)
        {
            tlp_precios.Visible = !tlp_precios.Visible;
        }

        private void b_stock_Click(object sender, EventArgs e)
        {
            tlp_stock.Visible = !tlp_stock.Visible;
        }

        private void b_imagen_Click(object sender, EventArgs e)
        {
            if (_articulo._datoCargado)
                //BC.Comun.abrirCarpeta(_articulo.getPath());
                System.Windows.Forms.MessageBox.Show("No implementado");
            else
                System.Windows.Forms.MessageBox.Show("Ha de guardar primero el artículo");
        }

        private void b_archivos_Click(object sender, EventArgs e)
        {
            if (_articulo._datoCargado)
                BC.Comun.abrirCarpeta(_articulo.getPath());
            else
                System.Windows.Forms.MessageBox.Show("Ha de guardar primero el artículo");
        }

        private void b_proveedorDeArticulo_Click(object sender, EventArgs e)
        {
            new FormProveedorDeArticulo(_articulo).ShowDialog();
            tb_precioCompra.Text = BC.Comun.currency_getValorFormateadoAsString(_articulo.getPrecioCompra());
        }


        
        private void mi_familias_Click(object sender, EventArgs e)
        {
            new FormFamiliasArticulos().ShowDialog();
        }



        private void b_add_familia_Click(object sender, EventArgs e)
        {
            if (_editando)
                if (_articulo._datoCargado)
                {
                    Int32 idAniadir = BC.Articulos.FamiliasArticulos.FormVariasOpcionesFamiliasArticulos(_articulo.getIdArticulo(), true);
                    if (idAniadir != -1)
                    {
                        BC.Articulos.Articulos.addFamiliaAArticulo(_articulo.getIdArticulo(), idAniadir);
                        tb_familias.Text = BC.Articulos.Articulos.getNombresFamiliasDeArticulo(_articulo.getIdArticulo());
                    }
                }
                else
                    System.Windows.Forms.MessageBox.Show("Ha de guardar primero el artículo");
        }

        private void b_remove_familia_Click(object sender, EventArgs e)
        {
            if (_editando)
                if (_articulo._datoCargado)
                {
                    Int32 idQuitar = BC.Articulos.FamiliasArticulos.FormVariasOpcionesFamiliasArticulos(_articulo.getIdArticulo(), false);
                    if (idQuitar != -1)
                    {
                        BC.Articulos.Articulos.removeFamiliaDeArticulo(_articulo.getIdArticulo(), idQuitar);
                        tb_familias.Text = BC.Articulos.Articulos.getNombresFamiliasDeArticulo(_articulo.getIdArticulo());
                    }
                }
                else
                    System.Windows.Forms.MessageBox.Show("Ha de guardar primero el artículo");
        }

        private void tb_stock_TextChanged(object sender, EventArgs e)
        {
            double valorStock = Conversiones.toDouble(tb_stock.Text);
            double valorStockMin = Conversiones.toDouble(tb_stockMin.Text);

            if (valorStockMin > 0)
            {
                if (valorStock <= 0)
                    tb_stock.ForeColor = Color.Red;
                else if (valorStock < valorStockMin)
                    tb_stock.ForeColor = Color.DarkOrange;
                else
                    tb_stock.ForeColor = Color.Green;
            }
            else
            {
                if (valorStock < 0)
                    tb_stock.ForeColor = Color.Red;
                else
                    tb_stock.ForeColor = Color.Black;
            }
        }

    } // end class
} // end namespace
