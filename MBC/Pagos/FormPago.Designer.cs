namespace MBC.Pagos
{
    partial class FormPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPago));
            this.p_bottom = new System.Windows.Forms.Panel();
            this.tlp_serie = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_contacto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_fechaReal = new System.Windows.Forms.DateTimePicker();
            this.cb_pagado = new System.Windows.Forms.CheckBox();
            this.dtp_fechaPrevista = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_descripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_importe = new System.Windows.Forms.TextBox();
            this.cb_autoPagable = new System.Windows.Forms.CheckBox();
            this.cb_persistente = new System.Windows.Forms.CheckBox();
            this.b_contacto = new System.Windows.Forms.Button();
            this.b_serie_first = new System.Windows.Forms.Button();
            this.b_serie_prev = new System.Windows.Forms.Button();
            this.b_serie_next = new System.Windows.Forms.Button();
            this.b_serie_last = new System.Windows.Forms.Button();
            this.b_repeticiones = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_guardar = new System.Windows.Forms.Button();
            this.p_bottom.SuspendLayout();
            this.tlp_serie.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_bottom
            // 
            this.p_bottom.Controls.Add(this.tlp_serie);
            this.p_bottom.Controls.Add(this.b_repeticiones);
            this.p_bottom.Controls.Add(this.b_borrar);
            this.p_bottom.Controls.Add(this.b_guardar);
            this.p_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_bottom.Location = new System.Drawing.Point(0, 167);
            this.p_bottom.Name = "p_bottom";
            this.p_bottom.Size = new System.Drawing.Size(494, 30);
            this.p_bottom.TabIndex = 0;
            // 
            // tlp_serie
            // 
            this.tlp_serie.ColumnCount = 4;
            this.tlp_serie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_serie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_serie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_serie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_serie.Controls.Add(this.b_serie_first, 0, 0);
            this.tlp_serie.Controls.Add(this.b_serie_prev, 1, 0);
            this.tlp_serie.Controls.Add(this.b_serie_next, 2, 0);
            this.tlp_serie.Controls.Add(this.b_serie_last, 3, 0);
            this.tlp_serie.Location = new System.Drawing.Point(120, 3);
            this.tlp_serie.Name = "tlp_serie";
            this.tlp_serie.RowCount = 1;
            this.tlp_serie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_serie.Size = new System.Drawing.Size(96, 24);
            this.tlp_serie.TabIndex = 3;
            this.tlp_serie.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_contacto, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_tipo, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_descripcion, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_importe, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.b_contacto, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_autoPagable, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cb_persistente, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 167);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contacto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_contacto
            // 
            this.tb_contacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_contacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_contacto.Location = new System.Drawing.Point(110, 10);
            this.tb_contacto.Margin = new System.Windows.Forms.Padding(0);
            this.tb_contacto.Name = "tb_contacto";
            this.tb_contacto.ReadOnly = true;
            this.tb_contacto.Size = new System.Drawing.Size(354, 20);
            this.tb_contacto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha prevista:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.dtp_fechaReal);
            this.panel1.Controls.Add(this.cb_pagado);
            this.panel1.Controls.Add(this.dtp_fechaPrevista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(110, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 20);
            this.panel1.TabIndex = 4;
            // 
            // dtp_fechaReal
            // 
            this.dtp_fechaReal.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtp_fechaReal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaReal.Location = new System.Drawing.Point(173, 0);
            this.dtp_fechaReal.Name = "dtp_fechaReal";
            this.dtp_fechaReal.Size = new System.Drawing.Size(100, 20);
            this.dtp_fechaReal.TabIndex = 5;
            this.dtp_fechaReal.Visible = false;
            // 
            // cb_pagado
            // 
            this.cb_pagado.AutoSize = true;
            this.cb_pagado.Dock = System.Windows.Forms.DockStyle.Left;
            this.cb_pagado.Location = new System.Drawing.Point(100, 0);
            this.cb_pagado.Margin = new System.Windows.Forms.Padding(0);
            this.cb_pagado.Name = "cb_pagado";
            this.cb_pagado.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cb_pagado.Size = new System.Drawing.Size(73, 20);
            this.cb_pagado.TabIndex = 4;
            this.cb_pagado.Text = "Pagado";
            this.cb_pagado.UseVisualStyleBackColor = true;
            this.cb_pagado.Leave += new System.EventHandler(this.tb_X_Leave);
            this.cb_pagado.Enter += new System.EventHandler(this.tb_X_Enter);
            this.cb_pagado.CheckedChanged += new System.EventHandler(this.cb_pagado_CheckedChanged);
            // 
            // dtp_fechaPrevista
            // 
            this.dtp_fechaPrevista.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtp_fechaPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaPrevista.Location = new System.Drawing.Point(0, 0);
            this.dtp_fechaPrevista.Name = "dtp_fechaPrevista";
            this.dtp_fechaPrevista.Size = new System.Drawing.Size(100, 20);
            this.dtp_fechaPrevista.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_tipo
            // 
            this.tb_tipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_tipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_tipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_tipo, 2);
            this.tb_tipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_tipo.Location = new System.Drawing.Point(110, 50);
            this.tb_tipo.Margin = new System.Windows.Forms.Padding(0);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.Size = new System.Drawing.Size(374, 20);
            this.tb_tipo.TabIndex = 6;
            this.tb_tipo.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_tipo.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripción:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_descripcion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tb_descripcion, 2);
            this.tb_descripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_descripcion.Location = new System.Drawing.Point(110, 70);
            this.tb_descripcion.Margin = new System.Windows.Forms.Padding(0);
            this.tb_descripcion.MaxLength = 50;
            this.tb_descripcion.Name = "tb_descripcion";
            this.tb_descripcion.Size = new System.Drawing.Size(374, 20);
            this.tb_descripcion.TabIndex = 8;
            this.tb_descripcion.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_descripcion.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Importe:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_importe
            // 
            this.tb_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_importe.Location = new System.Drawing.Point(110, 90);
            this.tb_importe.Margin = new System.Windows.Forms.Padding(0);
            this.tb_importe.Name = "tb_importe";
            this.tb_importe.Size = new System.Drawing.Size(100, 20);
            this.tb_importe.TabIndex = 10;
            this.tb_importe.Text = "0,00 €";
            this.tb_importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_importe.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_importe.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // cb_autoPagable
            // 
            this.cb_autoPagable.AutoSize = true;
            this.cb_autoPagable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_autoPagable.Location = new System.Drawing.Point(10, 110);
            this.cb_autoPagable.Margin = new System.Windows.Forms.Padding(0);
            this.cb_autoPagable.Name = "cb_autoPagable";
            this.cb_autoPagable.Size = new System.Drawing.Size(100, 24);
            this.cb_autoPagable.TabIndex = 12;
            this.cb_autoPagable.Text = "Auto-pagable";
            this.cb_autoPagable.UseVisualStyleBackColor = true;
            this.cb_autoPagable.Leave += new System.EventHandler(this.tb_X_Leave);
            this.cb_autoPagable.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // cb_persistente
            // 
            this.cb_persistente.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.cb_persistente, 2);
            this.cb_persistente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_persistente.Location = new System.Drawing.Point(110, 110);
            this.cb_persistente.Margin = new System.Windows.Forms.Padding(0);
            this.cb_persistente.Name = "cb_persistente";
            this.cb_persistente.Size = new System.Drawing.Size(374, 24);
            this.cb_persistente.TabIndex = 13;
            this.cb_persistente.Text = "Persistente (este pago se repite y siempre deber haber alguno dispnible)";
            this.cb_persistente.UseVisualStyleBackColor = true;
            this.cb_persistente.Leave += new System.EventHandler(this.tb_X_Leave);
            this.cb_persistente.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // b_contacto
            // 
            this.b_contacto.BackgroundImage = global::MBC.Properties.Resources.search16_h;
            this.b_contacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_contacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_contacto.Location = new System.Drawing.Point(464, 10);
            this.b_contacto.Margin = new System.Windows.Forms.Padding(0);
            this.b_contacto.Name = "b_contacto";
            this.b_contacto.Size = new System.Drawing.Size(20, 20);
            this.b_contacto.TabIndex = 11;
            this.b_contacto.UseVisualStyleBackColor = true;
            this.b_contacto.Visible = false;
            this.b_contacto.Click += new System.EventHandler(this.b_contacto_Click);
            // 
            // b_serie_first
            // 
            this.b_serie_first.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_serie_first.Enabled = false;
            this.b_serie_first.Image = global::MBC.Properties.Resources.first_square16_h;
            this.b_serie_first.Location = new System.Drawing.Point(0, 0);
            this.b_serie_first.Margin = new System.Windows.Forms.Padding(0);
            this.b_serie_first.Name = "b_serie_first";
            this.b_serie_first.Size = new System.Drawing.Size(24, 24);
            this.b_serie_first.TabIndex = 0;
            this.b_serie_first.UseVisualStyleBackColor = true;
            this.b_serie_first.Click += new System.EventHandler(this.b_serie_first_Click);
            // 
            // b_serie_prev
            // 
            this.b_serie_prev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_serie_prev.Enabled = false;
            this.b_serie_prev.Image = global::MBC.Properties.Resources.previous_square16_h;
            this.b_serie_prev.Location = new System.Drawing.Point(24, 0);
            this.b_serie_prev.Margin = new System.Windows.Forms.Padding(0);
            this.b_serie_prev.Name = "b_serie_prev";
            this.b_serie_prev.Size = new System.Drawing.Size(24, 24);
            this.b_serie_prev.TabIndex = 1;
            this.b_serie_prev.UseVisualStyleBackColor = true;
            this.b_serie_prev.Click += new System.EventHandler(this.b_serie_prev_Click);
            // 
            // b_serie_next
            // 
            this.b_serie_next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_serie_next.Enabled = false;
            this.b_serie_next.Image = global::MBC.Properties.Resources.next_square16_h;
            this.b_serie_next.Location = new System.Drawing.Point(48, 0);
            this.b_serie_next.Margin = new System.Windows.Forms.Padding(0);
            this.b_serie_next.Name = "b_serie_next";
            this.b_serie_next.Size = new System.Drawing.Size(24, 24);
            this.b_serie_next.TabIndex = 2;
            this.b_serie_next.UseVisualStyleBackColor = true;
            this.b_serie_next.Click += new System.EventHandler(this.b_serie_next_Click);
            // 
            // b_serie_last
            // 
            this.b_serie_last.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_serie_last.Enabled = false;
            this.b_serie_last.Image = global::MBC.Properties.Resources.last_square16_h;
            this.b_serie_last.Location = new System.Drawing.Point(72, 0);
            this.b_serie_last.Margin = new System.Windows.Forms.Padding(0);
            this.b_serie_last.Name = "b_serie_last";
            this.b_serie_last.Size = new System.Drawing.Size(24, 24);
            this.b_serie_last.TabIndex = 3;
            this.b_serie_last.UseVisualStyleBackColor = true;
            this.b_serie_last.Click += new System.EventHandler(this.b_serie_last_Click);
            // 
            // b_repeticiones
            // 
            this.b_repeticiones.Dock = System.Windows.Forms.DockStyle.Left;
            this.b_repeticiones.Image = global::MBC.Properties.Resources.redo_square16_h;
            this.b_repeticiones.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_repeticiones.Location = new System.Drawing.Point(0, 0);
            this.b_repeticiones.Name = "b_repeticiones";
            this.b_repeticiones.Size = new System.Drawing.Size(100, 30);
            this.b_repeticiones.TabIndex = 2;
            this.b_repeticiones.Text = "Repeticiones";
            this.b_repeticiones.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_repeticiones.UseVisualStyleBackColor = true;
            this.b_repeticiones.Visible = false;
            this.b_repeticiones.Click += new System.EventHandler(this.b_repeticiones_Click);
            // 
            // b_borrar
            // 
            this.b_borrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.b_borrar.Image = global::MBC.Properties.Resources.delete_square16_h;
            this.b_borrar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_borrar.Location = new System.Drawing.Point(344, 0);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(75, 30);
            this.b_borrar.TabIndex = 1;
            this.b_borrar.Text = "Borrar";
            this.b_borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Visible = false;
            this.b_borrar.Click += new System.EventHandler(this.b_borrar_Click);
            // 
            // b_guardar
            // 
            this.b_guardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.b_guardar.Image = global::MBC.Properties.Resources.save16_h;
            this.b_guardar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_guardar.Location = new System.Drawing.Point(419, 0);
            this.b_guardar.Name = "b_guardar";
            this.b_guardar.Size = new System.Drawing.Size(75, 30);
            this.b_guardar.TabIndex = 0;
            this.b_guardar.Text = "Guardar";
            this.b_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_guardar.UseVisualStyleBackColor = true;
            this.b_guardar.Click += new System.EventHandler(this.b_guardar_Click);
            // 
            // FormPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 197);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.p_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.FormPago_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPago_FormClosed);
            this.p_bottom.ResumeLayout(false);
            this.tlp_serie.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_bottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_contacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fechaPrevista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_descripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_importe;
        private System.Windows.Forms.Button b_contacto;
        private System.Windows.Forms.CheckBox cb_pagado;
        private System.Windows.Forms.CheckBox cb_autoPagable;
        private System.Windows.Forms.CheckBox cb_persistente;
        private System.Windows.Forms.Button b_repeticiones;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_guardar;
        private System.Windows.Forms.DateTimePicker dtp_fechaReal;
        private System.Windows.Forms.TableLayoutPanel tlp_serie;
        private System.Windows.Forms.Button b_serie_first;
        private System.Windows.Forms.Button b_serie_prev;
        private System.Windows.Forms.Button b_serie_next;
        private System.Windows.Forms.Button b_serie_last;
    }
}