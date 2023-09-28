using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BC;
using LT48;

namespace MBC
{
    public partial class FormAlbaran : Form
    {
        private BC.Contactos.Contactos _contacto = null;
        private BC.Ventas.Albaran _albaran;
        private BC.Ventas.AlbaranA _lineaEdit = null;

        private bool _editandoLinea = false;

        private bool _botonGuardarPulsado = false;



        public FormAlbaran(Int32 idAlbaran)
        {
            InitializeComponent();
            _albaran = new BC.Ventas.Albaran(idAlbaran);
            _contacto = new BC.Contactos.Contactos(_albaran.getIdContacto());
        }

        public FormAlbaran(BC.Ventas.Albaran albaran)
        {
            InitializeComponent();
            _albaran = albaran;
            _contacto = new BC.Contactos.Contactos(_albaran.getIdContacto());
        }



        #region Procedimientos Albarán

        private void cargarGrid()
        {
            grid.DataSource = _albaran._t_albaranA;

            string[] columnasOcultar = { "idAlbaranA", "idAlbaran", "agrupado", "idArticulo", "datoCargado" };
            foreach(string columnaOcultar in columnasOcultar)
                try { grid.Columns[columnaOcultar].Visible = false; }
                catch { ;}

            //BC.Comun.grid_tituloAnchoColumna(grid, "agrupado", "Grupo", 50);
            BC.Comun.grid_tituloAnchoColumna(grid, "orden", "Orden", 50, BC.Comun.AlineacionColumna.Centro);
            BC.Comun.grid_tituloAnchoColumna(grid, "codigo", "Cod", 75, BC.Comun.AlineacionColumna.Derecha);
            BC.Comun.grid_tituloColumna(grid, "nombre", "Artículo");
            BC.Comun.grid_tituloAnchoColumna(grid, "cantidad", "Qty", 50, BC.Comun.AlineacionColumna.Derecha);
            BC.Comun.grid_tituloAnchoColumna(grid, "pvp_ori", "PVP", 75, BC.Comun.AlineacionColumna.Derecha);
            BC.Comun.grid_tituloAnchoColumna(grid, "dto", "Dto", 50, BC.Comun.AlineacionColumna.Centro);
            BC.Comun.grid_tituloAnchoColumna(grid, "pvpTotal", "Total", 75, BC.Comun.AlineacionColumna.Derecha);
            BC.Comun.grid_tituloAnchoColumna(grid, "iva", "IVA", 50, BC.Comun.AlineacionColumna.Centro);
            
            try { grid.Columns["iva"].Visible = mi_mostrarIVA.Checked; }
            catch { ;}

            grid.AllowUserToOrderColumns = false;
        }

        private void instanceToFormAlbaran()
        {
            tb_anio.Text = _albaran.getAnio().ToString();
            tb_numero.Text = _albaran.getNumero().ToString();
            dtp_fecha.Value = _albaran.getFechaAsDateTime();

            tb_contacto.Text = _contacto.getRazonSocial();

            tb_observaciones.Text = _albaran.getObservaciones();

            tb_pvp.Text = BC.Comun.currency_getValorFormateadoAsString(_albaran.getPvp());
            tb_sumaIVA.Text = BC.Comun.currency_getValorFormateadoAsString(_albaran.getSumaIVA());
            tb_total.Text = BC.Comun.currency_getValorFormateadoAsString(_albaran.getPvp() + _albaran.getSumaIVA());

            cargarGrid();
            calcularSumasEIVA_soloIVA();

            b_factura.Visible = _albaran._datoCargado;
            b_anio.Visible = _albaran._datoCargado && tb_anio.Text == "0" && tb_numero.Text == "0";
        }

        private void formToInstanceAlbaran()
        {
            _albaran.setAnio(Conversiones.toInt(tb_anio.Text));
            _albaran.setNumero(Conversiones.toInt(tb_numero.Text));
            _albaran.setFecha(dtp_fecha.Value);
            _albaran.setIdContacto(_contacto.getIdContacto());

            _albaran.setPvp(BC.Comun.currency_getValorDoubleFromString(tb_pvp.Text));
            _albaran.setSumaIVA(BC.Comun.currency_getValorDoubleFromString(tb_sumaIVA.Text));

            _albaran.setObservaciones(tb_observaciones.Text);            
        }



        private void calcularSumasEIVA()
        {
            double suma = 0.0;
            double sumaImpuestos = 0.0;

            // Iniciamos el grid que contendrá los valores del IVA
            if (gridIVA.DataSource == null)
            {
                DataTable tIVA = new DataTable();
                tIVA.Columns.Add("IVA", typeof(double));
                tIVA.Columns.Add("Suma", typeof(double));
                gridIVA.DataSource = tIVA;
            }
            else
                ((DataTable)gridIVA.DataSource).Rows.Clear();

            foreach (DataRow r in _albaran._t_albaranA.Rows)
            {
                BC.Ventas.AlbaranA linea = new BC.Ventas.AlbaranA(r.ItemArray);
                suma += linea.getPvpTotal();
                double valorSumaImpuestosAniadir = BC.Comun.currency_getIVAdeValor(linea.getPvpTotal(), linea.getIva());
                sumaImpuestos += valorSumaImpuestosAniadir;

                // Parcial de IVA para su grid
                calcularSumasEIVA_parteIVA(linea.getIva(), valorSumaImpuestosAniadir);
            }

            tb_pvp.Text = BC.Comun.currency_getValorFormateadoAsString(suma);
            tb_sumaIVA.Text = BC.Comun.currency_getValorFormateadoAsString(sumaImpuestos);
            tb_total.Text = BC.Comun.currency_getValorFormateadoAsString(suma + sumaImpuestos);
        }

        private void calcularSumasEIVA_soloIVA()
        {
            // Iniciamos el grid que contendrá los valores del IVA
            if (gridIVA.DataSource == null)
            {
                DataTable tIVA = new DataTable();
                tIVA.Columns.Add("IVA", typeof(double));
                tIVA.Columns.Add("Suma", typeof(double));
                gridIVA.DataSource = tIVA;
            }
            else
                ((DataTable)gridIVA.DataSource).Rows.Clear();

            foreach (DataRow r in _albaran._t_albaranA.Rows)
            {
                BC.Ventas.AlbaranA linea = new BC.Ventas.AlbaranA(r.ItemArray);
                calcularSumasEIVA_parteIVA(
                    linea.getIva(), 
                    BC.Comun.currency_getIVAdeValor(linea.getPvpTotal(), linea.getIva()));
            }
        }

        private void calcularSumasEIVA_parteIVA(double IVA_buscar, double valorSumar)
        {
            DataTable tIVA = ((DataTable)gridIVA.DataSource);

            DataRow[] rowDelIVA = null;
            try { rowDelIVA = tIVA.Select("IVA=" + IVA_buscar.ToString("0")); }
            catch (Exception ex) { Log.log("FormAlbaran.calcularSumasEIVA.Exception: " + ex.Message); }
            if (rowDelIVA != null && rowDelIVA.Length >= 1)
            {
                object[] o = rowDelIVA[0].ItemArray;
                double suma = Conversiones.toDouble(o[1]);
                suma = Conversiones.toDouble(BC.Comun.currency_getValorFormateadoAsString(suma));
                suma += valorSumar;
                o[1] = BC.Comun.currency_getValorFormateadoAsDouble(suma);
                rowDelIVA[0].ItemArray = o;
            }
            else if (rowDelIVA == null || rowDelIVA.Length == 0)
            {
                object[] o = { IVA_buscar, BC.Comun.currency_getValorFormateadoAsDouble(valorSumar) };
                tIVA.Rows.Add(o);
            }
        }

        #endregion



        #region Procedimientos línea de albarán

        private void calcularTotales()
        {
            double cantidad = Conversiones.toDouble(tb_a_cantidad.Text);
            double pvp = BC.Comun.currency_getValorDoubleFromString(tb_a_pvp_ori.Text);
            double dto = Conversiones.toDouble(tb_a_dto.Text);
            double iva = Conversiones.toDouble(tb_a_iva.Text);

            double totalConDto = BC.Comun.currency_getValorConDescuento(cantidad * pvp, dto);
            double parteIVA = BC.Comun.currency_getIVAdeValor(totalConDto, iva);

            tb_a_pvpTotal.Text = BC.Comun.currency_getValorFormateadoAsString(totalConDto);
            tb_a_totalPlusIVA.Text = BC.Comun.currency_getValorFormateadoAsString(totalConDto + parteIVA);
        }

        private void instanceToFormAlbaranA()
        {
            tb_a_grupo.Text = _lineaEdit.getAgrupado().ToString();
            tb_a_orden.Text = _lineaEdit.getOrden().ToString();
            tb_a_codigo.Text = _lineaEdit.getCodigo();
            tb_a_codigo.Tag = _lineaEdit.getIdArticulo();
            tb_a_articulo.Text = _lineaEdit.getNombre();
            tb_a_cantidad.Text = _lineaEdit.getCantidad().ToString("0.##");
            tb_a_pvp_ori.Text = BC.Comun.currency_getValorFormateadoAsString(_lineaEdit.getPvp_ori());
            tb_a_dto.Text = _lineaEdit.getDto().ToString("0.##");
            tb_a_pvpTotal.Text = BC.Comun.currency_getValorFormateadoAsString(_lineaEdit.getPvpTotal());
            tb_a_iva.Text = _lineaEdit.getIva().ToString("0");
            double totalPlusIVA = _lineaEdit.getPvpTotal() + BC.Comun.currency_getIVAdeValor(_lineaEdit.getPvpTotal(), _lineaEdit.getIva());
            tb_a_totalPlusIVA.Text = BC.Comun.currency_getValorFormateadoAsString(totalPlusIVA);
        }

        private void formToInstanceAlbaranA()
        {
            _lineaEdit.setAgrupado(tb_a_grupo.Text);
            _lineaEdit.setOrden(Conversiones.toInt(tb_a_orden.Text));
            _lineaEdit.setIdArticulo(Conversiones.toInt(tb_a_codigo.Tag));
            _lineaEdit.setCodigo(tb_a_codigo.Text);
            _lineaEdit.setNombre(tb_a_articulo.Text);
            _lineaEdit.setCantidad(Conversiones.toDouble(tb_a_cantidad.Text));
            _lineaEdit.setPvp_ori(BC.Comun.currency_getValorDoubleFromString(tb_a_pvp_ori.Text));
            _lineaEdit.setDto(Conversiones.toDouble(tb_a_dto.Text));
            _lineaEdit.setPvpTotal(BC.Comun.currency_getValorDoubleFromString(tb_a_pvpTotal.Text));
            _lineaEdit.setIva(Conversiones.toDouble(tb_a_iva.Text));
        }

        private Int32 maxOrden()
        {
            Int32 max = 0;
            foreach (DataGridViewRow r in grid.Rows)
            {
                Int32 ordenDeFila = Conversiones.toIntWN(r.Cells["orden"].Value);
                if (ordenDeFila > max)
                    max = ordenDeFila;
            }
            return max;
        }

        #endregion



        private void FormAlbaran_Load(object sender, EventArgs e)
        {
            instanceToFormAlbaran();
        }

        private void FormAlbaran_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_botonGuardarPulsado)
                try { BC.Comun.GeneraEnvioAInterfazComun("FormAlbaran_FormClosed", _albaran); }
                catch { ;}
        }

        private void b_anio_Click(object sender, EventArgs e)
        {
            if (_albaran.getAnio() == 0 || _albaran.getNumero() == 0)
            {
                b_anio_Click_do();

                if (tb_anio.Text != "0" && !_albaran._datoCargado)
                {
                    System.Windows.Forms.MessageBox.Show("Debe guardar primero para poder generar un número de albarán para este año");
                    tb_anio.Text = "0";
                    b_generarNumero.Visible = false;
                }
            }
            else
                System.Windows.Forms.MessageBox.Show("No se puede variar la numeración de un albarán con año ya guardado", "Albaranes");
        }
        private void b_anio_Click_do()
        {
            string sql = "select distinct anio from t_albaran where anio<>0";
            sql += " order by anio asc";
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch { t = null; }

            if (t == null)
                t.Columns.Add("anio", typeof(Int32));

            Int32 esteAnio = DateTime.Now.Year;
            bool esteAnioMetido = false;
            t.Rows.InsertAt(t.NewRow(), 0);
            object[] fila0 = { 0 };
            t.Rows[0].ItemArray = fila0;

            Int32 i = 0; Int32 numFilas = t.Rows.Count;
            while (i < numFilas && !esteAnioMetido)
            {
                esteAnioMetido = Conversiones.toInt(t.Rows[i].ItemArray[0]) == esteAnio;
                i++;
            }

            if (!esteAnioMetido)
            {
                object[] filaEsteAnio = { esteAnio };
                t.Rows.Add(filaEsteAnio);
            }


            FormVariasOpciones w = new FormVariasOpciones("Indique año");
            foreach (DataRow r in t.Rows)
            {
                Int32 valorAnio = Conversiones.toInt(r.ItemArray[0]);
                w.addOpcion(valorAnio, valorAnio.ToString());
            }
            w.setSelectedValue(Conversiones.toInt(tb_anio.Text));
            if (w.ShowDialog() == DialogResult.OK)
            {
                tb_anio.Text = w.getSelectedText();

                if (tb_anio.Text == "0")
                    tb_numero.BackColor = Color.White;
                else
                {
                    tb_numero.Text = "0";
                    tb_numero.BackColor = Color.FromArgb(192, 255, 255);
                }
            }
        }

        private void b_selectContacto_Click(object sender, EventArgs e)
        {
            BC.Contactos.SelectorDeContactos w = new BC.Contactos.SelectorDeContactos();
            w.ContactoSeleccionado += new BC.Contactos.SelectorDeContactos.DelegadoContactoSeleccionado(w_ContactoSeleccionado);
            w.Show();
        }

        void w_ContactoSeleccionado(BC.Contactos.Contactos contactoSeleccionado)
        {
            _contacto = contactoSeleccionado;
            tb_contacto.Text = _contacto.getRazonSocial();
        }

        private void b_view_contacto_Click(object sender, EventArgs e)
        {
            ;
        }

        private void tb_X_Enter(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                ((TextBox)sender).BackColor = Color.Cyan;
            }
        }

        private void tb_X_Leave(object sender, EventArgs e)
        {
            tb_X_Leave_sub(sender);
        }
        private void tb_X_Leave_sub(object sender)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                ((TextBox)sender).BackColor = Color.White;
            }
        }

        private void tb_numero_Enter(object sender, EventArgs e)
        {
            tb_numero.BackColor = Color.Cyan;
        }

        private void tb_numero_Leave(object sender, EventArgs e)
        {
            if (Conversiones.esInt(tb_numero.Text))
            {
                tb_numero.BackColor = tb_anio.Text == "0" ?  Color.White : Color.FromArgb(192, 255, 255);
            }
            else
            {
                tb_numero.BackColor = Color.Orange;
                tb_numero.Focus();
            }
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                b_edit.Enabled = true;
                b_remove.Enabled = true;
                _lineaEdit = new BC.Ventas.AlbaranA(Conversiones.DataGridViewRowToObjectArray(grid.CurrentRow));
            }
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                instanceToFormAlbaranA();
                tlpLinea.Visible = true;
                tb_a_codigo.Focus();
            }
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                instanceToFormAlbaranA();
                tlpLinea.Visible = true;
                tb_a_codigo.Focus();
            }
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            _lineaEdit = new BC.Ventas.AlbaranA();
            _lineaEdit.setIdAlbaran(_albaran.getIdAlbaran());
            _lineaEdit.setOrden(maxOrden() + 1);
            instanceToFormAlbaranA();
            tlpLinea.Visible = true;
            tb_a_codigo.Focus();
        }

        private void b_remove_Click(object sender, EventArgs e)
        {
            if (BC.Comun.preguntaSiNo("¿Realmente desea eliminar esta fila?", "Albarán") == DialogResult.Yes)
            {
                if (_lineaEdit._datoCargado)
                    _lineaEdit.borra();

                try { grid.Rows.Remove(grid.CurrentRow); }
                catch { ;}

                calcularSumasEIVA();

                if (_albaran._datoCargado)
                    _albaran.guarda();
            }            
        }

        private bool seHaSeleccionadoGuardarAlbaran = false;
        private void b_guardarAlbaran_Click(object sender, EventArgs e)
        {
            seHaSeleccionadoGuardarAlbaran = false;
            bool _datoCargadoAlPulsar = _albaran._datoCargado;

            _botonGuardarPulsado = true;
            bool seguir = true;

            if (tb_anio.Text.Trim() != "0" && tb_numero.Text.Trim() == "0")
            {
                string msg = @"No ha generado el número, si prosigue se colocará al año en 0 para que genere el número más adelante.
    ¿Desea Vd seguir?";
                if (BC.Comun.preguntaSiNo(msg, "Albaranes") == DialogResult.Yes)
                    tb_anio.Text = "0";
                else
                    seguir = false;
            }

            if (seguir)
            {
                formToInstanceAlbaran();
                _albaran.guarda();

                b_factura.Visible = true;
                seHaSeleccionadoGuardarAlbaran = true;

                string esteAnio = DateTime.Now.Year.ToString();
                if (!_datoCargadoAlPulsar && tb_numero.Text == "0" && BC.Comun.preguntaSiNo("¿Desea generar automáticamente un número de albarán en este año (" + esteAnio + ")?", "Albaranes") == DialogResult.Yes)
                {
                    tb_anio.Text = esteAnio;
                    b_generarNumero_Click(null, null);
                }
                else
                    b_anio.Visible = tb_anio.Text == "0" && tb_numero.Text == "0";
            } // if (seguir)
        }

        private void tb_codigo_Leave(object sender, EventArgs e)
        {
            tb_X_Leave_sub(sender);
            BC.Articulos.Articulos articuloBuscar = BC.Articulos.Articulos.getArticuloPorCodigo(tb_a_codigo.Text.Trim());
            if (articuloBuscar._datoCargado)
                w_ArticuloSeleccionado(articuloBuscar);
            else
                tb_a_codigo.Tag = -1; // Porque no es un artículo
        }

        private void b_articulo_Click(object sender, EventArgs e)
        {
            BC.Articulos.SelectorDeArticulos w = new BC.Articulos.SelectorDeArticulos();
            w.form_Text = "Indique artículo";
            w.ArticuloSeleccionado += new BC.Articulos.SelectorDeArticulos.DelegadoArticuloSeleccionado(w_ArticuloSeleccionado);
            w.Show();
        }

        void w_ArticuloSeleccionado(BC.Articulos.Articulos articuloSeleccionado)
        {
            tb_a_codigo.Tag = articuloSeleccionado.getIdArticulo();
            tb_a_codigo.Text = articuloSeleccionado.getCodigo();
            tb_a_articulo.Text = articuloSeleccionado.getNombre();

            double usarDescuento = 0.0;
            int usarTarifa = 1;
            double usarIVA = 0.0;
            if (_contacto != null)
            {
                usarDescuento = _contacto.getDescuento();
                usarTarifa = _contacto.getTarifa();
                usarIVA = _contacto.getAplicaIva() ? articuloSeleccionado.getIVA() : 0.0;
            }
            tb_a_dto.Text = usarDescuento.ToString("0.##");
            tb_a_pvp_ori.Text = BC.Comun.currency_getValorFormateadoAsString(
                usarTarifa == 1 ? articuloSeleccionado.getPrecioT1() :
                usarTarifa == 2 ? articuloSeleccionado.getPrecioT2() :
                articuloSeleccionado.getPrecioT3());
            tb_a_iva.Text = usarIVA.ToString("0");

            calcularTotales();
        }

        private void tb_cantidad_Leave(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                TextBox tb = (TextBox)sender;
                string tb_text = tb.Text.Replace(" ", "").Replace("€", "");
                if (Conversiones.esDouble(tb_text) || tb_text == "")
                {
                    tb_X_Leave_sub(sender);

                    if (tb.Name == "tb_a_cantidad" || tb.Name == "tb_a_dto" || tb.Name == "tb_a_iva")
                        tb.Text = Conversiones.toDouble(tb_text).ToString("0.##");
                    else if (tb.Name == "tb_a_pvp_ori")
                        tb.Text = BC.Comun.currency_getValorFormateadoAsString(Conversiones.toDouble(tb_text));

                    if (tb.Name == "tb_a_cantidad" || tb.Name == "tb_a_pvp_ori" || tb.Name == "tb_a_dto" || tb.Name == "tb_a_iva")
                        calcularTotales();
                }
                else
                {
                    tb.BackColor = Color.Orange;
                    tb.Focus();
                }
            }
        }

        private void b_cancelEdit_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
                _lineaEdit = new BC.Ventas.AlbaranA(LT48.Conversiones.DataGridViewRowToObjectArray(grid.CurrentRow));
            else
                _lineaEdit = new BC.Ventas.AlbaranA();

            esNuevo = false;

            tlpLinea.Visible = false;
        }

        private bool esNuevo = false;
        private void b_guardarLinea_Click(object sender, EventArgs e)
        {
            formToInstanceAlbaranA();

            if (esNuevo)
                _albaran._t_albaranA.Rows.Add(_lineaEdit.getInstanciaLikeARow());
            else
                LT48.Conversiones.ObjectArrayToDataGridViewRow(_lineaEdit.getInstanciaLikeARow(), grid.CurrentRow);

            tlpLinea.Visible = false;

            calcularSumasEIVA();

            esNuevo = false;
        }

        private void b_guardarLineaYOtro_Click(object sender, EventArgs e)
        {
            b_guardarLinea_Click(sender, e);

            _lineaEdit = new BC.Ventas.AlbaranA();
            _lineaEdit.setOrden(maxOrden() + 1);
            instanceToFormAlbaranA();

            esNuevo = true;

            tlpLinea.Visible = true;
            tb_a_codigo.Focus();
        }

        private void FormAlbaran_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tb_anio_TextChanged(object sender, EventArgs e)
        {
            tb_numero.ReadOnly = tb_anio.Text != "0";
            t_verBotonGenerarNumero.Enabled = true;
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView g = (DataGridView)sender;
            DataGridViewRow fila = g.Rows[e.RowIndex];
            string nombreColumna = g.Columns[e.ColumnIndex].Name;
            DataGridViewCell celda = g.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (fila != null && celda != null)
            {
                switch (nombreColumna)
                {
                    case "pvp_ori":
                    case "pvpTotal":
                        e.Value = BC.Comun.currency_getValorFormateadoAsString(Conversiones.toDouble(e.Value));
                        break;

                    case "cantidad":
                    case "iva":
                        e.Value = Conversiones.toDouble(e.Value).ToString("0");
                        break;

                    case "dto":
                        e.Value = Conversiones.toDouble(e.Value).ToString("0.##");
                        break;
                }
            }
        }

        private void gridIVA_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView g = (DataGridView)sender;
            DataGridViewRow fila = g.Rows[e.RowIndex];
            string nombreColumna = g.Columns[e.ColumnIndex].Name;
            if (fila != null && nombreColumna == "Suma")
                e.Value = BC.Comun.currency_getValorFormateadoAsString(Conversiones.toDouble(e.Value));
        }

        private void t_verBotonGenerarNumero_Tick(object sender, EventArgs e)
        {
            t_verBotonGenerarNumero.Enabled = false;
            b_generarNumero.Visible = tb_anio.Text != "0" && tb_numero.Text == "0";
        }

        private void b_generarNumero_Click(object sender, EventArgs e)
        {
            if (tb_anio.Text != "0" && tb_numero.Text == "0" && _albaran._datoCargado)
            {
                _albaran.generaNumero(Conversiones.toIntWN(tb_anio.Text));
                tb_anio.Text = _albaran.getAnio().ToString();
                tb_numero.Text = _albaran.getNumero().ToString();

                b_generarNumero.Visible = false;
                b_anio.Visible = false;
            }
        }

        private void mi_mostrarX_CheckedChanged(object sender, EventArgs e)
        {
            try { grid.Columns["orden"].Visible = mi_mostrarOrden.Checked; }
            catch { ;}
            try { grid.Columns["dto"].Visible = mi_mostrarDescuento.Checked; }
            catch { ;}
            try { grid.Columns["iva"].Visible = mi_mostrarIVA.Checked; }
            catch { ;}
        }



        Int32 lineaActual;
        private void b_imprime_Click(object sender, EventArgs e)
        {
            lineaActual = 0;

            FormVariasOpciones wvo = new FormVariasOpciones("Imprimir");
            wvo.addOpcion(0, "Vista previa");
            wvo.addOpcion(1, "Impresora predeterminada");

            if (wvo.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Printing.PrintDocument document = new System.Drawing.Printing.PrintDocument();
                document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(document_PrintPage);
                document.EndPrint += new System.Drawing.Printing.PrintEventHandler(document_EndPrint);

                if (wvo.getSelectedValue() == 0)
                {
                    PrintPreviewDialog w = new PrintPreviewDialog();
                    w.ShowIcon = false;
                    w.PrintPreviewControl.Zoom = 1.5;

                    BC.Comun.Form_ajustaTamanioYCentraForm(w, 90, 90);

                    w.Document = document;
                    w.ShowDialog();
                }
                else
                    document.Print();

            } // if (wvo.ShowDialog()...
        }

        void document_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // Volvemos a mostar columnas que se habían ocultado.
            ;
        }

        void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*
             * left=100 top=100 right=727 bottom=1069
             * ancho=627 alto=969
             */
            int yPos = e.MarginBounds.Top;
            
            int leftMargin = e.MarginBounds.Left;
            int righMargin = e.MarginBounds.Right;
            int anchoMarginTotal = Math.Abs(righMargin - leftMargin);
            int posicionCentro = leftMargin + anchoMarginTotal / 2;

            int auxMargin = leftMargin;

            Font fontNormal = new Font(this.Font, FontStyle.Regular);
            Font fontTitulo = new Font("Arial", 10, FontStyle.Bold);
            Font fontBold = new Font(fontNormal, FontStyle.Bold);
            Font fontBoldUnderline = new Font(fontNormal, FontStyle.Underline | FontStyle.Bold);

            int lineHeight = (int)fontNormal.GetHeight(e.Graphics);

            int altoResumenFinal = lineHeight * 10;

            string strAux = "";
            int anchoTextoAux = 0; 



            // Título (vamos a dejarle un alto de 200, suponiendo para el logo un tamaño máximo de 100)
            if (System.IO.File.Exists(@".\logo.jpg"))
            {
                e.Graphics.DrawImage(new Bitmap(@".\logo.jpg"), 10, 10);
                yPos = 150;
            }

            e.Graphics.DrawString("Albarán " + _albaran.getAnio() + "/" + _albaran.getNumero(), fontTitulo, Brushes.Black, leftMargin, yPos);
            yPos += (int)fontTitulo.GetHeight(e.Graphics);

            e.Graphics.DrawString("Fecha: " + _albaran.getFechaAsString(), fontNormal, Brushes.Black, leftMargin, yPos);
            //yPos += lineHeight;



            // Parte datos del contacto
            yPos = 50;
            auxMargin = posicionCentro;

            if (_contacto.getCodigo() != "")
            {
                strAux = "(" + _contacto.getCodigo() + ") ";
                anchoTextoAux = (int)e.Graphics.MeasureString(strAux, fontNormal).Width;

                e.Graphics.DrawString(strAux, fontNormal, Brushes.Black, auxMargin, yPos);
                auxMargin += anchoTextoAux;
            }
            e.Graphics.DrawString(_contacto.getRazonSocial(), fontBold, Brushes.Black, auxMargin, yPos);

            BC.Contactos.Direcciones _direccion = BC.Contactos.Direcciones.getDireccionPredeterminadaDe(_contacto.getIdContacto());
            if (_direccion._datoCargado)
            {
                yPos += lineHeight + 10;
                auxMargin = posicionCentro;
                e.Graphics.DrawString(_direccion.getDireccion(), fontNormal, Brushes.Black, auxMargin, yPos);
                // El alto de la dirección es el alto que ocuparía desde auxMargin hasta rightMargin
                yPos += (int)e.Graphics.MeasureString(_direccion.getDireccion(), fontNormal, righMargin - auxMargin).Height + 5;

                strAux = _direccion.getCp() != "" ? _direccion.getCp() + " " : "";
                strAux += _direccion.getLocalidad();
                e.Graphics.DrawString(strAux, fontNormal, Brushes.Black, auxMargin, yPos);
                yPos += lineHeight;

                strAux = _direccion.getProvincia();
                if (_direccion.getPais() != "" && _direccion.getPais().ToUpper() != "ESPAÑA")
                    strAux += "     " + _direccion.getPais().ToUpper();
                e.Graphics.DrawString(strAux, fontNormal, Brushes.Black, auxMargin, yPos);
            }



            yPos = 200;
            auxMargin = leftMargin;

            // Imprimir los títulos del listado
            foreach (DataGridViewColumn c in grid.Columns)
                if (c.Visible)// && auxMargin < righMargin - 100)
                {
                    strAux = c.HeaderText;
                    anchoTextoAux = (int)e.Graphics.MeasureString(strAux, fontBoldUnderline).Width;

                    int ancho = tamanioProporcional(c.Width, grid.Width, anchoMarginTotal);
                    int desplazamiento = BC.Comun.grid_desplazamientoParaCentrarAlImprimir(c, anchoTextoAux, ancho);

                    e.Graphics.DrawString(strAux, fontBoldUnderline, Brushes.Black, auxMargin + desplazamiento, yPos);
                    auxMargin += tamanioProporcional(c.Width, grid.Width, anchoMarginTotal);
                }

            yPos += (int)fontBoldUnderline.GetHeight(e.Graphics) + 5;


            
            // Imprimir las líneas
            while (yPos < (e.MarginBounds.Bottom - altoResumenFinal) && lineaActual < grid.Rows.Count)
            {
                DataGridViewRow fila = grid.Rows[lineaActual];
                
                auxMargin = leftMargin;

                foreach (DataGridViewColumn c in grid.Columns)
                    if (c.Visible)// && auxMargin < righMargin - 100)
                    {
                        strAux = fila.Cells[c.Name].FormattedValue.ToString();
                        anchoTextoAux = (int)e.Graphics.MeasureString(strAux, fontNormal).Width;

                        int ancho = tamanioProporcional(c.Width, grid.Width, anchoMarginTotal);
                        int desplazamiento = BC.Comun.grid_desplazamientoParaCentrarAlImprimir(c, anchoTextoAux, ancho);

                        e.Graphics.DrawString(strAux, fontNormal, Brushes.Black, auxMargin + desplazamiento, yPos);
                        auxMargin += ancho;
                    }

                lineaActual++;
                yPos += lineHeight;
            }

            // Imprimimos el resumen
            if (lineaActual >= grid.Rows.Count)
            {
                e.Graphics.DrawLine(Pens.Black, new Point(leftMargin, yPos + lineHeight), new Point(righMargin, yPos + lineHeight));

                yPos += lineHeight * 3;
                int iniYpos = yPos;

                Font fontResumen = new Font(fontNormal, FontStyle.Bold);
                anchoTextoAux = (int)e.Graphics.MeasureString("Suma IVA: ", fontResumen).Width;
                posicionCentro = righMargin - (int)((double)anchoTextoAux * 2.5);

                anchoTextoAux = (int)e.Graphics.MeasureString(tb_pvp.Text, fontNormal).Width;
                e.Graphics.DrawString("Suma: ", fontResumen, Brushes.Black, posicionCentro, yPos);
                e.Graphics.DrawString(tb_pvp.Text, fontNormal, Brushes.Black, righMargin - anchoTextoAux, yPos);
                yPos += lineHeight + 2;

                anchoTextoAux = (int)e.Graphics.MeasureString(tb_sumaIVA.Text, fontNormal).Width;
                e.Graphics.DrawString("Suma IVA: ", fontResumen, Brushes.Black, posicionCentro, yPos);
                e.Graphics.DrawString(tb_sumaIVA.Text, fontNormal, Brushes.Black, righMargin - anchoTextoAux, yPos);
                yPos += lineHeight + 2;

                anchoTextoAux = (int)e.Graphics.MeasureString(tb_total.Text, fontNormal).Width;
                e.Graphics.DrawString("Total: ", fontResumen, Brushes.Black, posicionCentro, yPos);
                e.Graphics.DrawString(tb_total.Text, fontNormal, Brushes.Black, righMargin - anchoTextoAux, yPos);
                yPos += lineHeight + 2;

                if (tb_observaciones.Text != "")
                {
                    yPos = iniYpos;
                    auxMargin = leftMargin;
                    e.Graphics.DrawString("Observaciones", fontBoldUnderline, Brushes.Black, auxMargin, yPos);
                    yPos += (int)e.Graphics.MeasureString("Observaciones", fontBoldUnderline).Height + 5;
                    e.Graphics.DrawString(tb_observaciones.Text, fontNormal, Brushes.Black, new RectangleF(auxMargin, yPos, auxMargin + anchoMarginTotal / 2, e.MarginBounds.Bottom - yPos - 3 * lineHeight));
                }
            }


            if (lineaActual < grid.Rows.Count)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private int tamanioProporcional(int tamanioAEscalar, int tamanioIni, int tamanioFin)
        {
            double d_tamanioAEscalar = (double)tamanioAEscalar;
            double d_tamanioIni = (double)tamanioIni;
            double d_tamanioFin = (double)tamanioFin;

            // tamanioIni       - 100
            // tamanioAEscalar  -   x   x = tamanioAEscalar * 100 / tamanioIni

            // tamanioFin       - 100
            // nuevoTamanio     - x     nuevoTamaio = x*tamanioFin/100
            double aux = d_tamanioIni == 0 ? d_tamanioAEscalar : d_tamanioAEscalar * d_tamanioFin / d_tamanioIni;
            return (int)aux;
        }



        private void t_quitarTopMost_Tick(object sender, EventArgs e)
        {
            t_quitarTopMost.Enabled = false;
            this.TopMost = false;
        }



        private void b_factura_Click(object sender, EventArgs e)
        {
            b_guardarAlbaran_Click(null, null);
            if (seHaSeleccionadoGuardarAlbaran)
            {
                BC.Ventas.Factura factura = null;
                if (_albaran.getIdFactura() == -1)
                {
                    if (BC.Comun.preguntaSiNo("No existe factura para este albarán. ¿Desea crear una?", "Facturas") == DialogResult.Yes)
                    {
                        factura = new BC.Ventas.Factura();
                        factura.setIdContacto(_albaran.getIdContacto());
                        factura.addAlbaran(_albaran.getIdAlbaran());
                        factura.setPvp(_albaran.getPvp());
                        factura.setSumaIVA(_albaran.getSumaIVA());
                    }
                }
                else
                    factura = new BC.Ventas.Factura(_albaran.getIdFactura());

                if (factura != null)
                {
                    BC.Comun.GeneraEnvioAInterfazComun("abrir_factura", factura);
                    this.Close();
                }
            }
        }

    } // end class
} // end namespace
