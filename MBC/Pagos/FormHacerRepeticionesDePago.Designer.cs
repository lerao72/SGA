namespace MBC.Pagos
{
    partial class FormHacerRepeticionesDePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHacerRepeticionesDePago));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_cada = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_qty = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.l_cada = new System.Windows.Forms.Label();
            this.b_cada = new System.Windows.Forms.Button();
            this.b_hacer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qty)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nud_cada, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nud_qty, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.l_cada, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.b_cada, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repetir este pago cada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_cada
            // 
            this.nud_cada.Location = new System.Drawing.Point(134, 10);
            this.nud_cada.Margin = new System.Windows.Forms.Padding(0);
            this.nud_cada.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nud_cada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_cada.Name = "nud_cada";
            this.nud_cada.Size = new System.Drawing.Size(50, 20);
            this.nud_cada.TabIndex = 1;
            this.nud_cada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_cada.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Añadir";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_qty
            // 
            this.nud_qty.Location = new System.Drawing.Point(134, 40);
            this.nud_qty.Margin = new System.Windows.Forms.Padding(0);
            this.nud_qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_qty.Name = "nud_qty";
            this.nud_qty.Size = new System.Drawing.Size(50, 20);
            this.nud_qty.TabIndex = 4;
            this.nud_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(187, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "repeticiones";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // l_cada
            // 
            this.l_cada.AutoSize = true;
            this.l_cada.BackColor = System.Drawing.Color.White;
            this.l_cada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_cada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_cada.Location = new System.Drawing.Point(187, 10);
            this.l_cada.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.l_cada.Name = "l_cada";
            this.l_cada.Size = new System.Drawing.Size(77, 20);
            this.l_cada.TabIndex = 6;
            this.l_cada.Text = "Días";
            this.l_cada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // b_cada
            // 
            this.b_cada.BackgroundImage = global::MBC.Properties.Resources.down_square16_h;
            this.b_cada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_cada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cada.Location = new System.Drawing.Point(264, 10);
            this.b_cada.Margin = new System.Windows.Forms.Padding(0);
            this.b_cada.Name = "b_cada";
            this.b_cada.Size = new System.Drawing.Size(20, 20);
            this.b_cada.TabIndex = 7;
            this.b_cada.UseVisualStyleBackColor = true;
            this.b_cada.Click += new System.EventHandler(this.b_cada_Click);
            // 
            // b_hacer
            // 
            this.b_hacer.Image = global::MBC.Properties.Resources.post_square16_h_g;
            this.b_hacer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_hacer.Location = new System.Drawing.Point(110, 82);
            this.b_hacer.Name = "b_hacer";
            this.b_hacer.Size = new System.Drawing.Size(75, 30);
            this.b_hacer.TabIndex = 1;
            this.b_hacer.Text = "Hacer";
            this.b_hacer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_hacer.UseVisualStyleBackColor = true;
            this.b_hacer.Click += new System.EventHandler(this.b_hacer_Click);
            // 
            // FormHacerRepeticionesDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(294, 122);
            this.Controls.Add(this.b_hacer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHacerRepeticionesDePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repeticiones";
            this.Load += new System.EventHandler(this.FormHacerRepeticionesDePago_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_cada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_cada;
        private System.Windows.Forms.Button b_hacer;
        private System.Windows.Forms.Button b_cada;
    }
}