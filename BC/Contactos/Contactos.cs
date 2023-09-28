using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LT48;

namespace BC.Contactos
{
    public class Contactos
    {
        #region Zona generada automaticamente

        private Int32 _idContacto;
        private string _codigo;
        private bool _activo;
        private bool _visible;
        private string _nifCif;
        private string _razonSocial;
        private string _nombreComercial;
        private string _observaciones;
        private bool _aplicaIva;
        private Int32 _tipoFormaMePaga;
        private Int32 _tipoFormaLePago;
        private Int32 _tarifa;
        private Double _descuento;
        private string _fechaCrea;
        private Int32 _idUsuarioCrea;
        private bool _esProveedor;
        private bool _esCliente;

        public bool _datoCargado = false;



        public Contactos() { inicializa(); }
        public Contactos(object[] o) { instanciaFromVector(o); }
        public Contactos(Int32 id) { carga(id); }



        public Int32 getIdContacto() { return _idContacto; }
        public void setIdContacto(Int32 valor) { _idContacto = valor; }

        public string getCodigo() { return _codigo; }
        public void setCodigo(string valor) { _codigo = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 15); }

        public bool getActivo() { return _activo; }
        public void setActivo(object valor) { _activo = Conversiones.objectToBool(valor); }

        public bool getVisible() { return _visible; }
        public void setVisible(object valor) { _visible = Conversiones.objectToBool(valor); }

        public string getNifCif() { return _nifCif; }
        public void setNifCif(string valor) { _nifCif = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 20); }

        public string getRazonSocial() { return _razonSocial; }
        public void setRazonSocial(string valor) { _razonSocial = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 255); }

        public string getNombreComercial() { return _nombreComercial; }
        public void setNombreComercial(string valor) { _nombreComercial = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 255); }

        public string getObservaciones() { return _observaciones; }
        public void setObservaciones(string valor) { _observaciones = Conversiones.quitarComillas(valor); }

        public bool getAplicaIva() { return _aplicaIva; }
        public void setAplicaIva(object valor) { _aplicaIva = Conversiones.objectToBool(valor); }

        public Int32 getTipoFormaMePaga() { return _tipoFormaMePaga; }
        public void setTipoFormaMePaga(Int32 valor) { _tipoFormaMePaga = valor; }

        public Int32 getTipoFormaLePago() { return _tipoFormaLePago; }
        public void setTipoFormaLePago(Int32 valor) { _tipoFormaLePago = valor; }

        public Int32 getTarifa() { return _tarifa; }
        public void setTarifa(Int32 valor) { _tarifa = Math.Max(1, Math.Min(valor, 3)); }

        public double getDescuento() { return _descuento; }
        public void setDescuento(double valor) { _descuento = valor; }

        public string getFechaCrea() { return _fechaCrea; }
        public void setFechaCrea(object valor)
        {
            if (valor.ToString() != "")
                _fechaCrea = Conversiones.toFechaUniversal(valor);
            else
                _fechaCrea = "";
        }
        public string getFechaCreaAsString() { return _fechaCrea == "" ? _fechaCrea : Conversiones.fechaUniversal_to_fechaESP(_fechaCrea); }
        public DateTime getFechaCreaAsDateTime() { return _fechaCrea == "" ? DateTime.Now : Conversiones.fechaUniversal_to_DateTime(_fechaCrea); }

        public Int32 getIdUsuarioCrea() { return _idUsuarioCrea; }
        public void setIdUsuarioCrea(Int32 valor) { _idUsuarioCrea = valor; }

        public bool getEsProveedor() { return _esProveedor; }
        public void setEsProveedor(object valor) { _esProveedor = Conversiones.objectToBool(valor); }

        public bool getEsCliente() { return _esCliente; }
        public void setEsCliente(object valor) { _esCliente = Conversiones.objectToBool(valor); }

        private static string __campos = "idContacto, codigo, activo, visible, nifCif, razonSocial, nombreComercial, observaciones, aplicaIva, tipoFormaMePaga, tipoFormaLePago, tarifa, descuento, fechaCrea, idUsuarioCrea, esProveedor, esCliente";






        public void inicializa()
        {
            _idContacto = -1;
            _codigo = "";
            _activo = true;
            _visible = true;
            _nifCif = "";
            _razonSocial = "";
            _nombreComercial = "";
            _observaciones = "";
            _aplicaIva = true;
            _tipoFormaMePaga = 0;
            _tipoFormaLePago = 0;
            _tarifa = 1;
            _descuento = 0.0;
            _fechaCrea = DateTime.Now.ToString("yyyyMMdd");
            _idUsuarioCrea = -1;
            _esProveedor = false;
            _esCliente = false;

            _datoCargado = false;
        }

        public void instanciaFromVector(object[] o)
        {
            setIdContacto(Conversiones.toInt(o[0]));
            setCodigo(Conversiones.toString(o[1]));
            setActivo(o[2]);
            setVisible(o[3]);
            setNifCif(Conversiones.toString(o[4]));
            setRazonSocial(Conversiones.toString(o[5]));
            setNombreComercial(Conversiones.toString(o[6]));
            setObservaciones(Conversiones.toString(o[7]));
            setAplicaIva(o[8]);
            setTipoFormaMePaga(Conversiones.toInt(o[9]));
            setTipoFormaLePago(Conversiones.toInt(o[10]));
            setTarifa(Conversiones.toInt(o[11]));
            setDescuento(Conversiones.toDouble(o[12]));
            setFechaCrea(o[13]);
            setIdUsuarioCrea(Conversiones.toInt(o[14]));
            try { setEsProveedor(o[15]); }
            catch { _esProveedor = false; }
            try { setEsCliente(o[16]); }
            catch { _esCliente = false; }
            try { _datoCargado = (bool)o[17]; }
            catch { _datoCargado = true; }
        }

        public object[] getInstanciaLikeARow()
        {
            object[] o = new object[18];
            o[0] = getIdContacto();
            o[1] = getCodigo();
            o[2] = getActivo();
            o[3] = getVisible();
            o[4] = getNifCif();
            o[5] = getRazonSocial();
            o[6] = getNombreComercial();
            o[7] = getObservaciones();
            o[8] = getAplicaIva();
            o[9] = getTipoFormaMePaga();
            o[10] = getTipoFormaLePago();
            o[11] = getTarifa();
            o[12] = getDescuento();
            o[13] = getFechaCreaAsString();
            o[14] = getIdUsuarioCrea();
            o[15] = getEsProveedor();
            o[16] = getEsCliente();

            o[17] = _datoCargado;
            // Ojo con el tamaño del vector

            return o;
        }

        public void carga(Int32 id)
        {
            string sql = "select " + __campos + " from t_contactos where idContacto=" + id;
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Contactos.carga.Exception: " + ex.Message); t = null; }
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
                _idContacto = DB.nextValue_conReintento("idContacto", "t_contactos", "Contactos.guarda.Exception.Re1: ");
                sql = "insert into t_contactos(" + __campos + ") values(";
                sql += _idContacto;
                sql += ", '" + _codigo + "'";
                sql += ", '" + (_activo ? "s" : "n") + "'";
                sql += ", '" + (_visible ? "s" : "n") + "'";
                sql += ", '" + _nifCif + "'";
                sql += ", '" + _razonSocial + "'";
                sql += ", '" + _nombreComercial + "'";
                sql += ", '" + _observaciones + "'";
                sql += ", '" + (_aplicaIva ? "s" : "n") + "'";
                sql += ", " + _tipoFormaMePaga;
                sql += ", " + _tipoFormaLePago;
                sql += ", " + _tarifa;
                sql += ", " + _descuento.ToString().Replace(",", ".");
                sql += ", '" + _fechaCrea + "'";
                sql += ", " + _idUsuarioCrea;
                sql += ", '" + (_esProveedor ? "s" : "n") + "'";
                sql += ", '" + (_esCliente ? "s" : "n") + "'";
                sql += ")";
            }
            else
            {
                sql = "update t_contactos set ";
                sql += "codigo='" + _codigo + "'";
                sql += ", activo='" + (_activo ? "s" : "n") + "'";
                sql += ", visible='" + (_visible ? "s" : "n") + "'";
                sql += ", nifCif='" + _nifCif + "'";
                sql += ", razonSocial='" + _razonSocial + "'";
                sql += ", nombreComercial='" + _nombreComercial + "'";
                sql += ", observaciones='" + _observaciones + "'";
                sql += ", aplicaIva='" + (_aplicaIva ? "s" : "n") + "'";
                sql += ", tipoFormaMePaga=" + _tipoFormaMePaga;
                sql += ", tipoFormaLePago=" + _tipoFormaLePago;
                sql += ", tarifa=" + _tarifa;
                sql += ", descuento=" + _descuento.ToString().Replace(",", ".");
                sql += ", fechaCrea='" + _fechaCrea + "'";
                sql += ", idUsuarioCrea=" + _idUsuarioCrea;
                sql += ", esProveedor='" + (_esProveedor ? "s" : "n") + "'";
                sql += ", esCliente='" + (_esCliente ? "s" : "n") + "'";
                sql += " where idContacto=" + _idContacto;
            }
            try { DB.ejecutaSQL_conReintento(sql, "Contactos.guarda.Exception.Re2: "); _datoCargado = true; }
            catch (Exception ex) { Log.log("Contactos.guarda.Exception: " + ex.Message); }
        }

        public static DataTable getDataTableVacia()
        {
            DataTable t = new DataTable();
            t.Columns.Add("idContacto", typeof(Int32));
            t.Columns.Add("codigo", typeof(string));
            t.Columns.Add("activo", typeof(bool));
            t.Columns.Add("visible", typeof(bool));
            t.Columns.Add("nifCif", typeof(string));
            t.Columns.Add("razonSocial", typeof(string));
            t.Columns.Add("nombreComercial", typeof(string));
            t.Columns.Add("observaciones", typeof(string));
            t.Columns.Add("aplicaIva", typeof(bool));
            t.Columns.Add("tipoFormaMePaga", typeof(Int32));
            t.Columns.Add("tipoFormaLePago", typeof(Int32));
            t.Columns.Add("tarifa", typeof(Int32));
            t.Columns.Add("descuento", typeof(Double));
            t.Columns.Add("fechaCrea", typeof(string));
            t.Columns.Add("idUsuarioCrea", typeof(Int32));
            t.Columns.Add("esProveedor", typeof(bool));
            t.Columns.Add("esCliente", typeof(bool));
            t.Columns.Add("datoCargado", typeof(bool));
            return t;
        }

        public static DataTable getDataTable(string codigoP)
        {
            DataTable t = getDataTableVacia();
            DataTable tSql;
            string sql = "select " + __campos + " from t_contactos where codigo='" + codigoP + "'";
            try { tSql = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Contactos.getDataTable.Exception: " + ex.Message); tSql = null; }
            if (tSql != null)
                foreach (DataRow r in tSql.Rows)
                {
                    t.Rows.Add(new Contactos(r.ItemArray).getInstanciaLikeARow());
                }
            return t;
        }

        #endregion 



        


        public enum FormasPago { no_determinado, aplazado_15_dias, aplazado_30_dias, contado, transferencia_bancaria, aplazado_60_dias, aplazado_90_dias };

        public static int getFormaPagoAsInt(FormasPago forma)
        {
            return (int)forma;
        }
        public static int getFormaPagoAsInt(string forma)
        {
            forma = forma.Replace("í", "i").Replace(" ", "_").ToLower();
            FormasPago fp;
            try { fp = (FormasPago)Enum.Parse(typeof(FormasPago), forma); }
            catch { fp = FormasPago.no_determinado; }

            return getFormaPagoAsInt(fp);
        }
        public static string getFormaPagoAsString(FormasPago forma)
        {
            return getFormaPagoAsString((int)forma);
        }
        public static string getFormaPagoAsString(int forma)
        {
            string[] v = { "No determinado", "Aplazado 15 días", "Aplazado 30 días", "Contado", "Transferencia bancaria", "Aplazado 60 días", "Aplazado 90 días" };
            return v[forma];
        }

        public static Int32 FormVariasOpcionesFormaPago(Int32 valorInicial)
        {
            Int32 vi = valorInicial >= 0 & valorInicial <= 7 ? valorInicial : 0;

            BC.FormVariasOpciones w = new BC.FormVariasOpciones("Indique modo");
            w.addOpcion((int)BC.Contactos.Contactos.FormasPago.no_determinado, "No determinado");
            w.addOpcion((int)BC.Contactos.Contactos.FormasPago.aplazado_15_dias, "Aplazado 15 días");
            w.addOpcion((int)BC.Contactos.Contactos.FormasPago.aplazado_30_dias, "Aplazado 30 días");
            w.addOpcion((int)BC.Contactos.Contactos.FormasPago.aplazado_60_dias, "Aplazado 60 días");
            w.addOpcion((int)BC.Contactos.Contactos.FormasPago.aplazado_90_dias, "Aplazado 90 días");
            w.addOpcion((int)BC.Contactos.Contactos.FormasPago.contado, "Contado");
            w.addOpcion((int)BC.Contactos.Contactos.FormasPago.transferencia_bancaria, "Transferencia bancaria");

            w.setSelectedValue(vi);

            if (w.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return w.getSelectedValue();
            else
                return vi;
        }



        /// <summary>
        /// Esta función, además de indicarnos el path en cuestión, si no existe de forma previa, lo crea.
        /// </summary>
        public string getPath() { return getPath(""); }
        /// <summary>
        /// Esta función, además de indicarnos el path en cuestión, si no existe de forma previa, lo crea.
        /// Si nombreSubPathOVacio es '' simplemente crea la carpeta del contacto y si no, crea la subcarpeta también.
        /// </summary>
        /// <param name="nombreSubPathOVacio">Nombre final de la carpeta sin \</param>
        public string getPath(string nombreSubPathOVacio)
        {
            string nombreCarpetaLvl0 = BC.Comun.SGA_base_path + @"\Contactos";
            string nombreCarpetaLvl1 = nombreCarpetaLvl0 + @"\c" + BC.Comun.getStringWidthLength(_idContacto.ToString(), 5, "0", true);
            string nombreCarpetaLvl2 = nombreSubPathOVacio == "" ? 
                nombreCarpetaLvl1 : 
                nombreCarpetaLvl1 + @"\" + nombreSubPathOVacio;
            
            if (!System.IO.Directory.Exists(nombreCarpetaLvl2))
            {
                if (!System.IO.Directory.Exists(nombreCarpetaLvl0))
                    System.IO.Directory.CreateDirectory(nombreCarpetaLvl0);

                if (!System.IO.Directory.Exists(nombreCarpetaLvl1))
                {
                    System.IO.Directory.CreateDirectory(nombreCarpetaLvl1);
                    LT48.Files.guardaFicheroTXT(nombreCarpetaLvl1 + @"\_Info.txt", "Carpeta de archivos del contacto " + _razonSocial);
                }

                // He de meter el if otra vez porque puede ser que la 2 sea igual que la 1 y ya estaría creada
                if (!System.IO.Directory.Exists(nombreCarpetaLvl2)) 
                    System.IO.Directory.CreateDirectory(nombreCarpetaLvl2);
            }

            return nombreCarpetaLvl2;
        }



        public static string getRazonSocialDe(Int32 idContacto)
        {
            string sql = "select razonSocial from t_contactos where idContacto=" + idContacto;

            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Contactos.getRazonSocialDe.Exception: " + ex.Message); t = null; }

            string aux = "???";
            if (t != null && t.Rows.Count > 0)
                aux = t.Rows[0].ItemArray[0].ToString();

            return aux;
        }

    } // end class
} // end namespace
