namespace MCC
{
    partial class FormNotas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotas));
            this.label7 = new System.Windows.Forms.Label();
            this.b_editar = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.p_bottom = new System.Windows.Forms.Panel();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_nuevo = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_creacion = new System.Windows.Forms.TextBox();
            this.b_f_search = new System.Windows.Forms.Button();
            this.tb_f_1 = new System.Windows.Forms.TextBox();
            this.t_filtro_1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.p_grid = new System.Windows.Forms.Panel();
            this.tb_nota = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.p_bottom.SuspendLayout();
            this.t_filtro_1.SuspendLayout();
            this.p_grid.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nota:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b_editar
            // 
            this.b_editar.Dock = System.Windows.Forms.DockStyle.Right;
            this.b_editar.Image = global::MCC.Properties.Resources.edit_square16_h_c;
            this.b_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_editar.Location = new System.Drawing.Point(519, 0);
            this.b_editar.Name = "b_editar";
            this.b_editar.Size = new System.Drawing.Size(75, 24);
            this.b_editar.TabIndex = 0;
            this.b_editar.Text = "Editar";
            this.b_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_editar.UseVisualStyleBackColor = true;
            this.b_editar.Click += new System.EventHandler(this.b_editar_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(200, 452);
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
            this.p_bottom.Location = new System.Drawing.Point(200, 448);
            this.p_bottom.Name = "p_bottom";
            this.p_bottom.Size = new System.Drawing.Size(594, 24);
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
            this.b_cancelar.Location = new System.Drawing.Point(444, 0);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(75, 24);
            this.b_cancelar.TabIndex = 1;
            this.b_cancelar.Text = "Cancelar";
            this.b_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
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
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Creación:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_creacion
            // 
            this.tb_creacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_creacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_creacion.Location = new System.Drawing.Point(80, 0);
            this.tb_creacion.Margin = new System.Windows.Forms.Padding(0);
            this.tb_creacion.Name = "tb_creacion";
            this.tb_creacion.ReadOnly = true;
            this.tb_creacion.Size = new System.Drawing.Size(514, 20);
            this.tb_creacion.TabIndex = 26;
            // 
            // b_f_search
            // 
            this.b_f_search.BackgroundImage = global::MCC.Properties.Resources.search16_h;
            this.b_f_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_f_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_f_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_f_search.Location = new System.Drawing.Point(180, 0);
            this.b_f_search.Margin = new System.Windows.Forms.Padding(0);
            this.b_f_search.Name = "b_f_search";
            this.b_f_search.Size = new System.Drawing.Size(20, 20);
            this.b_f_search.TabIndex = 0;
            this.b_f_search.UseVisualStyleBackColor = true;
            // 
            // tb_f_1
            // 
            this.tb_f_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_f_1.Location = new System.Drawing.Point(60, 0);
            this.tb_f_1.Margin = new System.Windows.Forms.Padding(0);
            this.tb_f_1.Name = "tb_f_1";
            this.tb_f_1.Size = new System.Drawing.Size(120, 20);
            this.tb_f_1.TabIndex = 2;
            // 
            // t_filtro_1
            // 
            this.t_filtro_1.ColumnCount = 3;
            this.t_filtro_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.t_filtro_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.t_filtro_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.t_filtro_1.Controls.Add(this.b_f_search, 2, 0);
            this.t_filtro_1.Controls.Add(this.tb_f_1, 1, 0);
            this.t_filtro_1.Controls.Add(this.label1, 0, 0);
            this.t_filtro_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.t_filtro_1.Location = new System.Drawing.Point(0, 452);
            this.t_filtro_1.Name = "t_filtro_1";
            this.t_filtro_1.RowCount = 1;
            this.t_filtro_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.t_filtro_1.Size = new System.Drawing.Size(200, 20);
            this.t_filtro_1.TabIndex = 2;
            this.t_filtro_1.Visible = false;
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
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtro:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // p_grid
            // 
            this.p_grid.Controls.Add(this.grid);
            this.p_grid.Controls.Add(this.t_filtro_1);
            this.p_grid.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_grid.Location = new System.Drawing.Point(0, 0);
            this.p_grid.Name = "p_grid";
            this.p_grid.Size = new System.Drawing.Size(200, 472);
            this.p_grid.TabIndex = 9;
            // 
            // tb_nota
            // 
            this.tb_nota.BackColor = System.Drawing.Color.White;
            this.tb_nota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_nota.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nota.Location = new System.Drawing.Point(80, 30);
            this.tb_nota.Margin = new System.Windows.Forms.Padding(0);
            this.tb_nota.Multiline = true;
            this.tb_nota.Name = "tb_nota";
            this.tableLayoutPanel1.SetRowSpan(this.tb_nota, 2);
            this.tb_nota.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_nota.Size = new System.Drawing.Size(514, 408);
            this.tb_nota.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_nota, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_creacion, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(200, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(594, 448);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // FormNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 472);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.p_bottom);
            this.Controls.Add(this.p_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.FormNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.p_bottom.ResumeLayout(false);
            this.t_filtro_1.ResumeLayout(false);
            this.t_filtro_1.PerformLayout();
            this.p_grid.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button b_editar;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Panel p_bottom;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_nuevo;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_creacion;
        private System.Windows.Forms.Button b_f_search;
        private System.Windows.Forms.TextBox tb_f_1;
        private System.Windows.Forms.TableLayoutPanel t_filtro_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p_grid;
        private System.Windows.Forms.TextBox tb_nota;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}