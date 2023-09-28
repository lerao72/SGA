using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LT48;

namespace BC.Articulos
{
    public class ProveedorDeArticulo
    {
        #region Zona generada automaticamente

        private Int32 _idArticulo;
        private Int32 _idContacto;
        private Double _precio;
        private string _observaciones;

        public bool _datoCargado = false;



        public ProveedorDeArticulo() { inicializa(); }
        public ProveedorDeArticulo(object[] o) { instanciaFromVector(o); }
        public ProveedorDeArticulo(Int32 idArticulo, Int32 idContacto) { carga(idArticulo, idContacto); }



        public Int32 getIdArticulo() { return _idArticulo; }
        public void setIdArticulo(Int32 valor) { _idArticulo = valor; }

        public Int32 getIdContacto() { return _idContacto; }
        public void setIdContacto(Int32 valor) { _idContacto = valor; }

        public double getPrecio() { return _precio; }
        public void setPrecio(double valor) { _precio = valor; }

        public string getObservaciones() { return _observaciones; }
        public void setObservaciones(string valor) { _observaciones = Conversiones.quitarComillas(valor); }




        public void inicializa()
        {
            _idArticulo = -1;
            _idContacto = -1;
            _precio = 0.0;
            _observaciones = "";

            _datoCargado = false;
        }

        public void instanciaFromVector(object[] o)
        {
            setIdArticulo(Conversiones.toInt(o[0]));
            setIdContacto(Conversiones.toInt(o[1]));
            setPrecio(Conversiones.toDouble(o[2]));
            setObservaciones(Conversiones.toString(o[3]));
            try { _datoCargado = (bool)o[4]; }
            catch { _datoCargado = true; }
        }

        public object[] getInstanciaLikeARow()
        {
            object[] o = new object[5];
            o[0] = getIdArticulo();
            o[1] = getIdContacto();
            o[2] = getPrecio();
            o[3] = getObservaciones();

            o[4] = _datoCargado;
            // Ojo con el tamaño del vector

            return o;
        }

        public void carga(Int32 idArticulo, Int32 idContacto)
        {
            string sql = "select idArticulo, idContacto, precio, observaciones from t_proveedorDeArticulo where idArticulo=" + idArticulo;
            sql += " and idContacto=" + idContacto;
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("ProveedorDeArticulo.carga.Exception: " + ex.Message); t = null; }
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
                sql = "insert into t_proveedorDeArticulo(idArticulo, idContacto, precio, observaciones) values(";
                sql += _idArticulo;
                sql += ", " + _idContacto;
                sql += ", " + _precio.ToString().Replace(",", ".");
                sql += ", '" + _observaciones + "'";
                sql += ")";
            }
            else
            {
                sql = "update t_proveedorDeArticulo set ";
                sql += " precio=" + _precio.ToString().Replace(",", ".");
                sql += ", observaciones='" + _observaciones + "'";
                sql += " where idArticulo=" + _idArticulo;
                sql += " and idContacto=" + _idContacto;
            }
            try { DB.ejecutaSQL_CCP(sql); _datoCargado = true; }
            catch (Exception ex) { Log.log("ProveedorDeArticulo.guarda.Exception: " + ex.Message); }
        }

        public void borra()
        {
            if (_idArticulo != -1 && _idContacto != -1 && _datoCargado)
            {
                borra(_idArticulo, _idContacto);
                _datoCargado = false;
            }
        }
        
        public static void borra(Int32 idArticuloP, Int32 idContactoP)
        {
            string sql = "delete from t_proveedorDeArticulo where idArticulo=" + idArticuloP;
            sql += " and idContacto=" + idContactoP;
            try { DB.ejecutaSQL_CCP(sql); }
            catch (Exception ex) { Log.log("ProveedorDeArticulo.borra.Exception: " + ex.Message); }
        }

        public static DataTable getDataTableVacia()
        {
            DataTable t = new DataTable();
            t.Columns.Add("idArticulo", typeof(Int32));
            t.Columns.Add("idContacto", typeof(Int32));
            t.Columns.Add("precio", typeof(Double));
            t.Columns.Add("observaciones", typeof(string));
            t.Columns.Add("datoCargado", typeof(bool));
            return t;
        }

        public static DataTable getDataTable(Int32 idArticuloP)
        {
            DataTable t = getDataTableVacia();
            DataTable tSql;
            string sql = "select idArticulo, idContacto, precio, observaciones from t_proveedorDeArticulo where idArticulo=" + idArticuloP;
            try { tSql = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("ProveedorDeArticulo.getDataTable.Exception: " + ex.Message); tSql = null; }
            if (tSql != null)
                foreach (DataRow r in tSql.Rows)
                {
                    t.Rows.Add(new ProveedorDeArticulo(r.ItemArray).getInstanciaLikeARow());
                }
            return t;
        }

        #endregion 

    } // end class
} // end namespace
