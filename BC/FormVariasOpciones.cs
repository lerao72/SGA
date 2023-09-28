using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BC
{
    public partial class FormVariasOpciones : Form
    {
        private Int32 _selectedValue = -1;
        private string _selectedText = "";
        private object _selectedObject = null;
        private Int32 _valorPoner = -1;
        private Int32 _alturaElementos = 30;

        private Int32 _numOpciones = 0;

        public FormVariasOpciones(string texto)
        {
            InitializeComponent();
            this.Text = texto;
        }

        /// <summary>
        /// Permite asignar la altura de los elementos (botones y separadores). Como mínimo será 25
        /// </summary>
        /// <param name="valor"></param>
        public void setAlturaElementos(int valor) { _alturaElementos = valor > 25 ? valor : 25; }

        private void FormVariasOpciones_Load(object sender, EventArgs e)
        {
            if (_valorPoner != -1)
            {
                string b_name = "b_" + _valorPoner.ToString().Replace("-", "minus");
                try
                {
                    Button b = (Button)panel1.Controls[b_name];
                    b.BackColor = Color.Orange;
                    b.Font = new Font(b.Font, FontStyle.Bold);
                    b.Focus();
                }
                catch { ;}
            }
        }

        public void addOpcion(Int32 valor, string texto)
        {
            addOpcion(valor, texto, Color.FromKnownColor(KnownColor.Control), null);
        }

        public void addOpcion(Int32 valor, string texto, Color color)
        {
            addOpcion(valor, texto, color, null);
        }

        public void addOpcionAlt(Int32 valor, string texto, object valorAlt)
        {
            addOpcion(valor, texto, Color.FromKnownColor(KnownColor.Control), valorAlt);
        }

        public void addOpcion(Int32 valor, string texto, Color color, object valorAlt)
        {
            _numOpciones++;

            Button b = new Button();
            b.Size = new Size(20, _alturaElementos);
            b.Dock = DockStyle.Top;
            b.Name = "b_" + valor.ToString().Replace("-", "minus");
            b.Text = texto;
            b.Tag = valorAlt;
            b.BackColor = color;
            b.Click += new EventHandler(b_Click);
            panel1.Controls.Add(b);
            panel1.Controls.SetChildIndex(b, 0);
        }

        void b_Click(object sender, EventArgs e)
        {
            string b_name;
            try { b_name = ((Button)sender).Name; }
            catch { b_name = "b_minus1"; }

            b_name = b_name.Replace("minus", "-").Replace("b_", "");

            _selectedValue = LT48.Conversiones.toIntWN(b_name);
            try { _selectedText = ((Button)sender).Text; }
            catch { ;}

            try { _selectedObject = ((Button)sender).Tag; }
            catch { ;}

            this.DialogResult = DialogResult.OK;
        }

        public void addSeparador()
        {
            Panel p = new Panel();
            p.Size = new Size(20, _alturaElementos);
            p.Dock = DockStyle.Top;
            p.Name = "p_" + panel1.Controls.Count.ToString();
            panel1.Controls.Add(p);
            panel1.Controls.SetChildIndex(p, 0);
        }

        public void addTexto(string texto, Int32 alto)
        {
            Int32 _alto = Math.Max(alto, 20);

            Label l = new Label();
            l.AutoSize = false;

            l.Size = new Size(30, _alto);
            l.Padding = new Padding(10, 0, 10, 0);
            l.TextAlign = ContentAlignment.MiddleLeft;
            l.Dock = DockStyle.Top;
            l.Name = "l_" + panel1.Controls.Count.ToString();
            l.Text = texto;
            panel1.Controls.Add(l);
            panel1.Controls.SetChildIndex(l, 0);
        }

        public Int32 getSelectedValue() { return _selectedValue; }
        public string getSelectedText() { return _selectedText; }
        public object getSelectedObject() { return _selectedObject; }

        public Int32 getNumOpciones() { return _numOpciones; }

        public void setSelectedValue(Int32 valor)
        {
            _valorPoner = valor;
        }

        public void autoAjustarAlto()
        {
            /*
             * Miramos la posición del último control metido (como usamos SetChildIndex
             * esto hace que sea el control en la posición 0. Si es un botón, cogemos
             * su posición, su alto, le sumamos un poco más y lo colocamos como alto de 
             * la ventana
             */
            try
            {
                if (panel1.Controls.Count > 0 &&
                    panel1.Controls[0].GetType() == typeof(Button))
                {
                    Button ultimoBoton = (Button)panel1.Controls[0];
                    Int32 posicionYDeBoton = ultimoBoton.Location.Y;
                    Int32 altoDeBoton = ultimoBoton.Size.Height;
                    Int32 posicionFinalEstimada = posicionYDeBoton + altoDeBoton + 70;

                    Int32 altoMaximoDeVentana = Math.Min(Comun.Form_getAltoMaximoDePantalla(), posicionFinalEstimada);
                    this.Size = new Size(this.Size.Width, altoMaximoDeVentana);
                }
            }
            catch { ;}
        }

        private void FormVariasOpciones_Shown(object sender, EventArgs e)
        {
            autoAjustarAlto();
            Comun.Form_colocaFormEnPosicionDelCursor(this);
        }

    } // end class
} // end namespace
