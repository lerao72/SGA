namespace MAC
{
    partial class FormArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArticulos));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.tb_idArticulo = new System.Windows.Forms.TextBox();
            this.tlp_descripcion = new System.Windows.Forms.TableLayoutPanel();
            this.tb_descripcion = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_referencia = new System.Windows.Forms.TextBox();
            this.tb_observaciones = new System.Windows.Forms.TextBox();
            this.b_observaciones = new System.Windows.Forms.Button();
            this.tlp_botones_edit = new System.Windows.Forms.TableLayoutPanel();
            this.t_filtro = new System.Windows.Forms.Timer(this.components);
            this.tb_f_1 = new System.Windows.Forms.TextBox();
            this.t_filtro_1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.t_filtro_2 = new System.Windows.Forms.TableLayoutPanel();
            this.p_edit = new System.Windows.Forms.Panel();
            this.tlp_stock = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.tb_stockMin = new System.Windows.Forms.TextBox();
            this.tlp_precios = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_precioT3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_soloVenta = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_soloCompra = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_precioT1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_precioT2 = new System.Windows.Forms.TextBox();
            this.tb_precioCompra = new System.Windows.Forms.TextBox();
            this.tb_IVA = new System.Windows.Forms.TextBox();
            this.tlp_observaciones = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_familias = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_familias = new System.Windows.Forms.TextBox();
            this.tlp_activoVisible = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_activo = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_visible = new System.Windows.Forms.CheckBox();
            this.p_top = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mi_familias = new System.Windows.Forms.ToolStripMenuItem();
            this.p_left = new System.Windows.Forms.Panel();
            this.p_bottom = new System.Windows.Forms.Panel();
            this.p_botones_right = new System.Windows.Forms.Panel();
            this.tlp_botones = new System.Windows.Forms.TableLayoutPanel();
            this.b_add_familia = new System.Windows.Forms.Button();
            this.b_remove_familia = new System.Windows.Forms.Button();
            this.b_archivos = new System.Windows.Forms.Button();
            this.b_imagen = new System.Windows.Forms.Button();
            this.b_proveedorDeArticulo = new System.Windows.Forms.Button();
            this.b_tarifas = new System.Windows.Forms.Button();
            this.b_stock = new System.Windows.Forms.Button();
            this.b_nuevo = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_editar = new System.Windows.Forms.Button();
            this.b_f_search = new System.Windows.Forms.Button();
            this.b_f_alt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.tlp_descripcion.SuspendLayout();
            this.tlp_botones_edit.SuspendLayout();
            this.t_filtro_1.SuspendLayout();
            this.p_edit.SuspendLayout();
            this.tlp_stock.SuspendLayout();
            this.tlp_precios.SuspendLayout();
            this.tlp_observaciones.SuspendLayout();
            this.tlp_familias.SuspendLayout();
            this.tlp_activoVisible.SuspendLayout();
            this.p_top.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.p_left.SuspendLayout();
            this.p_bottom.SuspendLayout();
            this.p_botones_right.SuspendLayout();
            this.tlp_botones.SuspendLayout();
            this.SuspendLayout();
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
            this.label3.Location = new System.Drawing.Point(221, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripción:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Observaciones:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.grid.TabIndex = 0;
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
            this.grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEnter);
            // 
            // tb_idArticulo
            // 
            this.tb_idArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_idArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_idArticulo.Location = new System.Drawing.Point(100, 0);
            this.tb_idArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.tb_idArticulo.Name = "tb_idArticulo";
            this.tb_idArticulo.ReadOnly = true;
            this.tb_idArticulo.Size = new System.Drawing.Size(118, 20);
            this.tb_idArticulo.TabIndex = 1;
            this.tb_idArticulo.TabStop = false;
            this.tb_idArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlp_descripcion
            // 
            this.tlp_descripcion.ColumnCount = 4;
            this.tlp_descripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_descripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_descripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_descripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_descripcion.Controls.Add(this.label2, 0, 0);
            this.tlp_descripcion.Controls.Add(this.label5, 0, 4);
            this.tlp_descripcion.Controls.Add(this.label4, 0, 3);
            this.tlp_descripcion.Controls.Add(this.tb_idArticulo, 1, 0);
            this.tlp_descripcion.Controls.Add(this.tb_descripcion, 1, 4);
            this.tlp_descripcion.Controls.Add(this.tb_nombre, 1, 3);
            this.tlp_descripcion.Controls.Add(this.label3, 2, 0);
            this.tlp_descripcion.Controls.Add(this.tb_codigo, 3, 0);
            this.tlp_descripcion.Controls.Add(this.label13, 0, 1);
            this.tlp_descripcion.Controls.Add(this.tb_referencia, 1, 1);
            this.tlp_descripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_descripcion.Location = new System.Drawing.Point(0, 0);
            this.tlp_descripcion.Name = "tlp_descripcion";
            this.tlp_descripcion.RowCount = 7;
            this.tlp_descripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_descripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_descripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_descripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_descripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_descripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_descripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_descripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_descripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_descripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_descripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_descripcion.Size = new System.Drawing.Size(437, 130);
            this.tlp_descripcion.TabIndex = 0;
            // 
            // tb_descripcion
            // 
            this.tb_descripcion.BackColor = System.Drawing.Color.White;
            this.tlp_descripcion.SetColumnSpan(this.tb_descripcion, 3);
            this.tb_descripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_descripcion.Location = new System.Drawing.Point(100, 70);
            this.tb_descripcion.Margin = new System.Windows.Forms.Padding(0);
            this.tb_descripcion.Multiline = true;
            this.tb_descripcion.Name = "tb_descripcion";
            this.tlp_descripcion.SetRowSpan(this.tb_descripcion, 2);
            this.tb_descripcion.Size = new System.Drawing.Size(337, 50);
            this.tb_descripcion.TabIndex = 9;
            this.tb_descripcion.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_descripcion.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_nombre
            // 
            this.tb_nombre.BackColor = System.Drawing.Color.White;
            this.tlp_descripcion.SetColumnSpan(this.tb_nombre, 3);
            this.tb_nombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre.Location = new System.Drawing.Point(100, 50);
            this.tb_nombre.Margin = new System.Windows.Forms.Padding(0);
            this.tb_nombre.MaxLength = 255;
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(337, 20);
            this.tb_nombre.TabIndex = 7;
            this.tb_nombre.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_nombre.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_codigo
            // 
            this.tb_codigo.BackColor = System.Drawing.Color.White;
            this.tb_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_codigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(318, 0);
            this.tb_codigo.Margin = new System.Windows.Forms.Padding(0);
            this.tb_codigo.MaxLength = 25;
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(119, 20);
            this.tb_codigo.TabIndex = 3;
            this.tb_codigo.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_codigo.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Blue;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 14);
            this.label13.TabIndex = 4;
            this.label13.Text = "Referencia:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_referencia
            // 
            this.tb_referencia.BackColor = System.Drawing.Color.White;
            this.tb_referencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tlp_descripcion.SetColumnSpan(this.tb_referencia, 3);
            this.tb_referencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_referencia.Location = new System.Drawing.Point(100, 20);
            this.tb_referencia.Margin = new System.Windows.Forms.Padding(0);
            this.tb_referencia.MaxLength = 50;
            this.tb_referencia.Name = "tb_referencia";
            this.tb_referencia.Size = new System.Drawing.Size(337, 20);
            this.tb_referencia.TabIndex = 5;
            this.tb_referencia.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_referencia.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_observaciones
            // 
            this.tb_observaciones.BackColor = System.Drawing.Color.White;
            this.tlp_observaciones.SetColumnSpan(this.tb_observaciones, 3);
            this.tb_observaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_observaciones.Location = new System.Drawing.Point(100, 0);
            this.tb_observaciones.Margin = new System.Windows.Forms.Padding(0);
            this.tb_observaciones.Multiline = true;
            this.tb_observaciones.Name = "tb_observaciones";
            this.tlp_observaciones.SetRowSpan(this.tb_observaciones, 2);
            this.tb_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_observaciones.Size = new System.Drawing.Size(337, 40);
            this.tb_observaciones.TabIndex = 1;
            this.tb_observaciones.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_observaciones.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // b_observaciones
            // 
            this.b_observaciones.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_observaciones.Location = new System.Drawing.Point(0, 0);
            this.b_observaciones.Margin = new System.Windows.Forms.Padding(0);
            this.b_observaciones.Name = "b_observaciones";
            this.b_observaciones.Size = new System.Drawing.Size(90, 24);
            this.b_observaciones.TabIndex = 0;
            this.b_observaciones.Text = "Observaciones";
            this.b_observaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_observaciones.UseVisualStyleBackColor = true;
            this.b_observaciones.Click += new System.EventHandler(this.b_observaciones_Click);
            // 
            // tlp_botones_edit
            // 
            this.tlp_botones_edit.AutoSize = true;
            this.tlp_botones_edit.ColumnCount = 1;
            this.tlp_botones_edit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_botones_edit.Controls.Add(this.b_observaciones, 0, 0);
            this.tlp_botones_edit.Controls.Add(this.b_tarifas, 0, 1);
            this.tlp_botones_edit.Controls.Add(this.b_stock, 0, 2);
            this.tlp_botones_edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_botones_edit.Location = new System.Drawing.Point(0, 0);
            this.tlp_botones_edit.Name = "tlp_botones_edit";
            this.tlp_botones_edit.RowCount = 3;
            this.tlp_botones_edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones_edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones_edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones_edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_botones_edit.Size = new System.Drawing.Size(90, 90);
            this.tlp_botones_edit.TabIndex = 2;
            // 
            // t_filtro
            // 
            this.t_filtro.Interval = 500;
            this.t_filtro.Tick += new System.EventHandler(this.t_filtro_Tick);
            // 
            // tb_f_1
            // 
            this.tb_f_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_f_1.Location = new System.Drawing.Point(100, 0);
            this.tb_f_1.Margin = new System.Windows.Forms.Padding(0);
            this.tb_f_1.Name = "tb_f_1";
            this.tb_f_1.Size = new System.Drawing.Size(110, 20);
            this.tb_f_1.TabIndex = 1;
            this.tb_f_1.TextChanged += new System.EventHandler(this.tb_f_1_TextChanged);
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
            this.label1.TabIndex = 0;
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
            this.t_filtro_2.TabIndex = 2;
            this.t_filtro_2.Visible = false;
            // 
            // p_edit
            // 
            this.p_edit.AutoScroll = true;
            this.p_edit.Controls.Add(this.tlp_stock);
            this.p_edit.Controls.Add(this.tlp_precios);
            this.p_edit.Controls.Add(this.tlp_observaciones);
            this.p_edit.Controls.Add(this.tlp_descripcion);
            this.p_edit.Controls.Add(this.tlp_familias);
            this.p_edit.Controls.Add(this.tlp_activoVisible);
            this.p_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_edit.Location = new System.Drawing.Point(250, 24);
            this.p_edit.Name = "p_edit";
            this.p_edit.Size = new System.Drawing.Size(454, 374);
            this.p_edit.TabIndex = 1;
            // 
            // tlp_stock
            // 
            this.tlp_stock.ColumnCount = 4;
            this.tlp_stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_stock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_stock.Controls.Add(this.label18, 0, 0);
            this.tlp_stock.Controls.Add(this.label19, 2, 0);
            this.tlp_stock.Controls.Add(this.tb_stock, 1, 0);
            this.tlp_stock.Controls.Add(this.tb_stockMin, 3, 0);
            this.tlp_stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_stock.Location = new System.Drawing.Point(0, 290);
            this.tlp_stock.Name = "tlp_stock";
            this.tlp_stock.RowCount = 2;
            this.tlp_stock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_stock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_stock.Size = new System.Drawing.Size(437, 30);
            this.tlp_stock.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Green;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(3, 3);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 14);
            this.label18.TabIndex = 0;
            this.label18.Text = "Stock actual:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Green;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(221, 3);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 14);
            this.label19.TabIndex = 2;
            this.label19.Text = "Stock mínimo:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_stock
            // 
            this.tb_stock.BackColor = System.Drawing.Color.White;
            this.tb_stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stock.Location = new System.Drawing.Point(100, 0);
            this.tb_stock.Margin = new System.Windows.Forms.Padding(0);
            this.tb_stock.MaxLength = 10;
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(118, 20);
            this.tb_stock.TabIndex = 3;
            this.tb_stock.TextChanged += new System.EventHandler(this.tb_stock_TextChanged);
            this.tb_stock.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_stock.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_stockMin
            // 
            this.tb_stockMin.BackColor = System.Drawing.Color.White;
            this.tb_stockMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_stockMin.Location = new System.Drawing.Point(318, 0);
            this.tb_stockMin.Margin = new System.Windows.Forms.Padding(0);
            this.tb_stockMin.MaxLength = 10;
            this.tb_stockMin.Name = "tb_stockMin";
            this.tb_stockMin.Size = new System.Drawing.Size(119, 20);
            this.tb_stockMin.TabIndex = 4;
            this.tb_stockMin.TextChanged += new System.EventHandler(this.tb_stock_TextChanged);
            this.tb_stockMin.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_stockMin.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tlp_precios
            // 
            this.tlp_precios.ColumnCount = 4;
            this.tlp_precios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_precios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_precios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_precios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_precios.Controls.Add(this.label16, 0, 3);
            this.tlp_precios.Controls.Add(this.label15, 2, 1);
            this.tlp_precios.Controls.Add(this.tb_precioT3, 1, 1);
            this.tlp_precios.Controls.Add(this.label14, 0, 1);
            this.tlp_precios.Controls.Add(this.cb_soloVenta, 3, 5);
            this.tlp_precios.Controls.Add(this.label6, 2, 5);
            this.tlp_precios.Controls.Add(this.label10, 0, 5);
            this.tlp_precios.Controls.Add(this.cb_soloCompra, 1, 5);
            this.tlp_precios.Controls.Add(this.label8, 0, 0);
            this.tlp_precios.Controls.Add(this.tb_precioT1, 1, 0);
            this.tlp_precios.Controls.Add(this.label9, 2, 0);
            this.tlp_precios.Controls.Add(this.tb_precioT2, 3, 0);
            this.tlp_precios.Controls.Add(this.tb_precioCompra, 3, 1);
            this.tlp_precios.Controls.Add(this.tb_IVA, 1, 3);
            this.tlp_precios.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_precios.Location = new System.Drawing.Point(0, 180);
            this.tlp_precios.Name = "tlp_precios";
            this.tlp_precios.RowCount = 7;
            this.tlp_precios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_precios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_precios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_precios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_precios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_precios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_precios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_precios.Size = new System.Drawing.Size(437, 110);
            this.tlp_precios.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Blue;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 53);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 14);
            this.label16.TabIndex = 8;
            this.label16.Text = "IVA:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Green;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(221, 23);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 14);
            this.label15.TabIndex = 6;
            this.label15.Text = "Precio compra:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_precioT3
            // 
            this.tb_precioT3.BackColor = System.Drawing.Color.White;
            this.tb_precioT3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_precioT3.Location = new System.Drawing.Point(100, 20);
            this.tb_precioT3.Margin = new System.Windows.Forms.Padding(0);
            this.tb_precioT3.MaxLength = 20;
            this.tb_precioT3.Name = "tb_precioT3";
            this.tb_precioT3.ReadOnly = true;
            this.tb_precioT3.Size = new System.Drawing.Size(118, 20);
            this.tb_precioT3.TabIndex = 5;
            this.tb_precioT3.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_precioT3.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Teal;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 14);
            this.label14.TabIndex = 4;
            this.label14.Text = "PVP Tarifa 3:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_soloVenta
            // 
            this.cb_soloVenta.AutoSize = true;
            this.cb_soloVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_soloVenta.Location = new System.Drawing.Point(328, 80);
            this.cb_soloVenta.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cb_soloVenta.Name = "cb_soloVenta";
            this.cb_soloVenta.Size = new System.Drawing.Size(109, 20);
            this.cb_soloVenta.TabIndex = 13;
            this.cb_soloVenta.Text = "No";
            this.cb_soloVenta.UseVisualStyleBackColor = true;
            this.cb_soloVenta.Leave += new System.EventHandler(this.tb_X_Leave);
            this.cb_soloVenta.Enter += new System.EventHandler(this.tb_X_Enter);
            this.cb_soloVenta.CheckedChanged += new System.EventHandler(this.cb_X_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(221, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Solo venta:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Blue;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 83);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "Solo compra:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_soloCompra
            // 
            this.cb_soloCompra.AutoSize = true;
            this.cb_soloCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_soloCompra.Location = new System.Drawing.Point(110, 80);
            this.cb_soloCompra.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cb_soloCompra.Name = "cb_soloCompra";
            this.cb_soloCompra.Size = new System.Drawing.Size(108, 20);
            this.cb_soloCompra.TabIndex = 11;
            this.cb_soloCompra.Text = "No";
            this.cb_soloCompra.UseVisualStyleBackColor = true;
            this.cb_soloCompra.Leave += new System.EventHandler(this.tb_X_Leave);
            this.cb_soloCompra.Enter += new System.EventHandler(this.tb_X_Enter);
            this.cb_soloCompra.CheckedChanged += new System.EventHandler(this.cb_X_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Blue;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "PVP Tarifa 1:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_precioT1
            // 
            this.tb_precioT1.BackColor = System.Drawing.Color.White;
            this.tb_precioT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_precioT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precioT1.Location = new System.Drawing.Point(100, 0);
            this.tb_precioT1.Margin = new System.Windows.Forms.Padding(0);
            this.tb_precioT1.MaxLength = 20;
            this.tb_precioT1.Name = "tb_precioT1";
            this.tb_precioT1.ReadOnly = true;
            this.tb_precioT1.Size = new System.Drawing.Size(118, 20);
            this.tb_precioT1.TabIndex = 1;
            this.tb_precioT1.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_precioT1.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Purple;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(221, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "PVP Tarifa 2:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_precioT2
            // 
            this.tb_precioT2.BackColor = System.Drawing.Color.White;
            this.tb_precioT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_precioT2.Location = new System.Drawing.Point(318, 0);
            this.tb_precioT2.Margin = new System.Windows.Forms.Padding(0);
            this.tb_precioT2.MaxLength = 20;
            this.tb_precioT2.Name = "tb_precioT2";
            this.tb_precioT2.ReadOnly = true;
            this.tb_precioT2.Size = new System.Drawing.Size(119, 20);
            this.tb_precioT2.TabIndex = 3;
            this.tb_precioT2.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_precioT2.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_precioCompra
            // 
            this.tb_precioCompra.BackColor = System.Drawing.Color.White;
            this.tb_precioCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_precioCompra.Location = new System.Drawing.Point(318, 20);
            this.tb_precioCompra.Margin = new System.Windows.Forms.Padding(0);
            this.tb_precioCompra.MaxLength = 20;
            this.tb_precioCompra.Name = "tb_precioCompra";
            this.tb_precioCompra.ReadOnly = true;
            this.tb_precioCompra.Size = new System.Drawing.Size(119, 20);
            this.tb_precioCompra.TabIndex = 7;
            this.tb_precioCompra.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_precioCompra.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_IVA
            // 
            this.tb_IVA.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "4",
            "10",
            "21"});
            this.tb_IVA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_IVA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_IVA.BackColor = System.Drawing.Color.White;
            this.tb_IVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_IVA.Location = new System.Drawing.Point(100, 50);
            this.tb_IVA.Margin = new System.Windows.Forms.Padding(0);
            this.tb_IVA.MaxLength = 20;
            this.tb_IVA.Name = "tb_IVA";
            this.tb_IVA.ReadOnly = true;
            this.tb_IVA.Size = new System.Drawing.Size(118, 20);
            this.tb_IVA.TabIndex = 9;
            this.tb_IVA.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_IVA.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tlp_observaciones
            // 
            this.tlp_observaciones.ColumnCount = 4;
            this.tlp_observaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_observaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_observaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_observaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_observaciones.Controls.Add(this.label7, 0, 0);
            this.tlp_observaciones.Controls.Add(this.tb_observaciones, 1, 0);
            this.tlp_observaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_observaciones.Location = new System.Drawing.Point(0, 130);
            this.tlp_observaciones.Name = "tlp_observaciones";
            this.tlp_observaciones.RowCount = 3;
            this.tlp_observaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_observaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_observaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_observaciones.Size = new System.Drawing.Size(437, 50);
            this.tlp_observaciones.TabIndex = 1;
            // 
            // tlp_familias
            // 
            this.tlp_familias.ColumnCount = 3;
            this.tlp_familias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_familias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_familias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_familias.Controls.Add(this.label17, 0, 0);
            this.tlp_familias.Controls.Add(this.tb_familias, 1, 0);
            this.tlp_familias.Controls.Add(this.b_add_familia, 2, 0);
            this.tlp_familias.Controls.Add(this.b_remove_familia, 2, 1);
            this.tlp_familias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlp_familias.Location = new System.Drawing.Point(0, 320);
            this.tlp_familias.Name = "tlp_familias";
            this.tlp_familias.RowCount = 3;
            this.tlp_familias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_familias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_familias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_familias.Size = new System.Drawing.Size(437, 50);
            this.tlp_familias.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(3, 3);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label17.Name = "label17";
            this.tlp_familias.SetRowSpan(this.label17, 2);
            this.label17.Size = new System.Drawing.Size(97, 34);
            this.label17.TabIndex = 0;
            this.label17.Text = "El artículo pertenece a:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_familias
            // 
            this.tb_familias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_familias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_familias.Location = new System.Drawing.Point(100, 0);
            this.tb_familias.Margin = new System.Windows.Forms.Padding(0);
            this.tb_familias.Multiline = true;
            this.tb_familias.Name = "tb_familias";
            this.tb_familias.ReadOnly = true;
            this.tlp_familias.SetRowSpan(this.tb_familias, 2);
            this.tb_familias.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_familias.Size = new System.Drawing.Size(317, 40);
            this.tb_familias.TabIndex = 1;
            // 
            // tlp_activoVisible
            // 
            this.tlp_activoVisible.ColumnCount = 4;
            this.tlp_activoVisible.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_activoVisible.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_activoVisible.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_activoVisible.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_activoVisible.Controls.Add(this.label11, 0, 0);
            this.tlp_activoVisible.Controls.Add(this.cb_activo, 1, 0);
            this.tlp_activoVisible.Controls.Add(this.label12, 2, 0);
            this.tlp_activoVisible.Controls.Add(this.cb_visible, 3, 0);
            this.tlp_activoVisible.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlp_activoVisible.Location = new System.Drawing.Point(0, 370);
            this.tlp_activoVisible.Name = "tlp_activoVisible";
            this.tlp_activoVisible.RowCount = 2;
            this.tlp_activoVisible.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_activoVisible.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_activoVisible.Size = new System.Drawing.Size(437, 30);
            this.tlp_activoVisible.TabIndex = 5;
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
            this.label11.TabIndex = 0;
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
            this.cb_activo.Size = new System.Drawing.Size(108, 20);
            this.cb_activo.TabIndex = 1;
            this.cb_activo.Text = "No";
            this.cb_activo.UseVisualStyleBackColor = true;
            this.cb_activo.Leave += new System.EventHandler(this.tb_X_Leave);
            this.cb_activo.Enter += new System.EventHandler(this.tb_X_Enter);
            this.cb_activo.CheckedChanged += new System.EventHandler(this.cb_X_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Blue;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(221, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 14);
            this.label12.TabIndex = 2;
            this.label12.Text = "Visible:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_visible
            // 
            this.cb_visible.AutoSize = true;
            this.cb_visible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_visible.Location = new System.Drawing.Point(328, 0);
            this.cb_visible.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cb_visible.Name = "cb_visible";
            this.cb_visible.Size = new System.Drawing.Size(109, 20);
            this.cb_visible.TabIndex = 3;
            this.cb_visible.Text = "No";
            this.cb_visible.UseVisualStyleBackColor = true;
            this.cb_visible.Leave += new System.EventHandler(this.tb_X_Leave);
            this.cb_visible.Enter += new System.EventHandler(this.tb_X_Enter);
            this.cb_visible.CheckedChanged += new System.EventHandler(this.cb_X_CheckedChanged);
            // 
            // p_top
            // 
            this.p_top.Controls.Add(this.menuStrip1);
            this.p_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top.Location = new System.Drawing.Point(250, 0);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(544, 24);
            this.p_top.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_familias});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mi_familias
            // 
            this.mi_familias.Name = "mi_familias";
            this.mi_familias.Size = new System.Drawing.Size(62, 20);
            this.mi_familias.Text = "Familias";
            this.mi_familias.Click += new System.EventHandler(this.mi_familias_Click);
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
            // p_bottom
            // 
            this.p_bottom.Controls.Add(this.b_nuevo);
            this.p_bottom.Controls.Add(this.b_cancelar);
            this.p_bottom.Controls.Add(this.b_editar);
            this.p_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_bottom.Location = new System.Drawing.Point(250, 398);
            this.p_bottom.Name = "p_bottom";
            this.p_bottom.Size = new System.Drawing.Size(544, 24);
            this.p_bottom.TabIndex = 3;
            // 
            // p_botones_right
            // 
            this.p_botones_right.Controls.Add(this.tlp_botones);
            this.p_botones_right.Controls.Add(this.tlp_botones_edit);
            this.p_botones_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_botones_right.Location = new System.Drawing.Point(704, 24);
            this.p_botones_right.Name = "p_botones_right";
            this.p_botones_right.Size = new System.Drawing.Size(90, 374);
            this.p_botones_right.TabIndex = 4;
            // 
            // tlp_botones
            // 
            this.tlp_botones.ColumnCount = 1;
            this.tlp_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_botones.Controls.Add(this.b_archivos, 0, 2);
            this.tlp_botones.Controls.Add(this.b_imagen, 0, 1);
            this.tlp_botones.Controls.Add(this.b_proveedorDeArticulo, 0, 4);
            this.tlp_botones.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_botones.Location = new System.Drawing.Point(0, 90);
            this.tlp_botones.Name = "tlp_botones";
            this.tlp_botones.RowCount = 9;
            this.tlp_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_botones.Size = new System.Drawing.Size(90, 252);
            this.tlp_botones.TabIndex = 3;
            // 
            // b_add_familia
            // 
            this.b_add_familia.BackgroundImage = global::MAC.Properties.Resources.insert_square16_h_g;
            this.b_add_familia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_add_familia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_add_familia.Location = new System.Drawing.Point(417, 0);
            this.b_add_familia.Margin = new System.Windows.Forms.Padding(0);
            this.b_add_familia.Name = "b_add_familia";
            this.b_add_familia.Size = new System.Drawing.Size(20, 20);
            this.b_add_familia.TabIndex = 2;
            this.b_add_familia.UseVisualStyleBackColor = true;
            this.b_add_familia.Click += new System.EventHandler(this.b_add_familia_Click);
            // 
            // b_remove_familia
            // 
            this.b_remove_familia.BackgroundImage = global::MAC.Properties.Resources.delete_square16_h;
            this.b_remove_familia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_remove_familia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_remove_familia.Location = new System.Drawing.Point(417, 20);
            this.b_remove_familia.Margin = new System.Windows.Forms.Padding(0);
            this.b_remove_familia.Name = "b_remove_familia";
            this.b_remove_familia.Size = new System.Drawing.Size(20, 20);
            this.b_remove_familia.TabIndex = 3;
            this.b_remove_familia.UseVisualStyleBackColor = true;
            this.b_remove_familia.Click += new System.EventHandler(this.b_remove_familia_Click);
            // 
            // b_archivos
            // 
            this.b_archivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_archivos.Image = global::MAC.Properties.Resources.folder_open16;
            this.b_archivos.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_archivos.Location = new System.Drawing.Point(0, 60);
            this.b_archivos.Margin = new System.Windows.Forms.Padding(0);
            this.b_archivos.Name = "b_archivos";
            this.b_archivos.Size = new System.Drawing.Size(90, 24);
            this.b_archivos.TabIndex = 3;
            this.b_archivos.Text = "Archivos";
            this.b_archivos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_archivos.UseVisualStyleBackColor = true;
            this.b_archivos.Click += new System.EventHandler(this.b_archivos_Click);
            // 
            // b_imagen
            // 
            this.b_imagen.Image = global::MAC.Properties.Resources.table_image;
            this.b_imagen.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_imagen.Location = new System.Drawing.Point(0, 30);
            this.b_imagen.Margin = new System.Windows.Forms.Padding(0);
            this.b_imagen.Name = "b_imagen";
            this.b_imagen.Size = new System.Drawing.Size(90, 24);
            this.b_imagen.TabIndex = 2;
            this.b_imagen.Text = "Imagen";
            this.b_imagen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_imagen.UseVisualStyleBackColor = true;
            this.b_imagen.Visible = false;
            this.b_imagen.Click += new System.EventHandler(this.b_imagen_Click);
            // 
            // b_proveedorDeArticulo
            // 
            this.b_proveedorDeArticulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_proveedorDeArticulo.Image = global::MAC.Properties.Resources.group_user16_h;
            this.b_proveedorDeArticulo.Location = new System.Drawing.Point(0, 120);
            this.b_proveedorDeArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.b_proveedorDeArticulo.Name = "b_proveedorDeArticulo";
            this.b_proveedorDeArticulo.Size = new System.Drawing.Size(90, 24);
            this.b_proveedorDeArticulo.TabIndex = 4;
            this.b_proveedorDeArticulo.Text = "Proveedor";
            this.b_proveedorDeArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_proveedorDeArticulo.UseVisualStyleBackColor = true;
            this.b_proveedorDeArticulo.Click += new System.EventHandler(this.b_proveedorDeArticulo_Click);
            // 
            // b_tarifas
            // 
            this.b_tarifas.Image = global::MAC.Properties.Resources.table_16;
            this.b_tarifas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_tarifas.Location = new System.Drawing.Point(0, 30);
            this.b_tarifas.Margin = new System.Windows.Forms.Padding(0);
            this.b_tarifas.Name = "b_tarifas";
            this.b_tarifas.Size = new System.Drawing.Size(90, 24);
            this.b_tarifas.TabIndex = 1;
            this.b_tarifas.Text = "Tarifas";
            this.b_tarifas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_tarifas.UseVisualStyleBackColor = true;
            this.b_tarifas.Click += new System.EventHandler(this.b_tarifas_Click);
            // 
            // b_stock
            // 
            this.b_stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_stock.Image = global::MAC.Properties.Resources.paquetes;
            this.b_stock.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_stock.Location = new System.Drawing.Point(0, 60);
            this.b_stock.Margin = new System.Windows.Forms.Padding(0);
            this.b_stock.Name = "b_stock";
            this.b_stock.Size = new System.Drawing.Size(90, 24);
            this.b_stock.TabIndex = 2;
            this.b_stock.Text = "Stock";
            this.b_stock.UseVisualStyleBackColor = true;
            this.b_stock.Click += new System.EventHandler(this.b_stock_Click);
            // 
            // b_nuevo
            // 
            this.b_nuevo.Dock = System.Windows.Forms.DockStyle.Left;
            this.b_nuevo.Image = global::MAC.Properties.Resources.insert_square16_h_g;
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
            this.b_cancelar.Image = global::MAC.Properties.Resources.cancel_square16;
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
            this.b_editar.Image = global::MAC.Properties.Resources.edit_square16_h_c;
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
            // b_f_search
            // 
            this.b_f_search.BackgroundImage = global::MAC.Properties.Resources.search16_h;
            this.b_f_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_f_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_f_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_f_search.Location = new System.Drawing.Point(210, 0);
            this.b_f_search.Margin = new System.Windows.Forms.Padding(0);
            this.b_f_search.Name = "b_f_search";
            this.b_f_search.Size = new System.Drawing.Size(20, 20);
            this.b_f_search.TabIndex = 2;
            this.b_f_search.UseVisualStyleBackColor = true;
            this.b_f_search.Click += new System.EventHandler(this.b_f_search_Click);
            // 
            // b_f_alt
            // 
            this.b_f_alt.BackgroundImage = global::MAC.Properties.Resources.down_square16_h;
            this.b_f_alt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_f_alt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_f_alt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_f_alt.Location = new System.Drawing.Point(230, 0);
            this.b_f_alt.Margin = new System.Windows.Forms.Padding(0);
            this.b_f_alt.Name = "b_f_alt";
            this.b_f_alt.Size = new System.Drawing.Size(20, 20);
            this.b_f_alt.TabIndex = 3;
            this.b_f_alt.UseVisualStyleBackColor = true;
            this.b_f_alt.Visible = false;
            this.b_f_alt.Click += new System.EventHandler(this.b_f_alt_Click);
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 422);
            this.Controls.Add(this.p_edit);
            this.Controls.Add(this.p_botones_right);
            this.Controls.Add(this.p_top);
            this.Controls.Add(this.p_bottom);
            this.Controls.Add(this.p_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículos";
            this.Deactivate += new System.EventHandler(this.FormArticulos_Deactivate);
            this.Load += new System.EventHandler(this.FormArticulos_Load);
            this.Activated += new System.EventHandler(this.FormArticulos_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.tlp_descripcion.ResumeLayout(false);
            this.tlp_descripcion.PerformLayout();
            this.tlp_botones_edit.ResumeLayout(false);
            this.t_filtro_1.ResumeLayout(false);
            this.t_filtro_1.PerformLayout();
            this.p_edit.ResumeLayout(false);
            this.tlp_stock.ResumeLayout(false);
            this.tlp_stock.PerformLayout();
            this.tlp_precios.ResumeLayout(false);
            this.tlp_precios.PerformLayout();
            this.tlp_observaciones.ResumeLayout(false);
            this.tlp_observaciones.PerformLayout();
            this.tlp_familias.ResumeLayout(false);
            this.tlp_familias.PerformLayout();
            this.tlp_activoVisible.ResumeLayout(false);
            this.tlp_activoVisible.PerformLayout();
            this.p_top.ResumeLayout(false);
            this.p_top.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.p_left.ResumeLayout(false);
            this.p_bottom.ResumeLayout(false);
            this.p_botones_right.ResumeLayout(false);
            this.p_botones_right.PerformLayout();
            this.tlp_botones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox tb_idArticulo;
        private System.Windows.Forms.TableLayoutPanel tlp_descripcion;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_descripcion;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_observaciones;
        private System.Windows.Forms.Button b_observaciones;
        private System.Windows.Forms.Button b_tarifas;
        private System.Windows.Forms.Button b_archivos;
        private System.Windows.Forms.TableLayoutPanel tlp_botones_edit;
        private System.Windows.Forms.Button b_imagen;
        private System.Windows.Forms.Timer t_filtro;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Button b_f_search;
        private System.Windows.Forms.Button b_f_alt;
        private System.Windows.Forms.TextBox tb_f_1;
        private System.Windows.Forms.Button b_nuevo;
        private System.Windows.Forms.Button b_editar;
        private System.Windows.Forms.TableLayoutPanel t_filtro_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel t_filtro_2;
        private System.Windows.Forms.Panel p_edit;
        private System.Windows.Forms.TableLayoutPanel tlp_activoVisible;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cb_activo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cb_visible;
        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.Panel p_left;
        private System.Windows.Forms.Panel p_bottom;
        private System.Windows.Forms.TextBox tb_referencia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tlp_observaciones;
        private System.Windows.Forms.TableLayoutPanel tlp_precios;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_precioT3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cb_soloVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cb_soloCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_precioT1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_precioT2;
        private System.Windows.Forms.TextBox tb_precioCompra;
        private System.Windows.Forms.TextBox tb_IVA;
        private System.Windows.Forms.Panel p_botones_right;
        private System.Windows.Forms.TableLayoutPanel tlp_botones;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_familias;
        private System.Windows.Forms.TableLayoutPanel tlp_familias;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_familias;
        private System.Windows.Forms.Button b_add_familia;
        private System.Windows.Forms.Button b_remove_familia;
        private System.Windows.Forms.TableLayoutPanel tlp_stock;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.TextBox tb_stockMin;
        private System.Windows.Forms.Button b_stock;
        private System.Windows.Forms.Button b_proveedorDeArticulo;
    }
}