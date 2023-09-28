using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LT48;

namespace BC.Contactos
{
    public class Cuentas
    {
        #region Zona generada automaticamente

        private Int32 _idCuenta;
        private Int32 _idContacto;
        private string _banco;
        private string _iban;
        private string _swift;
        private bool _pago;
        private bool _cobro;

        public bool _datoCargado = false;



        public Cuentas() { inicializa(); }
        public Cuentas(object[] o) { instanciaFromVector(o); }
        public Cuentas(Int32 id) { carga(id); }



        public Int32 getIdCuenta() { return _idCuenta; }
        public void setIdCuenta(Int32 valor) { _idCuenta = valor; }

        public Int32 getIdContacto() { return _idContacto; }
        public void setIdContacto(Int32 valor) { _idContacto = valor; }

        public string getBanco() { return _banco; }
        public void setBanco(string valor) { _banco = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 50); }

        public string getIban() { return _iban; }
        public void setIban(string valor) { _iban = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 34); }

        public string getSwift() { return _swift; }
        public void setSwift(string valor) { _swift = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 11); }

        public bool getPago() { return _pago; }
        public void setPago(object valor) { _pago = Conversiones.objectToBool(valor); }

        public bool getCobro() { return _cobro; }
        public void setCobro(object valor) { _cobro = Conversiones.objectToBool(valor); }




        public void inicializa()
        {
            _idCuenta = -1;
            _idContacto = -1;
            _banco = "";
            _iban = "";
            _swift = "";
            _pago = false;
            _cobro = false;

            _datoCargado = false;
        }

        public void instanciaFromVector(object[] o)
        {
            setIdCuenta(Conversiones.toInt(o[0]));
            setIdContacto(Conversiones.toInt(o[1]));
            setBanco(Conversiones.toString(o[2]));
            setIban(Conversiones.toString(o[3]));
            setSwift(Conversiones.toString(o[4]));
            setPago(o[5]);
            setCobro(o[6]);
            try { _datoCargado = (bool)o[7]; }
            catch { _datoCargado = true; }
        }

        public object[] getInstanciaLikeARow()
        {
            object[] o = new object[8];
            o[0] = getIdCuenta();
            o[1] = getIdContacto();
            o[2] = getBanco();
            o[3] = getIban();
            o[4] = getSwift();
            o[5] = getPago();
            o[6] = getCobro();

            o[7] = _datoCargado;
            // Ojo con el tamaño del vector

            return o;
        }

        public void carga(Int32 id)
        {
            string sql = "select idCuenta, idContacto, banco, iban, swift, pago, cobro from t_cuentas where idCuenta=" + id;
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Cuentas.carga.Exception: " + ex.Message); t = null; }
            if (t != null && t.Rows.Count > 0)
            {
                instanciaFromVector(t.Rows[0].ItemArray);
            }
            else
            {
                inicializa();
            }
        }

        public void guarda()
        {
            string sql;
            if (!_datoCargado)
            {
                _idCuenta = DB.nextValue_conReintento("idCuenta", "t_cuentas", "Cuentas.guarda.Exception.Re1: ");
                sql = "insert into t_cuentas(idCuenta, idContacto, banco, iban, swift, pago, cobro) values(";
                sql += _idCuenta;
                sql += ", " + _idContacto;
                sql += ", '" + _banco + "'";
                sql += ", '" + _iban + "'";
                sql += ", '" + _swift + "'";
                sql += ", '" + (_pago ? "s" : "n") + "'";
                sql += ", '" + (_cobro ? "s" : "n") + "'";
                sql += ")";
            }
            else
            {
                sql = "update t_cuentas set ";
                sql += "idContacto=" + _idContacto;
                sql += ", banco='" + _banco + "'";
                sql += ", iban='" + _iban + "'";
                sql += ", swift='" + _swift + "'";
                sql += ", pago='" + (_pago ? "s" : "n") + "'";
                sql += ", cobro='" + (_cobro ? "s" : "n") + "'";
                sql += " where idCuenta=" + _idCuenta;
            }
            try { DB.ejecutaSQL_conReintento(sql, "Cuentas.guarda.Exception.Re2: "); _datoCargado = true; }
            catch (Exception ex) { Log.log("Cuentas.guarda.Exception: " + ex.Message); }
        }

        public void borra()
        {
            borra(_idCuenta);
            _datoCargado = false;
        }

        public static void borra(Int32 idCuentaBorrar)
        {
            string sql = "delete from t_cuentas where idCuenta=" + idCuentaBorrar;
            try { DB.ejecutaSQL_CCP(sql); }
            catch (Exception ex) { Log.log("Cuentas.borra.Exception: " + ex.Message); }
        }

        public static DataTable getDataTableVacia()
        {
            DataTable t = new DataTable();
            t.Columns.Add("idCuenta", typeof(Int32));
            t.Columns.Add("idContacto", typeof(Int32));
            t.Columns.Add("banco", typeof(string));
            t.Columns.Add("iban", typeof(string));
            t.Columns.Add("swift", typeof(string));
            t.Columns.Add("pago", typeof(bool));
            t.Columns.Add("cobro", typeof(bool));
            t.Columns.Add("datoCargado", typeof(bool));
            return t;
        }

        public static DataTable getDataTable(Int32 idContactoP)
        {
            DataTable t = getDataTableVacia();
            DataTable tSql;
            string sql = "select idCuenta, idContacto, banco, iban, swift, pago, cobro from t_cuentas where idContacto=" + idContactoP;
            try { tSql = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Cuentas.getDataTable.Exception: " + ex.Message); tSql = null; }
            if (tSql != null)
                foreach (DataRow r in tSql.Rows)
                {
                    t.Rows.Add(new Cuentas(r.ItemArray).getInstanciaLikeARow());
                }
            return t;
        }

        #endregion



        public string getNumCuentaFormateado()
        {
            return getNumCuentaFormateado(_iban);
        }

        public static string getNumCuentaFormateado(string numCuenta)
        {
            string r = "";
            string nc = numCuenta.Replace(" ", "").Replace("-", "");
            string letrasIBAN = "ES";
            if (nc.Length > 4 && !LT48.Conversiones.esInt(nc.Substring(0, 2)))
            {
                // Es un número de cuenta con IBAN
                letrasIBAN = nc.Substring(0, 2).ToUpper();
                r = nc.Substring(0, 4) + " ";
                nc = nc.Substring(4);
            }

            if (letrasIBAN == "ES" && nc.Length == 20)
            {
                r += nc.Substring(0, 4) + " " + nc.Substring(4, 4) + " " + nc.Substring(8, 2) + " " + nc.Substring(10);
            }
            else
            {
                // Agrupamos en grupos de 4
                r += Comun.getStringSeparadaEnGruposDe(nc, 4);
            }

            return r;
        }



        #region Digitos de control de una cuenta bancaria

        //http://conpb.blogspot.com/2006/03/comprobacin-del-dgito-de-control-del.html

        private static int dc(long i)
        {
            // Codigo copiado de http://latecladeescape.com
            int[] pesos = { 6, 3, 7, 9, 10, 5, 8, 4, 2, 1 };
            int contador = 0;
            long s = 0, d;
            while (i != 0)
            {
                d = i % 10;
                i = i / 10;
                s += d * pesos[contador];
                contador++;
            }
            int resultado = (int)(11 - (s % 11));
            if (resultado == 10)
                resultado = 1;
            else if (resultado == 11)
                resultado = 0;
            return resultado;
        }

        private static int DigitosControl(int entidad, int sucursal, long cuenta)
        {
            // Codigo copiado de http://latecladeescape.com
            long d = dc(entidad * 10000 + sucursal);
            d = d * 10;
            d += dc(cuenta);
            return (int)d;
        }



        public static bool cuentaCorrienteCorrectaES(string numeroCuenta)
        {
            // Comprobamos cuentas corrientes españolas que son 20 dígitos
            bool r = false;
            if (numeroCuenta.Length == 20)
            {
                // Quitamos los espacios
                string nc = numeroCuenta.Replace(" ", "").Replace("-", "");

                // Separamos la cadena en nº de oficina, sucursal, dígitos de control y cuenta
                Int32 entidad = LT48.Conversiones.stringToInt(nc.Substring(0, 4));
                Int32 sucursal = LT48.Conversiones.stringToInt(nc.Substring(4, 4));
                int dc_in = LT48.Conversiones.stringToInt(nc.Substring(8, 2));
                long cuenta = 0;
                try
                {
                    cuenta = (long)Convert.ToInt64(nc.Substring(10, 10));
                }
                catch { ;}

                // Comprobamos el número de control introducido por el usuario es el que tiene que ser
                int dc_out = DigitosControl(entidad, sucursal, cuenta);
                r = dc_in == dc_out;
            }

            return r;
        }

        public static bool IBANCorrecto(string numeroCuenta)
        {
            bool r;
            // Definimos el vector de letras. A=10, B=11...
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Quitamos los espacios en blanco.
            string nc = numeroCuenta.Replace(" ", "").Replace("-", "").ToUpper();

            // Sustituimos las dos letras por su número equivalente.
            string nn = "";
            while (nc.Length > 0)
            {
                nn += LT48.Conversiones.esInt(nc.Substring(0, 1)) ? nc.Substring(0, 1) : (letras.IndexOf(nc.Substring(0, 1)) + 10).ToString();
                nc = nc.Substring(1);
            }
            nc = nn;


            // Movemos los primeros seis caractéres al final
            nc = nc.Substring(6) + nc.Substring(0, 6);

            // Calculamos el resto de dividir el número por 97 que tiene que se 1
            r = Comun.getRestoDivisionMuyLarga(nc, "97") == "1";

            return r;
        }

        public static bool cuentaCorrienteOIBANCorrectos(string numeroCuenta)
        {
            /* Comprobamos si es iban (los dos primeros son letra) y si además es español (los dos primeros son ES)
             * comprobamos que el número de cuenta sea correcto. También comprobamos si el número de cuenta corriente es correcto
             * si parece ser un número de cuenta español 20 dígitos */

            bool r = false;

            // Quitamos los espacios en blanco.
            string nc = numeroCuenta.Replace(" ", "").Replace("-", "").ToUpper();
            string letras = "ES";

            // Comprobamos si empieza por letra
            if (!LT48.Conversiones.esInt(nc.Substring(0, 2)))
            {
                // Comprobamos que el IBAN es correcto
                r = IBANCorrecto(nc);

                /* Si el IBAN es correcto, cogemos las letras de identificador de pais y el número de cuenta
                 * Esto lo haremos para comprobar si es un número de cuenta española, poder comprobar su 
                 * correctitud */
                if (r)
                {
                    letras = nc.Substring(0, 2);
                    nc = nc.Substring(4);
                }
            }
            else r = nc.Length == 20; // Seguiremos comprobando si es posible que solo sea un número de cuenta

            // Si el IBAN es correcto y las dos primera letras con ES, comprobamos que la cuenta es correcta
            // Si no empieza por letra suponemos que es cc española y comprobamos.
            if (r && letras == "ES")
            {
                r = cuentaCorrienteCorrectaES(nc);
            }

            return r;
        }



        /// <summary>
        /// Dado una cadena que es un número de cuenta con 20 o 24 dígitos (si es IBAN), devuelve un vector en el que:
        /// La posición 0: IBAN (o 0000 si había 20 dígitos)
        /// La posición 1: Entidad
        /// La posición 2: Oficina
        /// La posición 3: DC
        /// La posición 4: Nº de cuenta.
        /// </summary>
        /// <param name="cuenta"></param>
        /// <returns></returns>
        public static string[] getPartesDeNoCuentaES(string cuenta)
        {
            string _c = cuenta.Replace(" ", "").Replace("-", "");
            while (_c.Length < 24) _c = "0" + _c;
            string[] partes = new string[5];
            partes[0] = _c.Substring(0, 4);     // IBAN
            partes[1] = _c.Substring(4, 4);     // Entidad
            partes[2] = _c.Substring(8, 4);     // Oficina
            partes[3] = _c.Substring(12, 2);    // DC
            partes[4] = _c.Substring(14, 10);   // Nº cuenta
            return partes;
        }

        ///// <summary>
        ///// Si la cuenta proporcionada es un IBAN correcto, devuelve la cadena con el IBAN, si no devuelve la cadena de la cuenta
        ///// dividida en bloques de 4
        ///// </summary>
        ///// <param name="cuenta">Nº de cuenta que se quiere mostrar formateado como una cuenta IBAN española</param>
        ///// <returns></returns>
        //public static string getNoDeCuentaESFormateado(string cuenta)
        //{
        //    string aux = "";

        //    if (IBANCorrecto(cuenta))
        //        try
        //        {
        //            string[] partes = getPartesDeNoCuentaES(cuenta);
        //            aux = partes[0] + " " + partes[1] + " " + partes[2] + " " + partes[3] + " " + partes[4];
        //        }
        //        catch
        //        {
        //            aux = Comun.getStringSeparadaEnGruposDe(cuenta, 4);
        //        }
        //    else aux = Comun.getStringSeparadaEnGruposDe(cuenta, 4);

        //    return aux;
        //}

        #endregion

    
    } // end class
} // end namespace
