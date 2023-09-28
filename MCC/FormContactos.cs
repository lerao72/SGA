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
    public partial class FormContactos : Form
    {
        private bool _editando = true;
        private BC.Contactos.Contactos _contacto = new BC.Contactos.Contactos();

        public FormContactos()
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
                b_editar.Image = MCC.Properties.Resources.save16_h;

                tb_codigo.Focus();
            }
            else
            {
                b_editar.Text = "Editar";
                b_editar.Image = MCC.Properties.Resources.edit_square16_h_c;
            }

            p_left.Enabled = !_editando;

            bool ro = !_editando;
            tb_codigo.ReadOnly = ro;
            tb_nifCif.ReadOnly = ro;
            tb_razonSocial.ReadOnly = ro;
            tb_nombreComercial.ReadOnly = ro;
            tb_observaciones.ReadOnly = ro;

            cb_aplicaIVA.AutoCheck = _editando;
            cb_activo.AutoCheck = _editando;
            cb_visible.AutoCheck = _editando;

            b_mePaga.Visible = _editando;
            b_lePago.Visible = _editando;

            b_cuentas.Enabled = !_editando;

            b_tarifa.Visible = _editando;
            nud_descuento.ReadOnly = ro;

            tlp_botones1.Enabled = !_editando;
            tlp_botones3.Enabled = !_editando;
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
            string sql = "select idContacto, codigo, razonsocial, activo, visible from t_contactos";
            string filtro1 = tb_f_1.Text.Trim();
            if (filtro1 != "")
                sql += " where razonSocial like '%" + filtro1 +"%' or codigo='" + filtro1 + "'";
            sql += " order by razonSocial asc";

            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("FormContactos.cargarGrid_do.Exception: " + ex.Message); t = null; }

            if (t != null)
            {
                grid.DataSource = t;

                string[] columnasOcultar = { "idContacto", "codigo", "activo", "visible" };
                foreach(string columnaOcultar in columnasOcultar)
                    try { grid.Columns[columnaOcultar].Visible = false; }
                    catch { ;}

                BC.Comun.grid_tituloColumna(grid, "razonsocial", "Contacto");

                if (grid.Rows.Count > 0)
                    grid.CurrentCell = grid.Rows[0].Cells["razonsocial"];
            }
        }

        private void instanceToForm()
        {
            tb_idContacto.Text = _contacto.getIdContacto() >= 0 ? _contacto.getIdContacto().ToString() : "";
            tb_codigo.Text = _contacto.getCodigo();
            tb_nifCif.Text = _contacto.getNifCif();
            tb_razonSocial.Text = _contacto.getRazonSocial();
            tb_nombreComercial.Text = _contacto.getNombreComercial();
            tb_observaciones.Text = _contacto.getObservaciones();

            cb_esProveedor.Checked = _contacto.getEsProveedor();
            cb_esCliente.Checked = _contacto.getEsCliente();

            tb_lePago.Text = BC.Contactos.Contactos.getFormaPagoAsString(_contacto.getTipoFormaLePago());
            tb_mePaga.Text = BC.Contactos.Contactos.getFormaPagoAsString(_contacto.getTipoFormaMePaga());

            tb_tarifa.Text = "Tarifa " + _contacto.getTarifa();
            nud_descuento.Value = Convert.ToDecimal(_contacto.getDescuento());

            cb_aplicaIVA.Checked = _contacto.getAplicaIva();
            cb_activo.Checked = _contacto.getActivo();
            cb_visible.Checked = _contacto.getVisible();
        }

        private void formToInstance()
        {
            _contacto.setCodigo(tb_codigo.Text);
            _contacto.setNifCif(tb_nifCif.Text);
            _contacto.setRazonSocial(tb_razonSocial.Text);
            _contacto.setNombreComercial(tb_nombreComercial.Text);
            _contacto.setObservaciones(tb_observaciones.Text);

            _contacto.setEsProveedor(cb_esProveedor.Checked);
            _contacto.setEsCliente(cb_esCliente.Checked);

            _contacto.setTipoFormaLePago(BC.Contactos.Contactos.getFormaPagoAsInt(tb_lePago.Text));
            _contacto.setTipoFormaMePaga(BC.Contactos.Contactos.getFormaPagoAsInt(tb_mePaga.Text));

            _contacto.setTarifa(Conversiones.toInt(tb_tarifa.Text.Replace("Tarifa ", "")));
            _contacto.setDescuento((double)nud_descuento.Value);

            _contacto.setAplicaIva(cb_aplicaIVA.Checked);
            _contacto.setActivo(cb_activo.Checked);
            _contacto.setVisible(cb_visible.Checked);
        }

        #endregion






        private void FormContactos_Load(object sender, EventArgs e)
        {
            swichEditMode();
            cargarGrid();
        }

        private void FormContactos_Shown(object sender, EventArgs e)
        {
            tb_f_1.Focus();
        }


        
        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_editando && grid.CurrentRow != null)
            {
                Int32 idContactoCargar = Conversiones.toIntWN(grid.CurrentRow.Cells["idContacto"].Value);
                _contacto = new BC.Contactos.Contactos(idContactoCargar);
                instanceToForm();
            }
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow fila = grid.Rows[e.RowIndex];
            string nombreColumna = grid.Columns[e.ColumnIndex].Name;

            if (fila != null)
            {
                if (nombreColumna == "razonsocial")
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



        private void b_mePaga_Click(object sender, EventArgs e)
        {
            if (_editando)
            {
                Int32 nuevoValor = BC.Contactos.Contactos.FormVariasOpcionesFormaPago(_contacto.getTipoFormaMePaga());
                tb_mePaga.Text = BC.Contactos.Contactos.getFormaPagoAsString(nuevoValor);
            }
        }

        private void b_lePago_Click(object sender, EventArgs e)
        {
            if (_editando)
            {
                Int32 nuevoValor = BC.Contactos.Contactos.FormVariasOpcionesFormaPago(_contacto.getTipoFormaLePago());
                tb_lePago.Text = BC.Contactos.Contactos.getFormaPagoAsString(nuevoValor);
            }
        }

        private void b_cuentas_Click(object sender, EventArgs e)
        {
            if (_contacto._datoCargado)
                new FormCuentas(_contacto.getIdContacto()).ShowDialog();
            else
                System.Windows.Forms.MessageBox.Show("Ha de guardar primero el contacto");
        }
        
        private void b_tarifa_Click(object sender, EventArgs e)
        {
            if (_editando)
            {
                BC.FormVariasOpciones w = new BC.FormVariasOpciones("Indique tarifa");
                w.addOpcion(1, "Tarifa 1");
                w.addOpcion(2, "Tarifa 2");
                w.addOpcion(3, "Tarifa 3");

                w.setSelectedValue(_contacto.getTarifa());
                if (w.ShowDialog() == DialogResult.OK)
                    tb_tarifa.Text = w.getSelectedText();
            }           
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
            _contacto = new BC.Contactos.Contactos();
            instanceToForm();
            swichEditMode();
        }

        private void b_editar_Click(object sender, EventArgs e)
        {
            if (_editando)
            {
                formToInstance();

                bool esNuevo = !_contacto._datoCargado;

                _contacto.guarda();

                object[] o = { _contacto.getIdContacto(),
                           _contacto.getCodigo(),
                           _contacto.getRazonSocial(),
                           _contacto.getActivo() ? "s" : "n",
                           _contacto.getVisible() ? "s" : "n" };

                if (esNuevo)
                {
                    ((DataTable)grid.DataSource).Rows.Add(o);
                    grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells["razonsocial"];

                    tb_idContacto.Text = _contacto.getIdContacto().ToString();
                }
                else
                    BC.Comun.setDataGridViewRowFromObjectV(o, grid.CurrentRow);

                swichEditMode();
            }
            else if (_contacto != null && _contacto._datoCargado)
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



        private void tb_nifCif_TextChanged(object sender, EventArgs e)
        {
            string nif = tb_nifCif.Text.Trim();
            if (nif != "")
                tb_nifCif.ForeColor = BC.Comun.esNIF(nif) || BC.Comun.esCIF(nif) ?
                    Color.Black :
                    Color.Red;
                    
        }



        private void FormContactos_Activated(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void FormContactos_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        
        
        private void b_direcciones_Click(object sender, EventArgs e)
        {
            if (_contacto._datoCargado)
                new FormDirecciones(_contacto.getIdContacto()).ShowDialog();
            else
                System.Windows.Forms.MessageBox.Show("Ha de guardar primero el contacto");
        }

        private void b_datosContacto_Click(object sender, EventArgs e)
        {
            if (_contacto._datoCargado)
                new FormDatosContacto(_contacto.getIdContacto()).ShowDialog();
            else
                System.Windows.Forms.MessageBox.Show("Ha de guardar primero el contacto");
        }

        private void b_archivos_Click(object sender, EventArgs e)
        {
            if (_contacto._datoCargado)
                BC.Comun.abrirCarpeta(_contacto.getPath());
            else
                System.Windows.Forms.MessageBox.Show("Ha de guardar primero el contacto");
        }

        private void b_otrosDatos_Click(object sender, EventArgs e)
        {
            tlp_otrosDatos.Visible = !tlp_otrosDatos.Visible; ;
        }

        private void b_notas_Click(object sender, EventArgs e)
        {
            if (_contacto._datoCargado)
            {
                // Abrir formulario de notas
                //BC.Comun.abrirCarpeta(_contacto.getPath("Notas"));
                new MCC.FormNotas(_contacto).ShowDialog();
            }
            else
                System.Windows.Forms.MessageBox.Show("Ha de guardar primero el contacto");
        }

        private void b_agenda_Click(object sender, EventArgs e)
        {
            if (_contacto._datoCargado)
                BC.Varios.SelectorDeRecordatorios.FormSelectorDeRecordatoriosContactos_Show(_contacto.getIdContacto());
            else
                System.Windows.Forms.MessageBox.Show("Ha de guardar primero el contacto");
        }


        
        private void b_ventas_Click(object sender, EventArgs e)
        {
            if (_contacto._datoCargado)
            {
                BC.FormVariasOpciones w = new BC.FormVariasOpciones("Indique opción");
                w.addOpcion(0, "Albaranes");
                w.addOpcion(1, "Facturas");

                if (w.ShowDialog() == DialogResult.OK)
                {
                    if (w.getSelectedValue() == 0)
                    {
                        BC.Ventas.SelectorDeAlbaranesDeContacto ws = new BC.Ventas.SelectorDeAlbaranesDeContacto();
                        ws.idContactoFiltrar = _contacto.getIdContacto();
                        ws.AlbaranSeleccionado += new BC.Ventas.SelectorDeAlbaranesDeContacto.DelegadoAlbaranSeleccionado(ws_AlbaranSeleccionado);
                        ws.form_porcAlto = 80;
                        ws.form_porcAncho = 30;
                        ws.form_Text = "Albaranes del contacto";
                        ws.Show();
                    }
                    else if (w.getSelectedValue() == 1)
                    {
                        BC.Ventas.SelectorDeFacturasDeContacto wf = new BC.Ventas.SelectorDeFacturasDeContacto();
                        wf.idContactoFiltrar = _contacto.getIdContacto();
                        wf.FacturaSeleccionada += new BC.Ventas.SelectorDeFacturasDeContacto.DelegadoFacturaSeleccionada(wf_FacturaSeleccionada);
                        wf.form_porcAlto = 80;
                        wf.form_porcAncho = 30;
                        wf.form_Text = "Facturas del contacto";
                        //wf.idContactoFiltrar = -1;
                        wf.Show();
                    }
                }
            } // if (_contacto._datoCargado
            else
                System.Windows.Forms.MessageBox.Show("Ha de guardar primero el contacto");
        }

        void ws_AlbaranSeleccionado(BC.Ventas.Albaran albaranSeleccionado)
        {
            BC.Comun.GeneraEnvioAInterfazComun("abrir_albaran", albaranSeleccionado);
        }

        void wf_FacturaSeleccionada(BC.Ventas.Factura facturaSeleccionada)
        {
            BC.Comun.GeneraEnvioAInterfazComun("abrir_factura", facturaSeleccionada);
        }



        private void b_compras_Click(object sender, EventArgs e)
        {
            if (_contacto._datoCargado)
            {
                BC.Compras.SelectorDePagosContacto wpc = new BC.Compras.SelectorDePagosContacto();
                wpc.idContactoFiltrar = _contacto.getIdContacto();
                wpc.PagoSeleccionado += new BC.Compras.SelectorDePagosContacto.DelegadoPagoSeleccionado(wpc_PagoSeleccionado);
                wpc.form_porcAlto = 80;
                wpc.form_porcAncho = 70;
                wpc.form_Text = "Pagos al contacto";

                wpc.form_usarFiltroFecha = true;

                wpc.form_usarFiltroComboA = true;
                wpc.form_filtroComboA_titulo = "Pagados:";
                wpc.form_filtroComboA_cb.Items.Add("Cualquiera");
                wpc.form_filtroComboA_cb.Items.Add("Si");
                wpc.form_filtroComboA_cb.Items.Add("No");
                wpc.form_filtroComboA_cb.Text = "No";

                wpc.Show();
            }
            else
                System.Windows.Forms.MessageBox.Show("Ha de guardar primero el contacto");
        }

        void wpc_PagoSeleccionado(BC.Compras.Pago pagoSeleccionado)
        {
            BC.Comun.GeneraEnvioAInterfazComun("abrir_pago", pagoSeleccionado);
        }

    } // end class
}
