using System;
using System.Collections.Generic;
using System.Text;
using LT48;

namespace BC
{
    public static class Comun
    {
        public static DBConexion conexionEstaticaDeDB;
        public static string nombreBD = "";

        public static string accessKey = "0238";

        public static string SGA_base_path = "."; //@"\\VBOXSVR\Carpeta_compartida\temp"; //".";

        public delegate void DelegadoInterfazComun(string strSolicitud, object parametro);
        public static event DelegadoInterfazComun EnvioAInterfazComun;

        public static void GeneraEnvioAInterfazComun(string strSolicitud, object parametros)
        {
            try { EnvioAInterfazComun(strSolicitud, parametros); }
            catch { ;}
        }






        #region Funciones para Form

        public static System.Drawing.Size Form_getTamanioMaximoPantalla()
        {
            return System.Windows.Forms.SystemInformation.PrimaryMonitorMaximizedWindowSize;
        }
        public static Int32 Form_getAnchoMaximoDePantalla()
        {
            return System.Windows.Forms.SystemInformation.PrimaryMonitorMaximizedWindowSize.Width;
        }
        public static Int32 Form_getAltoMaximoDePantalla()
        {
            return System.Windows.Forms.SystemInformation.PrimaryMonitorMaximizedWindowSize.Height;
        }

        /// <summary>
        /// Ajusta el tamaño de un formulario expresado en porcentaje del tamaño de la pantalla y lo centra.
        /// </summary>
        /// <param name="form">Formulario que queremos redimensionar y centrar</param>
        /// <param name="porcAncho">Porcentaje del ancho de la pantalla que queremos ocupar</param>
        /// <param name="porcAlto">Porcentaje del alto de la pantalla que queremos ocupar</param>
        public static void Form_ajustaTamanioYCentraForm(System.Windows.Forms.Form form, int porcAncho, int porcAlto)
        {
            int anchoMaxPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorMaximizedWindowSize.Width;
            int altoMaxPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorMaximizedWindowSize.Height;

            int nuevoAnchoForm = anchoMaxPantalla * porcAncho / 100;
            int nuevoAltoForm = altoMaxPantalla * porcAlto / 100;

            form.Size = new System.Drawing.Size(nuevoAnchoForm, nuevoAltoForm);
            form.Location = new System.Drawing.Point((anchoMaxPantalla - nuevoAnchoForm) / 2, (altoMaxPantalla - nuevoAltoForm) / 2);
        }

        /// <summary>
        /// Dado un form, lo coloca en la posición del cursor (del ratón)
        /// </summary>
        public static void Form_colocaFormEnPosicionDelCursor(System.Windows.Forms.Form form)
        {
            System.Drawing.Point posCursor = System.Windows.Forms.Control.MousePosition;

            int nuevaX = posCursor.X + form.Width > Comun.Form_getAnchoMaximoDePantalla() ?
                Comun.Form_getAnchoMaximoDePantalla() - form.Width :
                posCursor.X;

            int nuevaY = posCursor.Y + form.Height > Comun.Form_getAltoMaximoDePantalla() ?
                Comun.Form_getAltoMaximoDePantalla() - form.Height :
                posCursor.Y;

            form.Location = new System.Drawing.Point(nuevaX, nuevaY);
        }

        #endregion



        #region Formateado de columnas de grid de datos

        public enum AlineacionColumna { PorDefecto, Izquierda, Centro, Derecha }
        private static void grid_setAlineacionColumna(System.Windows.Forms.DataGridViewColumn columna, AlineacionColumna alineacion)
        {
            switch (alineacion)
            {
                case AlineacionColumna.Izquierda:
                    columna.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                    break;

                case AlineacionColumna.Centro:
                    columna.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                    break;

                case AlineacionColumna.Derecha:
                    columna.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                    break;

                default:
                    break;
            }
        }
        public static void grid_anchoColumna(System.Windows.Forms.DataGridView grid, string nombreColumna, Int32 ancho)
        {
            grid_anchoColumna(grid, nombreColumna, ancho, AlineacionColumna.PorDefecto);
        }
        public static void grid_anchoColumna(System.Windows.Forms.DataGridView grid, string nombreColumna, Int32 ancho, AlineacionColumna alineacion)
        {
            try
            {
                grid.Columns[nombreColumna].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                grid.Columns[nombreColumna].Width = ancho;
                grid_setAlineacionColumna(grid.Columns[nombreColumna], alineacion);
            }
            catch { ;}
        }
        public static void grid_tituloColumna(System.Windows.Forms.DataGridView grid, string nombreColumna, string titulo)
        {
            grid_tituloColumna(grid, nombreColumna, titulo, AlineacionColumna.PorDefecto);
        }
        public static void grid_tituloColumna(System.Windows.Forms.DataGridView grid, string nombreColumna, string titulo, AlineacionColumna alineacion)
        {
            try
            {
                grid.Columns[nombreColumna].HeaderText = titulo;
                grid_setAlineacionColumna(grid.Columns[nombreColumna], alineacion);
            }
            catch { ;}
        }
        public static void grid_tituloAnchoColumna(System.Windows.Forms.DataGridView grid, string nombreColumna, string titulo, Int32 ancho)
        {
            grid_tituloAnchoColumna(grid, nombreColumna, titulo, ancho, AlineacionColumna.PorDefecto);
        }
        public static void grid_tituloAnchoColumna(System.Windows.Forms.DataGridView grid, string nombreColumna, string titulo, Int32 ancho, AlineacionColumna alineacion)
        {
            try
            {
                grid.Columns[nombreColumna].HeaderText = titulo;
                grid.Columns[nombreColumna].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                grid.Columns[nombreColumna].Width = ancho;
                grid_setAlineacionColumna(grid.Columns[nombreColumna], alineacion);
            }
            catch { ;}
        }

        public static int grid_desplazamientoParaCentrarAlImprimir(System.Windows.Forms.DataGridViewColumn c, int anchoTexto, int ancho)
        {
            int desplazamiento = 0;
            if (anchoTexto < ancho)
                switch (c.DefaultCellStyle.Alignment)
                {
                    case System.Windows.Forms.DataGridViewContentAlignment.BottomRight:
                    case System.Windows.Forms.DataGridViewContentAlignment.MiddleRight:
                    case System.Windows.Forms.DataGridViewContentAlignment.TopRight:
                        desplazamiento = ancho - anchoTexto;
                        break;

                    case System.Windows.Forms.DataGridViewContentAlignment.BottomCenter:
                    case System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter:
                    case System.Windows.Forms.DataGridViewContentAlignment.TopCenter:
                        desplazamiento = ((ancho - anchoTexto) / 2) - 1;
                        break;
                }
            return desplazamiento;
        }

        #endregion

        /// <summary>
        /// Dado un grid y un texto a buscar, busca el texto en el grid.
        /// Si encuentra un coincidente, se posiciona sobre él y devuelve true, si no encuentra
        /// devuelve false
        /// </summary>
        /// <param name="buscar">Cadena que se busca</param>
        /// <param name="grid">Grid de datos en el que se busca</param>
        public static bool grid_buscadorEnGridPorPosicionamiento(string buscar, System.Windows.Forms.DataGridView grid)
        {
            bool encontrada = false;

            // Inicializamos variables como número de filas, número de columnas y fila actual
            Int32 numFilas = grid.Rows.Count;
            if (numFilas > 0)
            {
                Int32 numColumnas = grid.Columns.Count;
                Int32 filaActual = grid.CurrentRow != null ? grid.CurrentRow.Index : 0;

                // Pasamos a mayúsculas el texto a buscar
                string buscarUCase = buscar.ToUpper();

                // Buscamos la primera columna visible pues es en ella en la que nos posicionaremos si encontramos el dato.
                Int32 primeraColumnaPosicionable = -1;
                bool primeraColumnaPosicionableEncontrada = false;
                Int32 i = 0;
                while (!primeraColumnaPosicionableEncontrada && i < grid.Columns.Count)
                {
                    primeraColumnaPosicionableEncontrada = grid.Columns[i].Visible;
                    if (!primeraColumnaPosicionableEncontrada)
                        i++;
                    else
                        primeraColumnaPosicionable = i;
                }

                // Procedemos a la búsqueda del dato entre los elementos del grid            
                i = filaActual;

                do
                {
                    // Nos posicionamos en la siguiente fila
                    i = (i + 1) % numFilas;

                    // Buscamos en las columnas (si el dato es visible)
                    Int32 j = 0;
                    while (!encontrada && j < numColumnas)
                    {
                        if (grid.Columns[j].Visible)
                            encontrada = grid.Rows[i].Cells[j].Value.ToString().ToUpper().IndexOf(buscarUCase) >= 0;
                        j++;
                    }
                } while (!encontrada && i != filaActual);

                // Si hemos visto un elemento, nos posicionamos en el. Así si se vuelve a buscar seguimos desde donde estamos.
                if (encontrada)
                    try { grid.CurrentCell = grid.Rows[i].Cells[primeraColumnaPosicionable]; }
                    catch { ;}
            }
            return encontrada;
        }

        #region Exportación de un grid de datos a un archivo CSV

        public static void guardaCSV_From_DataGridView(System.Windows.Forms.DataGridView grid, string nombreFicheroPredeterminado)
        {
            guardaCSV_From_DataGridView(grid, nombreFicheroPredeterminado, null, null, false);
        }

        public static void guardaCSV_From_DataGridView(System.Windows.Forms.DataGridView grid, string nombreFicheroPredeterminado, bool usarValoresFormateados)
        {
            guardaCSV_From_DataGridView(grid, nombreFicheroPredeterminado, null, null, usarValoresFormateados);
        }

        public static void guardaCSV_From_DataGridView(System.Windows.Forms.DataGridView grid, string nombreFicheroPredeterminado, string[] cabecera, string[] resumen)
        {
            guardaCSV_From_DataGridView(grid, nombreFicheroPredeterminado, cabecera, resumen, false);
        }

        public static void guardaCSV_From_DataGridView(System.Windows.Forms.DataGridView grid, string nombreFicheroPredeterminado, string[] cabecera, string[] resumen, bool usarValoresFormateados)
        {
            string fila = "";
            string _rc = "\r\n";

            string _nombreColumnas = "";

            // Si hay cabecera, la colocamos al principio
            if (cabecera != null)
            {
                foreach (string s in cabecera)
                {
                    fila += s + ";";
                }
                fila += _rc + _rc;
            }

            // Sustituimos las dos líneas anteriores por las siguientes instrucciones (hasta fila += _rc) para que se exporte en el mismo
            // orden que se muestra en el grid.
            System.Windows.Forms.DataGridViewColumn c = grid.Columns.GetFirstColumn(System.Windows.Forms.DataGridViewElementStates.None);
            try
            {
                while (c != null)
                {
                    if (c.Visible)
                    {
                        fila += c.HeaderText.Replace(_rc, " ").Replace(";", ",") + ";";
                        _nombreColumnas += c.Name + "/#";
                    }
                    c = grid.Columns.GetNextColumn(c, System.Windows.Forms.DataGridViewElementStates.None, System.Windows.Forms.DataGridViewElementStates.None);
                }
            }
            catch { ;}
            fila += _rc;

            // Montamos un vector con los nombres de las columnas para el foreach
            string[] _separador = { "/#" };
            string[] _nombreColumnasVector = _nombreColumnas.Split(_separador, StringSplitOptions.RemoveEmptyEntries);

            foreach (System.Windows.Forms.DataGridViewRow r in grid.Rows)
            {
                foreach (string s in _nombreColumnasVector)
                {
                    if (usarValoresFormateados)
                        fila += r.Cells[s].FormattedValue.ToString().Replace(_rc, " ").Replace(";", ",") + ";";
                    else
                        fila += r.Cells[s].Value.ToString().Replace(_rc, " ").Replace(";", ",") + ";";
                }
                fila += _rc;
            }

            // Si hay resumen, lo colocamos aqui
            if (resumen != null)
            {
                foreach (string s in resumen)
                {
                    fila += s + ";";
                }
                fila += _rc;
            }

            System.Windows.Forms.SaveFileDialog sfd = new System.Windows.Forms.SaveFileDialog();
            sfd.RestoreDirectory = true;
            //sfd.InitialDirectory = Comun.pathCarpetaERPPTM;
            sfd.FileName = nombreFicheroPredeterminado;
            sfd.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string nombreFichero = sfd.FileName;

                Files.guardaFicheroTXT(nombreFichero, fila);
                System.Windows.Forms.MessageBox.Show("Archivo guardado", "Exportación a CSV");
            }
        }

        #endregion

        /// <summary>
        /// Dado un vector, nos devuelve una copya sin el último elemento
        /// </summary>
        public static object[] getCopyOfAVectorMinusLastElement(object[] o)
        {
            object[] copy = new object[o.Length - 1];
            Array.Copy(o, copy, copy.Length);
            return copy;
        }



        public static System.Windows.Forms.DialogResult preguntaSiNo(string pregunta, string titulo)
        {
            return System.Windows.Forms.MessageBox.Show(pregunta, titulo, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
        }



        /// <summary>
        /// Coje los valores de las celdas de un dataGridViewRow y las devuelve en un object[]
        /// Tiene dos procedimientos inversos: setDataRowFromObjectArray y setDataridViewRowFromObjectV
        /// </summary>
        /// <param name="r">dataGridViewRow que contiene los valores</param>
        /// <returns></returns>
        public static object[] dataGridViewRowToObjectV(System.Windows.Forms.DataGridViewRow r)
        {
            try
            {
                object[] o = new object[r.Cells.Count];
                for (int i = 0; i < o.Length; i++)
                {
                    try { o[i] = r.Cells[i].Value; }
                    catch { o[i] = ""; }
                }
                return o;
            }
            catch { object[] o = { "" }; return o; }
        }

        /// <summary>
        /// Dado un vector y una fila de un DataGridView, si las longitudes son iguales, copia el contenido de los elementos
        /// del vector en las celdas del DataGridView
        /// Es el método "inverso" a dataGridVeiwRowToObjectV.
        /// </summary>
        /// <param name="arrayOrigen">Vector de elementos que queremos copiar</param>
        /// <param name="rowDestino">DataGridViewRow en el que copiaremo los datos</param>
        /// 
        public static void setDataRowFromObjectArray(object[] arrayOrigen, System.Windows.Forms.DataGridViewRow rowDestino)
        {
            if (arrayOrigen.Length == rowDestino.Cells.Count)
            {
                for (Int32 i = 0; i < arrayOrigen.Length; i++) try
                    {
                        rowDestino.Cells[i].Value = arrayOrigen[i];
                    }
                    catch (Exception ex) { Log.log("BC.Comun.setDataRowFromObjectArray(static).Exception: " + ex.Message); }
            }
        }

        /// <summary>
        /// Dado un vector y una fila de un DataGridView, si las longitudes son iguales, copia el contenido de los elementos
        /// del vector en las celdas del DataGridView. (Simplemente llama a setDataRowFromObjectArray).
        /// Es el método "inverso" a dataGridVeiwRowToObjectV.
        /// </summary>
        /// <param name="arrayOrigen">Vector de elementos que queremos copiar</param>
        /// <param name="rowDestino">DataGridViewRow en el que copiaremo los datos</param>
        public static void setDataGridViewRowFromObjectV(object[] arrayOrigen, System.Windows.Forms.DataGridViewRow rowDestino)
        {
            setDataRowFromObjectArray(arrayOrigen, rowDestino);
        }





        #region NIF/CIF

        public static bool esNIF(string nif)
        {
            string cadenaControl = "TRWAGMYFPDXBNJZSQVHLCKE";
            bool nifTieneLetra = !Conversiones.esInt(nif);
            string numeros = nif.Substring(0, nif.Length - 1);
            bool letraAlFinal = Conversiones.esInt(numeros);
            string letraControl = "";
            if (nifTieneLetra && letraAlFinal)
            {
                Int32 numerosInt = Conversiones.stringToInt(numeros);
                int resto = numerosInt % 23;
                letraControl = cadenaControl.Substring(resto, 1);
            }
            return numeros + letraControl == nif.ToUpper();
        }

        public static bool esCIF(string cif)
        {
            bool aux = false;
            string cadenaControl = "JABCDEFGHI";
            if (cif.Length == 9)
            {
                string cif_centro = cif.Substring(1, 7);
                string letraControl = cif.Substring(8, 1).ToUpper();
                if (Conversiones.esInt(cif_centro))
                {
                    int suma = 0;
                    for (int i = 0; i < 7; i++)
                    {
                        int valorLetra = Conversiones.stringToInt(cif_centro.Substring(i, 1));
                        suma += i % 2 == 1 ? valorLetra : ((valorLetra * 2) / 10) + ((valorLetra * 2) % 10);
                    }
                    suma = suma % 10; // Cojemos sólo la unidad
                    int control = suma == 0 ? suma : 10 - suma;

                    switch (cif.Substring(0, 1).ToUpper())
                    {
                        case "K":
                        case "P":
                        case "Q":
                        case "S":
                            aux = letraControl == cadenaControl.Substring(control, 1);
                            break;
                        case "A":
                        case "B":
                        case "E":
                        case "H":
                            aux = letraControl == control.ToString();
                            break;
                        default:
                            aux = letraControl == cadenaControl.Substring(control, 1) || letraControl == control.ToString();
                            break;
                    }
                }
            }
            return aux;
        }

        #endregion



        /// <summary>
        /// Dada una cadena, nos devuelve otra con un tamaño fijo. Si la cadena inicial es menor
        /// rellena con un caracter que se indique y si es mayor, devuelve los primeros caracteres.
        /// </summary>
        public static string getStringWidthLength(string cadena, int length, string relleno, bool rellenarAIzquierda)
        {
            if (cadena.Length < length)
            {
                // Nos aseguramos que relleno tenga al menos tamaño 1 (colocando por defecto un espacio)
                string rellenoNoVacio = relleno + " ";

                // Seleccionamos el primer carácter
                string r = rellenoNoVacio.Substring(0, 1);

                // Dependiendo de si es a izquierda o a derecha como hay que rellenar, montamos sufijo y prefijo
                string izq = rellenarAIzquierda ? r : "";
                string der = rellenarAIzquierda ? "" : r;

                while (cadena.Length < length)
                    cadena = izq + cadena + der;

                return cadena;
            }
            else
                return LT48.Conversiones.getStringWidhtLenghtLessThan(cadena, length);
        }



        #region Abrir archivos y carpetas

        public static void abrirDocumentoConAplicacionExterna(string filename)
        {
            string extension = System.IO.Path.GetExtension(filename).ToLower();

            string comando = "";
            string argumentos = "";

            switch (extension)
            {
                case ".doc":
                    comando = "winword.exe";
                    break;
                case ".xls":
                    comando = "excel.exe";
                    break;
                case ".jpg":
                case ".bmp":
                case ".gif":
                    //comando = "mspaint.exe";
                    comando = "runDll32";
                    argumentos = " shimgvw.dll,ImageView_Fullscreen " + filename.Replace("/", @"\");
                    break;
                case ".pdf":
                    comando = "acrord32.exe";
                    break;
                case ".eml":
                    comando = "msimn.exe";
                    argumentos = "/eml:" + filename.Replace("/", @"\");
                    break;
                case ".msg":
                    comando = "outlook.exe";
                    argumentos = "/f \"" + filename.Replace("/", @"\") + "\"";
                    break;
                default:
                    comando = "explorer.exe";
                    break;
            }

            if (argumentos == "") argumentos = "\"" + filename.Replace("/", @"\") + "\"";

            try
            {

                System.Diagnostics.Process com;
                System.Diagnostics.ProcessStartInfo st = new System.Diagnostics.ProcessStartInfo(comando, argumentos);
                st.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

                com = System.Diagnostics.Process.Start(st);
                //com.WaitForExit();
            }
            catch (Exception ex)
            {
                Log.log("BC.Comun.abrirDocumentoConAplicacionExterna.Exception: " + ex.Message);
            }

        }

        public static void abrirCarpeta(string path)
        {
            string comando = "explorer.exe";
            string argumentos = "";

            if (argumentos == "") argumentos = "\"" + path.Replace("/", @"\") + "\"";

            try
            {

                System.Diagnostics.Process com;
                System.Diagnostics.ProcessStartInfo st = new System.Diagnostics.ProcessStartInfo(comando, argumentos);
                st.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

                com = System.Diagnostics.Process.Start(st);
            }
            catch (Exception ex)
            {
                Log.log("BC.Comun.abrirCarpeta.Exception: " + ex.Message);
            }
        }

        #endregion



        /// <summary>
        /// Dada una cadena, la subdivide en otra en la que intercala espacios en blanco cada
        /// 'cuanto's caracteres
        /// </summary>
        public static string getStringSeparadaEnGruposDe(string que, int cuanto)
        {
            // abcdefghij
            // 0123456789
            // 012012012
            string aux = "";
            Int32 i = 0;
            while (i < que.Length)
            {
                aux += que.Substring(i, 1);
                i++;
                if (i % cuanto == 0) aux += " ";
            }
            return aux;
        }

        /// <summary>
        /// Dado un par de cadenas que representan números muy grandes, calcula la división
        /// y la devuelve como otra cadena.
        /// </summary>
        public static string getDivisionMuyLarga(string dividendo, string divisor)
        {
            string cadenadividendo = dividendo;
            Int64 subdividendo = 0;
            Int64 int_divisor;
            try
            {
                int_divisor = Convert.ToInt64(divisor);
            }
            catch { throw new Exception("El divisor no puede ser tan grande"); }

            string cociente = "";

            while (cadenadividendo.Length > 0)
            {
                while (subdividendo < int_divisor && cadenadividendo.Length > 0)
                {
                    subdividendo *= 10;
                    try
                    {
                        subdividendo += Convert.ToInt64(cadenadividendo.Substring(0, 1));
                    }
                    catch
                    {
                        throw new Exception("El divisor no es un número");
                    }
                    cadenadividendo = cadenadividendo.Length > 1 ? cadenadividendo.Substring(1) : "";
                }
                cociente += Convert.ToString(subdividendo / int_divisor);
                subdividendo = subdividendo % int_divisor;
            }
            return cociente;
        }

        /// <summary>
        /// Dado un par de cadenas que representan números muy grandes, calcula el resto
        /// y la devuelve como otra cadena.
        /// </summary>
        public static string getRestoDivisionMuyLarga(string dividendo, string divisor)
        {
            string cadenadividendo = dividendo;
            Int64 subdividendo = 0;
            Int64 int_divisor;
            try
            {
                int_divisor = Convert.ToInt64(divisor);
            }
            catch { throw new Exception("El divisor no puede ser tan grande"); }
            string cociente = "";

            while (cadenadividendo.Length > 0)
            {
                while (subdividendo < int_divisor && cadenadividendo.Length > 0)
                {
                    subdividendo *= 10;
                    try
                    {
                        subdividendo += Convert.ToInt64(cadenadividendo.Substring(0, 1));
                    }
                    catch
                    {
                        throw new Exception("El divisor no es un número");
                    }
                    cadenadividendo = cadenadividendo.Length > 1 ? cadenadividendo.Substring(1) : "";
                }
                cociente += Convert.ToString(subdividendo / int_divisor);
                subdividendo = subdividendo % int_divisor;
            }
            return subdividendo.ToString();
        }



        #region Operaciones con moneda

        public static double currency_getDescuento(double inicial, double dto)
        {
            double valorDescontar = dto * inicial / 100.0;
            valorDescontar = Conversiones.toDouble(valorDescontar.ToString("0.00"));
            return valorDescontar;
        }

        public static double currency_getValorConDescuento(double inicial, double dto)
        {
            double valorConDto = inicial - currency_getDescuento(inicial, dto);
            valorConDto = Conversiones.toDouble(valorConDto.ToString("0.00"));
            return valorConDto;
        }



        /// <summary>
        /// Dado un double, devuelve el dato formateado como moneda
        /// </summary>
        public static string currency_getValorFormateadoAsString(double valor)
        {
            return valor.ToString("#,###,##0.00 €");
        }

        /// <summary>
        /// Dado una cadena, devuelve su valor (elimina espacios y símbolos de moneda)
        /// </summary>
        public static double currency_getValorDoubleFromString(string valor)
        {
            return Conversiones.toDouble(valor.Replace(" ", "").Replace("€", ""));
        }



        /// <summary>
        /// Dado un valor, si es de tipo cadena, elimina espacios y símbolo de moneda y devuelve el valor double.
        /// Si no es string, trata de hacer la conversión a double directamente.
        /// El valor double es devuelto con dos decimales
        /// </summary>
        public static double currency_getValorFormateadoAsDouble(object valor)
        {
            double aux;
            if (valor.GetType() == typeof(string))
            {
                // Limpiamos la cifra
                string strValor = ((string)valor).Replace(" ", "").Replace("€", "");
                // Obtenemos su valor
                aux = Conversiones.toDouble(strValor);
            }
            else
                aux = Conversiones.toDouble(valor);

            // Devolvemos asegurándonos de haber limitado a 2 decimales
            return Conversiones.toDouble(aux.ToString("0.##"));
        }

        public static double currency_getIVAdeValor(double valor, double IVA)
        {
            return valor * IVA / 100.0;
        }

        #endregion

    } // end class
} // end namespace
