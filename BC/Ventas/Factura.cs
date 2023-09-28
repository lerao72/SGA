using System;
using System.Collections.Generic;
using System.Text;
using LT48;
using System.Data;

namespace BC.Ventas
{
    public class Factura
    {
        #region Zona generada automaticamente

        private Int32 _idFactura;
        private Int32 _idContacto;
        private string _fecha;
        private Int32 _anio; private Int32 _anioAlCargar;
        private Int32 _numero;
        private Double _pvp;
        private Double _sumaIVA;
        private string _observaciones;

        public bool _datoCargado = false;

        public DataTable _t_albaran;
        public DataTable _t_albaranA;



        public Factura() { inicializa(); }
        public Factura(object[] o) { instanciaFromVector(o); }
        public Factura(Int32 id) { carga(id); }



        public Int32 getIdFactura() { return _idFactura; }
        public void setIdFactura(Int32 valor) { _idFactura = valor; }

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




        public void inicializa()
        {
            _idFactura = -1;
            _idContacto = -1;
            _fecha = DateTime.Now.ToString("yyyyMMdd");
            _anio = 0; _anioAlCargar = 0;
            _numero = 0;
            _pvp = 0.0;
            _sumaIVA = 0.0;
            _observaciones = "";

            _datoCargado = false;

            _t_albaran = Albaran.getDataTableVacia();
            _t_albaranA = AlbaranA.getDataTableVacia();
        }

        public void instanciaFromVector(object[] o)
        {
            setIdFactura(Conversiones.toInt(o[0]));
            setIdContacto(Conversiones.toInt(o[1]));
            setFecha(o[2]);
            setAnio(Conversiones.toInt(o[3]));
            setNumero(Conversiones.toInt(o[4]));
            setPvp(Conversiones.toDouble(o[5]));
            setSumaIVA(Conversiones.toDouble(o[6]));
            setObservaciones(Conversiones.toString(o[7]));
            try { _datoCargado = (bool)o[8]; }
            catch { _datoCargado = true; }

            if (_datoCargado)
                _anioAlCargar = getAnio();
            else
                _anioAlCargar = 0;

            if (_idFactura != -1)
            {
                _t_albaran = Albaran.getDataTableAlbaranesDeFactura(_idFactura);
                _t_albaranA = AlbaranA.getDataTableDesdeFactura(_idFactura);
            }
            else
            {
                _t_albaran = Albaran.getDataTableVacia();
                _t_albaranA = AlbaranA.getDataTableVacia();
            }
        }

        public object[] getInstanciaLikeARow()
        {
            object[] o = new object[9];
            o[0] = getIdFactura();
            o[1] = getIdContacto();
            o[2] = getFechaAsString();
            o[3] = getAnio();
            o[4] = getNumero();
            o[5] = getPvp();
            o[6] = getSumaIVA();
            o[7] = getObservaciones();

            o[8] = _datoCargado;
            // Ojo con el tamaño del vector

            return o;
        }

        public void carga(Int32 id)
        {
            string sql = "select idFactura, idContacto, fecha, anio, numero, pvp, sumaIVA, observaciones from t_factura where idFactura=" + id;
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Factura.carga.Exception: " + ex.Message); t = null; }
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
                _idFactura = DB.nextValue_conReintento("idFactura", "t_factura", "Factura.guarda.Exception.Re1: ");
                sql = "insert into t_factura(idFactura, idContacto, fecha, anio, numero, pvp, sumaIVA, observaciones) values(";
                sql += _idFactura;
                sql += ", " + _idContacto;
                sql += ", '" + _fecha + "'";
                sql += ", " + _anio;
                sql += ", " + _numero;
                sql += ", " + _pvp.ToString().Replace(",", ".");
                sql += ", " + _sumaIVA.ToString().Replace(",", ".");
                sql += ", '" + _observaciones + "'";
                sql += ")";
            }
            else
            {
                sql = "update t_factura set ";
                sql += "idContacto=" + _idContacto;
                sql += ", fecha='" + _fecha + "'";
                sql += ", anio=" + _anio;
                sql += ", numero=" + _numero;
                sql += ", pvp=" + _pvp.ToString().Replace(",", ".");
                sql += ", sumaIVA=" + _sumaIVA.ToString().Replace(",", ".");
                sql += ", observaciones='" + _observaciones + "'";
                sql += " where idFactura=" + _idFactura;
            }
            try { DB.ejecutaSQL_conReintento(sql, "Factura.guarda.Exception.Re2: "); _datoCargado = true; }
            catch (Exception ex) { Log.log("Factura.guarda.Exception: " + ex.Message); }
            
            if (_datoCargado)
                guardarLineas();
        }

        private void guardarLineas()
        {
            foreach (DataRow r in _t_albaran.Rows)
            {
                Albaran linea = new Albaran(r.ItemArray);
                linea.setIdFactura(_idFactura);
                linea.guarda();
                r.ItemArray = linea.getInstanciaLikeARow();
            }
        }

        public static DataTable getDataTableVacia()
        {
            DataTable t = new DataTable();
            t.Columns.Add("idFactura", typeof(Int32));
            t.Columns.Add("idContacto", typeof(Int32));
            t.Columns.Add("fecha", typeof(string));
            t.Columns.Add("anio", typeof(Int32));
            t.Columns.Add("numero", typeof(Int32));
            t.Columns.Add("pvp", typeof(Double));
            t.Columns.Add("sumaIVA", typeof(Double));
            t.Columns.Add("observaciones", typeof(string));
            t.Columns.Add("datoCargado", typeof(bool));
            return t;
        }

        #endregion 



        public void generaNumero(Int32 anioPoner)
        {
            if (_anioAlCargar == 0 && _numero == 0 && _datoCargado)
            {
                string sql = "select max(numero), count(*) from t_factura where anio=" + anioPoner;
                Int32 nuevoNumero, cuenta;
                try
                {
                    DataTable t = DB.getDataTable_CCP(sql);
                    nuevoNumero = Conversiones.toIntWN(t.Rows[0].ItemArray[0]);
                    cuenta = Conversiones.toIntWN(t.Rows[0].ItemArray[1]);
                }
                catch (Exception ex) { Log.log("Factura.generaNumero.Exception: " + ex.Message); nuevoNumero = -1; cuenta = 0; }

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
                }
            }
        }



        public void addAlbaran(Int32 idAlbaranP)
        {
            bool meter = true;

            // Buscamos si el albarán ya está metido
            if (_t_albaran.Rows.Count > 0)
            {
                Int32 i = 0;
                Int32 numFilas = _t_albaran.Rows.Count;
                int ordIdAlbaran = _t_albaran.Columns["idAlbaran"].Ordinal;

                while (meter && i < numFilas)
                {
                    if (Conversiones.toInt(_t_albaran.Rows[i].ItemArray[ordIdAlbaran]) == idAlbaranP)
                        meter = false;
                    i++;
                }
            }

            if (meter)
            {
                Albaran _albaran = new Albaran(idAlbaranP);
                _albaran.setIdFactura(_idFactura);
                _albaran.guarda();

                // Añadimosel albarán
                _t_albaran.Rows.Add(_albaran.getInstanciaLikeARow());

                // Añadimos los elementos del albarán
                foreach (DataRow r in _albaran._t_albaranA.Rows)
                {
                    AlbaranA _albaranA = new AlbaranA(r.ItemArray);
                    _t_albaranA.Rows.Add(_albaranA.getInstanciaLikeARow());
                }
            } // if (meter)
        }

        public void removeAlbaran(Int32 idAlbaranP)
        {
            System.Collections.ArrayList lista_t_albaran_rows_quitar = new System.Collections.ArrayList();
            System.Collections.ArrayList lista_t_albarana_rows_quitar = new System.Collections.ArrayList();

            Int32 ord_t_albaran_idAlbaran = _t_albaran.Columns["idAlbaran"].Ordinal;
            Int32 ord_t_albaranA_idAlbaran = _t_albaranA.Columns["idAlbaran"].Ordinal;

            // Buscamos la filas del albaran, lo modificamos y las metemos en una lista para borrar posteriormente
            foreach (DataRow r_albaran in _t_albaran.Rows)
                if (Conversiones.toInt(r_albaran.ItemArray[ord_t_albaran_idAlbaran]) == idAlbaranP)
                {
                    Albaran _albaran = new Albaran(r_albaran.ItemArray);
                    _albaran.setIdFactura(-1);
                    _albaran.guarda();

                    lista_t_albaran_rows_quitar.Add(r_albaran);
                }

            // Buscamos las filas de artículos de albaran y las metemos en la lista para borrar posteriormente
            foreach(DataRow r_albaranA in _t_albaranA.Rows)
                if (Conversiones.toInt(r_albaranA.ItemArray[ord_t_albaranA_idAlbaran]) == idAlbaranP)
                    lista_t_albarana_rows_quitar.Add(r_albaranA);

            
            
            // Borramos las filas que hemos metido en las listas
            foreach (DataRow r_albaran_q in lista_t_albaran_rows_quitar)
                try { _t_albaran.Rows.Remove(r_albaran_q); }
                catch { ;}

            foreach (DataRow r_albaranA_q in lista_t_albarana_rows_quitar)
                try { _t_albaranA.Rows.Remove(r_albaranA_q); }
                catch { ;}
        }

    } // end class
} // end namespace
