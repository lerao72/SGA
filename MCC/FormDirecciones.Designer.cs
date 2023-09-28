namespace MCC
{
    partial class FormDirecciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDirecciones));
            this.t_filtro_1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_f_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p_cb_filtro = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.tb_localidad = new System.Windows.Forms.TextBox();
            this.tb_provincia = new System.Windows.Forms.TextBox();
            this.tb_pais = new System.Windows.Forms.TextBox();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_tipo = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.p_bottom = new System.Windows.Forms.Panel();
            this.p_grid = new System.Windows.Forms.Panel();
            this.b_f_search = new System.Windows.Forms.Button();
            this.b_tipo = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_nuevo = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_editar = new System.Windows.Forms.Button();
            this.t_filtro_1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.p_bottom.SuspendLayout();
            this.p_grid.SuspendLayout();
            this.SuspendLayout();
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
            this.t_filtro_1.Size = new System.Drawing.Size(794, 20);
            this.t_filtro_1.TabIndex = 2;
            this.t_filtro_1.Visible = false;
            // 
            // tb_f_1
            // 
            this.tb_f_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_f_1.Location = new System.Drawing.Point(574, 0);
            this.tb_f_1.Margin = new System.Windows.Forms.Padding(0);
            this.tb_f_1.Name = "tb_f_1";
            this.tb_f_1.Size = new System.Drawing.Size(200, 20);
            this.tb_f_1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(477, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtro:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // p_cb_filtro
            // 
            this.p_cb_filtro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_cb_filtro.Location = new System.Drawing.Point(0, 0);
            this.p_cb_filtro.Margin = new System.Windows.Forms.Padding(0);
            this.p_cb_filtro.Name = "p_cb_filtro";
            this.p_cb_filtro.Size = new System.Drawing.Size(474, 20);
            this.p_cb_filtro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cod.Postal:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_cp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_localidad, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_provincia, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_pais, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_direccion, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 130);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.label4.TabIndex = 3;
            this.label4.Text = "Provincia:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dirección:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(400, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pais:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(400, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Localidad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_cp
            // 
            this.tb_cp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_cp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_cp.BackColor = System.Drawing.Color.White;
            this.tb_cp.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_cp.Location = new System.Drawing.Point(100, 30);
            this.tb_cp.Margin = new System.Windows.Forms.Padding(0);
            this.tb_cp.MaxLength = 10;
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.Size = new System.Drawing.Size(100, 20);
            this.tb_cp.TabIndex = 7;
            this.tb_cp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_cp.Leave += new System.EventHandler(this.tb_cp_Leave);
            this.tb_cp.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_localidad
            // 
            this.tb_localidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_localidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_localidad.BackColor = System.Drawing.Color.White;
            this.tb_localidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_localidad.Location = new System.Drawing.Point(497, 30);
            this.tb_localidad.Margin = new System.Windows.Forms.Padding(0);
            this.tb_localidad.MaxLength = 100;
            this.tb_localidad.Name = "tb_localidad";
            this.tb_localidad.Size = new System.Drawing.Size(297, 20);
            this.tb_localidad.TabIndex = 8;
            this.tb_localidad.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_localidad.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_provincia
            // 
            this.tb_provincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_provincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_provincia.BackColor = System.Drawing.Color.White;
            this.tb_provincia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_provincia.Location = new System.Drawing.Point(100, 50);
            this.tb_provincia.Margin = new System.Windows.Forms.Padding(0);
            this.tb_provincia.MaxLength = 100;
            this.tb_provincia.Name = "tb_provincia";
            this.tb_provincia.Size = new System.Drawing.Size(297, 20);
            this.tb_provincia.TabIndex = 9;
            this.tb_provincia.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_provincia.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_pais
            // 
            this.tb_pais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_pais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_pais.BackColor = System.Drawing.Color.White;
            this.tb_pais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_pais.Location = new System.Drawing.Point(497, 50);
            this.tb_pais.Margin = new System.Windows.Forms.Padding(0);
            this.tb_pais.MaxLength = 100;
            this.tb_pais.Name = "tb_pais";
            this.tb_pais.Size = new System.Drawing.Size(297, 20);
            this.tb_pais.TabIndex = 10;
            this.tb_pais.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_pais.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tb_direccion
            // 
            this.tb_direccion.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_direccion, 3);
            this.tb_direccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_direccion.Location = new System.Drawing.Point(100, 80);
            this.tb_direccion.Margin = new System.Windows.Forms.Padding(0);
            this.tb_direccion.Multiline = true;
            this.tb_direccion.Name = "tb_direccion";
            this.tableLayoutPanel1.SetRowSpan(this.tb_direccion, 2);
            this.tb_direccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_direccion.Size = new System.Drawing.Size(694, 40);
            this.tb_direccion.TabIndex = 11;
            this.tb_direccion.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_direccion.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tb_tipo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.b_tipo, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(100, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(297, 20);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // tb_tipo
            // 
            this.tb_tipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_tipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_tipo.Location = new System.Drawing.Point(0, 0);
            this.tb_tipo.Margin = new System.Windows.Forms.Padding(0);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.ReadOnly = true;
            this.tb_tipo.Size = new System.Drawing.Size(277, 20);
            this.tb_tipo.TabIndex = 26;
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
            this.grid.Size = new System.Drawing.Size(794, 73);
            this.grid.TabIndex = 4;
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
            this.grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEnter);
            // 
            // p_bottom
            // 
            this.p_bottom.Controls.Add(this.b_borrar);
            this.p_bottom.Controls.Add(this.b_nuevo);
            this.p_bottom.Controls.Add(this.b_cancelar);
            this.p_bottom.Controls.Add(this.b_editar);
            this.p_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_bottom.Location = new System.Drawing.Point(0, 223);
            this.p_bottom.Name = "p_bottom";
            this.p_bottom.Size = new System.Drawing.Size(794, 24);
            this.p_bottom.TabIndex = 5;
            // 
            // p_grid
            // 
            this.p_grid.Controls.Add(this.grid);
            this.p_grid.Controls.Add(this.t_filtro_1);
            this.p_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_grid.Location = new System.Drawing.Point(0, 0);
            this.p_grid.Name = "p_grid";
            this.p_grid.Size = new System.Drawing.Size(794, 93);
            this.p_grid.TabIndex = 6;
            // 
            // b_f_search
            // 
            this.b_f_search.BackgroundImage = global::MCC.Properties.Resources.search16_h;
            this.b_f_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_f_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_f_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_f_search.Location = new System.Drawing.Point(774, 0);
            this.b_f_search.Margin = new System.Windows.Forms.Padding(0);
            this.b_f_search.Name = "b_f_search";
            this.b_f_search.Size = new System.Drawing.Size(20, 20);
            this.b_f_search.TabIndex = 0;
            this.b_f_search.UseVisualStyleBackColor = true;
            // 
            // b_tipo
            // 
            this.b_tipo.BackgroundImage = global::MCC.Properties.Resources.down_square16_h;
            this.b_tipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_tipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_tipo.Location = new System.Drawing.Point(277, 0);
            this.b_tipo.Margin = new System.Windows.Forms.Padding(0);
            this.b_tipo.Name = "b_tipo";
            this.b_tipo.Size = new System.Drawing.Size(20, 20);
            this.b_tipo.TabIndex = 25;
            this.b_tipo.UseVisualStyleBackColor = true;
            this.b_tipo.Visible = false;
            this.b_tipo.Click += new System.EventHandler(this.b_tipo_Click);
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
            this.b_cancelar.Location = new System.Drawing.Point(644, 0);
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
            this.b_editar.Location = new System.Drawing.Point(719, 0);
            this.b_editar.Name = "b_editar";
            this.b_editar.Size = new System.Drawing.Size(75, 24);
            this.b_editar.TabIndex = 0;
            this.b_editar.Text = "Editar";
            this.b_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_editar.UseVisualStyleBackColor = true;
            this.b_editar.Click += new System.EventHandler(this.b_editar_Click);
            // 
            // FormDirecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 247);
            this.Controls.Add(this.p_grid);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.p_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDirecciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Direcciones";
            this.Load += new System.EventHandler(this.FormDirecciones_Load);
            this.t_filtro_1.ResumeLayout(false);
            this.t_filtro_1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.p_bottom.ResumeLayout(false);
            this.p_grid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel t_filtro_1;
        private System.Windows.Forms.Button b_f_search;
        private System.Windows.Forms.TextBox tb_f_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p_cb_filtro;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel p_bottom;
        private System.Windows.Forms.Button b_nuevo;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Button b_editar;
        private System.Windows.Forms.TextBox tb_cp;
        private System.Windows.Forms.TextBox tb_localidad;
        private System.Windows.Forms.TextBox tb_provincia;
        private System.Windows.Forms.TextBox tb_pais;
        private System.Windows.Forms.TextBox tb_direccion;
        private System.Windows.Forms.Panel p_grid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button b_tipo;
        private System.Windows.Forms.TextBox tb_tipo;
        private System.Windows.Forms.Button b_borrar;
    }
}