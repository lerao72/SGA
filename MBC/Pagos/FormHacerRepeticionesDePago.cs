using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BC;
using LT48;

namespace MBC.Pagos
{
    public partial class FormHacerRepeticionesDePago : Form
    {
        private BC.Compras.Pago _pago;
        private string opcionActual = "D";
        private Int32 int_opcionActual = 0;
        private string[] v_opciones_char = { "D", "S", "M", "A" };
        private string[] v_opciones_string = { "Días", "Semanas", "Meses", "Años" };

        public FormHacerRepeticionesDePago(BC.Compras.Pago pago)
        {
            InitializeComponent();

            _pago = pago;
            opcionActual = _pago.getPatronSerie().Substring(3, 1).ToUpper();
            int_opcionActual = getOpcionAsInt(opcionActual);
        }

        private int getOpcionAsInt(string opcionAsCharOrString)
        {
            string aux = opcionAsCharOrString + "D";
            string opcionAsChar = aux.Substring(0, 1).ToUpper();

            int valor;

            if (opcionAsChar == "D")
                valor = 0;
            else if (opcionAsChar == "S")
                valor = 1;
            else if (opcionAsChar == "M")
                valor = 2;
            else
                valor = 3;

            return valor;
        }

        private void FormHacerRepeticionesDePago_Load(object sender, EventArgs e)
        {
            nud_cada.Value = Conversiones.toInt(_pago.getPatronSerie().Substring(0, 2));
            instanciarLabelCada();
            limitarNudQty();
        }

        private void instanciarLabelCada()
        {
            l_cada.Text = v_opciones_string[int_opcionActual];
        }
        private void limitarNudQty()
        {
            int[] maximos = { 30, 50, 12, 10 };
            if (nud_qty.Value > maximos[int_opcionActual])
                nud_qty.Value = maximos[int_opcionActual];
            nud_qty.Maximum = maximos[int_opcionActual];

            int[] maximos2 = { 14, 8, 24, 10 };
            if (nud_cada.Value > maximos2[int_opcionActual])
                nud_cada.Value = maximos2[int_opcionActual];
            nud_cada.Maximum = maximos2[int_opcionActual];
        }

        private void b_cada_Click(object sender, EventArgs e)
        {
            FormVariasOpciones w = new FormVariasOpciones("Indique opción");
            w.addOpcion(0, "Días");
            w.addOpcion(1, "Semanas");
            w.addOpcion(2, "Meses");
            w.addOpcion(3, "Años");

            w.setSelectedValue(int_opcionActual);

            if (w.ShowDialog() == DialogResult.OK)
            {
                opcionActual = w.getSelectedText().Substring(0, 1);
                int_opcionActual = getOpcionAsInt(opcionActual);

                instanciarLabelCada();
                limitarNudQty();
            }
        }

        private void b_hacer_Click(object sender, EventArgs e)
        {
            System.DateTime fecha = _pago.getFechaPrevistaAsDateTime();

            string cadenaPatronSerie = nud_cada.Value.ToString();
            if (nud_cada.Value < 10)
                cadenaPatronSerie = "0" + cadenaPatronSerie;
            cadenaPatronSerie += "#" + opcionActual;

            Int32 serie;
            try
            {
                serie = _pago.getSerie();
                if (serie == -1)
                    serie = DB.nextValue_CCP("serie", "t_pago");
            }
            catch { serie = -1; }

            if (serie != -1)
            {
                if (_pago.getSerie() == -1)
                {
                    _pago.setSerie(serie);
                    _pago.setPatronSerie(cadenaPatronSerie);
                    _pago.guarda();
                }

                for (Int32 i = 0; i < nud_qty.Value; i++)
                {
                    switch (int_opcionActual)
                    {
                        case 0:
                            fecha = fecha.AddDays((Int32)nud_cada.Value);
                            break;

                        case 1:
                            fecha = fecha.AddDays((Int32)nud_cada.Value * 7);
                            break;

                        case 2:
                            fecha = fecha.AddMonths((Int32)nud_cada.Value);
                            break;

                        case 3:
                            fecha = fecha.AddYears((Int32)nud_cada.Value);
                            break;
                    }

                    BC.Compras.Pago nuevoPago = BC.Compras.Pago.getACopyOf(_pago);
                    nuevoPago.setFechaPrevista(fecha);
                    nuevoPago.setPatronSerie(cadenaPatronSerie);
                    nuevoPago.setFechaReal("");

                    nuevoPago.guarda();
                }

                System.Windows.Forms.MessageBox.Show("Proceso finalizado");
                this.Close();
            } // if (serie != -1)
        }

    } // end class
} // end namespace
