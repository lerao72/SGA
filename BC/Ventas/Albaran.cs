using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LT48;

namespace BC.Ventas
{
    public class Albaran
    {
        #region Zona generada automaticamente

        private Int32 _idAlbaran;
        private Int32 _idContacto;
        private string _fecha;
        private Int32 _anio; private Int32 _anioAlCargar;
        private Int32 _numero;
        private Double _pvp;
        private Double _sumaIVA;
        private string _observaciones;
        private Int32 _idFactura;

        public bool _datoCargado = false;

        public DataTable _t_albaranA;



        public Albaran() { inicializa(); }
        public Albaran(object[] o) { instanciaFromVector(o); }
        public Albaran(Int32 id) { carga(id); }



        public Int32 getIdAlbaran() { return _idAlbaran; }
        public void setIdAlbaran(Int32 valor) { _idAlbaran = valor; }

        public Int32 getIdContacto() { return _idContacto; }
        public void setIdContacto(Int32 valor) { _idContacto = valor; }

        public string getFecha() { return _fecha; }
        public void setFecha(object valor)
        {
            if (valor.ToString() != "")
                _fecha = Conversiones.toFechaUniversal(valor);
            else
                _fecha = "";
        }
        public string getFechaAsString() { return _fecha == "" ? _fecha : Conversiones.fechaUniversal_to_fechaESP(_fecha); }
        public DateTime getFechaAsDateTime() { return _fecha == "" ? DateTime.Now : Conversiones.fechaUniversal_to_DateTime(_fecha); }
        
        public Int32 getAnio() { return _anio; }
        public void setAnio(Int32 valor) { _anio = valor; }

        public Int32 getNumero() { return _numero; }
        public void setNumero(Int32 valor) { _numero = valor; }

        public double getPvp() { return _pvp; }
        public void setPvp(double valor) { _pvp = valor; }

        public double getSumaIVA() { return _sumaIVA; }
        public void setSumaIVA(double valor) { _sumaIVA = valor; }

        public string getObservaciones() { return _observaciones; }
        public void setObservaciones(string valor) { _observaciones = Conversiones.quitarComillas(valor); }

        public Int32 getIdFactura() { return _idFactura; }
        public void setIdFactura(Int32 valor) { _idFactura = valor; }




        public void inicializa()
        {
            _idAlbaran = -1;
            _idContacto = -1;
            _fecha = DateTime.Now.ToString("yyyyMMdd");
            _anio = 0; _anioAlCargar = 0;
            _numero = 0;
            _pvp = 0.0;
            _sumaIVA = 0.0;
            _observaciones = "";
            _idFactura = -1;

            _datoCargado = false;

            _t_albaranA = AlbaranA.getDataTableVacia();
        }

        public void instanciaFromVector(object[] o)
        {
            setIdAlbaran(Conversiones.toInt(o[0]));
            setIdContacto(Conversiones.toInt(o[1]));
            setFecha(o[2]);
            setAnio(Conversiones.toInt(o[3]));
            setNumero(Conversiones.toInt(o[4]));
            setPvp(Conversiones.toDouble(o[5]));
            setSumaIVA(Conversiones.toDouble(o[6]));
            setObservaciones(Conversiones.toString(o[7]));
            setIdFactura(Conversiones.toIntWN(o[8]));
            try { _datoCargado = (bool)o[9]; }
            catch { _datoCargado = true; }

            if (_datoCargado)
                _anioAlCargar = getAnio();
            else
                _anioAlCargar = 0;

            if (_idAlbaran != -1)
                _t_albaranA = AlbaranA.getDataTable(_idAlbaran);
            else
                _t_albaranA = AlbaranA.getDataTableVacia();
        }

        public object[] getInstanciaLikeARow()
        {
            object[] o = new object[10];
            o[0] = getIdAlbaran();
            o[1] = getIdContacto();
            o[2] = getFechaAsString();
            o[3] = getAnio();
            o[4] = getNumero();
            o[5] = getPvp();
            o[6] = getSumaIVA();
            o[7] = getObservaciones();
            o[8] = getIdFactura();

            o[9] = _datoCargado;
            // Ojo con el tamaño del vector

            return o;
        }

        public void carga(Int32 id)
        {
            string sql = "select idAlbaran, idContacto, fecha, anio, numero, pvp, sumaIVA, observaciones, idFactura from t_albaran where idAlbaran=" + id;
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Albaran.carga.Exception: " + ex.Message); t = null; }
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
                _idAlbaran = DB.nextValue_conReintento("idAlbaran", "t_albaran", "Albaran.guarda.Exception.Re1: ");
                sql = "insert into t_albaran(idAlbaran, idContacto, fecha, anio, numero, pvp, sumaIVA, observaciones, idFactura) values(";
                sql += _idAlbaran;
                sql += ", " + _idContacto;
                sql += ", '" + _fecha + "'";
                sql += ", " + _anio;
                sql += ", " + _numero;
                sql += ", " + _pvp.ToString().Replace(",", ".");
                sql += ", " + _sumaIVA.ToString().Replace(",", ".");
                sql += ", '" + _observaciones + "'";
                sql += ", " + _idFactura;
                sql += ")";
            }
            else
            {
                sql = "update t_albaran set ";
                sql += "idContacto=" + _idContacto;
                sql += ", fecha='" + _fecha + "'";
                sql += ", anio=" + _anio;
                sql += ", numero=" + _numero;
                sql += ", pvp=" + _pvp.ToString().Replace(",", ".");
                sql += ", sumaIVA=" + _sumaIVA.ToString().Replace(",", ".");
                sql += ", observaciones='" + _observaciones + "'";
                sql += ", idFactura=" + _idFactura;
                sql += " where idAlbaran=" + _idAlbaran;
            }
            try { DB.ejecutaSQL_conReintento(sql, "Albaran.guarda.Exception.Re2: "); _datoCargado = true; }
            catch (Exception ex) { Log.log("Albaran.guarda.Exception: " + ex.Message); }

            if (_datoCargado)
                guardarLineas();
        }

        private void guardarLineas()
        {
            foreach (DataRow r in _t_albaranA.Rows)
            {
                AlbaranA linea = new AlbaranA(r.ItemArray);
                linea.setIdAlbaran(_idAlbaran);
                linea.guarda();
                r.ItemArray = linea.getInstanciaLikeARow();
            }
        }

        public static DataTable getDataTableVacia()
        {
            DataTable t = new DataTable();
            t.Columns.Add("idAlbaran", typeof(Int32));
            t.Columns.Add("idContacto", typeof(Int32));
            t.Columns.Add("fecha", typeof(string));
            t.Columns.Add("anio", typeof(Int32));
            t.Columns.Add("numero", typeof(Int32));
            t.Columns.Add("pvp", typeof(Double));
            t.Columns.Add("sumaIVA", typeof(Double));
            t.Columns.Add("observaciones", typeof(string));
            t.Columns.Add("idFactura", typeof(Int32));
            t.Columns.Add("datoCargado", typeof(bool));
            return t;
        }

        public static DataTable getDataTableAlbaranesDeFactura(Int32 idFacturaP)
        {
            DataTable t = getDataTableVacia();
            DataTable tSql;
            
            string sql = "select idAlbaran, idContacto, fecha, anio, numero, pvp, sumaIVA, observaciones, idFactura from t_albaran where idFactura=" + idFacturaP;
            try { tSql = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Albaran.getDataTable.Exception: " + ex.Message); tSql = null; }
            
            if (tSql != null)
                foreach (DataRow r in tSql.Rows)
                    t.Rows.Add(new Albaran(r.ItemArray).getInstanciaLikeARow());

            return t;
        }

        #endregion 



        public void generaNumero(Int32 anioPoner)
        {
            if (_anioAlCargar == 0 && _numero == 0 && _datoCargado)
            {
                string sql = "select max(numero), count(*) from t_albaran where anio=" + anioPoner;
                Int32 nuevoNumero, cuenta;
                try
                {
                    DataTable t = DB.getDataTable_CCP(sql);
                    nuevoNumero = Conversiones.toIntWN(t.Rows[0].ItemArray[0]);
                    cuenta = Conversiones.toIntWN(t.Rows[0].ItemArray[1]);
                }
                catch (Exception ex) { Log.log("Albaran.generaNumero.Exception: " + ex.Message); nuevoNumero = -1; cuenta = 0; }

                if (cuenta == 0)
                    nuevoNumero = 1;
                else
                    nuevoNumero = nuevoNumero == -1 ? 1 : nuevoNumero + 1;

                if (nuevoNumero != -1)
                {
                    setAnio(anioPoner);
                    setNumero(nuevoNumero);
                    guarda();
                    _anioAlCargar = anioPoner;

                    ajustaStock();
                }
            }
        }

        private void ajustaStock()
        {
            foreach (DataRow r in _t_albaranA.Rows)
            {
                Ventas.AlbaranA _linea = new AlbaranA(r.ItemArray);
                if (_linea.getIdArticulo() != -1)
                    BC.Articulos.Articulos.restaCantidadAStock(_linea.getIdArticulo(), _linea.getCantidad());
            }
        }

    } // end class
} // end namespace
