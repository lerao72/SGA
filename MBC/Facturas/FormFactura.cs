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
    public partial class FormFactura : Form
    {
        private BC.Contactos.Contactos _contacto = null;
        private BC.Ventas.Factura _factura;

        private bool _editandoLinea = false;

        private bool _botonGuardarPulsado = false;



        public FormFactura(Int32 idFactura)
        {
            InitializeComponent();
            _factura = new BC.Ventas.Factura(idFactura);
            _contacto = new BC.Contactos.Contactos(_factura.getIdContacto());
        }

        public FormFactura(BC.Ventas.Factura factura)
        {
            InitializeComponent();
            _factura = factura;
            _contacto = new BC.Contactos.Contactos(_factura.getIdContacto());
        }



        #region Procedimientos Factura

        private void cargarGrid()
        {
            grid.DataSource = _factura._t_albaranA;

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

        private void instanceToFormFactura()
        {
            tb_anio.Text = _factura.getAnio().ToString();
            tb_numero.Text = _factura.getNumero().ToString();
            dtp_fecha.Value = _factura.getFechaAsDateTime();

            tb_contacto.Text = _contacto.getRazonSocial();

            tb_observaciones.Text = _factura.getObservaciones();

            tb_pvp.Text = BC.Comun.currency_getValorFormateadoAsString(_factura.getPvp());
            tb_sumaIVA.Text = BC.Comun.currency_getValorFormateadoAsString(_factura.getSumaIVA());
            tb_total.Text = BC.Comun.currency_getValorFormateadoAsString(_factura.getPvp() + _factura.getSumaIVA());

            cargarGrid();
            calcularSumasEIVA_soloIVA();

            b_cobros.Enabled = _factura._datoCargado;
            b_anio.Visible = _factura._datoCargado && tb_anio.Text == "0" && tb_numero.Text == "0";
        }

        private void formToInstanceFactura()
        {
            _factura.setAnio(Conversiones.toInt(tb_anio.Text));
            _factura.setNumero(Conversiones.toInt(tb_numero.Text));
            _factura.setFecha(dtp_fecha.Value);
            _factura.setIdContacto(_contacto.getIdContacto());

            _factura.setPvp(BC.Comun.currency_getValorDoubleFromString(tb_pvp.Text));
            _factura.setSumaIVA(BC.Comun.currency_getValorDoubleFromString(tb_sumaIVA.Text));

            _factura.setObservaciones(tb_observaciones.Text);            
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

            foreach (DataRow r in _factura._t_albaranA.Rows)
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

            foreach (DataRow r in _factura._t_albaranA.Rows)
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
            catch (Exception ex) { Log.log("FormFactura.calcularSumasEIVA.Exception: " + ex.Message); }
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






        private void FormFactura_Load(object sender, EventArgs e)
        {
            instanceToFormFactura();
        }

        private void FormFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_botonGuardarPulsado)
                try { BC.Comun.GeneraEnvioAInterfazComun("FormFactura_FormClosed", _factura); }
                catch { ;}
        }

        private void b_anio_Click(object sender, EventArgs e)
        {
            if (_factura.getAnio() == 0 || _factura.getNumero() == 0)
            {
                b_anio_Click_do();

                if (tb_anio.Text != "0" && !_factura._datoCargado)
                {
                    System.Windows.Forms.MessageBox.Show("Debe guardar primero para poder generar un número de factura para este año");
                    tb_anio.Text = "0";
                    b_generarNumero.Visible = false;
                }
            }
            else
                System.Windows.Forms.MessageBox.Show("No se puede variar la numeración de una factura con año ya guardado", "Facturas");
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
            // Para la factura quito la opción de añadir el año 0
            //t.Rows.InsertAt(t.NewRow(), 0);
            //object[] fila0 = { 0 };
            //t.Rows[0].ItemArray = fila0;

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

        private void b_add_Click(object sender, EventArgs e)
        {
            BC.Ventas.SelectorDeAlbaranesDeContacto w = new BC.Ventas.SelectorDeAlbaranesDeContacto();
            
            w.idContactoFiltrar = _factura.getIdContacto();
            w.mostrarSoloNoFacturados = true;
            w.mostrarOpcionDeNuevoAlbaran = false;
            w.form_cerrarTrasSeleccionar = true;

            w.AlbaranSeleccionado += new BC.Ventas.SelectorDeAlbaranesDeContacto.DelegadoAlbaranSeleccionado(w_AlbaranSeleccionado);

            w.form_porcAlto = 50;
            w.form_porcAncho = 30;
            w.Show();
        }

        private void w_AlbaranSeleccionado(BC.Ventas.Albaran albaranSeleccionado)
        {
            if (albaranSeleccionado._datoCargado)
            {
                _factura.addAlbaran(albaranSeleccionado.getIdAlbaran());
                calcularSumasEIVA();
            }
        }

        private void b_remove_Click(object sender, EventArgs e)
        {
            FormVariasOpciones w = new FormVariasOpciones("Indique albarán a quitar");
            w.addOpcion(0, "Ninguno");
            foreach (DataRow r in _factura._t_albaran.Rows)
            {
                BC.Ventas.Albaran candidatoAQuitar = new BC.Ventas.Albaran(r.ItemArray);
                w.addOpcion(candidatoAQuitar.getIdAlbaran(), candidatoAQuitar.getAnio() + "/" + candidatoAQuitar.getNumero());
            } // foreach

            if (w.ShowDialog() == DialogResult.OK)
            {
                Int32 idQuitar = w.getSelectedValue();
                if (idQuitar > 0)
                {
                    _factura.removeAlbaran(idQuitar);
                    calcularSumasEIVA();
                }
            } // if (w.ShowDialog() == ...
        }

        private void b_guardar_Click(object sender, EventArgs e)
        {
            bool _datoCargadoAlPulsar = _factura._datoCargado;

            _botonGuardarPulsado = true;
            bool seguir = true;

            if (tb_anio.Text.Trim() != "0" && tb_numero.Text.Trim() == "0")
            {
                string msg = @"No ha generado el número, si prosigue se colocará al año en 0 para que genere el número más adelante.
    ¿Desea Vd seguir?";
                if (BC.Comun.preguntaSiNo(msg, "Facturas") == DialogResult.Yes)
                    tb_anio.Text = "0";
                else
                    seguir = false;
            }

            if (seguir)
            {
                formToInstanceFactura();
                _factura.guarda();

                b_cobros.Enabled = true;

                string esteAnio = DateTime.Now.Year.ToString();
                if (!_datoCargadoAlPulsar && BC.Comun.preguntaSiNo("¿Desea generar automáticamente un número de factura en este año (" + esteAnio + ")?", "Factura") == DialogResult.Yes)
                {
                    tb_anio.Text = esteAnio;
                    b_generarNumero_Click(null, null);
                }
                else
                    b_anio.Visible = tb_anio.Text == "0" && tb_numero.Text == "0";
            }
        }

        private void FormFactura_KeyUp(object sender, KeyEventArgs e)
        {
            ;
        }

        private void tb_anio_TextChanged(object sender, EventArgs e)
        {
            //tb_numero.ReadOnly = tb_anio.Text != "0";
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
            if (tb_anio.Text != "0" && tb_numero.Text == "0" && _factura._datoCargado)
            {
                _factura.generaNumero(Conversiones.toIntWN(tb_anio.Text));
                tb_anio.Text = _factura.getAnio().ToString();
                tb_numero.Text = _factura.getNumero().ToString();

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

            e.Graphics.DrawString("Factura " + _factura.getAnio() + "/" + _factura.getNumero(), fontTitulo, Brushes.Black, leftMargin, yPos);
            yPos += (int)fontTitulo.GetHeight(e.Graphics);

            e.Graphics.DrawString("Fecha: " + _factura.getFechaAsString(), fontNormal, Brushes.Black, leftMargin, yPos);
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

        double pendienteAlPulsarBotonCobros = 0.0;
        private void b_cobros_Click(object sender, EventArgs e)
        {
            if (_factura._datoCargado)
            {
                double suma = BC.Ventas.Cobro.getSumaImportesDeCobrosDeFactura(_factura.getIdFactura());
                double totalFactura = BC.Comun.currency_getValorDoubleFromString(tb_total.Text);
                pendienteAlPulsarBotonCobros = BC.Comun.currency_getValorFormateadoAsDouble(totalFactura - suma);

                if (suma == 0.0)
                {
                    BC.Ventas.Cobro _nuevoCobro = new BC.Ventas.Cobro();
                    _nuevoCobro.setIdContacto(_factura.getIdContacto());
                    _nuevoCobro.setIdFactura(_factura.getIdFactura());
                    _nuevoCobro.setImporte(pendienteAlPulsarBotonCobros);

                    BC.Comun.GeneraEnvioAInterfazComun("abrir_cobro", _nuevoCobro);
                }
                else
                {
                    BC.Ventas.SelectorDeCobrosContacto w = new BC.Ventas.SelectorDeCobrosContacto();
                    w.idContactoFiltrar = _factura.getIdContacto();
                    w.idFacturaFiltrar = _factura.getIdFactura();
                    w.form_porcAlto = 30;
                    w.form_porcAncho = 40;
                    w.form_cerrarTrasSeleccionar = true;
                    w.form_mostrarOpcionDeNuevoCobro = pendienteAlPulsarBotonCobros >= 0.01;

                    w.CobroSeleccionado += new BC.Ventas.SelectorDeCobrosContacto.DelegadoCobroSeleccionado(w_CobroSeleccionado);
                    
                    w.Show();
                }
            } // if (_factura._datoCargado)
        }

        void w_CobroSeleccionado(BC.Ventas.Cobro cobroSeleccionado)
        {
            if (cobroSeleccionado.getIdFactura() == -1)
            {
                cobroSeleccionado.setIdContacto(_factura.getIdContacto());
                cobroSeleccionado.setIdFactura(_factura.getIdFactura());
                cobroSeleccionado.setImporte(pendienteAlPulsarBotonCobros);
            }

            BC.Comun.GeneraEnvioAInterfazComun("abrir_cobro", cobroSeleccionado);
        }

    } // end class
} // end namespace
