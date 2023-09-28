using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LT48;
using BC;


namespace SGA
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            Comun.EnvioAInterfazComun += new Comun.DelegadoInterfazComun(Comun_EnvioAInterfazComun);
        }

        private void Comun_EnvioAInterfazComun(string strSolicitud, object parametro)
        {
            switch (strSolicitud)
            {
                case "abrir_albaran":
                    new MBC.FormAlbaran((BC.Ventas.Albaran)parametro).Show();
                    break;

                case "abrir_cobro":
                    new MBC.Facturas.FormCobro((BC.Ventas.Cobro)parametro).Show();
                    break;

                case "abrir_factura":
                    new MBC.FormFactura((BC.Ventas.Factura)parametro).Show();
                    break;

                case "abrir_pago":
                    new MBC.Pagos.FormPago((BC.Compras.Pago)parametro).Show();
                    break;

                case "abrir_recordatorio":
                    new MVC.Recordatorios.FormRecordatorio((BC.Varios.Recordatorio)parametro).Show();
                    break;

                case "FormRecordatorio_FormClosed":
                    t_agenda.Enabled = true;
                    break;

                case "FormRecordatorio_FormCreado":
                    t_agenda.Enabled = false;
                    break;
            } // switch
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);

            LT48.Log.setModoGuardado(Log.ModoGuardado.Directo);
            borrarLogsAntiguos();

            iniciarBaseDeDatos();
            t_delay_activacion.Enabled = true;
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { BC.Comun.conexionEstaticaDeDB.Cierra(); }
            catch { ;}
        }

        private void t_delay_activacion_Tick(object sender, EventArgs e)
        {
            string sql = "select * from t_contactos where idContacto<10";
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch { t = null; }

            if (t != null)
            {
                t_delay_activacion.Enabled = false;
                activarBotonesTrasComprobarCrearBD();
                t_comprobacionesAlInicio.Enabled = true;

                BC.Varios.Recordatorio.comprobarAgendaHoy();
            }
        }


        
        public void iniciarBaseDeDatos()
        {
            if (!System.IO.File.Exists(@".\server.cfg"))
            {
                BC.Comun.nombreBD = BDSeleccionada();
                this.Text = BC.Comun.nombreBD;
            }

            if (System.IO.File.Exists(@".\server.cfg"))
            {
                string cadenaServidor = Files.cargaFicheroTXTToString(@".\server.cfg");
                cadenaServidor = Encriptador.desEncriptarCadena(cadenaServidor);

                string[] separador = { "\r\n" };
                string[] partes = cadenaServidor.Split(separador, StringSplitOptions.RemoveEmptyEntries);

                string SQLS_nombreServidor = "";
                if (partes.Length > 0)
                    SQLS_nombreServidor = partes[0].Trim();

                string SQLS_nombreBD = "SGA";
                if (partes.Length > 1)
                    SQLS_nombreBD = partes[1].Trim();

                string SQLS_user = "xxx";
                if (partes.Length > 2)
                    SQLS_user = partes[2].Trim();

                string SQLS_psw = "xxx";
                if (partes.Length > 3)
                    SQLS_psw = partes[3].Trim();

                Comun.conexionEstaticaDeDB = new DBConexion(DBConexion.Tipo.SQLServer, SQLS_nombreServidor, SQLS_user, SQLS_psw, SQLS_nombreBD);
                DB.setConexionEstatica(Comun.conexionEstaticaDeDB);

                actualizarBD(true);
            }
            else if (System.IO.File.Exists(@".\" + BC.Comun.nombreBD + ".dat"))
            {
                iniciarBaseDeDatos_conexionAccess();
            }
            else if (System.IO.File.Exists(@".\base.mdb"))
            {
                System.IO.File.Copy(@".\base.mdb", @".\" + BC.Comun.nombreBD + ".dat", false);
                iniciarBaseDeDatos_conexionAccess();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error. No hay base de datos. La aplicación no puede iniciarse");
                this.Close();
            }
        }

        private void iniciarBaseDeDatos_conexionAccess()
        {
            Comun.conexionEstaticaDeDB = new DBConexion(DBConexion.Tipo.Access, @".\" + BC.Comun.nombreBD + ".dat", null, null, BC.Comun.accessKey);
            DB.setConexionEstatica(Comun.conexionEstaticaDeDB);
            try { Comun.conexionEstaticaDeDB.Abre(); }
            catch (Exception ex) { Log.log("FormPrincipal.iniciarBaseDeDatos.AbrirConexion.Exception: " + ex.Message); }

            actualizarBD(false);
        }

        private static void actualizarBD(bool esSQLServer)
        {          
            if (MCC.Comun.Activo)
                MCC.Comun.actualizarBD(esSQLServer);

            if (MAC.Comun.Activo)
                MAC.Comun.actualizarBD(esSQLServer);

            if (MBC.Comun.Activo)
                MBC.Comun.actualizarBD(esSQLServer);

            if (MVC.Comun.Activo)
                MVC.Comun.actualizarBD(esSQLServer);
        }

        private static bool hayDATs()
        {
            string[] dats_filenames = System.IO.Directory.GetFiles(".", "*.dat");
            return dats_filenames.Length > 0;
        }

        private static string BDSeleccionada()
        {
            return "2020";
        }



        public static void borrarLogsAntiguos()
        {
            DateTime hoy = DateTime.Now;
            DateTime haceDias = hoy.AddDays(-20);

            string[] todosLosArchivosLogs = System.IO.Directory.GetFiles(".", "log2*.log");
            foreach (string archivoLog in todosLosArchivosLogs)
                try
                {
                    string poda = archivoLog.Substring(archivoLog.IndexOf("log") + 3);
                    poda = poda.Replace(".log", "");
                    if (Conversiones.fechaUniversal_to_DateTime(poda) < haceDias)
                        System.IO.File.Delete(archivoLog);
                }
                catch { ;}
        }



        private void activarBotonesTrasComprobarCrearBD()
        {
            b_contactos.Enabled = true;
            b_articulos.Enabled = true;
            b_negocio.Enabled = true;
            b_recordatorio.Enabled = true;
        }



        private void b_contactos_Click(object sender, EventArgs e)
        {
            new MCC.FormContactos().Show();
        }

        private void b_articulos_Click(object sender, EventArgs e)
        {
            new MAC.FormArticulos().Show();
        }

        private void b_negocio_Click(object sender, EventArgs e)
        {
            FormVariasOpciones w = new FormVariasOpciones("Indique opción");
            w.addOpcion(0, "Pagos", Color.LightBlue);
            w.addOpcion(1, "Ventas", Color.LightGreen);

            if (w.ShowDialog() == DialogResult.OK)
                switch (w.getSelectedValue())
                {
                    case 0:
                        BC.Compras.SelectorDePagosContacto.FormSelectorDePagosGenerico_Show();
                        break;

                    case 1:
                        FormVariasOpciones w1 = new FormVariasOpciones("Indique opción");
                        w1.addOpcion(0, "Albaranes", Color.LightBlue);
                        w1.addOpcion(1, "Facturas", Color.LightGreen);
                        w1.addSeparador();
                        w1.addOpcion(2, "Cobros", Color.PaleGoldenrod);

                        if (w1.ShowDialog() == DialogResult.OK)
                        {
                            switch (w1.getSelectedValue())
                            {
                                case 0:
                                    BC.Ventas.SelectorDeAlbaranesDeContacto.FormSelectorDeAlbaranes_Show();
                                    break;

                                case 1:
                                    BC.Ventas.SelectorDeFacturasDeContacto.FormSelectorDeFacturas_Show();
                                    break;

                                case 2:
                                    BC.Ventas.SelectorDeCobrosContacto.FormSelectorDeCobrosGenerico_Show();
                                    break;
                            } // switch (w1.GetSelectedValue...
                        } // if (w1.Showdialog....
                        break;
                } // switch (w.getSelectedValue()
        }

        private void b_recordatorio_Click(object sender, EventArgs e)
        {
            BC.Varios.SelectorDeRecordatorios.FormSelectorDeRecordatoriosGenerico_Show();
        }

        private int pasoComprobaciones = 0;
        private void t_comprobacionesAlInicio_Tick(object sender, EventArgs e)
        {
            t_comprobacionesAlInicio.Enabled = false;
            switch (pasoComprobaciones)
            {
                case 0:
                    BC.Compras.Pago.actualizarAutoPagos();
                    pasoComprobaciones++;
                    t_comprobacionesAlInicio.Enabled = true;
                    break;

                case 1:
                    BC.Compras.Pago[] v_ppf = BC.Compras.Pago.getPagosPersistentesSinPagosPendientes();
                    if (v_ppf != null &&
                        Comun.preguntaSiNo("Se han detectado pagos persistentes de los cuales ya se han hecho todos los pagos. ¿Desea revisarlos para generar pagos nuevos?",
                        "Pagos persistentes") == DialogResult.Yes)
                    {
                        foreach (BC.Compras.Pago pago in v_ppf)
                            Comun.GeneraEnvioAInterfazComun("abrir_pago", pago);
                    }
                    pasoComprobaciones++;
                    t_comprobacionesAlInicio.Enabled = true;
                    break;

                default:
                    break;
            }
        }

        private void t_agenda_Tick(object sender, EventArgs e)
        {
            BC.Varios.Recordatorio.comprobarAgendaHoy();
        }

    } // end class
} // end namespace
