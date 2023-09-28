using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LT48;

namespace BC.Ventas
{
    public class Cobro
    {
        #region Zona generada automaticamente

        private Int32 _idCobro;
        private Int32 _idContacto;
        private Int32 _idFactura;
        private string _fechaPrevista;
        private string _fechaReal;
        private string _descripcion;
        private Double _importe;

        public bool _datoCargado = false;



        public Cobro() { inicializa(); }
        public Cobro(object[] o) { instanciaFromVector(o); }
        public Cobro(Int32 id) { carga(id); }



        public Int32 getIdCobro() { return _idCobro; }
        public void setIdCobro(Int32 valor) { _idCobro = valor; }

        public Int32 getIdContacto() { return _idContacto; }
        public void setIdContacto(Int32 valor) { _idContacto = valor; }

        public Int32 getIdFactura() { return _idFactura; }
        public void setIdFactura(Int32 valor) { _idFactura = valor; }

        public string getFechaPrevista() { return _fechaPrevista; }
        public void setFechaPrevista(object valor)
        {
            if (valor.ToString() != "")
                _fechaPrevista = Conversiones.toFechaUniversal(valor);
            else
                _fechaPrevista = "";
        }
        public string getFechaPrevistaAsString() { return _fechaPrevista == "" ? _fechaPrevista : Conversiones.fechaUniversal_to_fechaESP(_fechaPrevista); }
        public DateTime getFechaPrevistaAsDateTime() { return _fechaPrevista == "" ? DateTime.Now : Conversiones.fechaUniversal_to_DateTime(_fechaPrevista); }

        public string getFechaReal() { return _fechaReal; }
        public void setFechaReal(object valor)
        {
            if (valor.ToString() != "")
            {
                string valorU = valor.ToString().ToUpper();
                if (valorU == "IMPAGO")
                    _fechaReal = valorU;
                else
                    _fechaReal = Conversiones.toFechaUniversal(valor);
            }
            else
                _fechaReal = "";
        }
        public string getFechaRealAsString() { return _fechaReal == "" || _fechaReal == "IMPAGO" ? _fechaReal : Conversiones.fechaUniversal_to_fechaESP(_fechaReal); }
        public DateTime getFechaRealAsDateTime() { return _fechaReal == "" ? DateTime.Now : Conversiones.fechaUniversal_to_DateTime(_fechaReal); }

        public string getDescripcion() { return _descripcion; }
        public void setDescripcion(string valor) { _descripcion = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 50); }

        public double getImporte() { return _importe; }
        public void setImporte(double valor) { _importe = valor; }




        public void inicializa()
        {
            _idCobro = -1;
            _idContacto = -1;
            _idFactura = -1;
            _fechaPrevista = DateTime.Now.ToString("yyyyMMdd");
            _fechaReal = "";
            _descripcion = "";
            _importe = 0.0;

            _datoCargado = false;
        }

        public void instanciaFromVector(object[] o)
        {
            setIdCobro(Conversiones.toInt(o[0]));
            setIdContacto(Conversiones.toInt(o[1]));
            setIdFactura(Conversiones.toInt(o[2]));
            setFechaPrevista(o[3]);
            setFechaReal(o[4]);
            setDescripcion(Conversiones.toString(o[5]));
            setImporte(Conversiones.toDouble(o[6]));
            try { _datoCargado = (bool)o[7]; }
            catch { _datoCargado = true; }
        }

        public object[] getInstanciaLikeARow()
        {
            object[] o = new object[8];
            o[0] = getIdCobro();
            o[1] = getIdContacto();
            o[2] = getIdFactura();
            o[3] = getFechaPrevistaAsString();
            o[4] = getFechaRealAsString();
            o[5] = getDescripcion();
            o[6] = getImporte();

            o[7] = _datoCargado;
            // Ojo con el tamaño del vector

            return o;
        }

        public void carga(Int32 id)
        {
            string sql = "select idCobro, idContacto, idFactura, fechaPrevista, fechaReal, descripcion, importe from t_cobro where idCobro=" + id;
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Cobro.carga.Exception: " + ex.Message); t = null; }
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
                _idCobro = DB.nextValue_conReintento("idCobro", "t_cobro", "Cobro.guarda.Exception.Re1: ");
                sql = "insert into t_cobro(idCobro, idContacto, idFactura, fechaPrevista, fechaReal, descripcion, importe) values(";
                sql += _idCobro;
                sql += ", " + _idContacto;
                sql += ", " + _idFactura;
                sql += ", '" + _fechaPrevista + "'";
                sql += ", '" + _fechaReal + "'";
                sql += ", '" + _descripcion + "'";
                sql += ", " + _importe.ToString().Replace(",", ".");
                sql += ")";
            }
            else
            {
                sql = "update t_cobro set ";
                sql += "idContacto=" + _idContacto;
                sql += ", idFactura=" + _idFactura;
                sql += ", fechaPrevista='" + _fechaPrevista + "'";
                sql += ", fechaReal='" + _fechaReal + "'";
                sql += ", descripcion='" + _descripcion + "'";
                sql += ", importe=" + _importe.ToString().Replace(",", ".");
                sql += " where idCobro=" + _idCobro;
            }
            try { DB.ejecutaSQL_conReintento(sql, "Cobro.guarda.Exception.Re2: "); _datoCargado = true; }
            catch (Exception ex) { Log.log("Cobro.guarda.Exception: " + ex.Message); }
        }

        public void borra()
        {
            borra(_idCobro);
            _datoCargado = false;
        }

        public static void borra(Int32 idCobro)
        {
            string sql = "delete from t_cobro where idCobro=" + idCobro;
            try { DB.ejecutaSQL_CCP(sql); }
            catch (Exception ex) { Log.log("Cobro.borra.Exception: " + ex.Message); }
        }

        public static DataTable getDataTableVacia()
        {
            DataTable t = new DataTable();
            t.Columns.Add("idCobro", typeof(Int32));
            t.Columns.Add("idContacto", typeof(Int32));
            t.Columns.Add("idFactura", typeof(Int32));
            t.Columns.Add("fechaPrevista", typeof(string));
            t.Columns.Add("fechaReal", typeof(string));
            t.Columns.Add("descripcion", typeof(string));
            t.Columns.Add("importe", typeof(Double));
            t.Columns.Add("datoCargado", typeof(bool));
            return t;
        }

        public static DataTable getDataTable_deContacto(Int32 idContactoP)
        {
            string sql = "select idCobro, idContacto, idFactura, fechaPrevista, fechaReal, descripcion, importe from t_cobro where idContacto=" + idContactoP;
            sql += " order by fechaPrevista desc, idContacto asc";
            return getDataTable_base(sql);
        }

        public static DataTable getDataTable_deFactura(Int32 idFacturaP)
        {
            string sql = "select idCobro, idContacto, idFactura, fechaPrevista, fechaReal, descripcion, importe from t_cobro where idFactura=" + idFacturaP;
            sql += " order by fechaPrevista desc, idContacto asc";
            return getDataTable_base(sql);
        }

        private static DataTable getDataTable_base(string sql)
        {
            DataTable t = getDataTableVacia();
            DataTable tSql;
            try { tSql = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Cobro.getDataTable_base.Exception: " + ex.Message); tSql = null; }
            if (tSql != null)
                foreach (DataRow r in tSql.Rows)
                {
                    t.Rows.Add(new Cobro(r.ItemArray).getInstanciaLikeARow());
                }
            return t;
        }

        #endregion 



        public static double getSumaImportesDeCobrosDeFactura(Int32 idFactura)
        {
            double suma = 0.0;
            string sql = "select sum(importe) from t_cobro where idFactura=" + idFactura;
            try { suma = LT48.Conversiones.toDouble(DB.getValue_conReintento(sql, "Cobro.getSumaImportesDeCobrosDeFactura.Exception.Re: ")); }
            catch (Exception ex) { Log.log("Cobro.getSumaImportesDeCobrosDeFactura.Exception: " + ex.Message); }
            return suma;
        }

    } // end class
} // end namespace
