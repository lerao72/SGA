using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LT48;

namespace BC.Compras
{
    public class Pago
    {
        #region Zona generada automaticamente

        private Int32 _idPago;
        private Int32 _idContacto;
        private Int32 _serie;
        private string _patronSerie;
        private string _fechaPrevista;
        private string _fechaReal;
        private string _tipo;
        private string _descripcion;
        private Double _importe;
        private bool _autopagable;
        private bool _persistente; private bool _persistenteAlCargar;

        public bool _datoCargado = false;



        public Pago() { inicializa(); }
        public Pago(object[] o) { instanciaFromVector(o); }
        public Pago(Int32 id) { carga(id); }



        public Int32 getIdPago() { return _idPago; }
        public void setIdPago(Int32 valor) { _idPago = valor; }

        public Int32 getIdContacto() { return _idContacto; }
        public void setIdContacto(Int32 valor) { _idContacto = valor; }

        public Int32 getSerie() { return _serie; }
        public void setSerie(Int32 valor) { _serie = valor; }

        public string getPatronSerie() { return _patronSerie; }
        public void setPatronSerie(string valor) { _patronSerie = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 4); }

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
                _fechaReal = Conversiones.toFechaUniversal(valor);
            else
                _fechaReal = "";
        }
        public string getFechaRealAsString() { return _fechaReal == "" ? _fechaReal : Conversiones.fechaUniversal_to_fechaESP(_fechaReal); }
        public DateTime getFechaRealAsDateTime() { return _fechaReal == "" ? DateTime.Now : Conversiones.fechaUniversal_to_DateTime(_fechaReal); }

        public string getTipo() { return _tipo; }
        public void setTipo(string valor) { _tipo = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 20).ToUpper(); }

        public string getDescripcion() { return _descripcion; }
        public void setDescripcion(string valor) { _descripcion = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 50); }

        public double getImporte() { return _importe; }
        public void setImporte(double valor) { _importe = valor; }

        public bool getAutopagable() { return _autopagable; }
        public void setAutopagable(object valor) { _autopagable = Conversiones.objectToBool(valor); }

        public bool getPersistente() { return _persistente; }
        public void setPersistente(object valor) { _persistente = Conversiones.objectToBool(valor); }




        public void inicializa()
        {
            _idPago = -1;
            _idContacto = -1;
            _serie = -1;
            _patronSerie = "01#a";
            _fechaPrevista = "";
            _fechaReal = "";
            _tipo = "";
            _descripcion = "";
            _importe = 0.0;
            _autopagable = false;
            _persistente = false;

            _datoCargado = false;
        }

        public void instanciaFromVector(object[] o)
        {
            setIdPago(Conversiones.toInt(o[0]));
            setIdContacto(Conversiones.toInt(o[1]));
            setSerie(Conversiones.toInt(o[2]));
            setPatronSerie(Conversiones.toString(o[3]));
            setFechaPrevista(o[4]);
            setFechaReal(o[5]);
            setTipo(Conversiones.toString(o[6]));
            setDescripcion(Conversiones.toString(o[7]));
            setImporte(Conversiones.toDouble(o[8]));
            setAutopagable(o[9]);
            setPersistente(o[10]);
            _persistenteAlCargar = getPersistente();
            try { _datoCargado = (bool)o[11]; }
            catch { _datoCargado = true; }
        }

        public object[] getInstanciaLikeARow()
        {
            object[] o = new object[12];
            o[0] = getIdPago();
            o[1] = getIdContacto();
            o[2] = getSerie();
            o[3] = getPatronSerie();
            o[4] = getFechaPrevistaAsString();
            o[5] = getFechaRealAsString();
            o[6] = getTipo();
            o[7] = getDescripcion();
            o[8] = getImporte();
            o[9] = getAutopagable();
            o[10] = getPersistente();

            o[11] = _datoCargado;
            // Ojo con el tamaño del vector

            return o;
        }

        public void carga(Int32 id)
        {
            string sql = "select idPago, idContacto, serie, patronSerie, fechaPrevista, fechaReal, tipo, descripcion, importe, autopagable, persistente from t_pago where idPago=" + id;
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Pago.carga.Exception: " + ex.Message); t = null; }
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
            bool esNuevo = !_datoCargado;
            if (!_datoCargado)
            {
                _idPago = DB.nextValue_conReintento("idPago", "t_pago", "Pago.guarda.Exception.Re1: ");
                sql = "insert into t_pago(idPago, idContacto, serie, patronSerie, fechaPrevista, fechaReal, tipo, descripcion, importe, autopagable, persistente) values(";
                sql += _idPago;
                sql += ", " + _idContacto;
                sql += ", " + _serie;
                sql += ", '" + _patronSerie + "'";
                sql += ", '" + _fechaPrevista + "'";
                sql += ", '" + _fechaReal + "'";
                sql += ", '" + _tipo + "'";
                sql += ", '" + _descripcion + "'";
                sql += ", " + _importe.ToString().Replace(",", ".");
                sql += ", '" + (_autopagable ? "s" : "n") + "'";
                sql += ", '" + (_persistente ? "s" : "n") + "'";
                sql += ")";
            }
            else
            {
                sql = "update t_pago set ";
                sql += "idContacto=" + _idContacto;
                sql += ", serie=" + _serie;
                sql += ", patronSerie='" + _patronSerie + "'";
                sql += ", fechaPrevista='" + _fechaPrevista + "'";
                sql += ", fechaReal='" + _fechaReal + "'";
                sql += ", tipo='" + _tipo + "'";
                sql += ", descripcion='" + _descripcion + "'";
                sql += ", importe=" + _importe.ToString().Replace(",", ".");
                sql += ", autopagable='" + (_autopagable ? "s" : "n") + "'";
                sql += ", persistente='" + (_persistente ? "s" : "n") + "'";
                sql += " where idPago=" + _idPago;
            }
            try { DB.ejecutaSQL_conReintento(sql, "Pago.guarda.Exception.Re2: "); _datoCargado = true; }
            catch (Exception ex) { Log.log("Pago.guarda.Exception: " + ex.Message); }

            // Si lo que estamos haciendo es modificar el dato y el valor de persistente difiere
            // de lo que había al cargar, se lanza el proceso de refrescarPersistente para que se
            // pueda avisar cuando no queden pagos pendientes (o no)
            if (!esNuevo && _persistenteAlCargar != _persistente)
                refrescaPersistente();
        }

        public void borra()
        {
            Pago.borra(_idPago);
            _datoCargado = false;
        }

        public static void borra(Int32 idPagoBorrar)
        {
            string sql = "delete from t_pago where idPago=" + idPagoBorrar;
            borra_sub(sql);
        }

        private static void borra_sub(string sql)
        {
            try { DB.ejecutaSQL_CCP(sql); }
            catch (Exception ex) { Log.log("Pago.borra.Exception: " + ex.Message); }
        }

        private void refrescaPersistente()
        {
            string sql = "update t_pago set persistente='" + (_persistente ? "s" : "n") + "'";
            sql += " where serie=" + _serie;
            try { DB.ejecutaSQL_CCP(sql); }
            catch (Exception ex) { Log.log("Pago.refrescaPersistente.Exception: " + ex.Message); }
        }

        public static DataTable getDataTableVacia()
        {
            DataTable t = new DataTable();
            t.Columns.Add("idPago", typeof(Int32));
            t.Columns.Add("idContacto", typeof(Int32));
            t.Columns.Add("serie", typeof(Int32));
            t.Columns.Add("patronSerie", typeof(string));
            t.Columns.Add("fechaPrevista", typeof(string));
            t.Columns.Add("fechaReal", typeof(string));
            t.Columns.Add("tipo", typeof(string));
            t.Columns.Add("descripcion", typeof(string));
            t.Columns.Add("importe", typeof(Double));
            t.Columns.Add("autopagable", typeof(bool));
            t.Columns.Add("persistente", typeof(bool));
            t.Columns.Add("datoCargado", typeof(bool));
            return t;
        }

        public static DataTable getDataTable(Int32 idContactoP)
        {
            DataTable t = getDataTableVacia();
            DataTable tSql;
            string sql = "select idPago, idContacto, serie, patronSerie, fechaPrevista, fechaReal, tipo, descripcion, importe, autopagable, persistente from t_pago where idContacto=" + idContactoP;
            try { tSql = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Pago.getDataTable.Exception: " + ex.Message); tSql = null; }
            if (tSql != null)
                foreach (DataRow r in tSql.Rows)
                {
                    t.Rows.Add(new Pago(r.ItemArray).getInstanciaLikeARow());
                }
            return t;
        }

        #endregion 



        public static Pago[] getPagosDeSerie(Int32 serie)
        {
            DataTable tSql;
            string sql = "select idPago, idContacto, serie, patronSerie, fechaPrevista, fechaReal, tipo, descripcion, importe, autopagable, persistente from t_pago where serie=" + serie;
            sql += " order by fechaPrevista asc, idPago asc";
            try { tSql = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Pago.getDataTablePagosDeSerie.Exception: " + ex.Message); tSql = null; }

            Pago[] v_pagos;
            if (tSql != null && tSql.Rows.Count > 0)
            {
                Int32 numFilas = tSql.Rows.Count;
                v_pagos = new Pago[numFilas];
                for (Int32 i = 0; i < numFilas; i++)
                    v_pagos[i] = new Pago(tSql.Rows[i].ItemArray);
            }
            else
                v_pagos = null;

            return v_pagos;
        }

        /// <summary>
        /// Dado un pago y un vector de pagos, nos devuelve la posición del pago en el vector. Si no se encuentra
        /// devuelve -1
        /// </summary>
        public static Int32 getIndiceDe(Pago pagoBuscar, Pago[] v_pagos_ordenado)
        {
            Int32 i = 0;
            Int32 numElementos = v_pagos_ordenado.Length;
            bool encontrado = false;
            while (!encontrado && i < numElementos)
            {
                encontrado = pagoBuscar.getIdPago() == v_pagos_ordenado[i].getIdPago();
                if (!encontrado)
                    i++;
            }
            return encontrado ? i : -1;
        }


        
        public static DataTable getDataTableTiposSugeridos(bool incluirCualquiera)
        {
            DataTable t;
            string sql = "select distinct tipo from t_pago order by tipo asc";
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex)
            {
                Log.log("Pago.getDataTableTiposSugeridos.Exception: " + ex.Message);
                t = new DataTable();
                t.Columns.Add("tipo", typeof(string));
            }

            if (incluirCualquiera)
            {
                t.Rows.InsertAt(t.NewRow(), 0);
                object[] o = { "Cualquiera" };
                t.Rows[0].ItemArray = o;
            }

            return t;
        }



        public static Pago getACopyOf(Pago inicial)
        {
            Pago copia = new Pago(inicial.getInstanciaLikeARow());
            
            copia.setIdPago(-1);
            copia._datoCargado = false;

            return copia;
        }



        public static void borraSerie_toda(Pago pagoP)
        {
            if (pagoP.getSerie() != -1)
            {
                string sql = "delete from t_pago where serie=" + pagoP.getSerie();
                borra_sub(sql);
            }
        }

        public static void borraSerie_anteriorA(Pago pagoP, bool pagoPIncluido)
        {
            if (pagoP.getSerie() != -1)
            {
                string sql = "delete from t_pago where serie=" + pagoP.getSerie();
                sql += " and (fechaPrevista<'" + pagoP.getFechaPrevista() + "'";
                if (pagoPIncluido)
                    sql += " or idPago=" + pagoP.getIdPago();
                sql += ")";
                borra_sub(sql);
            }
        }

        public static void borraSerie_posteriorA(Pago pagoP, bool pagoPIncluido)
        {
            if (pagoP.getSerie() != -1)
            {
                string sql = "delete from t_pago where serie=" + pagoP.getSerie();
                sql += " and (fechaPrevista>'" + pagoP.getFechaPrevista() + "'";
                if (pagoPIncluido)
                    sql += " or idPago=" + pagoP.getIdPago();
                sql += ")";
                borra_sub(sql);
            }
        }



        public static void actualizarAutoPagos()
        {
            string fechaHoy = DateTime.Now.ToString("yyyyMMdd");
            string sql = "update t_pago set fechaReal=fechaPrevista";
            sql += " where autopagable='s' and fechaReal='' and fechaPrevista<='" + fechaHoy + "'";

            try { DB.ejecutaSQL_CCP(sql); }
            catch (Exception ex) { Log.log("Pagos.actualizarAutoPagos.Exception: " + ex.Message); }
        }

        public static Pago[] getPagosPersistentesSinPagosPendientes()
        {
            string sqlAux = "select max(idPago) from t_pago where persistente='s' and serie<>-1 and serie not in (select distinct serie from t_pago where persistente='s' and fechaReal='')";
            string sql = "select idPago, idContacto, serie, patronSerie, fechaPrevista, fechaReal, tipo, descripcion, importe, autopagable, persistente from t_pago";
            sql += " where idPago in (" + sqlAux + ")";

            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Pagos.getPagosPersistentesSinPagosPendientes.Exception: " + ex.Message); t = null; }

            if (t != null && t.Rows.Count > 0)
            {
                Pago[] v_pagos = new Pago[t.Rows.Count];
                for (int i = 0; i < t.Rows.Count; i++)
                    v_pagos[i] = new Pago(t.Rows[i].ItemArray);

                return v_pagos;
            }
            else
                return null;
        }

    } // end class
} // end namespace
