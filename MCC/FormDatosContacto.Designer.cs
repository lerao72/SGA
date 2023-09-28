namespace MCC
{
    partial class FormDatosContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosContacto));
            this.grid = new System.Windows.Forms.DataGridView();
            this.p_grid = new System.Windows.Forms.Panel();
            this.t_filtro_1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_f_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p_cb_filtro = new System.Windows.Forms.Panel();
            this.rb_tipo_web = new System.Windows.Forms.RadioButton();
            this.rb_tipo_email = new System.Windows.Forms.RadioButton();
            this.rb_tipo_telefono = new System.Windows.Forms.RadioButton();
            this.p_bottom = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_tipo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_observaciones = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_dato = new System.Windows.Forms.TextBox();
            this.tb_cargo = new System.Windows.Forms.TextBox();
            this.t_CheckedChanged = new System.Windows.Forms.Timer(this.components);
            this.t_filtro = new System.Windows.Forms.Timer(this.components);
            this.b_f_search = new System.Windows.Forms.Button();
            this.b_enviar_email = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_nuevo = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.p_grid.SuspendLayout();
            this.t_filtro_1.SuspendLayout();
            this.p_cb_filtro.SuspendLayout();
            this.p_bottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.grid.Location = new System.Drawing.Point(0, 20);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(694, 158);
            this.grid.TabIndex = 1;
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
            this.grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEnter);
            // 
            // p_grid
            // 
            this.p_grid.Controls.Add(this.grid);
            this.p_grid.Controls.Add(this.t_filtro_1);
            this.p_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_grid.Location = new System.Drawing.Point(0, 0);
            this.p_grid.Name = "p_grid";
            this.p_grid.Size = new System.Drawing.Size(694, 178);
            this.p_grid.TabIndex = 0;
            // 
            // t_filtro_1
            // 
            this.t_filtro_1.ColumnCount = 4;
            this.t_filtro_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.t_filtro_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.t_filtro_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.t_filtro_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.t_filtro_1.Controls.Add(this.b_f_search, 3, 0);
            this.t_filtro_1.Controls.Add(this.tb_f_1, 2, 0);
            this.t_filtro_1.Controls.Add(this.label1, 1, 0);
            this.t_filtro_1.Controls.Add(this.p_cb_filtro, 0, 0);
            this.t_filtro_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.t_filtro_1.Location = new System.Drawing.Point(0, 0);
            this.t_filtro_1.Name = "t_filtro_1";
            this.t_filtro_1.RowCount = 1;
            this.t_filtro_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.t_filtro_1.Size = new System.Drawing.Size(694, 20);
            this.t_filtro_1.TabIndex = 2;
            // 
            // tb_f_1
            // 
            this.tb_f_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_f_1.Location = new System.Drawing.Point(474, 0);
            this.tb_f_1.Margin = new System.Windows.Forms.Padding(0);
            this.tb_f_1.Name = "tb_f_1";
            this.tb_f_1.Size = new System.Drawing.Size(200, 20);
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
            this.label1.Location = new System.Drawing.Point(377, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtro:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // p_cb_filtro
            // 
            this.p_cb_filtro.Controls.Add(this.rb_tipo_web);
            this.p_cb_filtro.Controls.Add(this.rb_tipo_email);
            this.p_cb_filtro.Controls.Add(this.rb_tipo_telefono);
            this.p_cb_filtro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_cb_filtro.Location = new System.Drawing.Point(0, 0);
            this.p_cb_filtro.Margin = new System.Windows.Forms.Padding(0);
            this.p_cb_filtro.Name = "p_cb_filtro";
            this.p_cb_filtro.Size = new System.Drawing.Size(374, 20);
            this.p_cb_filtro.TabIndex = 4;
            // 
            // rb_tipo_web
            // 
            this.rb_tipo_web.Dock = System.Windows.Forms.DockStyle.Left;
            this.rb_tipo_web.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_tipo_web.Location = new System.Drawing.Point(200, 0);
            this.rb_tipo_web.Name = "rb_tipo_web";
            this.rb_tipo_web.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rb_tipo_web.Size = new System.Drawing.Size(100, 20);
            this.rb_tipo_web.TabIndex = 2;
            this.rb_tipo_web.Text = "Web";
            this.rb_tipo_web.UseVisualStyleBackColor = true;
            this.rb_tipo_web.CheckedChanged += new System.EventHandler(this.rb_tipo_X_CheckedChanged);
            // 
            // rb_tipo_email
            // 
            this.rb_tipo_email.Dock = System.Windows.Forms.DockStyle.Left;
            this.rb_tipo_email.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_tipo_email.Location = new System.Drawing.Point(100, 0);
            this.rb_tipo_email.Name = "rb_tipo_email";
            this.rb_tipo_email.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rb_tipo_email.Size = new System.Drawing.Size(100, 20);
            this.rb_tipo_email.TabIndex = 1;
            this.rb_tipo_email.Text = "e-mail";
            this.rb_tipo_email.UseVisualStyleBackColor = true;
            this.rb_tipo_email.CheckedChanged += new System.EventHandler(this.rb_tipo_X_CheckedChanged);
            // 
            // rb_tipo_telefono
            // 
            this.rb_tipo_telefono.BackColor = System.Drawing.Color.Lime;
            this.rb_tipo_telefono.Checked = true;
            this.rb_tipo_telefono.Dock = System.Windows.Forms.DockStyle.Left;
            this.rb_tipo_telefono.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_tipo_telefono.Location = new System.Drawing.Point(0, 0);
            this.rb_tipo_telefono.Name = "rb_tipo_telefono";
            this.rb_tipo_telefono.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rb_tipo_telefono.Size = new System.Drawing.Size(100, 20);
            this.rb_tipo_telefono.TabIndex = 0;
            this.rb_tipo_telefono.TabStop = true;
            this.rb_tipo_telefono.Text = "Teléfono";
            this.rb_tipo_telefono.UseVisualStyleBackColor = false;
            this.rb_tipo_telefono.CheckedChanged += new System.EventHandler(this.rb_tipo_X_CheckedChanged);
            // 
            // p_bottom
            // 
            this.p_bottom.Controls.Add(this.b_enviar_email);
            this.p_bottom.Controls.Add(this.b_borrar);
            this.p_bottom.Controls.Add(this.b_nuevo);
            this.p_bottom.Controls.Add(this.b_cancelar);
            this.p_bottom.Controls.Add(this.b_editar);
            this.p_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_bottom.Location = new System.Drawing.Point(0, 298);
            this.p_bottom.Name = "p_bottom";
            this.p_bottom.Size = new System.Drawing.Size(694, 24);
            this.p_bottom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "Observaciones:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_tipo
            // 
            this.l_tipo.AutoSize = true;
            this.l_tipo.BackColor = System.Drawing.Color.Blue;
            this.l_tipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_tipo.ForeColor = System.Drawing.Color.White;
            this.l_tipo.Location = new System.Drawing.Point(3, 5);
            this.l_tipo.Margin = new System.Windows.Forms.Padding(3, 5, 0, 5);
            this.l_tipo.Name = "l_tipo";
            this.l_tipo.Size = new System.Drawing.Size(117, 14);
            this.l_tipo.TabIndex = 4;
            this.l_tipo.Text = "Teléfono:";
            this.l_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(377, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cargo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_nombre
            // 
            this.tb_nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_nombre.BackColor = System.Drawing.Color.White;
            this.tb_nombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_nombre.Location = new System.Drawing.Point(120, 34);
            this.tb_nombre.Margin = new System.Windows.Forms.Padding(0);
            this.tb_nombre.MaxLength = 255;
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(254, 20);
            this.tb_nombre.TabIndex = 1;
            this.tb_nombre.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_nombre.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_observaciones
            // 
            this.tb_observaciones.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_observaciones, 3);
            this.tb_observaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_observaciones.Location = new System.Drawing.Point(120, 64);
            this.tb_observaciones.Margin = new System.Windows.Forms.Padding(0);
            this.tb_observaciones.MaxLength = 255;
            this.tb_observaciones.Multiline = true;
            this.tb_observaciones.Name = "tb_observaciones";
            this.tableLayoutPanel1.SetRowSpan(this.tb_observaciones, 2);
            this.tb_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_observaciones.Size = new System.Drawing.Size(574, 46);
            this.tb_observaciones.TabIndex = 3;
            this.tb_observaciones.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_observaciones.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.l_tipo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_nombre, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_observaciones, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_dato, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_cargo, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 178);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 120);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tb_dato
            // 
            this.tb_dato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_dato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_dato.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_dato, 3);
            this.tb_dato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_dato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dato.Location = new System.Drawing.Point(120, 0);
            this.tb_dato.Margin = new System.Windows.Forms.Padding(0);
            this.tb_dato.MaxLength = 255;
            this.tb_dato.Name = "tb_dato";
            this.tb_dato.Size = new System.Drawing.Size(574, 24);
            this.tb_dato.TabIndex = 0;
            this.tb_dato.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_dato.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_cargo
            // 
            this.tb_cargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_cargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_cargo.BackColor = System.Drawing.Color.White;
            this.tb_cargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_cargo.Location = new System.Drawing.Point(494, 34);
            this.tb_cargo.Margin = new System.Windows.Forms.Padding(0);
            this.tb_cargo.MaxLength = 50;
            this.tb_cargo.Name = "tb_cargo";
            this.tb_cargo.Size = new System.Drawing.Size(200, 20);
            this.tb_cargo.TabIndex = 2;
            this.tb_cargo.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_cargo.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // t_CheckedChanged
            // 
            this.t_CheckedChanged.Interval = 50;
            this.t_CheckedChanged.Tick += new System.EventHandler(this.t_CheckedChanged_Tick);
            // 
            // t_filtro
            // 
            this.t_filtro.Interval = 300;
            this.t_filtro.Tick += new System.EventHandler(this.t_filtro_Tick);
            // 
            // b_f_search
            // 
            this.b_f_search.BackgroundImage = global::MCC.Properties.Resources.search16_h;
            this.b_f_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_f_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_f_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_f_search.Location = new System.Drawing.Point(674, 0);
            this.b_f_search.Margin = new System.Windows.Forms.Padding(0);
            this.b_f_search.Name = "b_f_search";
            this.b_f_search.Size = new System.Drawing.Size(20, 20);
            this.b_f_search.TabIndex = 0;
            this.b_f_search.UseVisualStyleBackColor = true;
            this.b_f_search.Click += new System.EventHandler(this.b_f_search_Click);
            // 
            // b_enviar_email
            // 
            this.b_enviar_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_enviar_email.Enabled = false;
            this.b_enviar_email.Image = global::MCC.Properties.Resources.mail16_h;
            this.b_enviar_email.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_enviar_email.Location = new System.Drawing.Point(297, 0);
            this.b_enviar_email.Name = "b_enviar_email";
            this.b_enviar_email.Size = new System.Drawing.Size(100, 24);
            this.b_enviar_email.TabIndex = 4;
            this.b_enviar_email.Text = "Enviar e-mail";
            this.b_enviar_email.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_enviar_email.UseVisualStyleBackColor = true;
            this.b_enviar_email.Visible = false;
            this.b_enviar_email.Click += new System.EventHandler(this.b_enviar_email_Click);
            // 
            // b_borrar
            // 
            this.b_borrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.b_borrar.Image = global::MCC.Properties.Resources.delete_square16_h;
            this.b_borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_borrar.Location = new System.Drawing.Point(75, 0);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(75, 24);
            this.b_borrar.TabIndex = 3;
            this.b_borrar.Text = "Borrar";
            this.b_borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Visible = false;
            this.b_borrar.Click += new System.EventHandler(this.b_borrar_Click);
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
            this.b_cancelar.Location = new System.Drawing.Point(544, 0);
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
            this.b_editar.Location = new System.Drawing.Point(619, 0);
            this.b_editar.Name = "b_editar";
            this.b_editar.Size = new System.Drawing.Size(75, 24);
            this.b_editar.TabIndex = 0;
            this.b_editar.Text = "Editar";
            this.b_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_editar.UseVisualStyleBackColor = true;
            this.b_editar.Click += new System.EventHandler(this.b_editar_Click);
            // 
            // FormDatosContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 322);
            this.Controls.Add(this.p_grid);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.p_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDatosContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de contacto";
            this.Load += new System.EventHandler(this.FormDatosContacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.p_grid.ResumeLayout(false);
            this.t_filtro_1.ResumeLayout(false);
            this.t_filtro_1.PerformLayout();
            this.p_cb_filtro.ResumeLayout(false);
            this.p_bottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Panel p_grid;
        private System.Windows.Forms.TableLayoutPanel t_filtro_1;
        private System.Windows.Forms.Button b_f_search;
        private System.Windows.Forms.TextBox tb_f_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p_cb_filtro;
        private System.Windows.Forms.Panel p_bottom;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_nuevo;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Button b_editar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_observaciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_dato;
        private System.Windows.Forms.TextBox tb_cargo;
        private System.Windows.Forms.RadioButton rb_tipo_web;
        private System.Windows.Forms.RadioButton rb_tipo_email;
        private System.Windows.Forms.RadioButton rb_tipo_telefono;
        private System.Windows.Forms.Timer t_CheckedChanged;
        private System.Windows.Forms.Timer t_filtro;
        private System.Windows.Forms.Button b_enviar_email;
    }
}