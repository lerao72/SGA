namespace MCC
{
    partial class FormCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCuentas));
            this.label4 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.p_grid = new System.Windows.Forms.Panel();
            this.p_bottom = new System.Windows.Forms.Panel();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_nuevo = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_editar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_banco = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_swift = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p_cuenta = new System.Windows.Forms.Panel();
            this.tb_cuenta = new System.Windows.Forms.TextBox();
            this.p_IBAN_ES = new System.Windows.Forms.Panel();
            this.gb_IBAN_ES_NoCuenta = new System.Windows.Forms.GroupBox();
            this.tb_IBAN_ES_NoCuenta = new System.Windows.Forms.TextBox();
            this.gb_IBAN_ES_DC = new System.Windows.Forms.GroupBox();
            this.tb_IBAN_ES_DC = new System.Windows.Forms.TextBox();
            this.gb_IBAN_ES_Oficina = new System.Windows.Forms.GroupBox();
            this.tb_IBAN_ES_Oficina = new System.Windows.Forms.TextBox();
            this.gb_IBAN_ES_Entidad = new System.Windows.Forms.GroupBox();
            this.tb_IBAN_ES_Entidad = new System.Windows.Forms.TextBox();
            this.gb_IBAN_ES_IBAN = new System.Windows.Forms.GroupBox();
            this.tb_IBAN_ES_IBAN = new System.Windows.Forms.TextBox();
            this.p_tipo_cuenta = new System.Windows.Forms.Panel();
            this.cb_cobro = new System.Windows.Forms.CheckBox();
            this.cb_pago = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.p_grid.SuspendLayout();
            this.p_bottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.p_cuenta.SuspendLayout();
            this.p_IBAN_ES.SuspendLayout();
            this.gb_IBAN_ES_NoCuenta.SuspendLayout();
            this.gb_IBAN_ES_DC.SuspendLayout();
            this.gb_IBAN_ES_Oficina.SuspendLayout();
            this.gb_IBAN_ES_Entidad.SuspendLayout();
            this.gb_IBAN_ES_IBAN.SuspendLayout();
            this.p_tipo_cuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "IBAN / Nº de cuenta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.grid.Size = new System.Drawing.Size(414, 103);
            this.grid.TabIndex = 0;
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
            this.grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEnter);
            // 
            // p_grid
            // 
            this.p_grid.Controls.Add(this.grid);
            this.p_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_grid.Location = new System.Drawing.Point(0, 0);
            this.p_grid.Name = "p_grid";
            this.p_grid.Size = new System.Drawing.Size(414, 103);
            this.p_grid.TabIndex = 9;
            // 
            // p_bottom
            // 
            this.p_bottom.Controls.Add(this.b_borrar);
            this.p_bottom.Controls.Add(this.b_nuevo);
            this.p_bottom.Controls.Add(this.b_cancelar);
            this.p_bottom.Controls.Add(this.b_editar);
            this.p_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_bottom.Location = new System.Drawing.Point(0, 218);
            this.p_bottom.Name = "p_bottom";
            this.p_bottom.Size = new System.Drawing.Size(414, 24);
            this.p_bottom.TabIndex = 8;
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
            this.b_cancelar.Location = new System.Drawing.Point(264, 0);
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
            this.b_editar.Location = new System.Drawing.Point(339, 0);
            this.b_editar.Name = "b_editar";
            this.b_editar.Size = new System.Drawing.Size(75, 24);
            this.b_editar.TabIndex = 0;
            this.b_editar.Text = "Editar";
            this.b_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_editar.UseVisualStyleBackColor = true;
            this.b_editar.Click += new System.EventHandler(this.b_editar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Banco:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cuenta usada para:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_banco
            // 
            this.tb_banco.BackColor = System.Drawing.Color.White;
            this.tb_banco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_banco.Location = new System.Drawing.Point(145, 0);
            this.tb_banco.Margin = new System.Windows.Forms.Padding(0);
            this.tb_banco.MaxLength = 50;
            this.tb_banco.Name = "tb_banco";
            this.tb_banco.Size = new System.Drawing.Size(263, 20);
            this.tb_banco.TabIndex = 1;
            this.tb_banco.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_banco.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tb_swift, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.p_cuenta, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_banco, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.p_tipo_cuenta, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 115);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tb_swift
            // 
            this.tb_swift.BackColor = System.Drawing.Color.White;
            this.tb_swift.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_swift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_swift.Location = new System.Drawing.Point(145, 58);
            this.tb_swift.Margin = new System.Windows.Forms.Padding(0);
            this.tb_swift.MaxLength = 11;
            this.tb_swift.Name = "tb_swift";
            this.tb_swift.Size = new System.Drawing.Size(263, 20);
            this.tb_swift.TabIndex = 5;
            this.tb_swift.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_swift.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "SWIFT:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // p_cuenta
            // 
            this.p_cuenta.Controls.Add(this.tb_cuenta);
            this.p_cuenta.Controls.Add(this.p_IBAN_ES);
            this.p_cuenta.Location = new System.Drawing.Point(145, 20);
            this.p_cuenta.Margin = new System.Windows.Forms.Padding(0);
            this.p_cuenta.Name = "p_cuenta";
            this.p_cuenta.Size = new System.Drawing.Size(263, 38);
            this.p_cuenta.TabIndex = 3;
            // 
            // tb_cuenta
            // 
            this.tb_cuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_cuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_cuenta.BackColor = System.Drawing.Color.White;
            this.tb_cuenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_cuenta.Location = new System.Drawing.Point(263, 0);
            this.tb_cuenta.Margin = new System.Windows.Forms.Padding(0);
            this.tb_cuenta.MaxLength = 100;
            this.tb_cuenta.Name = "tb_cuenta";
            this.tb_cuenta.Size = new System.Drawing.Size(263, 20);
            this.tb_cuenta.TabIndex = 1;
            this.tb_cuenta.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_cuenta.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // p_IBAN_ES
            // 
            this.p_IBAN_ES.Controls.Add(this.gb_IBAN_ES_NoCuenta);
            this.p_IBAN_ES.Controls.Add(this.gb_IBAN_ES_DC);
            this.p_IBAN_ES.Controls.Add(this.gb_IBAN_ES_Oficina);
            this.p_IBAN_ES.Controls.Add(this.gb_IBAN_ES_Entidad);
            this.p_IBAN_ES.Controls.Add(this.gb_IBAN_ES_IBAN);
            this.p_IBAN_ES.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_IBAN_ES.Location = new System.Drawing.Point(0, 0);
            this.p_IBAN_ES.Name = "p_IBAN_ES";
            this.p_IBAN_ES.Size = new System.Drawing.Size(263, 38);
            this.p_IBAN_ES.TabIndex = 0;
            // 
            // gb_IBAN_ES_NoCuenta
            // 
            this.gb_IBAN_ES_NoCuenta.Controls.Add(this.tb_IBAN_ES_NoCuenta);
            this.gb_IBAN_ES_NoCuenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_IBAN_ES_NoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_IBAN_ES_NoCuenta.Location = new System.Drawing.Point(185, 0);
            this.gb_IBAN_ES_NoCuenta.Name = "gb_IBAN_ES_NoCuenta";
            this.gb_IBAN_ES_NoCuenta.Size = new System.Drawing.Size(78, 38);
            this.gb_IBAN_ES_NoCuenta.TabIndex = 4;
            this.gb_IBAN_ES_NoCuenta.TabStop = false;
            this.gb_IBAN_ES_NoCuenta.Text = "Nº Cuenta";
            // 
            // tb_IBAN_ES_NoCuenta
            // 
            this.tb_IBAN_ES_NoCuenta.BackColor = System.Drawing.Color.White;
            this.tb_IBAN_ES_NoCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_IBAN_ES_NoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IBAN_ES_NoCuenta.Location = new System.Drawing.Point(3, 14);
            this.tb_IBAN_ES_NoCuenta.MaxLength = 10;
            this.tb_IBAN_ES_NoCuenta.Name = "tb_IBAN_ES_NoCuenta";
            this.tb_IBAN_ES_NoCuenta.Size = new System.Drawing.Size(72, 20);
            this.tb_IBAN_ES_NoCuenta.TabIndex = 0;
            this.tb_IBAN_ES_NoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_IBAN_ES_NoCuenta.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_IBAN_ES_NoCuenta.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // gb_IBAN_ES_DC
            // 
            this.gb_IBAN_ES_DC.Controls.Add(this.tb_IBAN_ES_DC);
            this.gb_IBAN_ES_DC.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_IBAN_ES_DC.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_IBAN_ES_DC.Location = new System.Drawing.Point(150, 0);
            this.gb_IBAN_ES_DC.Name = "gb_IBAN_ES_DC";
            this.gb_IBAN_ES_DC.Size = new System.Drawing.Size(35, 38);
            this.gb_IBAN_ES_DC.TabIndex = 3;
            this.gb_IBAN_ES_DC.TabStop = false;
            this.gb_IBAN_ES_DC.Text = "DC";
            // 
            // tb_IBAN_ES_DC
            // 
            this.tb_IBAN_ES_DC.BackColor = System.Drawing.Color.White;
            this.tb_IBAN_ES_DC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_IBAN_ES_DC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IBAN_ES_DC.Location = new System.Drawing.Point(3, 14);
            this.tb_IBAN_ES_DC.MaxLength = 2;
            this.tb_IBAN_ES_DC.Name = "tb_IBAN_ES_DC";
            this.tb_IBAN_ES_DC.Size = new System.Drawing.Size(29, 20);
            this.tb_IBAN_ES_DC.TabIndex = 0;
            this.tb_IBAN_ES_DC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_IBAN_ES_DC.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_IBAN_ES_DC.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // gb_IBAN_ES_Oficina
            // 
            this.gb_IBAN_ES_Oficina.Controls.Add(this.tb_IBAN_ES_Oficina);
            this.gb_IBAN_ES_Oficina.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_IBAN_ES_Oficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_IBAN_ES_Oficina.Location = new System.Drawing.Point(100, 0);
            this.gb_IBAN_ES_Oficina.Name = "gb_IBAN_ES_Oficina";
            this.gb_IBAN_ES_Oficina.Size = new System.Drawing.Size(50, 38);
            this.gb_IBAN_ES_Oficina.TabIndex = 2;
            this.gb_IBAN_ES_Oficina.TabStop = false;
            this.gb_IBAN_ES_Oficina.Text = "Oficina";
            // 
            // tb_IBAN_ES_Oficina
            // 
            this.tb_IBAN_ES_Oficina.BackColor = System.Drawing.Color.White;
            this.tb_IBAN_ES_Oficina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_IBAN_ES_Oficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IBAN_ES_Oficina.Location = new System.Drawing.Point(3, 14);
            this.tb_IBAN_ES_Oficina.MaxLength = 4;
            this.tb_IBAN_ES_Oficina.Name = "tb_IBAN_ES_Oficina";
            this.tb_IBAN_ES_Oficina.Size = new System.Drawing.Size(44, 20);
            this.tb_IBAN_ES_Oficina.TabIndex = 0;
            this.tb_IBAN_ES_Oficina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_IBAN_ES_Oficina.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_IBAN_ES_Oficina.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // gb_IBAN_ES_Entidad
            // 
            this.gb_IBAN_ES_Entidad.Controls.Add(this.tb_IBAN_ES_Entidad);
            this.gb_IBAN_ES_Entidad.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_IBAN_ES_Entidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_IBAN_ES_Entidad.Location = new System.Drawing.Point(50, 0);
            this.gb_IBAN_ES_Entidad.Name = "gb_IBAN_ES_Entidad";
            this.gb_IBAN_ES_Entidad.Size = new System.Drawing.Size(50, 38);
            this.gb_IBAN_ES_Entidad.TabIndex = 1;
            this.gb_IBAN_ES_Entidad.TabStop = false;
            this.gb_IBAN_ES_Entidad.Text = "Entidad";
            // 
            // tb_IBAN_ES_Entidad
            // 
            this.tb_IBAN_ES_Entidad.BackColor = System.Drawing.Color.White;
            this.tb_IBAN_ES_Entidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_IBAN_ES_Entidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IBAN_ES_Entidad.Location = new System.Drawing.Point(3, 14);
            this.tb_IBAN_ES_Entidad.MaxLength = 4;
            this.tb_IBAN_ES_Entidad.Name = "tb_IBAN_ES_Entidad";
            this.tb_IBAN_ES_Entidad.Size = new System.Drawing.Size(44, 20);
            this.tb_IBAN_ES_Entidad.TabIndex = 0;
            this.tb_IBAN_ES_Entidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_IBAN_ES_Entidad.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_IBAN_ES_Entidad.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // gb_IBAN_ES_IBAN
            // 
            this.gb_IBAN_ES_IBAN.Controls.Add(this.tb_IBAN_ES_IBAN);
            this.gb_IBAN_ES_IBAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_IBAN_ES_IBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_IBAN_ES_IBAN.Location = new System.Drawing.Point(0, 0);
            this.gb_IBAN_ES_IBAN.Name = "gb_IBAN_ES_IBAN";
            this.gb_IBAN_ES_IBAN.Size = new System.Drawing.Size(50, 38);
            this.gb_IBAN_ES_IBAN.TabIndex = 0;
            this.gb_IBAN_ES_IBAN.TabStop = false;
            this.gb_IBAN_ES_IBAN.Text = "IBAN";
            // 
            // tb_IBAN_ES_IBAN
            // 
            this.tb_IBAN_ES_IBAN.BackColor = System.Drawing.Color.White;
            this.tb_IBAN_ES_IBAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_IBAN_ES_IBAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_IBAN_ES_IBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IBAN_ES_IBAN.Location = new System.Drawing.Point(3, 14);
            this.tb_IBAN_ES_IBAN.MaxLength = 4;
            this.tb_IBAN_ES_IBAN.Name = "tb_IBAN_ES_IBAN";
            this.tb_IBAN_ES_IBAN.Size = new System.Drawing.Size(44, 20);
            this.tb_IBAN_ES_IBAN.TabIndex = 0;
            this.tb_IBAN_ES_IBAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_IBAN_ES_IBAN.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_IBAN_ES_IBAN.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // p_tipo_cuenta
            // 
            this.p_tipo_cuenta.Controls.Add(this.cb_cobro);
            this.p_tipo_cuenta.Controls.Add(this.cb_pago);
            this.p_tipo_cuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_tipo_cuenta.Location = new System.Drawing.Point(145, 88);
            this.p_tipo_cuenta.Margin = new System.Windows.Forms.Padding(0);
            this.p_tipo_cuenta.Name = "p_tipo_cuenta";
            this.p_tipo_cuenta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.p_tipo_cuenta.Size = new System.Drawing.Size(263, 20);
            this.p_tipo_cuenta.TabIndex = 7;
            // 
            // cb_cobro
            // 
            this.cb_cobro.Dock = System.Windows.Forms.DockStyle.Left;
            this.cb_cobro.Location = new System.Drawing.Point(110, 0);
            this.cb_cobro.Name = "cb_cobro";
            this.cb_cobro.Size = new System.Drawing.Size(100, 20);
            this.cb_cobro.TabIndex = 1;
            this.cb_cobro.Text = "Cobrar";
            this.toolTip1.SetToolTip(this.cb_cobro, "Cobro al contacto de esta cuenta");
            this.cb_cobro.UseVisualStyleBackColor = true;
            // 
            // cb_pago
            // 
            this.cb_pago.Dock = System.Windows.Forms.DockStyle.Left;
            this.cb_pago.Location = new System.Drawing.Point(10, 0);
            this.cb_pago.Name = "cb_pago";
            this.cb_pago.Size = new System.Drawing.Size(100, 20);
            this.cb_pago.TabIndex = 0;
            this.cb_pago.Text = "Pagar";
            this.toolTip1.SetToolTip(this.cb_pago, "Pago al contacto ingresando en esta cuenta");
            this.cb_pago.UseVisualStyleBackColor = true;
            // 
            // FormCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 242);
            this.Controls.Add(this.p_grid);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.p_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.FormCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.p_grid.ResumeLayout(false);
            this.p_bottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.p_cuenta.ResumeLayout(false);
            this.p_cuenta.PerformLayout();
            this.p_IBAN_ES.ResumeLayout(false);
            this.gb_IBAN_ES_NoCuenta.ResumeLayout(false);
            this.gb_IBAN_ES_NoCuenta.PerformLayout();
            this.gb_IBAN_ES_DC.ResumeLayout(false);
            this.gb_IBAN_ES_DC.PerformLayout();
            this.gb_IBAN_ES_Oficina.ResumeLayout(false);
            this.gb_IBAN_ES_Oficina.PerformLayout();
            this.gb_IBAN_ES_Entidad.ResumeLayout(false);
            this.gb_IBAN_ES_Entidad.PerformLayout();
            this.gb_IBAN_ES_IBAN.ResumeLayout(false);
            this.gb_IBAN_ES_IBAN.PerformLayout();
            this.p_tipo_cuenta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Panel p_grid;
        private System.Windows.Forms.Panel p_IBAN_ES;
        private System.Windows.Forms.GroupBox gb_IBAN_ES_NoCuenta;
        private System.Windows.Forms.TextBox tb_IBAN_ES_NoCuenta;
        private System.Windows.Forms.GroupBox gb_IBAN_ES_DC;
        private System.Windows.Forms.TextBox tb_IBAN_ES_DC;
        private System.Windows.Forms.GroupBox gb_IBAN_ES_Oficina;
        private System.Windows.Forms.TextBox tb_IBAN_ES_Oficina;
        private System.Windows.Forms.GroupBox gb_IBAN_ES_Entidad;
        private System.Windows.Forms.TextBox tb_IBAN_ES_Entidad;
        private System.Windows.Forms.GroupBox gb_IBAN_ES_IBAN;
        private System.Windows.Forms.TextBox tb_IBAN_ES_IBAN;
        private System.Windows.Forms.Panel p_bottom;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_nuevo;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Button b_editar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_banco;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_cuenta;
        private System.Windows.Forms.Panel p_cuenta;
        private System.Windows.Forms.Panel p_tipo_cuenta;
        private System.Windows.Forms.CheckBox cb_cobro;
        private System.Windows.Forms.CheckBox cb_pago;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tb_swift;
        private System.Windows.Forms.Label label1;
    }
}