namespace BC
{
    partial class FormSelectorGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectorGrid));
            this.tlp_filtro_1 = new System.Windows.Forms.TableLayoutPanel();
            this.b_filtro = new System.Windows.Forms.Button();
            this.tb_filtro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_seleccionar = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miExportarACSV = new System.Windows.Forms.ToolStripMenuItem();
            this.t_filtro = new System.Windows.Forms.Timer(this.components);
            this.tlp_fitroFecha = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_f_desde = new System.Windows.Forms.DateTimePicker();
            this.dtp_f_hasta = new System.Windows.Forms.DateTimePicker();
            this.cb_usar_filtro_fecha = new System.Windows.Forms.CheckBox();
            this.tlp_f_comboA = new System.Windows.Forms.TableLayoutPanel();
            this.l_f_comboA = new System.Windows.Forms.Label();
            this.cb_f_combo1 = new System.Windows.Forms.ComboBox();
            this.tlp_f_comboB = new System.Windows.Forms.TableLayoutPanel();
            this.l_f_comboB = new System.Windows.Forms.Label();
            this.cb_f_combo2 = new System.Windows.Forms.ComboBox();
            this.tlp_resumen = new System.Windows.Forms.TableLayoutPanel();
            this.l_resumen_suma_valor = new System.Windows.Forms.Label();
            this.l_resumen_suma_titulo = new System.Windows.Forms.Label();
            this.l_resumen_numFilas = new System.Windows.Forms.Label();
            this.tlp_filtro_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tlp_fitroFecha.SuspendLayout();
            this.tlp_f_comboA.SuspendLayout();
            this.tlp_f_comboB.SuspendLayout();
            this.tlp_resumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_filtro_1
            // 
            this.tlp_filtro_1.ColumnCount = 3;
            this.tlp_filtro_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_filtro_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_filtro_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_filtro_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_filtro_1.Controls.Add(this.b_filtro, 2, 0);
            this.tlp_filtro_1.Controls.Add(this.tb_filtro, 1, 0);
            this.tlp_filtro_1.Controls.Add(this.label1, 0, 0);
            this.tlp_filtro_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlp_filtro_1.Location = new System.Drawing.Point(0, 172);
            this.tlp_filtro_1.Name = "tlp_filtro_1";
            this.tlp_filtro_1.RowCount = 1;
            this.tlp_filtro_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_filtro_1.Size = new System.Drawing.Size(294, 20);
            this.tlp_filtro_1.TabIndex = 3;
            // 
            // b_filtro
            // 
            this.b_filtro.BackgroundImage = global::BC.Properties.Resources.search16_h;
            this.b_filtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_filtro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_filtro.Location = new System.Drawing.Point(274, 0);
            this.b_filtro.Margin = new System.Windows.Forms.Padding(0);
            this.b_filtro.Name = "b_filtro";
            this.b_filtro.Size = new System.Drawing.Size(20, 20);
            this.b_filtro.TabIndex = 0;
            this.b_filtro.UseVisualStyleBackColor = true;
            // 
            // tb_filtro
            // 
            this.tb_filtro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_filtro.Location = new System.Drawing.Point(100, 0);
            this.tb_filtro.Margin = new System.Windows.Forms.Padding(0);
            this.tb_filtro.Name = "tb_filtro";
            this.tb_filtro.Size = new System.Drawing.Size(174, 20);
            this.tb_filtro.TabIndex = 2;
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
            // b_seleccionar
            // 
            this.b_seleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.b_seleccionar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.b_seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_seleccionar.Location = new System.Drawing.Point(0, 142);
            this.b_seleccionar.Name = "b_seleccionar";
            this.b_seleccionar.Size = new System.Drawing.Size(294, 30);
            this.b_seleccionar.TabIndex = 4;
            this.b_seleccionar.Text = "S E L E C C I O N A R";
            this.b_seleccionar.UseVisualStyleBackColor = false;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ContextMenuStrip = this.contextMenuStrip1;
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
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(294, 122);
            this.grid.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExportarACSV});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 26);
            // 
            // miExportarACSV
            // 
            this.miExportarACSV.Name = "miExportarACSV";
            this.miExportarACSV.Size = new System.Drawing.Size(150, 22);
            this.miExportarACSV.Text = "Exportar a CSV";
            this.miExportarACSV.Click += new System.EventHandler(this.miExportarACSV_Click);
            // 
            // t_filtro
            // 
            this.t_filtro.Interval = 500;
            // 
            // tlp_fitroFecha
            // 
            this.tlp_fitroFecha.ColumnCount = 3;
            this.tlp_fitroFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_fitroFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_fitroFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_fitroFecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_fitroFecha.Controls.Add(this.label3, 0, 1);
            this.tlp_fitroFecha.Controls.Add(this.label2, 0, 0);
            this.tlp_fitroFecha.Controls.Add(this.dtp_f_desde, 1, 0);
            this.tlp_fitroFecha.Controls.Add(this.dtp_f_hasta, 1, 1);
            this.tlp_fitroFecha.Controls.Add(this.cb_usar_filtro_fecha, 2, 0);
            this.tlp_fitroFecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlp_fitroFecha.Location = new System.Drawing.Point(0, 192);
            this.tlp_fitroFecha.Name = "tlp_fitroFecha";
            this.tlp_fitroFecha.RowCount = 2;
            this.tlp_fitroFecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_fitroFecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_fitroFecha.Size = new System.Drawing.Size(294, 40);
            this.tlp_fitroFecha.TabIndex = 6;
            this.tlp_fitroFecha.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desde:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_f_desde
            // 
            this.dtp_f_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_f_desde.Location = new System.Drawing.Point(100, 0);
            this.dtp_f_desde.Margin = new System.Windows.Forms.Padding(0);
            this.dtp_f_desde.Name = "dtp_f_desde";
            this.dtp_f_desde.Size = new System.Drawing.Size(100, 20);
            this.dtp_f_desde.TabIndex = 4;
            // 
            // dtp_f_hasta
            // 
            this.dtp_f_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_f_hasta.Location = new System.Drawing.Point(100, 20);
            this.dtp_f_hasta.Margin = new System.Windows.Forms.Padding(0);
            this.dtp_f_hasta.Name = "dtp_f_hasta";
            this.dtp_f_hasta.Size = new System.Drawing.Size(100, 20);
            this.dtp_f_hasta.TabIndex = 5;
            // 
            // cb_usar_filtro_fecha
            // 
            this.cb_usar_filtro_fecha.AutoSize = true;
            this.cb_usar_filtro_fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_usar_filtro_fecha.Location = new System.Drawing.Point(205, 0);
            this.cb_usar_filtro_fecha.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cb_usar_filtro_fecha.Name = "cb_usar_filtro_fecha";
            this.tlp_fitroFecha.SetRowSpan(this.cb_usar_filtro_fecha, 2);
            this.cb_usar_filtro_fecha.Size = new System.Drawing.Size(89, 40);
            this.cb_usar_filtro_fecha.TabIndex = 6;
            this.cb_usar_filtro_fecha.Text = "Usar filtro de fechas";
            this.cb_usar_filtro_fecha.UseVisualStyleBackColor = true;
            // 
            // tlp_f_comboA
            // 
            this.tlp_f_comboA.ColumnCount = 2;
            this.tlp_f_comboA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_f_comboA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_f_comboA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_f_comboA.Controls.Add(this.l_f_comboA, 0, 0);
            this.tlp_f_comboA.Controls.Add(this.cb_f_combo1, 1, 0);
            this.tlp_f_comboA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlp_f_comboA.Location = new System.Drawing.Point(0, 232);
            this.tlp_f_comboA.Name = "tlp_f_comboA";
            this.tlp_f_comboA.RowCount = 2;
            this.tlp_f_comboA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_f_comboA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_f_comboA.Size = new System.Drawing.Size(294, 20);
            this.tlp_f_comboA.TabIndex = 7;
            this.tlp_f_comboA.Visible = false;
            // 
            // l_f_comboA
            // 
            this.l_f_comboA.AutoSize = true;
            this.l_f_comboA.BackColor = System.Drawing.Color.Blue;
            this.l_f_comboA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_f_comboA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_f_comboA.ForeColor = System.Drawing.Color.White;
            this.l_f_comboA.Location = new System.Drawing.Point(3, 3);
            this.l_f_comboA.Margin = new System.Windows.Forms.Padding(3);
            this.l_f_comboA.Name = "l_f_comboA";
            this.l_f_comboA.Size = new System.Drawing.Size(94, 14);
            this.l_f_comboA.TabIndex = 3;
            this.l_f_comboA.Text = "l_f_comboA";
            this.l_f_comboA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_f_combo1
            // 
            this.cb_f_combo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_f_combo1.FormattingEnabled = true;
            this.cb_f_combo1.Location = new System.Drawing.Point(100, 0);
            this.cb_f_combo1.Margin = new System.Windows.Forms.Padding(0);
            this.cb_f_combo1.Name = "cb_f_combo1";
            this.cb_f_combo1.Size = new System.Drawing.Size(194, 21);
            this.cb_f_combo1.TabIndex = 4;
            // 
            // tlp_f_comboB
            // 
            this.tlp_f_comboB.ColumnCount = 2;
            this.tlp_f_comboB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_f_comboB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_f_comboB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_f_comboB.Controls.Add(this.l_f_comboB, 0, 0);
            this.tlp_f_comboB.Controls.Add(this.cb_f_combo2, 1, 0);
            this.tlp_f_comboB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlp_f_comboB.Location = new System.Drawing.Point(0, 252);
            this.tlp_f_comboB.Name = "tlp_f_comboB";
            this.tlp_f_comboB.RowCount = 1;
            this.tlp_f_comboB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_f_comboB.Size = new System.Drawing.Size(294, 20);
            this.tlp_f_comboB.TabIndex = 4;
            this.tlp_f_comboB.Visible = false;
            // 
            // l_f_comboB
            // 
            this.l_f_comboB.AutoSize = true;
            this.l_f_comboB.BackColor = System.Drawing.Color.Blue;
            this.l_f_comboB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_f_comboB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_f_comboB.ForeColor = System.Drawing.Color.White;
            this.l_f_comboB.Location = new System.Drawing.Point(3, 3);
            this.l_f_comboB.Margin = new System.Windows.Forms.Padding(3);
            this.l_f_comboB.Name = "l_f_comboB";
            this.l_f_comboB.Size = new System.Drawing.Size(94, 14);
            this.l_f_comboB.TabIndex = 3;
            this.l_f_comboB.Text = "l_f_comboB";
            this.l_f_comboB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_f_combo2
            // 
            this.cb_f_combo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_f_combo2.FormattingEnabled = true;
            this.cb_f_combo2.Location = new System.Drawing.Point(100, 0);
            this.cb_f_combo2.Margin = new System.Windows.Forms.Padding(0);
            this.cb_f_combo2.Name = "cb_f_combo2";
            this.cb_f_combo2.Size = new System.Drawing.Size(194, 21);
            this.cb_f_combo2.TabIndex = 4;
            // 
            // tlp_resumen
            // 
            this.tlp_resumen.ColumnCount = 4;
            this.tlp_resumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_resumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_resumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_resumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlp_resumen.Controls.Add(this.l_resumen_suma_valor, 3, 0);
            this.tlp_resumen.Controls.Add(this.l_resumen_suma_titulo, 2, 0);
            this.tlp_resumen.Controls.Add(this.l_resumen_numFilas, 0, 0);
            this.tlp_resumen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlp_resumen.Location = new System.Drawing.Point(0, 122);
            this.tlp_resumen.Name = "tlp_resumen";
            this.tlp_resumen.RowCount = 1;
            this.tlp_resumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_resumen.Size = new System.Drawing.Size(294, 20);
            this.tlp_resumen.TabIndex = 8;
            this.tlp_resumen.Visible = false;
            // 
            // l_resumen_suma_valor
            // 
            this.l_resumen_suma_valor.AutoSize = true;
            this.l_resumen_suma_valor.BackColor = System.Drawing.Color.Yellow;
            this.l_resumen_suma_valor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_resumen_suma_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_resumen_suma_valor.ForeColor = System.Drawing.Color.Black;
            this.l_resumen_suma_valor.Location = new System.Drawing.Point(174, 3);
            this.l_resumen_suma_valor.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.l_resumen_suma_valor.Name = "l_resumen_suma_valor";
            this.l_resumen_suma_valor.Size = new System.Drawing.Size(117, 14);
            this.l_resumen_suma_valor.TabIndex = 9;
            this.l_resumen_suma_valor.Text = "0.000.000,00 €";
            this.l_resumen_suma_valor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.l_resumen_suma_valor.Visible = false;
            // 
            // l_resumen_suma_titulo
            // 
            this.l_resumen_suma_titulo.AutoSize = true;
            this.l_resumen_suma_titulo.BackColor = System.Drawing.Color.Blue;
            this.l_resumen_suma_titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_resumen_suma_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_resumen_suma_titulo.ForeColor = System.Drawing.Color.White;
            this.l_resumen_suma_titulo.Location = new System.Drawing.Point(127, 3);
            this.l_resumen_suma_titulo.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.l_resumen_suma_titulo.Name = "l_resumen_suma_titulo";
            this.l_resumen_suma_titulo.Size = new System.Drawing.Size(47, 14);
            this.l_resumen_suma_titulo.TabIndex = 3;
            this.l_resumen_suma_titulo.Text = "Suma:";
            this.l_resumen_suma_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_resumen_numFilas
            // 
            this.l_resumen_numFilas.AutoSize = true;
            this.l_resumen_numFilas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_resumen_numFilas.Location = new System.Drawing.Point(3, 0);
            this.l_resumen_numFilas.Name = "l_resumen_numFilas";
            this.l_resumen_numFilas.Size = new System.Drawing.Size(94, 20);
            this.l_resumen_numFilas.TabIndex = 10;
            this.l_resumen_numFilas.Text = "l_numFilas";
            this.l_resumen_numFilas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l_resumen_numFilas.Visible = false;
            this.l_resumen_numFilas.TextChanged += new System.EventHandler(this.l_resumen_numFilas_TextChanged);
            // 
            // FormSelectorGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(294, 272);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.tlp_resumen);
            this.Controls.Add(this.b_seleccionar);
            this.Controls.Add(this.tlp_filtro_1);
            this.Controls.Add(this.tlp_fitroFecha);
            this.Controls.Add(this.tlp_f_comboA);
            this.Controls.Add(this.tlp_f_comboB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectorGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.FormSelectorGrid_Shown);
            this.tlp_filtro_1.ResumeLayout(false);
            this.tlp_filtro_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tlp_fitroFecha.ResumeLayout(false);
            this.tlp_fitroFecha.PerformLayout();
            this.tlp_f_comboA.ResumeLayout(false);
            this.tlp_f_comboA.PerformLayout();
            this.tlp_f_comboB.ResumeLayout(false);
            this.tlp_f_comboB.PerformLayout();
            this.tlp_resumen.ResumeLayout(false);
            this.tlp_resumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button b_filtro;
        public System.Windows.Forms.TextBox tb_filtro;
        public System.Windows.Forms.Button b_seleccionar;
        public System.Windows.Forms.DataGridView grid;
        public System.Windows.Forms.TableLayoutPanel tlp_filtro_1;
        public System.Windows.Forms.Timer t_filtro;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miExportarACSV;
        public System.Windows.Forms.TableLayoutPanel tlp_fitroFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtp_f_desde;
        public System.Windows.Forms.DateTimePicker dtp_f_hasta;
        public System.Windows.Forms.CheckBox cb_usar_filtro_fecha;
        public System.Windows.Forms.TableLayoutPanel tlp_f_comboA;
        public System.Windows.Forms.TableLayoutPanel tlp_f_comboB;
        public System.Windows.Forms.Label l_f_comboA;
        public System.Windows.Forms.Label l_f_comboB;
        public System.Windows.Forms.ComboBox cb_f_combo1;
        public System.Windows.Forms.ComboBox cb_f_combo2;
        public System.Windows.Forms.TableLayoutPanel tlp_resumen;
        public System.Windows.Forms.Label l_resumen_suma_valor;
        public System.Windows.Forms.Label l_resumen_numFilas;
        public System.Windows.Forms.Label l_resumen_suma_titulo;
    }
}