namespace MAC
{
    partial class FormProveedorDeArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedorDeArticulo));
            this.label7 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.p_bottom = new System.Windows.Forms.Panel();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_nuevo = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_editar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_contacto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_f_1 = new System.Windows.Forms.TextBox();
            this.p_grid = new System.Windows.Forms.Panel();
            this.t_filtro_1 = new System.Windows.Forms.TableLayoutPanel();
            this.b_f_search = new System.Windows.Forms.Button();
            this.p_cb_filtro = new System.Windows.Forms.Panel();
            this.tb_observaciones = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_precioMedio = new System.Windows.Forms.TextBox();
            this.b_contacto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.p_bottom.SuspendLayout();
            this.p_grid.SuspendLayout();
            this.t_filtro_1.SuspendLayout();
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
            this.label7.Location = new System.Drawing.Point(3, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 14);
            this.label7.TabIndex = 5;
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
            this.grid.Location = new System.Drawing.Point(0, 20);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(814, 88);
            this.grid.TabIndex = 4;
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
            this.grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Precio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // p_bottom
            // 
            this.p_bottom.Controls.Add(this.b_borrar);
            this.p_bottom.Controls.Add(this.b_nuevo);
            this.p_bottom.Controls.Add(this.b_cancelar);
            this.p_bottom.Controls.Add(this.b_editar);
            this.p_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_bottom.Location = new System.Drawing.Point(0, 238);
            this.p_bottom.Name = "p_bottom";
            this.p_bottom.Size = new System.Drawing.Size(814, 24);
            this.p_bottom.TabIndex = 8;
            // 
            // b_borrar
            // 
            this.b_borrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.b_borrar.Image = global::MAC.Properties.Resources.delete_square16_h;
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
            this.b_cancelar.Location = new System.Drawing.Point(664, 0);
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
            this.b_editar.Location = new System.Drawing.Point(739, 0);
            this.b_editar.Name = "b_editar";
            this.b_editar.Size = new System.Drawing.Size(75, 24);
            this.b_editar.TabIndex = 0;
            this.b_editar.Text = "Editar";
            this.b_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.b_editar.UseVisualStyleBackColor = true;
            this.b_editar.Click += new System.EventHandler(this.b_editar_Click);
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
            this.label5.Text = "Contacto:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_contacto
            // 
            this.tb_contacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_contacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_contacto.Location = new System.Drawing.Point(100, 0);
            this.tb_contacto.Margin = new System.Windows.Forms.Padding(0);
            this.tb_contacto.Name = "tb_contacto";
            this.tb_contacto.ReadOnly = true;
            this.tb_contacto.Size = new System.Drawing.Size(694, 20);
            this.tb_contacto.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(497, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtro:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_f_1
            // 
            this.tb_f_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_f_1.Location = new System.Drawing.Point(594, 0);
            this.tb_f_1.Margin = new System.Windows.Forms.Padding(0);
            this.tb_f_1.Name = "tb_f_1";
            this.tb_f_1.Size = new System.Drawing.Size(200, 20);
            this.tb_f_1.TabIndex = 2;
            // 
            // p_grid
            // 
            this.p_grid.Controls.Add(this.grid);
            this.p_grid.Controls.Add(this.t_filtro_1);
            this.p_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_grid.Location = new System.Drawing.Point(0, 0);
            this.p_grid.Name = "p_grid";
            this.p_grid.Size = new System.Drawing.Size(814, 108);
            this.p_grid.TabIndex = 9;
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
            this.t_filtro_1.Size = new System.Drawing.Size(814, 20);
            this.t_filtro_1.TabIndex = 2;
            this.t_filtro_1.Visible = false;
            // 
            // b_f_search
            // 
            this.b_f_search.BackgroundImage = global::MAC.Properties.Resources.search16_h;
            this.b_f_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_f_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_f_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_f_search.Location = new System.Drawing.Point(794, 0);
            this.b_f_search.Margin = new System.Windows.Forms.Padding(0);
            this.b_f_search.Name = "b_f_search";
            this.b_f_search.Size = new System.Drawing.Size(20, 20);
            this.b_f_search.TabIndex = 0;
            this.b_f_search.UseVisualStyleBackColor = true;
            // 
            // p_cb_filtro
            // 
            this.p_cb_filtro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_cb_filtro.Location = new System.Drawing.Point(0, 0);
            this.p_cb_filtro.Margin = new System.Windows.Forms.Padding(0);
            this.p_cb_filtro.Name = "p_cb_filtro";
            this.p_cb_filtro.Size = new System.Drawing.Size(494, 20);
            this.p_cb_filtro.TabIndex = 4;
            // 
            // tb_observaciones
            // 
            this.tb_observaciones.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_observaciones, 2);
            this.tb_observaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_observaciones.Location = new System.Drawing.Point(100, 40);
            this.tb_observaciones.Margin = new System.Windows.Forms.Padding(0);
            this.tb_observaciones.Multiline = true;
            this.tb_observaciones.Name = "tb_observaciones";
            this.tableLayoutPanel1.SetRowSpan(this.tb_observaciones, 2);
            this.tb_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_observaciones.Size = new System.Drawing.Size(714, 50);
            this.tb_observaciones.TabIndex = 11;
            this.tb_observaciones.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_observaciones.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_precio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_observaciones, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_contacto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_precioMedio, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.b_contacto, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 130);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tb_precio
            // 
            this.tb_precio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_precio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_precio.BackColor = System.Drawing.Color.White;
            this.tb_precio.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_precio.Location = new System.Drawing.Point(100, 20);
            this.tb_precio.Margin = new System.Windows.Forms.Padding(0);
            this.tb_precio.MaxLength = 10;
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(100, 20);
            this.tb_precio.TabIndex = 7;
            this.tb_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_precio.Leave += new System.EventHandler(this.tb_X_Leave);
            this.tb_precio.Enter += new System.EventHandler(this.tb_X_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio medio:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_precioMedio
            // 
            this.tb_precioMedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_precioMedio.Location = new System.Drawing.Point(100, 100);
            this.tb_precioMedio.Margin = new System.Windows.Forms.Padding(0);
            this.tb_precioMedio.Name = "tb_precioMedio";
            this.tb_precioMedio.ReadOnly = true;
            this.tb_precioMedio.Size = new System.Drawing.Size(100, 20);
            this.tb_precioMedio.TabIndex = 27;
            // 
            // b_contacto
            // 
            this.b_contacto.BackgroundImage = global::MAC.Properties.Resources.search16_h;
            this.b_contacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_contacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_contacto.Location = new System.Drawing.Point(794, 0);
            this.b_contacto.Margin = new System.Windows.Forms.Padding(0);
            this.b_contacto.Name = "b_contacto";
            this.b_contacto.Size = new System.Drawing.Size(20, 20);
            this.b_contacto.TabIndex = 28;
            this.b_contacto.UseVisualStyleBackColor = true;
            this.b_contacto.Click += new System.EventHandler(this.b_contacto_Click);
            // 
            // FormProveedorDeArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 262);
            this.Controls.Add(this.p_grid);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.p_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProveedorDeArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor de artículo";
            this.Load += new System.EventHandler(this.FormProveedorDeArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.p_bottom.ResumeLayout(false);
            this.p_grid.ResumeLayout(false);
            this.t_filtro_1.ResumeLayout(false);
            this.t_filtro_1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel p_bottom;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_nuevo;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Button b_editar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_contacto;
        private System.Windows.Forms.Button b_f_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_f_1;
        private System.Windows.Forms.Panel p_grid;
        private System.Windows.Forms.TableLayoutPanel t_filtro_1;
        private System.Windows.Forms.Panel p_cb_filtro;
        private System.Windows.Forms.TextBox tb_observaciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_precioMedio;
        private System.Windows.Forms.Button b_contacto;
    }
}