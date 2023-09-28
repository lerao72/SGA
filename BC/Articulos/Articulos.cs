using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LT48;

namespace BC.Articulos
{
    public class Articulos
    {
        #region Zona generada automaticamente

        private Int32 _idArticulo;
        private string _codigo;
        private string _referencia;
        private string _nombre;
        private string _descripcion;
        private string _observaciones;
        private string _imagen;
        private Double _precioT1;
        private Double _precioT2;
        private Double _precioT3;
        private Double _IVA;
        private Double _precioCompra;
        private bool _soloCompra;
        private bool _soloVenta;
        private bool _activo;
        private bool _visible;
        private string _fechaCrea;
        private Int32 _idUsuarioCrea;
        private double _stock;
        private double _stockMin;

        public bool _datoCargado = false;



        public Articulos() { inicializa(); }
        public Articulos(object[] o) { instanciaFromVector(o); }
        public Articulos(Int32 id) { carga(id); }



        public Int32 getIdArticulo() { return _idArticulo; }
        public void setIdArticulo(Int32 valor) { _idArticulo = valor; }

        public string getCodigo() { return _codigo; }
        public void setCodigo(string valor) { _codigo = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 25); }

        public string getReferencia() { return _referencia; }
        public void setReferencia(string valor) { _referencia = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 50); }

        public string getNombre() { return _nombre; }
        public void setNombre(string valor) { _nombre = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 255); }

        public string getDescripcion() { return _descripcion; }
        public void setDescripcion(string valor) { _descripcion = Conversiones.quitarComillas(valor); }

        public string getObservaciones() { return _observaciones; }
        public void setObservaciones(string valor) { _observaciones = Conversiones.quitarComillas(valor); }

        public string getImagen() { return _imagen; }
        public void setImagen(string valor) { _imagen = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 255); }

        public double getPrecioT1() { return _precioT1; }
        public void setPrecioT1(double valor) { _precioT1 = valor; }

        public double getPrecioT2() { return _precioT2; }
        public void setPrecioT2(double valor) { _precioT2 = valor; }

        public double getPrecioT3() { return _precioT3; }
        public void setPrecioT3(double valor) { _precioT3 = valor; }

        public double getIVA() { return _IVA; }
        public void setIVA(double valor) { _IVA = valor; }

        public double getPrecioCompra() { return _precioCompra; }
        public void setPrecioCompra(double valor) { _precioCompra = valor; }

        public bool getSoloCompra() { return _soloCompra; }
        public void setSoloCompra(object valor) { _soloCompra = Conversiones.objectToBool(valor); }

        public bool getSoloVenta() { return _soloVenta; }
        public void setSoloVenta(object valor) { _soloVenta = Conversiones.objectToBool(valor); }

        public bool getActivo() { return _activo; }
        public void setActivo(object valor) { _activo = Conversiones.objectToBool(valor); }

        public bool getVisible() { return _visible; }
        public void setVisible(object valor) { _visible = Conversiones.objectToBool(valor); }

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

        public double getStock() { return _stock; }
        public void setStock(double valor) { _stock = valor; }

        public double getStockMin() { return _stockMin; }
        public void setStockMin(double valor) { _stockMin = valor; }


        
        public void inicializa()
        {
            _idArticulo = -1;
            _codigo = "";
            _referencia = "";
            _nombre = "";
            _descripcion = "";
            _observaciones = "";
            _imagen = "";
            _precioT1 = 0.0;
            _precioT2 = 0.0;
            _precioT3 = 0.0;
            _IVA = 0.0;
            _precioCompra = 0.0;
            _soloCompra = false;
            _soloVenta = false;
            _activo = true;
            _visible = true;
            _fechaCrea = DateTime.Now.ToString("yyyyMMdd");
            _idUsuarioCrea = -1;
            _stock = 0;
            _stockMin = 0;

            _datoCargado = false;
        }

        public void instanciaFromVector(object[] o)
        {
            setIdArticulo(Conversiones.toInt(o[0]));
            setCodigo(Conversiones.toString(o[1]));
            setReferencia(Conversiones.toString(o[2]));
            setNombre(Conversiones.toString(o[3]));
            setDescripcion(Conversiones.toString(o[4]));
            setObservaciones(Conversiones.toString(o[5]));
            setImagen(Conversiones.toString(o[6]));
            setPrecioT1(Conversiones.toDouble(o[7]));
            setPrecioT2(Conversiones.toDouble(o[8]));
            setPrecioT3(Conversiones.toDouble(o[9]));
            setIVA(Conversiones.toDouble(o[10]));
            setPrecioCompra(Conversiones.toDouble(o[11]));
            setSoloCompra(o[12]);
            setSoloVenta(o[13]);
            setActivo(o[14]);
            setVisible(o[15]);
            setFechaCrea(o[16]);
            setIdUsuarioCrea(Conversiones.toInt(o[17]));
            try { setStock(Conversiones.toDouble(o[18])); }
            catch { _stock = 0; }
            try { setStockMin(Conversiones.toDouble(o[19])); }
            catch { _stockMin = 0; }
            try { _datoCargado = (bool)o[20]; }
            catch { _datoCargado = true; }
        }

        public object[] getInstanciaLikeARow()
        {
            object[] o = new object[21];
            o[0] = getIdArticulo();
            o[1] = getCodigo();
            o[2] = getReferencia();
            o[3] = getNombre();
            o[4] = getDescripcion();
            o[5] = getObservaciones();
            o[6] = getImagen();
            o[7] = getPrecioT1();
            o[8] = getPrecioT2();
            o[9] = getPrecioT3();
            o[10] = getIVA();
            o[11] = getPrecioCompra();
            o[12] = getSoloCompra();
            o[13] = getSoloVenta();
            o[14] = getActivo();
            o[15] = getVisible();
            o[16] = getFechaCreaAsString();
            o[17] = getIdUsuarioCrea();
            o[18] = getStock();
            o[19] = getStockMin();

            o[20] = _datoCargado;
            // Ojo con el tamaño del vector

            return o;
        }

        public void carga(Int32 id)
        {
            string sql = "select idArticulo, codigo, referencia, nombre, descripcion, observaciones, imagen, precioT1, precioT2, precioT3, IVA, precioCompra, soloCompra, soloVenta, activo, visible, fechaCrea, idUsuarioCrea, stock, stockMin from t_articulos where idArticulo=" + id;
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Articulos.carga.Exception: " + ex.Message); t = null; }
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
                _idArticulo = DB.nextValue_conReintento("idArticulo", "t_articulos", "Articulos.guarda.Exception.Re1: ");
                sql = "insert into t_articulos(idArticulo, codigo, referencia, nombre, descripcion, observaciones, imagen, precioT1, precioT2, precioT3, IVA, precioCompra, soloCompra, soloVenta, activo, visible, fechaCrea, idUsuarioCrea, stock, stockMin) values(";
                sql += _idArticulo;
                sql += ", '" + _codigo + "'";
                sql += ", '" + _referencia + "'";
                sql += ", '" + _nombre + "'";
                sql += ", '" + _descripcion + "'";
                sql += ", '" + _observaciones + "'";
                sql += ", '" + _imagen + "'";
                sql += ", " + _precioT1.ToString().Replace(",", ".");
                sql += ", " + _precioT2.ToString().Replace(",", ".");
                sql += ", " + _precioT3.ToString().Replace(",", ".");
                sql += ", " + _IVA.ToString().Replace(",", ".");
                sql += ", " + _precioCompra.ToString().Replace(",", ".");
                sql += ", '" + (_soloCompra ? "s" : "n") + "'";
                sql += ", '" + (_soloVenta ? "s" : "n") + "'";
                sql += ", '" + (_activo ? "s" : "n") + "'";
                sql += ", '" + (_visible ? "s" : "n") + "'";
                sql += ", '" + _fechaCrea + "'";
                sql += ", " + _idUsuarioCrea;
                sql += ", " + _stock.ToString().Replace(",", ".");
                sql += ", " + _stockMin.ToString().Replace(",", ".");
                sql += ")";
            }
            else
            {
                sql = "update t_articulos set ";
                sql += "codigo='" + _codigo + "'";
                sql += ", referencia='" + _referencia + "'";
                sql += ", nombre='" + _nombre + "'";
                sql += ", descripcion='" + _descripcion + "'";
                sql += ", observaciones='" + _observaciones + "'";
                sql += ", imagen='" + _imagen + "'";
                sql += ", precioT1=" + _precioT1.ToString().Replace(",", ".");
                sql += ", precioT2=" + _precioT2.ToString().Replace(",", ".");
                sql += ", precioT3=" + _precioT3.ToString().Replace(",", ".");
                sql += ", IVA=" + _IVA.ToString().Replace(",", ".");
                sql += ", precioCompra=" + _precioCompra.ToString().Replace(",", ".");
                sql += ", soloCompra='" + (_soloCompra ? "s" : "n") + "'";
                sql += ", soloVenta='" + (_soloVenta ? "s" : "n") + "'";
                sql += ", activo='" + (_activo ? "s" : "n") + "'";
                sql += ", visible='" + (_visible ? "s" : "n") + "'";
                sql += ", fechaCrea='" + _fechaCrea + "'";
                sql += ", idUsuarioCrea=" + _idUsuarioCrea;
                sql += ", stock=" + _stock.ToString().Replace(",", ".");
                sql += ", stockMin=" + _stockMin.ToString().Replace(",", ".");
                sql += " where idArticulo=" + _idArticulo;
            }
            try { DB.ejecutaSQL_conReintento(sql, "Articulos.guarda.Exception.Re2: "); _datoCargado = true; }
            catch (Exception ex) { Log.log("Articulos.guarda.Exception: " + ex.Message); }
        }

        public static DataTable getDataTableVacia()
        {
            DataTable t = new DataTable();
            t.Columns.Add("idArticulo", typeof(Int32));
            t.Columns.Add("codigo", typeof(string));
            t.Columns.Add("referencia", typeof(string));
            t.Columns.Add("nombre", typeof(string));
            t.Columns.Add("descripcion", typeof(string));
            t.Columns.Add("observaciones", typeof(string));
            t.Columns.Add("imagen", typeof(string));
            t.Columns.Add("precioT1", typeof(Double));
            t.Columns.Add("precioT2", typeof(Double));
            t.Columns.Add("precioT3", typeof(Double));
            t.Columns.Add("IVA", typeof(Double));
            t.Columns.Add("precioCompra", typeof(Double));
            t.Columns.Add("soloCompra", typeof(bool));
            t.Columns.Add("soloVenta", typeof(bool));
            t.Columns.Add("activo", typeof(bool));
            t.Columns.Add("visible", typeof(bool));
            t.Columns.Add("fechaCrea", typeof(string));
            t.Columns.Add("idUsuarioCrea", typeof(Int32));
            t.Columns.Add("stock", typeof(double));
            t.Columns.Add("stockMin", typeof(double));
            t.Columns.Add("datoCargado", typeof(bool));
            return t;
        }

        public static DataTable getDataTable(string codigoP)
        {
            DataTable t = getDataTableVacia();
            DataTable tSql;
            string sql = "select idArticulo, codigo, referencia, nombre, descripcion, observaciones, imagen, precioT1, precioT2, precioT3, IVA, precioCompra, soloCompra, soloVenta, activo, visible, fechaCrea, idUsuarioCrea, stock, stockMin from t_articulos where codigo='" + codigoP + "'";
            try { tSql = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Articulos.getDataTable.Exception: " + ex.Message); tSql = null; }
            if (tSql != null)
                foreach (DataRow r in tSql.Rows)
                {
                    t.Rows.Add(new Articulos(r.ItemArray).getInstanciaLikeARow());
                }
            return t;
        }

        #endregion 



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
            string nombreCarpetaLvl0 = BC.Comun.SGA_base_path + @"\Articulos";
            string nombreCarpetaLvl1 = nombreCarpetaLvl0 + @"\a" + BC.Comun.getStringWidthLength(_idArticulo.ToString(), 5, "0", true);
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
                    LT48.Files.guardaFicheroTXT(nombreCarpetaLvl1 + @"\_Info.txt", "Carpeta de archivos del artículo " + _nombre);
                }

                // He de meter el if otra vez porque puede ser que la 2 sea igual que la 1 y ya estaría creada
                if (!System.IO.Directory.Exists(nombreCarpetaLvl2))
                    System.IO.Directory.CreateDirectory(nombreCarpetaLvl2);
            }

            return nombreCarpetaLvl2;
        }



        public static void restaCantidadAStock(Int32 idArticuloP, double cantidad)
        {
            string sql = "update t_articulos set stock=stock-" + cantidad.ToString().Replace(",", ".");
            sql += " where idArticulo=" + idArticuloP;
            try { DB.ejecutaSQL_CCP(sql); }
            catch (Exception ex) { Log.log("Articulos.restaCantidadAStock.Exception: " + ex.Message); }
        }



        public static void addFamiliaAArticulo(Int32 idArticulo, Int32 idFamilia)
        {
            string sql = "insert into t_rel_familiasArticulos(idFamiliaArticulo, idArticulo) values(";
            sql += idFamilia;
            sql += ", " + idArticulo;
            sql += ")";

            try { DB.ejecutaSQL_CCP(sql); }
            catch (Exception ex) { Log.log("Articulos.addFamiliaAArticulo.Exception: " + ex.Message); }
        }

        public static void removeFamiliaDeArticulo(Int32 idArticulo, Int32 idFamilia)
        {
            string sql = "delete from t_rel_familiasArticulos where";
            sql += " idFamiliaArticulo=" + idFamilia;
            sql += " and idArticulo=" + idArticulo;

            try { DB.ejecutaSQL_CCP(sql); }
            catch (Exception ex) { Log.log("Articulos.removeFamiliaDeArticulo.Exception: " + ex.Message); }
        }

        public static string getNombresFamiliasDeArticulo(Int32 idArticuloP)
        {
            string aux = "";
            string coma = "";

            string sql = "select f.nombre from t_rel_familiasArticulos r";
            sql += " left join t_familiasArticulos f on r.idFamiliaArticulo=f.idFamiliaArticulo";
            sql += " where r.idArticulo=" + idArticuloP;
            sql += " order by nombre asc";

            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Articulos.getNombresFamiliasDeArticulo.Exception: " + ex.Message); t = null; }

            if (t!= null && t.Rows.Count > 0)
                foreach (DataRow r in t.Rows)
                {
                    aux += coma + r.ItemArray[0].ToString();
                    coma = ", ";
                }

            return aux;
        }



        public static Articulos getArticuloPorCodigo(string codigoCargar)
        {
            Articulos aux = new Articulos();

            string sql = "select idArticulo, codigo, referencia, nombre, descripcion, observaciones, imagen, precioT1, precioT2, precioT3, IVA, precioCompra, soloCompra, soloVenta, activo, visible, fechaCrea, idUsuarioCrea, stock, stockMin from t_articulos where codigo='" + codigoCargar + "'";
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Articulos.carga.Exception: " + ex.Message); t = null; }
            if (t != null && t.Rows.Count > 0)
                aux.instanciaFromVector(t.Rows[0].ItemArray);

            return aux;
        }

    } // end class
} // end namespace
