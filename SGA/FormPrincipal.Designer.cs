namespace SGA
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.b_contactos = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.b_articulos = new System.Windows.Forms.Button();
            this.b_negocio = new System.Windows.Forms.Button();
            this.b_recordatorio = new System.Windows.Forms.Button();
            this.t_delay_activacion = new System.Windows.Forms.Timer(this.components);
            this.t_comprobacionesAlInicio = new System.Windows.Forms.Timer(this.components);
            this.t_agenda = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.b_contactos);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(80, 58);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // b_contactos
            // 
            this.b_contactos.Enabled = false;
            this.b_contactos.Image = global::SGA.Properties.Resources.user_edit16_h;
            this.b_contactos.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_contactos.Location = new System.Drawing.Point(0, 0);
            this.b_contactos.Margin = new System.Windows.Forms.Padding(0);
            this.b_contactos.Name = "b_contactos";
            this.b_contactos.Size = new System.Drawing.Size(75, 50);
            this.b_contactos.TabIndex = 0;
            this.b_contactos.Text = "Contactos";
            this.b_contactos.UseVisualStyleBackColor = true;
            this.b_contactos.Click += new System.EventHandler(this.b_contactos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_articulos, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_negocio, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_recordatorio, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 68);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // b_articulos
            // 
            this.b_articulos.Enabled = false;
            this.b_articulos.Image = global::SGA.Properties.Resources.paquetes;
            this.b_articulos.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_articulos.Location = new System.Drawing.Point(85, 0);
            this.b_articulos.Margin = new System.Windows.Forms.Padding(0);
            this.b_articulos.Name = "b_articulos";
            this.b_articulos.Size = new System.Drawing.Size(75, 50);
            this.b_articulos.TabIndex = 1;
            this.b_articulos.Text = "Artículos";
            this.b_articulos.UseVisualStyleBackColor = true;
            this.b_articulos.Click += new System.EventHandler(this.b_articulos_Click);
            // 
            // b_negocio
            // 
            this.b_negocio.Enabled = false;
            this.b_negocio.Image = global::SGA.Properties.Resources.table_16;
            this.b_negocio.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_negocio.Location = new System.Drawing.Point(170, 0);
            this.b_negocio.Margin = new System.Windows.Forms.Padding(0);
            this.b_negocio.Name = "b_negocio";
            this.b_negocio.Size = new System.Drawing.Size(75, 50);
            this.b_negocio.TabIndex = 2;
            this.b_negocio.Text = "Negocio";
            this.b_negocio.UseVisualStyleBackColor = true;
            this.b_negocio.Click += new System.EventHandler(this.b_negocio_Click);
            // 
            // b_recordatorio
            // 
            this.b_recordatorio.Enabled = false;
            this.b_recordatorio.Image = global::SGA.Properties.Resources.favorites16_h;
            this.b_recordatorio.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.b_recordatorio.Location = new System.Drawing.Point(255, 0);
            this.b_recordatorio.Margin = new System.Windows.Forms.Padding(0);
            this.b_recordatorio.Name = "b_recordatorio";
            this.b_recordatorio.Size = new System.Drawing.Size(75, 50);
            this.b_recordatorio.TabIndex = 3;
            this.b_recordatorio.Text = "Agenda";
            this.b_recordatorio.UseVisualStyleBackColor = true;
            this.b_recordatorio.Click += new System.EventHandler(this.b_recordatorio_Click);
            // 
            // t_delay_activacion
            // 
            this.t_delay_activacion.Interval = 1000;
            this.t_delay_activacion.Tick += new System.EventHandler(this.t_delay_activacion_Tick);
            // 
            // t_comprobacionesAlInicio
            // 
            this.t_comprobacionesAlInicio.Interval = 2000;
            this.t_comprobacionesAlInicio.Tick += new System.EventHandler(this.t_comprobacionesAlInicio_Tick);
            // 
            // t_agenda
            // 
            this.t_agenda.Enabled = true;
            this.t_agenda.Interval = 6000;
            this.t_agenda.Tick += new System.EventHandler(this.t_agenda_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 92);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button b_contactos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer t_delay_activacion;
        private System.Windows.Forms.Button b_articulos;
        private System.Windows.Forms.Timer t_comprobacionesAlInicio;
        private System.Windows.Forms.Button b_negocio;
        private System.Windows.Forms.Button b_recordatorio;
        private System.Windows.Forms.Timer t_agenda;
    }
}

