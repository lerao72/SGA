namespace MCC
{
    partial class FormContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContactos));
            this.p_left = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.t_filtro_1 = new System.Windows.Forms.TableLayoutPanel();
            this.b_f_search = new System.Windows.Forms.Button();
            this.b_f_alt = new System.Windows.Forms.Button();
            this.tb_f_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_filtro_2 = new System.Windows.Forms.TableLayoutPanel();
            this.p_bottom = new System.Windows.Forms.Panel();
            this.b_nuevo = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_editar = new System.Windows.Forms.Button();
            this.p_top = new System.Windows.Forms.Panel();
            this.p_edit = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_activo = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_visible = new System.Windows.Forms.CheckBox();
            this.tlp_otrosDatos = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.b_tarifa = new System.Windows.Forms.Button();
            this.b_mePaga = new System.Windows.Forms.Button();
            this.tb_tarifa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.b_lePago = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_aplicaIVA = new System.Windows.Forms.CheckBox();
            this.tb_mePaga = new System.Windows.Forms.TextBox();
            this.tb_lePago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.b_cuentas = new System.Windows.Forms.Button();
            this.nud_descuento = new System.Windows.Forms.NumericUpDown();
            this.tlp_tipo = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_esProveedor = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_esCliente = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_idContacto = new System.Windows.Forms.TextBox();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_nifCif = new System.Windows.Forms.TextBox();
            this.tb_razonSocial = new System.Windows.Forms.TextBox();
            this.tb_nombreComercial = new System.Windows.Forms.TextBox();
            this.tb_observaciones = new System.Windows.Forms.TextBox();
            this.t_filtro = new System.Windows.Forms.Timer(this.components);
            this.tlp_botones1 = new System.Windows.Forms.TableLayoutPanel();
            this.b_direcciones = new System.Windows.Forms.Button();
            this.b_datosContacto = new System.Windows.Forms.Button();
            this.p_right = new System.Windows.Forms.Panel();
            this.tlp_botones3 = new System.Windows.Forms.TableLayoutPanel();
            this.b_archivos = new System.Windows.Forms.Button();
            this.b_notas = new System.Windows.Forms.Button();
            this.b_ventas = new System.Windows.Forms.Button();
            this.b_compras = new System.Windows.Forms.Button();
            this.b_agenda = new System.Windows.Forms.Button();
            this.tlp_botones2 = new System.Windows.Forms.TableLayoutPanel();
            this.b_otrosDatos = new System.Windows.Forms.Button();
            this.p_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.t_filtro_1.SuspendLayout();
            this.p_bottom.SuspendLayout();
            this.p_edit.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tlp_otrosDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_descuento)).BeginInit();
            this.tlp_tipo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlp_botones1.SuspendLayout();
            this.p_right.SuspendLayout();
            this.tlp_botones3.SuspendLayout();
            this.tlp_botones2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_left
            // 
            this.p_left.Controls.Add(this.grid);
            this.p_left.Controls.Add(this.t_filtro_1);
            this.p_left.Controls.Add(this.t_filtro_2);
            this.p_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_left.Location = new System.Drawing.Point(0, 0);
            this.p_left.Name = "p_left";
            this.p_left.Size = new System.Drawing.Size(250, 422);
            this.p_left.TabIndex = 0;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(250, 362);
            this.grid.TabIndex = 2;
            this.grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEnter);
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
            // 
            // t_filtro_1
            // 
            this.t_filtro_1.ColumnCount = 4;
            this.t_filtro_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.t_filtro_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.t_filtro_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.t_filtro_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.t_filtro_1.Controls.Add(this.b_f_search, 2, 0);
            this.t_filtro_1.Controls.Add(this.b_f_alt, 3, 0);
            this.t_filtro_1.Controls.Add(this.tb_f_1, 1, 0);
            this.t_filtro_1.Controls.Add(this.label1, 0, 0);
            this.t_filtro_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.t_filtro_1.Location = new System.Drawing.Point(0, 362);
            this.t_filtro_1.Name = "t_filtro_1";
            this.t_filtro_1.RowCount = 1;
            this.t_filtro_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.t_filtro_1.Size = new System.Drawing.Size(250, 20);
            this.t_filtro_1.TabIndex = 1;
            // 
            // b_f_search
            // 
            this.b_f_search.BackgroundImage = global::MCC.Properties.Resources.search16_h;
            this.b_f_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_f_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_f_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_f_search.Location = new System.Drawing.Point(210, 0);
            this.b_f_search.Margin = new System.Windows.Forms.Padding(0);
            this.b_f_search.Name = "b_f_search";
            this.b_f_search.Size = new System.Drawing.Size(20, 20);
            this.b_f_search.TabIndex = 0;
            this.b_f_search.UseVisualStyleBackColor = true;
            this.b_f_search.Click += new System.EventHandler(this.b_f_search_Click);
            // 
            // b_f_alt
            // 
            this.b_f_alt.BackgroundImage = global::MCC.Properties.Resources.down_square16_h;
            this.b_f_alt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_f_alt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_f_alt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_f_alt.Location = new System.Drawing.Point(230, 0);
            this.b_f_alt.Margin = new System.Windows.Forms.Padding(0);
            this.b_f_alt.Name = "b_f_alt";
            this.b_f_alt.Size = new System.Drawing.Size(20, 20);
            this.b_f_alt.TabIndex = 1;
            this.b_f_alt.UseVisualStyleBackColor = true;
            this.b_f_alt.Visible = false;
            this.b_f_alt.Click += new System.EventHandler(this.b_f_alt_Click);
            // 
            // tb_f_1
            // 
            this.tb_f_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_f_1.Location = new System.Drawing.Point(100, 0);
            this.tb_f_1.Margin = new System.Windows.Forms.Padding(0);
            this.tb_f_1.Name = "tb_f_1";
            this.tb_f_1.Size = new System.Drawing.Size(110, 20);
            this.tb_f_1.TabIndex = 2;
            this.tb_f_1.TextChanged += new System.EventHandler(this.tb_f_1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtro:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_filtro_2
            // 
            this.t_filtro_2.ColumnCount = 2;
            this.t_filtro_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.t_filtro_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.t_filtro_2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.t_filtro_2.Location = new System.Drawing.Point(0, 382);
            this.t_filtro_2.Name = "t_filtro_2";
            this.t_filtro_2.RowCount = 2;
            this.t_filtro_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.t_filtro_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.t_filtro_2.Size = new System.Drawing.Size(250, 40);
            this.t_filtro_2.TabIndex = 0;
            this.t_filtro_2.Visible = false;
            // 
            // p_bottom
            // 
            this.p_bottom.Controls.Add(this.b_nuevo);
            this.p_bottom.Controls.Add(this.b_cancelar);
            this.p_bottom.Controls.Add(this.b_editar);
            this.p_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_bottom.Location = new System.Drawing.Point(250, 398);
            this.p_bottom.Name = "p_bottom";
            this.p_bottom.Size = new System.Drawing.Size(544, 24);
            this.p_bottom.TabIndex = 1;
            // 
            // b_nuevo
            // 
            this.b_nuevo.Dock = System.Windows.Forms.DockStyle.Left;
            this.b_nuevo.Image = global::MCC.Properties.Resources.insert_square16_h_g;
            this.b_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_nuevo.Location = new System.Drawing.Point(0, 0);
            this.b_nuevo.Name = "b_nuevo";
            this.b_nuevo.Size = new System.Drawing.Size(75, 24);
            this.b_nuevo.TabIndex = 2;
            this.b_nuevo.Text = "Nuevo";
            this.b_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_nuevo.UseVisualStyleBackColor = true;
            this.b_nuevo.Click += new System.EventHandler(this.b_nuevo_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.b_cancelar.Image = global::MCC.Properties.Resources.cancel_square16_h;
            this.b_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_cancelar.Location = new System.Drawing.Point(394, 0);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(75, 24);
            this.b_cancelar.TabIndex = 1;
            this.b_cancelar.Text = "Cancelar";
            this.b_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // b_editar
            // 
            this.b_editar.Dock = System.Windows.Forms.DockStyle.Right;
            this.b_editar.Image = global::MCC.Properties.Resources.edit_square16_h_c;
            this.b_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_editar.Location = new System.Drawing.Point(469, 0);
            this.b_editar.Name = "b_editar";
            this.b_editar.Size = new System.Drawing.Size(75, 24);
            this.b_editar.TabIndex = 0;
            this.b_editar.Text = "Editar";
            this.b_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_editar.UseVisualStyleBackColor = true;
            this.b_editar.Click += new System.EventHandler(this.b_editar_Click);
            // 
            // p_top
            // 
            this.p_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top.Location = new System.Drawing.Point(250, 0);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(544, 24);
            this.p_top.TabIndex = 2;
            // 
            // p_edit
            // 
            this.p_edit.AutoScroll = true;
            this.p_edit.Controls.Add(this.tableLayoutPanel3);
            this.p_edit.Controls.Add(this.tlp_otrosDatos);
            this.p_edit.Controls.Add(this.tlp_tipo);
            this.p_edit.Controls.Add(this.tableLayoutPanel1);
            this.p_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_edit.Location = new System.Drawing.Point(250, 24);
            this.p_edit.Name = "p_edit";
            this.p_edit.Size = new System.Drawing.Size(454, 374);
            this.p_edit.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cb_activo, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cb_visible, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 344);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(454, 30);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Blue;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 14);
            this.label11.TabIndex = 9;
            this.label11.Text = "Activo:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_activo
            // 
            this.cb_activo.AutoSize = true;
            this.cb_activo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_activo.Location = new System.Drawing.Point(110, 0);
            this.cb_activo.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cb_activo.Name = "cb_activo";
            this.cb_activo.Size = new System.Drawing.Size(117, 20);
            this.cb_activo.TabIndex = 20;
            this.cb_activo.Text = "No";
            this.cb_activo.UseVisualStyleBackColor = true;
            this.cb_activo.CheckedChanged += new System.EventHandler(this.cb_X_CheckedChanged);
            this.cb_activo.Enter += new System.EventHandler(this.tb_X_Enter);
            this.cb_activo.Leave += new System.EventHandler(this.tb_X_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Blue;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(230, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 14);
            this.label12.TabIndex = 10;
            this.label12.Text = "Visible:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_visible
            // 
            this.cb_visible.AutoSize = true;
            this.cb_visible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_visible.Location = new System.Drawing.Point(337, 0);
            this.cb_visible.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cb_visible.Name = "cb_visible";
            this.cb_visible.Size = new System.Drawing.Size(117, 20);
            this.cb_visible.TabIndex = 21;
            this.cb_visible.Text = "No";
            this.cb_visible.UseVisualStyleBackColor = true;
            this.cb_visible.CheckedChanged += new System.EventHandler(this.cb_X_CheckedChanged);
            this.cb_visible.Enter += new System.EventHandler(this.tb_X_Enter);
            this.cb_visible.Leave += new System.EventHandler(this.tb_X_Leave);
            // 
            // tlp_otrosDatos
            // 
            this.tlp_otrosDatos.ColumnCount = 6;
            this.tlp_otrosDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_otrosDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_otrosDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_otrosDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_otrosDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_otrosDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlp_otrosDatos.Controls.Add(this.label14, 3, 6);
            this.tlp_otrosDatos.Controls.Add(this.b_tarifa, 2, 6);
            this.tlp_otrosDatos.Controls.Add(this.b_mePaga, 2, 2);
            this.tlp_otrosDatos.Controls.Add(this.tb_tarifa, 1, 6);
            this.tlp_otrosDatos.Controls.Add(this.label13, 0, 6);
            this.tlp_otrosDatos.Controls.Add(this.b_lePago, 5, 2);
            this.tlp_otrosDatos.Controls.Add(this.label10, 0, 1);
            this.tlp_otrosDatos.Controls.Add(this.label8, 0, 2);
            this.tlp_otrosDatos.Controls.Add(this.cb_aplicaIVA, 1, 1);
            this.tlp_otrosDatos.Controls.Add(this.tb_mePaga, 1, 2);
            this.tlp_otrosDatos.Controls.Add(this.tb_lePago, 4, 2);
            this.tlp_otrosDatos.Controls.Add(this.label9, 3, 2);
            this.tlp_otrosDatos.Controls.Add(this.b_cuentas, 1, 4);
            this.tlp_otrosDatos.Controls.Add(this.nud_descuento, 4, 6);
            this.tlp_otrosDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_otrosDatos.Location = new System.Drawing.Point(0, 205);
            this.tlp_otrosDatos.Name = "tlp_otrosDatos";
            this.tlp_otrosDatos.RowCount = 8;
            this.tlp_otrosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_otrosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_otrosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_otrosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlp_otrosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_otrosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_otrosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_otrosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_otrosDatos.Size = new System.Drawing.Size(454, 116);
            this.tlp_otrosDatos.TabIndex = 2;
            this.tlp_otrosDatos.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Blue;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(229, 89);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 14);
            this.label14.TabIndex = 12;
            this.label14.Text = "Descuento:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b_tarifa
            // 
            this.b_tarifa.BackgroundImage = global::MCC.Properties.Resources.down_square16_h;
            this.b_tarifa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_tarifa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_tarifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_tarifa.Location = new System.Drawing.Point(206, 86);
            this.b_tarifa.Margin = new System.Windows.Forms.Padding(0);
            this.b_tarifa.Name = "b_tarifa";
            this.b_tarifa.Size = new System.Drawing.Size(20, 20);
            this.b_tarifa.TabIndex = 11;
            this.b_tarifa.UseVisualStyleBackColor = true;
            this.b_tarifa.Click += new System.EventHandler(this.b_tarifa_Click);
            // 
            // b_mePaga
            // 
            this.b_mePaga.BackgroundImage = global::MCC.Properties.Resources.down_square16_h;
            this.b_mePaga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_mePaga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_mePaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_mePaga.Location = new System.Drawing.Point(206, 30);
            this.b_mePaga.Margin = new System.Windows.Forms.Padding(0);
            this.b_mePaga.Name = "b_mePaga";
            this.b_mePaga.Size = new System.Drawing.Size(20, 20);
            this.b_mePaga.TabIndex = 4;
            this.b_mePaga.UseVisualStyleBackColor = true;
            this.b_mePaga.Click += new System.EventHandler(this.b_mePaga_Click);
            // 
            // tb_tarifa
            // 
            this.tb_tarifa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_tarifa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_tarifa.Location = new System.Drawing.Point(100, 86);
            this.tb_tarifa.Margin = new System.Windows.Forms.Padding(0);
            this.tb_tarifa.Name = "tb_tarifa";
            this.tb_tarifa.ReadOnly = true;
            this.tb_tarifa.Size = new System.Drawing.Size(106, 20);
            this.tb_tarifa.TabIndex = 10;
            this.tb_tarifa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Blue;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 89);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 14);
            this.label13.TabIndex = 9;
            this.label13.Text = "Usa tarifa:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b_lePago
            // 
            this.b_lePago.BackgroundImage = global::MCC.Properties.Resources.down_square16_h;
            this.b_lePago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_lePago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_lePago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_lePago.Location = new System.Drawing.Point(432, 30);
            this.b_lePago.Margin = new System.Windows.Forms.Padding(0);
            this.b_lePago.Name = "b_lePago";
            this.b_lePago.Size = new System.Drawing.Size(22, 20);
            this.b_lePago.TabIndex = 7;
            this.b_lePago.UseVisualStyleBackColor = true;
            this.b_lePago.Click += new System.EventHandler(this.b_lePago_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Blue;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "Aplica IVA:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Blue;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "Me paga:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_aplicaIVA
            // 
            this.cb_aplicaIVA.AutoSize = true;
            this.cb_aplicaIVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_aplicaIVA.Location = new System.Drawing.Point(110, 10);
            this.cb_aplicaIVA.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cb_aplicaIVA.Name = "cb_aplicaIVA";
            this.cb_aplicaIVA.Size = new System.Drawing.Size(96, 20);
            this.cb_aplicaIVA.TabIndex = 1;
            this.cb_aplicaIVA.Text = "No";
            this.cb_aplicaIVA.UseVisualStyleBackColor = true;
            this.cb_aplicaIVA.CheckedChanged += new System.EventHandler(this.cb_X_CheckedChanged);
            this.cb_aplicaIVA.Enter += new System.EventHandler(this.tb_X_Enter);
            this.cb_aplicaIVA.Leave += new System.EventHandler(this.tb_X_Leave);
            // 
            // tb_mePaga
            // 
            this.tb_mePaga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_mePaga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_mePaga.Location = new System.Drawing.Point(100, 30);
            this.tb_mePaga.Margin = new System.Windows.Forms.Padding(0);
            this.tb_mePaga.Name = "tb_mePaga";
            this.tb_mePaga.ReadOnly = true;
            this.tb_mePaga.Size = new System.Drawing.Size(106, 20);
            this.tb_mePaga.TabIndex = 3;
            // 
            // tb_lePago
            // 
            this.tb_lePago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_lePago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_lePago.Location = new System.Drawing.Point(326, 30);
            this.tb_lePago.Margin = new System.Windows.Forms.Padding(0);
            this.tb_lePago.Name = "tb_lePago";
            this.tb_lePago.ReadOnly = true;
            this.tb_lePago.Size = new System.Drawing.Size(106, 20);
            this.tb_lePago.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Blue;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(229, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 14);
            this.label9.TabIndex = 5;
            this.label9.Text = "Le pago:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b_cuentas
            // 
            this.tlp_otrosDatos.SetColumnSpan(this.b_cuentas, 3);
            this.b_cuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_cuentas.Location = new System.Drawing.Point(100, 56);
            this.b_cuentas.Margin = new System.Windows.Forms.Padding(0);
            this.b_cuentas.Name = "b_cuentas";
            this.b_cuentas.Size = new System.Drawing.Size(226, 20);
            this.b_cuentas.TabIndex = 8;
            this.b_cuentas.Text = "Ver cuentas bancarias";
            this.b_cuentas.UseVisualStyleBackColor = true;
            this.b_cuentas.Click += new System.EventHandler(this.b_cuentas_Click);
            // 
            // nud_descuento
            // 
            this.nud_descuento.BackColor = System.Drawing.Color.White;
            this.tlp_otrosDatos.SetColumnSpan(this.nud_descuento, 2);
            this.nud_descuento.DecimalPlaces = 2;
            this.nud_descuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_descuento.Location = new System.Drawing.Point(326, 86);
            this.nud_descuento.Margin = new System.Windows.Forms.Padding(0);
            this.nud_descuento.Name = "nud_descuento";
            this.nud_descuento.Size = new System.Drawing.Size(128, 20);
            this.nud_descuento.TabIndex = 14;
            this.nud_descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_descuento.Enter += new System.EventHandler(this.tb_X_Enter);
            this.nud_descuento.Leave += new System.EventHandler(this.tb_X_Leave);
            // 
            // tlp_tipo
            // 
            this.tlp_tipo.ColumnCount = 4;
            this.tlp_tipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_tipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_tipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_tipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_tipo.Controls.Add(this.label15, 0, 0);
            this.tlp_tipo.Controls.Add(this.cb_esProveedor, 1, 0);
            this.tlp_tipo.Controls.Add(this.label16, 2, 0);
            this.tlp_tipo.Controls.Add(this.cb_esCliente, 3, 0);
            this.tlp_tipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_tipo.Location = new System.Drawing.Point(0, 175);
            this.tlp_tipo.Name = "tlp_tipo";
            this.tlp_tipo.RowCount = 2;
            this.tlp_tipo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_tipo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_tipo.Size = new System.Drawing.Size(454, 30);
            this.tlp_tipo.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Blue;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 14);
            this.label15.TabIndex = 9;
            this.label15.Text = "Es proveedor:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_esProveedor
            // 
            this.cb_esProveedor.AutoSize = true;
            this.cb_esProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_esProveedor.Location = new System.Drawing.Point(110, 0);
            this.cb_esProveedor.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cb_esProveedor.Name = "cb_esProveedor";
            this.cb_esProveedor.Size = new System.Drawing.Size(117, 20);
            this.cb_esProveedor.TabIndex = 20;
            this.cb_esProveedor.Text = "No";
            this.cb_esProveedor.UseVisualStyleBackColor = true;
            this.cb_esProveedor.CheckedChanged += new System.EventHandler(this.cb_X_CheckedChanged);
            this.cb_esProveedor.Enter += new System.EventHandler(this.tb_X_Enter);
            this.cb_esProveedor.Leave += new System.EventHandler(this.tb_X_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Blue;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(230, 3);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 14);
            this.label16.TabIndex = 10;
            this.label16.Text = "Es cliente:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_esCliente
            // 
            this.cb_esCliente.AutoSize = true;
            this.cb_esCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_esCliente.Location = new System.Drawing.Point(337, 0);
            this.cb_esCliente.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cb_esCliente.Name = "cb_esCliente";
            this.cb_esCliente.Size = new System.Drawing.Size(117, 20);
            this.cb_esCliente.TabIndex = 21;
            this.cb_esCliente.Text = "No";
            this.cb_esCliente.UseVisualStyleBackColor = true;
            this.cb_esCliente.CheckedChanged += new System.EventHandler(this.cb_X_CheckedChanged);
            this.cb_esCliente.Enter += new System.EventHandler(this.tb_X_Enter);
            this.cb_esCliente.Leave += new System.EventHandler(this.tb_X_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_idContacto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_codigo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_nifCif, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_razonSocial, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_nombreComercial, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_observaciones, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 175);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identificador:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(230, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Código:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "N. comercial:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "Razón social:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "NIF/CIF:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "Observaciones:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_idContacto
            // 
            this.tb_idContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_idContacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_idContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_idContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idContacto.Location = new System.Drawing.Point(100, 0);
            this.tb_idContacto.Margin = new System.Windows.Forms.Padding(0);
            this.tb_idContacto.Name = "tb_idContacto";
            this.tb_idContacto.ReadOnly = true;
            this.tb_idContacto.Size = new System.Drawing.Size(127, 19);
            this.tb_idContacto.TabIndex = 11;
            this.tb_idContacto.TabStop = false;
            this.tb_idContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_codigo
            // 
            this.tb_codigo.BackColor = System.Drawing.Color.White;
            this.tb_codigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_codigo.Location = new System.Drawing.Point(327, 0);
            this.tb_codigo.Margin = new System.Windows.Forms.Padding(0);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(127, 20);
            this.tb_codigo.TabIndex = 12;
            this.tb_codigo.Enter += new System.EventHandler(this.tb_X_Enter);
            this.tb_codigo.Leave += new System.EventHandler(this.tb_X_Leave);
            // 
            // tb_nifCif
            // 
            this.tb_nifCif.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_nifCif, 3);
            this.tb_nifCif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_nifCif.Location = new System.Drawing.Point(100, 30);
            this.tb_nifCif.Margin = new System.Windows.Forms.Padding(0);
            this.tb_nifCif.Name = "tb_nifCif";
            this.tb_nifCif.Size = new System.Drawing.Size(354, 20);
            this.tb_nifCif.TabIndex = 13;
            this.tb_nifCif.TextChanged += new System.EventHandler(this.tb_nifCif_TextChanged);
            this.tb_nifCif.Enter += new System.EventHandler(this.tb_X_Enter);
            this.tb_nifCif.Leave += new System.EventHandler(this.tb_X_Leave);
            // 
            // tb_razonSocial
            // 
            this.tb_razonSocial.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_razonSocial, 3);
            this.tb_razonSocial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_razonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_razonSocial.Location = new System.Drawing.Point(100, 50);
            this.tb_razonSocial.Margin = new System.Windows.Forms.Padding(0);
            this.tb_razonSocial.Name = "tb_razonSocial";
            this.tb_razonSocial.Size = new System.Drawing.Size(354, 20);
            this.tb_razonSocial.TabIndex = 14;
            this.tb_razonSocial.Enter += new System.EventHandler(this.tb_X_Enter);
            this.tb_razonSocial.Leave += new System.EventHandler(this.tb_X_Leave);
            // 
            // tb_nombreComercial
            // 
            this.tb_nombreComercial.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_nombreComercial, 3);
            this.tb_nombreComercial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_nombreComercial.Location = new System.Drawing.Point(100, 70);
            this.tb_nombreComercial.Margin = new System.Windows.Forms.Padding(0);
            this.tb_nombreComercial.Name = "tb_nombreComercial";
            this.tb_nombreComercial.Size = new System.Drawing.Size(354, 20);
            this.tb_nombreComercial.TabIndex = 15;
            this.tb_nombreComercial.Enter += new System.EventHandler(this.tb_X_Enter);
            this.tb_nombreComercial.Leave += new System.EventHandler(this.tb_X_Leave);
            // 
            // tb_observaciones
            // 
            this.tb_observaciones.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_observaciones, 3);
            this.tb_observaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_observaciones.Location = new System.Drawing.Point(100, 100);
            this.tb_observaciones.Margin = new System.Windows.Forms.Padding(0);
            this.tb_observaciones.Multiline = true;
            this.tb_observaciones.Name = "tb_observaciones";
            this.tableLayoutPanel1.SetRowSpan(this.tb_observaciones, 3);
            this.tb_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_observaciones.Size = new System.Drawing.Size(354, 75);
            this.tb_observaciones.TabIndex = 16;
            this.tb_observaciones.Enter += new System.EventHandler(this.tb_X_Enter);
            this.tb_observaciones.Leave += new System.EventHandler(this.tb_X_Leave);
            // 
            // t_filtro
            // 
            this.t_filtro.Interval = 500;
            this.t_filtro.Tick += new System.EventHandler(this.t_filtro_Tick);
            // 
            // tlp_botones1
            // 
            this.tlp_botones1.ColumnCount = 1;
            this.tlp_botones1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_botones1.Controls.Add(this.b_direcciones, 0, 0);
            this.tlp_botones1.Controls.Add(this.b_datosContacto, 0, 1);
            this.tlp_botones1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_botones1.Location = new System.Drawing.Point(0, 0);
            this.tlp_botones1.Name = "tlp_botones1";
            this.tlp_botones1.RowCount = 2;
            this.tlp_botones1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlp_botones1.Size = new System.Drawing.Size(90, 90);
            this.tlp_botones1.TabIndex = 2;
            // 
            // b_direcciones
            // 
            this.b_direcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_direcciones.Image = global::MCC.Properties.Resources.home_green16_h;
            this.b_direcciones.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_direcciones.Location = new System.Drawing.Point(0, 0);
            this.b_direcciones.Margin = new System.Windows.Forms.Padding(0);
            this.b_direcciones.Name = "b_direcciones";
            this.b_direcciones.Size = new System.Drawing.Size(90, 24);
            this.b_direcciones.TabIndex = 0;
            this.b_direcciones.Text = "Direcciones";
            this.b_direcciones.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_direcciones.UseVisualStyleBackColor = true;
            this.b_direcciones.Click += new System.EventHandler(this.b_direcciones_Click);
            // 
            // b_datosContacto
            // 
            this.b_datosContacto.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_datosContacto.Image = global::MCC.Properties.Resources.user_nota16_h;
            this.b_datosContacto.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_datosContacto.Location = new System.Drawing.Point(0, 30);
            this.b_datosContacto.Margin = new System.Windows.Forms.Padding(0);
            this.b_datosContacto.Name = "b_datosContacto";
            this.b_datosContacto.Size = new System.Drawing.Size(90, 35);
            this.b_datosContacto.TabIndex = 1;
            this.b_datosContacto.Text = "Datos de contacto";
            this.b_datosContacto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_datosContacto.UseVisualStyleBackColor = true;
            this.b_datosContacto.Click += new System.EventHandler(this.b_datosContacto_Click);
            // 
            // p_right
            // 
            this.p_right.Controls.Add(this.tlp_botones3);
            this.p_right.Controls.Add(this.tlp_botones2);
            this.p_right.Controls.Add(this.tlp_botones1);
            this.p_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_right.Location = new System.Drawing.Point(704, 24);
            this.p_right.Name = "p_right";
            this.p_right.Size = new System.Drawing.Size(90, 374);
            this.p_right.TabIndex = 5;
            // 
            // tlp_botones3
            // 
            this.tlp_botones3.ColumnCount = 1;
            this.tlp_botones3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_botones3.Controls.Add(this.b_archivos, 0, 0);
            this.tlp_botones3.Controls.Add(this.b_notas, 0, 1);
            this.tlp_botones3.Controls.Add(this.b_ventas, 0, 3);
            this.tlp_botones3.Controls.Add(this.b_compras, 0, 4);
            this.tlp_botones3.Controls.Add(this.b_agenda, 0, 2);
            this.tlp_botones3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_botones3.Location = new System.Drawing.Point(0, 120);
            this.tlp_botones3.Name = "tlp_botones3";
            this.tlp_botones3.RowCount = 7;
            this.tlp_botones3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlp_botones3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_botones3.Size = new System.Drawing.Size(90, 235);
            this.tlp_botones3.TabIndex = 4;
            // 
            // b_archivos
            // 
            this.b_archivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_archivos.Image = global::MCC.Properties.Resources.folder_open16;
            this.b_archivos.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_archivos.Location = new System.Drawing.Point(0, 0);
            this.b_archivos.Margin = new System.Windows.Forms.Padding(0);
            this.b_archivos.Name = "b_archivos";
            this.b_archivos.Size = new System.Drawing.Size(90, 24);
            this.b_archivos.TabIndex = 2;
            this.b_archivos.Text = "Archivos";
            this.b_archivos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_archivos.UseVisualStyleBackColor = true;
            this.b_archivos.Click += new System.EventHandler(this.b_archivos_Click);
            // 
            // b_notas
            // 
            this.b_notas.Image = global::MCC.Properties.Resources.new_document16_h;
            this.b_notas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_notas.Location = new System.Drawing.Point(0, 30);
            this.b_notas.Margin = new System.Windows.Forms.Padding(0);
            this.b_notas.Name = "b_notas";
            this.b_notas.Size = new System.Drawing.Size(90, 24);
            this.b_notas.TabIndex = 4;
            this.b_notas.Text = "Notas";
            this.b_notas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_notas.UseVisualStyleBackColor = true;
            this.b_notas.Click += new System.EventHandler(this.b_notas_Click);
            // 
            // b_ventas
            // 
            this.b_ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_ventas.Image = global::MCC.Properties.Resources.up_folder16_h;
            this.b_ventas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_ventas.Location = new System.Drawing.Point(0, 120);
            this.b_ventas.Margin = new System.Windows.Forms.Padding(0);
            this.b_ventas.Name = "b_ventas";
            this.b_ventas.Size = new System.Drawing.Size(90, 24);
            this.b_ventas.TabIndex = 5;
            this.b_ventas.Text = "Ventas";
            this.b_ventas.UseVisualStyleBackColor = true;
            this.b_ventas.Click += new System.EventHandler(this.b_ventas_Click);
            // 
            // b_compras
            // 
            this.b_compras.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_compras.Image = global::MCC.Properties.Resources.open_document16_h;
            this.b_compras.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_compras.Location = new System.Drawing.Point(0, 150);
            this.b_compras.Margin = new System.Windows.Forms.Padding(0);
            this.b_compras.Name = "b_compras";
            this.b_compras.Size = new System.Drawing.Size(90, 24);
            this.b_compras.TabIndex = 6;
            this.b_compras.Text = "Compras";
            this.b_compras.UseVisualStyleBackColor = true;
            this.b_compras.Click += new System.EventHandler(this.b_compras_Click);
            // 
            // b_agenda
            // 
            this.b_agenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_agenda.Image = global::MCC.Properties.Resources.favorites16_h;
            this.b_agenda.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_agenda.Location = new System.Drawing.Point(0, 60);
            this.b_agenda.Margin = new System.Windows.Forms.Padding(0);
            this.b_agenda.Name = "b_agenda";
            this.b_agenda.Size = new System.Drawing.Size(90, 24);
            this.b_agenda.TabIndex = 7;
            this.b_agenda.Text = "Agenda";
            this.b_agenda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_agenda.UseVisualStyleBackColor = true;
            this.b_agenda.Click += new System.EventHandler(this.b_agenda_Click);
            // 
            // tlp_botones2
            // 
            this.tlp_botones2.ColumnCount = 1;
            this.tlp_botones2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_botones2.Controls.Add(this.b_otrosDatos, 0, 0);
            this.tlp_botones2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_botones2.Location = new System.Drawing.Point(0, 90);
            this.tlp_botones2.Name = "tlp_botones2";
            this.tlp_botones2.RowCount = 1;
            this.tlp_botones2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones2.Size = new System.Drawing.Size(90, 30);
            this.tlp_botones2.TabIndex = 3;
            // 
            // b_otrosDatos
            // 
            this.b_otrosDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_otrosDatos.Image = global::MCC.Properties.Resources.views16_h;
            this.b_otrosDatos.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_otrosDatos.Location = new System.Drawing.Point(0, 0);
            this.b_otrosDatos.Margin = new System.Windows.Forms.Padding(0);
            this.b_otrosDatos.Name = "b_otrosDatos";
            this.b_otrosDatos.Size = new System.Drawing.Size(90, 24);
            this.b_otrosDatos.TabIndex = 3;
            this.b_otrosDatos.Text = "Otros datos";
            this.b_otrosDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_otrosDatos.UseVisualStyleBackColor = true;
            this.b_otrosDatos.Click += new System.EventHandler(this.b_otrosDatos_Click);
            // 
            // FormContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 422);
            this.Controls.Add(this.p_edit);
            this.Controls.Add(this.p_right);
            this.Controls.Add(this.p_top);
            this.Controls.Add(this.p_bottom);
            this.Controls.Add(this.p_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactos";
            this.Activated += new System.EventHandler(this.FormContactos_Activated);
            this.Deactivate += new System.EventHandler(this.FormContactos_Deactivate);
            this.Load += new System.EventHandler(this.FormContactos_Load);
            this.Shown += new System.EventHandler(this.FormContactos_Shown);
            this.p_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.t_filtro_1.ResumeLayout(false);
            this.t_filtro_1.PerformLayout();
            this.p_bottom.ResumeLayout(false);
            this.p_edit.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tlp_otrosDatos.ResumeLayout(false);
            this.tlp_otrosDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_descuento)).EndInit();
            this.tlp_tipo.ResumeLayout(false);
            this.tlp_tipo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlp_botones1.ResumeLayout(false);
            this.p_right.ResumeLayout(false);
            this.tlp_botones3.ResumeLayout(false);
            this.tlp_botones2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_left;
        private System.Windows.Forms.TableLayoutPanel t_filtro_1;
        private System.Windows.Forms.TableLayoutPanel t_filtro_2;
        private System.Windows.Forms.Button b_f_search;
        private System.Windows.Forms.Button b_f_alt;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox tb_f_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p_bottom;
        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.Panel p_edit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_idContacto;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_nifCif;
        private System.Windows.Forms.TextBox tb_razonSocial;
        private System.Windows.Forms.TextBox tb_nombreComercial;
        private System.Windows.Forms.TextBox tb_observaciones;
        private System.Windows.Forms.CheckBox cb_aplicaIVA;
        private System.Windows.Forms.TextBox tb_mePaga;
        private System.Windows.Forms.TextBox tb_lePago;
        private System.Windows.Forms.CheckBox cb_activo;
        private System.Windows.Forms.CheckBox cb_visible;
        private System.Windows.Forms.Button b_editar;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Button b_nuevo;
        private System.Windows.Forms.TableLayoutPanel tlp_otrosDatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Timer t_filtro;
        private System.Windows.Forms.Button b_mePaga;
        private System.Windows.Forms.Button b_lePago;
        private System.Windows.Forms.Button b_direcciones;
        private System.Windows.Forms.Button b_datosContacto;
        private System.Windows.Forms.TableLayoutPanel tlp_botones1;
        private System.Windows.Forms.Button b_archivos;
        private System.Windows.Forms.Button b_otrosDatos;
        private System.Windows.Forms.Button b_notas;
        private System.Windows.Forms.Button b_cuentas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button b_tarifa;
        private System.Windows.Forms.TextBox tb_tarifa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nud_descuento;
        private System.Windows.Forms.Panel p_right;
        private System.Windows.Forms.TableLayoutPanel tlp_botones3;
        private System.Windows.Forms.TableLayoutPanel tlp_botones2;
        private System.Windows.Forms.Button b_ventas;
        private System.Windows.Forms.Button b_compras;
        private System.Windows.Forms.TableLayoutPanel tlp_tipo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox cb_esProveedor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cb_esCliente;
        private System.Windows.Forms.Button b_agenda;
    }
}