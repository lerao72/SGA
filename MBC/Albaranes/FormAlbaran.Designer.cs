namespace MBC
{
    partial class FormAlbaran
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlbaran));
            this.p_bottom = new System.Windows.Forms.Panel();
            this.b_factura = new System.Windows.Forms.Button();
            this.b_imprime = new System.Windows.Forms.Button();
            this.b_guardarAlbaran = new System.Windows.Forms.Button();
            this.tlp_detalleAlbaran = new System.Windows.Forms.TableLayoutPanel();
            this.b_view_contacto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.b_anio = new System.Windows.Forms.Button();
            this.tb_anio = new System.Windows.Forms.TextBox();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.tb_contacto = new System.Windows.Forms.TextBox();
            this.b_selectContacto = new System.Windows.Forms.Button();
            this.b_generarNumero = new System.Windows.Forms.Button();
            this.p_right = new System.Windows.Forms.TableLayoutPanel();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.b_remove = new System.Windows.Forms.Button();
            this.tlp_resumen = new System.Windows.Forms.TableLayoutPanel();
            this.gridIVA = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_observaciones = new System.Windows.Forms.TextBox();
            this.tb_pvp = new System.Windows.Forms.TextBox();
            this.tb_sumaIVA = new System.Windows.Forms.TextBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.grid_menuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_mostrarOrden = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_mostrarDescuento = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_mostrarIVA = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpLinea = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_a_codigo = new System.Windows.Forms.TextBox();
            this.b_articulo = new System.Windows.Forms.Button();
            this.tb_a_articulo = new System.Windows.Forms.TextBox();
            this.tb_a_cantidad = new System.Windows.Forms.TextBox();
            this.tb_a_pvp_ori = new System.Windows.Forms.TextBox();
            this.tb_a_dto = new System.Windows.Forms.TextBox();
            this.tb_a_pvpTotal = new System.Windows.Forms.TextBox();
            this.tb_a_iva = new System.Windows.Forms.TextBox();
            this.tb_a_totalPlusIVA = new System.Windows.Forms.TextBox();
            this.b_cancelEdit = new System.Windows.Forms.Button();
            this.p_botones_edit = new System.Windows.Forms.Panel();
            this.b_guardarLineaYOtro = new System.Windows.Forms.Button();
            this.b_guardarLinea = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_a_orden = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_a_grupo = new System.Windows.Forms.TextBox();
            this.t_quitarTopMost = new System.Windows.Forms.Timer(this.components);
            this.t_verBotonGenerarNumero = new System.Windows.Forms.Timer(this.components);
            this.p_bottom.SuspendLayout();
            this.tlp_detalleAlbaran.SuspendLayout();
            this.p_right.SuspendLayout();
            this.tlp_resumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.grid_menuContextual.SuspendLayout();
            this.tlpLinea.SuspendLayout();
            this.p_botones_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_bottom
            // 
            this.p_bottom.Controls.Add(this.b_factura);
            this.p_bottom.Controls.Add(this.b_imprime);
            this.p_bottom.Controls.Add(this.b_guardarAlbaran);
            this.p_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_bottom.Location = new System.Drawing.Point(0, 342);
            this.p_bottom.Name = "p_bottom";
            this.p_bottom.Size = new System.Drawing.Size(794, 30);
            this.p_bottom.TabIndex = 0;
            // 
            // b_factura
            // 
            this.b_factura.Dock = System.Windows.Forms.DockStyle.Left;
            this.b_factura.Image = global::MBC.Properties.Resources.calc;
            this.b_factura.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_factura.Location = new System.Drawing.Point(0, 0);
            this.b_factura.Name = "b_factura";
            this.b_factura.Size = new System.Drawing.Size(75, 30);
            this.b_factura.TabIndex = 3;
            this.b_factura.Text = "Factura";
            this.b_factura.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_factura.UseVisualStyleBackColor = true;
            this.b_factura.Visible = false;
            this.b_factura.Click += new System.EventHandler(this.b_factura_Click);
            // 
            // b_imprime
            // 
            this.b_imprime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_imprime.Image = global::MBC.Properties.Resources.print16_h;
            this.b_imprime.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_imprime.Location = new System.Drawing.Point(638, 0);
            this.b_imprime.Name = "b_imprime";
            this.b_imprime.Size = new System.Drawing.Size(75, 30);
            this.b_imprime.TabIndex = 2;
            this.b_imprime.Text = "Imprimir";
            this.b_imprime.UseVisualStyleBackColor = true;
            this.b_imprime.Click += new System.EventHandler(this.b_imprime_Click);
            // 
            // b_guardarAlbaran
            // 
            this.b_guardarAlbaran.Dock = System.Windows.Forms.DockStyle.Right;
            this.b_guardarAlbaran.Image = global::MBC.Properties.Resources.save16_h;
            this.b_guardarAlbaran.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_guardarAlbaran.Location = new System.Drawing.Point(719, 0);
            this.b_guardarAlbaran.Name = "b_guardarAlbaran";
            this.b_guardarAlbaran.Size = new System.Drawing.Size(75, 30);
            this.b_guardarAlbaran.TabIndex = 1;
            this.b_guardarAlbaran.TabStop = false;
            this.b_guardarAlbaran.Text = "Guardar";
            this.b_guardarAlbaran.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_guardarAlbaran.UseVisualStyleBackColor = true;
            this.b_guardarAlbaran.Click += new System.EventHandler(this.b_guardarAlbaran_Click);
            // 
            // tlp_detalleAlbaran
            // 
            this.tlp_detalleAlbaran.ColumnCount = 10;
            this.tlp_detalleAlbaran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_detalleAlbaran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp_detalleAlbaran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_detalleAlbaran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_detalleAlbaran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_detalleAlbaran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_detalleAlbaran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_detalleAlbaran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_detalleAlbaran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_detalleAlbaran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_detalleAlbaran.Controls.Add(this.b_view_contacto, 8, 1);
            this.tlp_detalleAlbaran.Controls.Add(this.label1, 0, 0);
            this.tlp_detalleAlbaran.Controls.Add(this.label2, 3, 0);
            this.tlp_detalleAlbaran.Controls.Add(this.label3, 5, 0);
            this.tlp_detalleAlbaran.Controls.Add(this.label4, 0, 1);
            this.tlp_detalleAlbaran.Controls.Add(this.b_anio, 2, 0);
            this.tlp_detalleAlbaran.Controls.Add(this.tb_anio, 1, 0);
            this.tlp_detalleAlbaran.Controls.Add(this.tb_numero, 4, 0);
            this.tlp_detalleAlbaran.Controls.Add(this.dtp_fecha, 6, 0);
            this.tlp_detalleAlbaran.Controls.Add(this.tb_contacto, 1, 1);
            this.tlp_detalleAlbaran.Controls.Add(this.b_selectContacto, 7, 1);
            this.tlp_detalleAlbaran.Controls.Add(this.b_generarNumero, 9, 0);
            this.tlp_detalleAlbaran.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_detalleAlbaran.Location = new System.Drawing.Point(0, 0);
            this.tlp_detalleAlbaran.Name = "tlp_detalleAlbaran";
            this.tlp_detalleAlbaran.RowCount = 3;
            this.tlp_detalleAlbaran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_detalleAlbaran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_detalleAlbaran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_detalleAlbaran.Size = new System.Drawing.Size(794, 50);
            this.tlp_detalleAlbaran.TabIndex = 1;
            // 
            // b_view_contacto
            // 
            this.b_view_contacto.BackgroundImage = global::MBC.Properties.Resources.user_nota16_h;
            this.b_view_contacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_view_contacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_view_contacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_view_contacto.Location = new System.Drawing.Point(620, 20);
            this.b_view_contacto.Margin = new System.Windows.Forms.Padding(0);
            this.b_view_contacto.Name = "b_view_contacto";
            this.b_view_contacto.Size = new System.Drawing.Size(20, 20);
            this.b_view_contacto.TabIndex = 10;
            this.b_view_contacto.UseVisualStyleBackColor = true;
            this.b_view_contacto.Visible = false;
            this.b_view_contacto.Click += new System.EventHandler(this.b_view_contacto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(403, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contacto:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b_anio
            // 
            this.b_anio.BackgroundImage = global::MBC.Properties.Resources.down_square16_h;
            this.b_anio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_anio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_anio.Location = new System.Drawing.Point(180, 0);
            this.b_anio.Margin = new System.Windows.Forms.Padding(0);
            this.b_anio.Name = "b_anio";
            this.b_anio.Size = new System.Drawing.Size(20, 20);
            this.b_anio.TabIndex = 4;
            this.b_anio.UseVisualStyleBackColor = true;
            this.b_anio.Visible = false;
            this.b_anio.Click += new System.EventHandler(this.b_anio_Click);
            // 
            // tb_anio
            // 
            this.tb_anio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_anio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_anio.Location = new System.Drawing.Point(100, 0);
            this.tb_anio.Margin = new System.Windows.Forms.Padding(0);
            this.tb_anio.Name = "tb_anio";
            this.tb_anio.ReadOnly = true;
            this.tb_anio.Size = new System.Drawing.Size(80, 20);
            this.tb_anio.TabIndex = 5;
            this.tb_anio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_anio.TextChanged += new System.EventHandler(this.tb_anio_TextChanged);
            // 
            // tb_numero
            // 
            this.tb_numero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_numero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_numero.Location = new System.Drawing.Point(300, 0);
            this.tb_numero.Margin = new System.Windows.Forms.Padding(0);
            this.tb_numero.MaxLength = 5;
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.ReadOnly = true;
            this.tb_numero.Size = new System.Drawing.Size(100, 20);
            this.tb_numero.TabIndex = 6;
            this.tb_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_numero.Leave += new System.EventHandler(this.tb_numero_Leave);
            this.tb_numero.Enter += new System.EventHandler(this.tb_numero_Enter);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(500, 0);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(0);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(100, 20);
            this.dtp_fecha.TabIndex = 7;
            // 
            // tb_contacto
            // 
            this.tb_contacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tlp_detalleAlbaran.SetColumnSpan(this.tb_contacto, 6);
            this.tb_contacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_contacto.Location = new System.Drawing.Point(100, 20);
            this.tb_contacto.Margin = new System.Windows.Forms.Padding(0);
            this.tb_contacto.Name = "tb_contacto";
            this.tb_contacto.ReadOnly = true;
            this.tb_contacto.Size = new System.Drawing.Size(500, 20);
            this.tb_contacto.TabIndex = 8;
            // 
            // b_selectContacto
            // 
            this.b_selectContacto.BackgroundImage = global::MBC.Properties.Resources.search16_h;
            this.b_selectContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_selectContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_selectContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_selectContacto.Location = new System.Drawing.Point(600, 20);
            this.b_selectContacto.Margin = new System.Windows.Forms.Padding(0);
            this.b_selectContacto.Name = "b_selectContacto";
            this.b_selectContacto.Size = new System.Drawing.Size(20, 20);
            this.b_selectContacto.TabIndex = 9;
            this.b_selectContacto.UseVisualStyleBackColor = true;
            this.b_selectContacto.Visible = false;
            this.b_selectContacto.Click += new System.EventHandler(this.b_selectContacto_Click);
            // 
            // b_generarNumero
            // 
            this.b_generarNumero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_generarNumero.Image = global::MBC.Properties.Resources.post_square16_h_g;
            this.b_generarNumero.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_generarNumero.Location = new System.Drawing.Point(643, 3);
            this.b_generarNumero.Name = "b_generarNumero";
            this.b_generarNumero.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tlp_detalleAlbaran.SetRowSpan(this.b_generarNumero, 2);
            this.b_generarNumero.Size = new System.Drawing.Size(148, 34);
            this.b_generarNumero.TabIndex = 11;
            this.b_generarNumero.Text = "Generar número de albarán";
            this.b_generarNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_generarNumero.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_generarNumero.UseVisualStyleBackColor = true;
            this.b_generarNumero.Visible = false;
            this.b_generarNumero.Click += new System.EventHandler(this.b_generarNumero_Click);
            // 
            // p_right
            // 
            this.p_right.ColumnCount = 1;
            this.p_right.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.p_right.Controls.Add(this.b_edit, 0, 0);
            this.p_right.Controls.Add(this.b_add, 0, 1);
            this.p_right.Controls.Add(this.b_remove, 0, 2);
            this.p_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_right.Location = new System.Drawing.Point(774, 50);
            this.p_right.Name = "p_right";
            this.p_right.RowCount = 7;
            this.p_right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.p_right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.p_right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.p_right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.p_right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.p_right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.p_right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.p_right.Size = new System.Drawing.Size(20, 292);
            this.p_right.TabIndex = 2;
            // 
            // b_edit
            // 
            this.b_edit.BackgroundImage = global::MBC.Properties.Resources.edit_square16_h_c;
            this.b_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_edit.Enabled = false;
            this.b_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_edit.Location = new System.Drawing.Point(0, 0);
            this.b_edit.Margin = new System.Windows.Forms.Padding(0);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(20, 20);
            this.b_edit.TabIndex = 0;
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // b_add
            // 
            this.b_add.BackgroundImage = global::MBC.Properties.Resources.insert_square16_h_g;
            this.b_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_add.Location = new System.Drawing.Point(0, 30);
            this.b_add.Margin = new System.Windows.Forms.Padding(0);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(20, 20);
            this.b_add.TabIndex = 1;
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // b_remove
            // 
            this.b_remove.BackgroundImage = global::MBC.Properties.Resources.delete_square16_h;
            this.b_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_remove.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_remove.Enabled = false;
            this.b_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_remove.Location = new System.Drawing.Point(0, 60);
            this.b_remove.Margin = new System.Windows.Forms.Padding(0);
            this.b_remove.Name = "b_remove";
            this.b_remove.Size = new System.Drawing.Size(20, 20);
            this.b_remove.TabIndex = 2;
            this.b_remove.UseVisualStyleBackColor = true;
            this.b_remove.Click += new System.EventHandler(this.b_remove_Click);
            // 
            // tlp_resumen
            // 
            this.tlp_resumen.ColumnCount = 6;
            this.tlp_resumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_resumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_resumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_resumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlp_resumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlp_resumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_resumen.Controls.Add(this.gridIVA, 3, 0);
            this.tlp_resumen.Controls.Add(this.label8, 4, 1);
            this.tlp_resumen.Controls.Add(this.label9, 4, 2);
            this.tlp_resumen.Controls.Add(this.label5, 0, 0);
            this.tlp_resumen.Controls.Add(this.label6, 2, 0);
            this.tlp_resumen.Controls.Add(this.label7, 4, 0);
            this.tlp_resumen.Controls.Add(this.tb_observaciones, 1, 0);
            this.tlp_resumen.Controls.Add(this.tb_pvp, 5, 0);
            this.tlp_resumen.Controls.Add(this.tb_sumaIVA, 5, 1);
            this.tlp_resumen.Controls.Add(this.tb_total, 5, 2);
            this.tlp_resumen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlp_resumen.Location = new System.Drawing.Point(0, 282);
            this.tlp_resumen.Name = "tlp_resumen";
            this.tlp_resumen.RowCount = 3;
            this.tlp_resumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_resumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_resumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_resumen.Size = new System.Drawing.Size(774, 60);
            this.tlp_resumen.TabIndex = 3;
            // 
            // gridIVA
            // 
            this.gridIVA.AllowUserToAddRows = false;
            this.gridIVA.AllowUserToDeleteRows = false;
            this.gridIVA.AllowUserToResizeColumns = false;
            this.gridIVA.AllowUserToResizeRows = false;
            this.gridIVA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridIVA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridIVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIVA.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridIVA.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridIVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridIVA.GridColor = System.Drawing.Color.White;
            this.gridIVA.Location = new System.Drawing.Point(474, 0);
            this.gridIVA.Margin = new System.Windows.Forms.Padding(0);
            this.gridIVA.Name = "gridIVA";
            this.gridIVA.ReadOnly = true;
            this.gridIVA.RowHeadersVisible = false;
            this.tlp_resumen.SetRowSpan(this.gridIVA, 3);
            this.gridIVA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIVA.Size = new System.Drawing.Size(125, 60);
            this.gridIVA.TabIndex = 8;
            this.gridIVA.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridIVA_CellFormatting);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Blue;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(602, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "Suma IVA:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Blue;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(602, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Observaciones:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(427, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "IVA:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(602, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Suma:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_observaciones
            // 
            this.tb_observaciones.BackColor = System.Drawing.Color.White;
            this.tb_observaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_observaciones.Location = new System.Drawing.Point(100, 0);
            this.tb_observaciones.Margin = new System.Windows.Forms.Padding(0);
            this.tb_observaciones.Multiline = true;
            this.tb_observaciones.Name = "tb_observaciones";
            this.tlp_resumen.SetRowSpan(this.tb_observaciones, 3);
            this.tb_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_observaciones.Size = new System.Drawing.Size(324, 60);
            this.tb_observaciones.TabIndex = 11;
            this.tb_observaciones.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_observaciones.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_pvp
            // 
            this.tb_pvp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_pvp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_pvp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pvp.Location = new System.Drawing.Point(674, 0);
            this.tb_pvp.Margin = new System.Windows.Forms.Padding(0);
            this.tb_pvp.Name = "tb_pvp";
            this.tb_pvp.Size = new System.Drawing.Size(100, 20);
            this.tb_pvp.TabIndex = 12;
            this.tb_pvp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_sumaIVA
            // 
            this.tb_sumaIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_sumaIVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_sumaIVA.Location = new System.Drawing.Point(674, 20);
            this.tb_sumaIVA.Margin = new System.Windows.Forms.Padding(0);
            this.tb_sumaIVA.Name = "tb_sumaIVA";
            this.tb_sumaIVA.Size = new System.Drawing.Size(100, 20);
            this.tb_sumaIVA.TabIndex = 13;
            this.tb_sumaIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_total
            // 
            this.tb_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_total.Location = new System.Drawing.Point(674, 40);
            this.tb_total.Margin = new System.Windows.Forms.Padding(0);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(100, 20);
            this.tb_total.TabIndex = 14;
            this.tb_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ContextMenuStrip = this.grid_menuContextual;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 50);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(774, 232);
            this.grid.TabIndex = 6;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
            this.grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEnter);
            // 
            // grid_menuContextual
            // 
            this.grid_menuContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_mostrarOrden,
            this.mi_mostrarDescuento,
            this.mi_mostrarIVA});
            this.grid_menuContextual.Name = "grid_menuContextual";
            this.grid_menuContextual.Size = new System.Drawing.Size(174, 70);
            // 
            // mi_mostrarOrden
            // 
            this.mi_mostrarOrden.Checked = true;
            this.mi_mostrarOrden.CheckOnClick = true;
            this.mi_mostrarOrden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_mostrarOrden.Name = "mi_mostrarOrden";
            this.mi_mostrarOrden.Size = new System.Drawing.Size(173, 22);
            this.mi_mostrarOrden.Text = "Mostrar orden";
            this.mi_mostrarOrden.CheckedChanged += new System.EventHandler(this.mi_mostrarX_CheckedChanged);
            // 
            // mi_mostrarDescuento
            // 
            this.mi_mostrarDescuento.Checked = true;
            this.mi_mostrarDescuento.CheckOnClick = true;
            this.mi_mostrarDescuento.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_mostrarDescuento.Name = "mi_mostrarDescuento";
            this.mi_mostrarDescuento.Size = new System.Drawing.Size(173, 22);
            this.mi_mostrarDescuento.Text = "Mostrar descuento";
            this.mi_mostrarDescuento.CheckedChanged += new System.EventHandler(this.mi_mostrarX_CheckedChanged);
            // 
            // mi_mostrarIVA
            // 
            this.mi_mostrarIVA.CheckOnClick = true;
            this.mi_mostrarIVA.Name = "mi_mostrarIVA";
            this.mi_mostrarIVA.Size = new System.Drawing.Size(173, 22);
            this.mi_mostrarIVA.Text = "Mostrar IVA";
            this.mi_mostrarIVA.CheckedChanged += new System.EventHandler(this.mi_mostrarX_CheckedChanged);
            // 
            // tlpLinea
            // 
            this.tlpLinea.ColumnCount = 11;
            this.tlpLinea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLinea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpLinea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpLinea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpLinea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpLinea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpLinea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpLinea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpLinea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpLinea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLinea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLinea.Controls.Add(this.label13, 7, 6);
            this.tlpLinea.Controls.Add(this.label18, 1, 6);
            this.tlpLinea.Controls.Add(this.label17, 1, 5);
            this.tlpLinea.Controls.Add(this.label11, 3, 5);
            this.tlpLinea.Controls.Add(this.label16, 5, 5);
            this.tlpLinea.Controls.Add(this.label15, 7, 5);
            this.tlpLinea.Controls.Add(this.label12, 1, 3);
            this.tlpLinea.Controls.Add(this.label14, 3, 3);
            this.tlpLinea.Controls.Add(this.tb_a_codigo, 2, 3);
            this.tlpLinea.Controls.Add(this.b_articulo, 9, 3);
            this.tlpLinea.Controls.Add(this.tb_a_articulo, 4, 3);
            this.tlpLinea.Controls.Add(this.tb_a_cantidad, 2, 5);
            this.tlpLinea.Controls.Add(this.tb_a_pvp_ori, 4, 5);
            this.tlpLinea.Controls.Add(this.tb_a_dto, 6, 5);
            this.tlpLinea.Controls.Add(this.tb_a_pvpTotal, 8, 5);
            this.tlpLinea.Controls.Add(this.tb_a_iva, 2, 6);
            this.tlpLinea.Controls.Add(this.tb_a_totalPlusIVA, 8, 6);
            this.tlpLinea.Controls.Add(this.b_cancelEdit, 9, 0);
            this.tlpLinea.Controls.Add(this.p_botones_edit, 1, 8);
            this.tlpLinea.Controls.Add(this.label19, 1, 1);
            this.tlpLinea.Controls.Add(this.tb_a_orden, 2, 1);
            this.tlpLinea.Controls.Add(this.label10, 3, 1);
            this.tlpLinea.Controls.Add(this.tb_a_grupo, 4, 1);
            this.tlpLinea.Location = new System.Drawing.Point(37, 72);
            this.tlpLinea.Name = "tlpLinea";
            this.tlpLinea.RowCount = 9;
            this.tlpLinea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpLinea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLinea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpLinea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLinea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpLinea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLinea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLinea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpLinea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLinea.Size = new System.Drawing.Size(720, 160);
            this.tlpLinea.TabIndex = 7;
            this.tlpLinea.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Blue;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(538, 93);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 14);
            this.label13.TabIndex = 19;
            this.label13.Text = "Tot + IVA:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Blue;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(13, 93);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 14);
            this.label18.TabIndex = 17;
            this.label18.Text = "IVA:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Blue;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(13, 73);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 14);
            this.label17.TabIndex = 9;
            this.label17.Text = "Cantidad:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Blue;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(188, 73);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 14);
            this.label11.TabIndex = 11;
            this.label11.Text = "Precio:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Blue;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(363, 73);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 14);
            this.label16.TabIndex = 13;
            this.label16.Text = "Descuento:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Blue;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(538, 73);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 14);
            this.label15.TabIndex = 15;
            this.label15.Text = "Total:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Blue;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 43);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 14);
            this.label12.TabIndex = 4;
            this.label12.Text = "Código:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Blue;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(188, 43);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 14);
            this.label14.TabIndex = 6;
            this.label14.Text = "Artículo:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_a_codigo
            // 
            this.tb_a_codigo.BackColor = System.Drawing.Color.White;
            this.tb_a_codigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_a_codigo.Location = new System.Drawing.Point(85, 40);
            this.tb_a_codigo.Margin = new System.Windows.Forms.Padding(0);
            this.tb_a_codigo.Name = "tb_a_codigo";
            this.tb_a_codigo.Size = new System.Drawing.Size(100, 20);
            this.tb_a_codigo.TabIndex = 5;
            this.tb_a_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_a_codigo.Leave += new System.EventHandler(this.tb_codigo_Leave);
            this.tb_a_codigo.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // b_articulo
            // 
            this.b_articulo.BackgroundImage = global::MBC.Properties.Resources.search16_h;
            this.b_articulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_articulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_articulo.Location = new System.Drawing.Point(690, 40);
            this.b_articulo.Margin = new System.Windows.Forms.Padding(0);
            this.b_articulo.Name = "b_articulo";
            this.b_articulo.Size = new System.Drawing.Size(20, 20);
            this.b_articulo.TabIndex = 7;
            this.b_articulo.UseVisualStyleBackColor = true;
            this.b_articulo.Click += new System.EventHandler(this.b_articulo_Click);
            // 
            // tb_a_articulo
            // 
            this.tb_a_articulo.AcceptsReturn = true;
            this.tb_a_articulo.BackColor = System.Drawing.Color.White;
            this.tlpLinea.SetColumnSpan(this.tb_a_articulo, 5);
            this.tb_a_articulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_a_articulo.Location = new System.Drawing.Point(260, 40);
            this.tb_a_articulo.Margin = new System.Windows.Forms.Padding(0);
            this.tb_a_articulo.Name = "tb_a_articulo";
            this.tb_a_articulo.Size = new System.Drawing.Size(430, 20);
            this.tb_a_articulo.TabIndex = 8;
            this.tb_a_articulo.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_a_articulo.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_a_cantidad
            // 
            this.tb_a_cantidad.BackColor = System.Drawing.Color.White;
            this.tb_a_cantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_a_cantidad.Location = new System.Drawing.Point(85, 70);
            this.tb_a_cantidad.Margin = new System.Windows.Forms.Padding(0);
            this.tb_a_cantidad.Name = "tb_a_cantidad";
            this.tb_a_cantidad.Size = new System.Drawing.Size(100, 20);
            this.tb_a_cantidad.TabIndex = 10;
            this.tb_a_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_a_cantidad.Leave += new System.EventHandler(this.tb_cantidad_Leave);
            this.tb_a_cantidad.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_a_pvp_ori
            // 
            this.tb_a_pvp_ori.BackColor = System.Drawing.Color.White;
            this.tb_a_pvp_ori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_a_pvp_ori.Location = new System.Drawing.Point(260, 70);
            this.tb_a_pvp_ori.Margin = new System.Windows.Forms.Padding(0);
            this.tb_a_pvp_ori.Name = "tb_a_pvp_ori";
            this.tb_a_pvp_ori.Size = new System.Drawing.Size(100, 20);
            this.tb_a_pvp_ori.TabIndex = 12;
            this.tb_a_pvp_ori.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_a_pvp_ori.Leave += new System.EventHandler(this.tb_cantidad_Leave);
            this.tb_a_pvp_ori.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_a_dto
            // 
            this.tb_a_dto.BackColor = System.Drawing.Color.White;
            this.tb_a_dto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_a_dto.Location = new System.Drawing.Point(435, 70);
            this.tb_a_dto.Margin = new System.Windows.Forms.Padding(0);
            this.tb_a_dto.Name = "tb_a_dto";
            this.tb_a_dto.Size = new System.Drawing.Size(100, 20);
            this.tb_a_dto.TabIndex = 14;
            this.tb_a_dto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_a_dto.Leave += new System.EventHandler(this.tb_cantidad_Leave);
            this.tb_a_dto.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_a_pvpTotal
            // 
            this.tb_a_pvpTotal.BackColor = System.Drawing.Color.White;
            this.tlpLinea.SetColumnSpan(this.tb_a_pvpTotal, 2);
            this.tb_a_pvpTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_a_pvpTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_a_pvpTotal.Location = new System.Drawing.Point(610, 70);
            this.tb_a_pvpTotal.Margin = new System.Windows.Forms.Padding(0);
            this.tb_a_pvpTotal.Name = "tb_a_pvpTotal";
            this.tb_a_pvpTotal.ReadOnly = true;
            this.tb_a_pvpTotal.Size = new System.Drawing.Size(100, 20);
            this.tb_a_pvpTotal.TabIndex = 16;
            this.tb_a_pvpTotal.TabStop = false;
            this.tb_a_pvpTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_a_iva
            // 
            this.tb_a_iva.BackColor = System.Drawing.Color.White;
            this.tb_a_iva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_a_iva.Location = new System.Drawing.Point(85, 90);
            this.tb_a_iva.Margin = new System.Windows.Forms.Padding(0);
            this.tb_a_iva.Name = "tb_a_iva";
            this.tb_a_iva.Size = new System.Drawing.Size(100, 20);
            this.tb_a_iva.TabIndex = 18;
            this.tb_a_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_a_iva.Leave += new System.EventHandler(this.tb_cantidad_Leave);
            this.tb_a_iva.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_a_totalPlusIVA
            // 
            this.tb_a_totalPlusIVA.BackColor = System.Drawing.Color.White;
            this.tlpLinea.SetColumnSpan(this.tb_a_totalPlusIVA, 2);
            this.tb_a_totalPlusIVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_a_totalPlusIVA.Location = new System.Drawing.Point(610, 90);
            this.tb_a_totalPlusIVA.Margin = new System.Windows.Forms.Padding(0);
            this.tb_a_totalPlusIVA.Name = "tb_a_totalPlusIVA";
            this.tb_a_totalPlusIVA.ReadOnly = true;
            this.tb_a_totalPlusIVA.Size = new System.Drawing.Size(100, 20);
            this.tb_a_totalPlusIVA.TabIndex = 20;
            this.tb_a_totalPlusIVA.TabStop = false;
            this.tb_a_totalPlusIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_cancelEdit
            // 
            this.b_cancelEdit.BackgroundImage = global::MBC.Properties.Resources.cancel_square16_h_r;
            this.b_cancelEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpLinea.SetColumnSpan(this.b_cancelEdit, 2);
            this.b_cancelEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_cancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cancelEdit.Location = new System.Drawing.Point(700, 0);
            this.b_cancelEdit.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.b_cancelEdit.Name = "b_cancelEdit";
            this.tlpLinea.SetRowSpan(this.b_cancelEdit, 2);
            this.b_cancelEdit.Size = new System.Drawing.Size(20, 20);
            this.b_cancelEdit.TabIndex = 26;
            this.b_cancelEdit.UseVisualStyleBackColor = true;
            this.b_cancelEdit.Click += new System.EventHandler(this.b_cancelEdit_Click);
            // 
            // p_botones_edit
            // 
            this.tlpLinea.SetColumnSpan(this.p_botones_edit, 9);
            this.p_botones_edit.Controls.Add(this.b_guardarLineaYOtro);
            this.p_botones_edit.Controls.Add(this.b_guardarLinea);
            this.p_botones_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_botones_edit.Location = new System.Drawing.Point(10, 120);
            this.p_botones_edit.Margin = new System.Windows.Forms.Padding(0);
            this.p_botones_edit.Name = "p_botones_edit";
            this.p_botones_edit.Size = new System.Drawing.Size(700, 40);
            this.p_botones_edit.TabIndex = 21;
            // 
            // b_guardarLineaYOtro
            // 
            this.b_guardarLineaYOtro.Image = global::MBC.Properties.Resources.save_add16_h;
            this.b_guardarLineaYOtro.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_guardarLineaYOtro.Location = new System.Drawing.Point(353, 0);
            this.b_guardarLineaYOtro.Name = "b_guardarLineaYOtro";
            this.b_guardarLineaYOtro.Size = new System.Drawing.Size(75, 40);
            this.b_guardarLineaYOtro.TabIndex = 1;
            this.b_guardarLineaYOtro.Text = "Guardar y otra";
            this.b_guardarLineaYOtro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_guardarLineaYOtro.UseVisualStyleBackColor = true;
            this.b_guardarLineaYOtro.Click += new System.EventHandler(this.b_guardarLineaYOtro_Click);
            // 
            // b_guardarLinea
            // 
            this.b_guardarLinea.Image = global::MBC.Properties.Resources.save16_h;
            this.b_guardarLinea.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_guardarLinea.Location = new System.Drawing.Point(272, 1);
            this.b_guardarLinea.Name = "b_guardarLinea";
            this.b_guardarLinea.Size = new System.Drawing.Size(75, 40);
            this.b_guardarLinea.TabIndex = 0;
            this.b_guardarLinea.TabStop = false;
            this.b_guardarLinea.Text = "Guardar";
            this.b_guardarLinea.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_guardarLinea.UseVisualStyleBackColor = true;
            this.b_guardarLinea.Click += new System.EventHandler(this.b_guardarLinea_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Blue;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(13, 13);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 14);
            this.label19.TabIndex = 0;
            this.label19.Text = "Orden:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_a_orden
            // 
            this.tb_a_orden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_a_orden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_a_orden.Location = new System.Drawing.Point(85, 10);
            this.tb_a_orden.Margin = new System.Windows.Forms.Padding(0);
            this.tb_a_orden.Name = "tb_a_orden";
            this.tb_a_orden.ReadOnly = true;
            this.tb_a_orden.Size = new System.Drawing.Size(100, 20);
            this.tb_a_orden.TabIndex = 1;
            this.tb_a_orden.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Blue;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(188, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 14);
            this.label10.TabIndex = 2;
            this.label10.Text = "Grupo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Visible = false;
            // 
            // tb_a_grupo
            // 
            this.tb_a_grupo.BackColor = System.Drawing.Color.White;
            this.tb_a_grupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_a_grupo.Location = new System.Drawing.Point(260, 10);
            this.tb_a_grupo.Margin = new System.Windows.Forms.Padding(0);
            this.tb_a_grupo.Name = "tb_a_grupo";
            this.tb_a_grupo.Size = new System.Drawing.Size(100, 20);
            this.tb_a_grupo.TabIndex = 3;
            this.tb_a_grupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_a_grupo.Visible = false;
            this.tb_a_grupo.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_a_grupo.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // t_quitarTopMost
            // 
            this.t_quitarTopMost.Enabled = true;
            this.t_quitarTopMost.Tick += new System.EventHandler(this.t_quitarTopMost_Tick);
            // 
            // t_verBotonGenerarNumero
            // 
            this.t_verBotonGenerarNumero.Tick += new System.EventHandler(this.t_verBotonGenerarNumero_Tick);
            // 
            // FormAlbaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 372);
            this.Controls.Add(this.tlpLinea);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.tlp_resumen);
            this.Controls.Add(this.p_right);
            this.Controls.Add(this.tlp_detalleAlbaran);
            this.Controls.Add(this.p_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlbaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Albarán";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormAlbaran_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAlbaran_FormClosed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormAlbaran_KeyUp);
            this.p_bottom.ResumeLayout(false);
            this.tlp_detalleAlbaran.ResumeLayout(false);
            this.tlp_detalleAlbaran.PerformLayout();
            this.p_right.ResumeLayout(false);
            this.tlp_resumen.ResumeLayout(false);
            this.tlp_resumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.grid_menuContextual.ResumeLayout(false);
            this.tlpLinea.ResumeLayout(false);
            this.tlpLinea.PerformLayout();
            this.p_botones_edit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_bottom;
        private System.Windows.Forms.TableLayoutPanel tlp_detalleAlbaran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_anio;
        private System.Windows.Forms.TextBox tb_anio;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.TextBox tb_contacto;
        private System.Windows.Forms.Button b_view_contacto;
        private System.Windows.Forms.Button b_selectContacto;
        private System.Windows.Forms.TableLayoutPanel p_right;
        private System.Windows.Forms.TableLayoutPanel tlp_resumen;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tlpLinea;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_a_grupo;
        private System.Windows.Forms.TextBox tb_a_codigo;
        private System.Windows.Forms.Button b_articulo;
        private System.Windows.Forms.TextBox tb_a_articulo;
        private System.Windows.Forms.TextBox tb_a_cantidad;
        private System.Windows.Forms.TextBox tb_a_pvp_ori;
        private System.Windows.Forms.TextBox tb_a_dto;
        private System.Windows.Forms.TextBox tb_a_pvpTotal;
        private System.Windows.Forms.TextBox tb_a_iva;
        private System.Windows.Forms.TextBox tb_a_totalPlusIVA;
        private System.Windows.Forms.Button b_cancelEdit;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_remove;
        private System.Windows.Forms.Panel p_botones_edit;
        private System.Windows.Forms.Button b_guardarLinea;
        private System.Windows.Forms.Button b_guardarLineaYOtro;
        private System.Windows.Forms.Button b_guardarAlbaran;
        private System.Windows.Forms.TextBox tb_observaciones;
        public System.Windows.Forms.DataGridView gridIVA;
        private System.Windows.Forms.TextBox tb_pvp;
        private System.Windows.Forms.TextBox tb_sumaIVA;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.TextBox tb_a_orden;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Timer t_quitarTopMost;
        private System.Windows.Forms.Button b_generarNumero;
        private System.Windows.Forms.Timer t_verBotonGenerarNumero;
        private System.Windows.Forms.Button b_imprime;
        private System.Windows.Forms.ContextMenuStrip grid_menuContextual;
        private System.Windows.Forms.ToolStripMenuItem mi_mostrarOrden;
        private System.Windows.Forms.ToolStripMenuItem mi_mostrarDescuento;
        private System.Windows.Forms.ToolStripMenuItem mi_mostrarIVA;
        private System.Windows.Forms.Button b_factura;
    }
}