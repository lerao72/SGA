namespace MVC.Recordatorios
{
    partial class FormRecordatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecordatorio));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.l_detalleVinculado = new System.Windows.Forms.Label();
            this.l_tipo_vinculado = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.p_hora_full = new System.Windows.Forms.Panel();
            this.p_hora = new System.Windows.Forms.Panel();
            this.nud_minutos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_hora = new System.Windows.Forms.NumericUpDown();
            this.cb_todoElDia = new System.Windows.Forms.CheckBox();
            this.tb_tarea = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_posponer = new System.Windows.Forms.Button();
            this.b_editar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.p_hora_full.SuspendLayout();
            this.p_hora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hora)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtp_fecha, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.p_hora_full, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_tarea, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 142);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hora:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripción:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.l_detalleVinculado);
            this.panel2.Controls.Add(this.l_tipo_vinculado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(100, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 14);
            this.panel2.TabIndex = 10;
            // 
            // l_detalleVinculado
            // 
            this.l_detalleVinculado.BackColor = System.Drawing.Color.Yellow;
            this.l_detalleVinculado.Cursor = System.Windows.Forms.Cursors.Default;
            this.l_detalleVinculado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_detalleVinculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_detalleVinculado.ForeColor = System.Drawing.Color.Black;
            this.l_detalleVinculado.Location = new System.Drawing.Point(100, 0);
            this.l_detalleVinculado.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.l_detalleVinculado.Name = "l_detalleVinculado";
            this.l_detalleVinculado.Size = new System.Drawing.Size(284, 14);
            this.l_detalleVinculado.TabIndex = 11;
            this.l_detalleVinculado.Text = "---";
            this.l_detalleVinculado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // l_tipo_vinculado
            // 
            this.l_tipo_vinculado.BackColor = System.Drawing.Color.Yellow;
            this.l_tipo_vinculado.Dock = System.Windows.Forms.DockStyle.Left;
            this.l_tipo_vinculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_tipo_vinculado.ForeColor = System.Drawing.Color.Black;
            this.l_tipo_vinculado.Location = new System.Drawing.Point(0, 0);
            this.l_tipo_vinculado.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.l_tipo_vinculado.Name = "l_tipo_vinculado";
            this.l_tipo_vinculado.Size = new System.Drawing.Size(100, 14);
            this.l_tipo_vinculado.TabIndex = 10;
            this.l_tipo_vinculado.Text = "Agenda";
            this.l_tipo_vinculado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(103, 33);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(100, 20);
            this.dtp_fecha.TabIndex = 11;
            // 
            // p_hora_full
            // 
            this.p_hora_full.Controls.Add(this.p_hora);
            this.p_hora_full.Controls.Add(this.cb_todoElDia);
            this.p_hora_full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_hora_full.Location = new System.Drawing.Point(100, 50);
            this.p_hora_full.Margin = new System.Windows.Forms.Padding(0);
            this.p_hora_full.Name = "p_hora_full";
            this.p_hora_full.Size = new System.Drawing.Size(384, 20);
            this.p_hora_full.TabIndex = 12;
            // 
            // p_hora
            // 
            this.p_hora.Controls.Add(this.nud_minutos);
            this.p_hora.Controls.Add(this.label4);
            this.p_hora.Controls.Add(this.nud_hora);
            this.p_hora.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_hora.Location = new System.Drawing.Point(100, 0);
            this.p_hora.Margin = new System.Windows.Forms.Padding(0);
            this.p_hora.Name = "p_hora";
            this.p_hora.Size = new System.Drawing.Size(95, 20);
            this.p_hora.TabIndex = 3;
            // 
            // nud_minutos
            // 
            this.nud_minutos.BackColor = System.Drawing.Color.White;
            this.nud_minutos.CausesValidation = false;
            this.nud_minutos.Dock = System.Windows.Forms.DockStyle.Left;
            this.nud_minutos.Location = new System.Drawing.Point(55, 0);
            this.nud_minutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_minutos.Name = "nud_minutos";
            this.nud_minutos.Size = new System.Drawing.Size(40, 20);
            this.nud_minutos.TabIndex = 2;
            this.nud_minutos.Leave += new System.EventHandler(this.tb_X_Leave);
            this.nud_minutos.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud_hora
            // 
            this.nud_hora.BackColor = System.Drawing.Color.White;
            this.nud_hora.CausesValidation = false;
            this.nud_hora.Dock = System.Windows.Forms.DockStyle.Left;
            this.nud_hora.Location = new System.Drawing.Point(0, 0);
            this.nud_hora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_hora.Name = "nud_hora";
            this.nud_hora.Size = new System.Drawing.Size(40, 20);
            this.nud_hora.TabIndex = 0;
            this.nud_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_hora.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud_hora.Leave += new System.EventHandler(this.tb_X_Leave);
            this.nud_hora.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // cb_todoElDia
            // 
            this.cb_todoElDia.Dock = System.Windows.Forms.DockStyle.Left;
            this.cb_todoElDia.Location = new System.Drawing.Point(0, 0);
            this.cb_todoElDia.Name = "cb_todoElDia";
            this.cb_todoElDia.Padding = new System.Windows.Forms.Padding(10, 2, 0, 0);
            this.cb_todoElDia.Size = new System.Drawing.Size(100, 20);
            this.cb_todoElDia.TabIndex = 4;
            this.cb_todoElDia.Text = "Todo el día";
            this.cb_todoElDia.UseVisualStyleBackColor = true;
            this.cb_todoElDia.Leave += new System.EventHandler(this.tb_X_Leave);
            this.cb_todoElDia.Enter += new System.EventHandler(this.tb_X_Enter);
            this.cb_todoElDia.CheckedChanged += new System.EventHandler(this.cb_todoElDia_CheckedChanged);
            // 
            // tb_tarea
            // 
            this.tb_tarea.BackColor = System.Drawing.Color.White;
            this.tb_tarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_tarea.Location = new System.Drawing.Point(103, 73);
            this.tb_tarea.Multiline = true;
            this.tb_tarea.Name = "tb_tarea";
            this.tableLayoutPanel1.SetRowSpan(this.tb_tarea, 2);
            this.tb_tarea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_tarea.Size = new System.Drawing.Size(378, 66);
            this.tb_tarea.TabIndex = 13;
            this.tb_tarea.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_tarea.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_borrar);
            this.panel1.Controls.Add(this.b_cancelar);
            this.panel1.Controls.Add(this.b_posponer);
            this.panel1.Controls.Add(this.b_editar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 30);
            this.panel1.TabIndex = 1;
            // 
            // b_borrar
            // 
            this.b_borrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_borrar.Image = global::MVC.Properties.Resources.delete_square16_h;
            this.b_borrar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_borrar.Location = new System.Drawing.Point(269, 0);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(75, 30);
            this.b_borrar.TabIndex = 3;
            this.b_borrar.Text = "Borrar";
            this.b_borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Click += new System.EventHandler(this.b_borrar_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.b_cancelar.Image = global::MVC.Properties.Resources.cancel_square16_h;
            this.b_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_cancelar.Location = new System.Drawing.Point(344, 0);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(75, 30);
            this.b_cancelar.TabIndex = 2;
            this.b_cancelar.Text = "Cancelar";
            this.b_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // b_posponer
            // 
            this.b_posponer.Location = new System.Drawing.Point(10, 0);
            this.b_posponer.Name = "b_posponer";
            this.b_posponer.Size = new System.Drawing.Size(75, 30);
            this.b_posponer.TabIndex = 1;
            this.b_posponer.Text = "Posponer";
            this.b_posponer.UseVisualStyleBackColor = true;
            this.b_posponer.Visible = false;
            this.b_posponer.Click += new System.EventHandler(this.b_posponer_Click);
            // 
            // b_editar
            // 
            this.b_editar.Dock = System.Windows.Forms.DockStyle.Right;
            this.b_editar.Image = global::MVC.Properties.Resources.edit_square16_h_c;
            this.b_editar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_editar.Location = new System.Drawing.Point(419, 0);
            this.b_editar.Name = "b_editar";
            this.b_editar.Size = new System.Drawing.Size(75, 30);
            this.b_editar.TabIndex = 0;
            this.b_editar.Text = "Editar";
            this.b_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_editar.UseVisualStyleBackColor = true;
            this.b_editar.Click += new System.EventHandler(this.b_editar_Click);
            // 
            // FormRecordatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 172);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRecordatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recordatorio";
            this.Load += new System.EventHandler(this.FormRecordatorio_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRecordatorio_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.p_hora_full.ResumeLayout(false);
            this.p_hora.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_minutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hora)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label l_detalleVinculado;
        private System.Windows.Forms.Label l_tipo_vinculado;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Panel p_hora_full;
        private System.Windows.Forms.NumericUpDown nud_hora;
        private System.Windows.Forms.NumericUpDown nud_minutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_tarea;
        private System.Windows.Forms.Button b_posponer;
        private System.Windows.Forms.Button b_editar;
        private System.Windows.Forms.Panel p_hora;
        private System.Windows.Forms.CheckBox cb_todoElDia;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Button b_borrar;
    }
}