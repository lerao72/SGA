using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LT48;

namespace BC.Contactos
{
    public class DatosContacto
    {
        #region Zona generada automaticamente

        private Int32 _idDatoContacto;
        private Int32 _idContacto;
        private Int32 _tipo;
        private string _dato;
        private string _nombre;
        private string _cargo;
        private string _observaciones;

        public bool _datoCargado = false;



        public DatosContacto() { inicializa(); }
        public DatosContacto(object[] o) { instanciaFromVector(o); }
        public DatosContacto(Int32 id) { carga(id); }



        public Int32 getIdDatoContacto() { return _idDatoContacto; }
        public void setIdDatoContacto(Int32 valor) { _idDatoContacto = valor; }

        public Int32 getIdContacto() { return _idContacto; }
        public void setIdContacto(Int32 valor) { _idContacto = valor; }

        public Int32 getTipo() { return _tipo; }
        //public void setTipo(Int32 valor) { _tipo = valor; }
        public void setTipo(object valor) { _tipo = getTipoAsIntFromObject(valor); }

        public string getDato() { return _dato; }
        public void setDato(string valor) { _dato = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 255); }

        public string getNombre() { return _nombre; }
        public void setNombre(string valor) { _nombre = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 100); }

        public string getCargo() { return _cargo; }
        public void setCargo(string valor) { _cargo = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 50); }

        public string getObservaciones() { return _observaciones; }
        public void setObservaciones(string valor) { _observaciones = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 255); }




        public void inicializa()
        {
            _idDatoContacto = -1;
            _idContacto = -1;
            _tipo = 0;
            _dato = "";
            _nombre = "";
            _cargo = "";
            _observaciones = "";

            _datoCargado = false;
        }

        public void instanciaFromVector(object[] o)
        {
            setIdDatoContacto(Conversiones.toInt(o[0]));
            setIdContacto(Conversiones.toInt(o[1]));
            setTipo(Conversiones.toInt(o[2]));
            setDato(Conversiones.toString(o[3]));
            setNombre(Conversiones.toString(o[4]));
            setCargo(Conversiones.toString(o[5]));
            setObservaciones(Conversiones.toString(o[6]));
            try { _datoCargado = (bool)o[7]; }
            catch { _datoCargado = true; }
        }

        public object[] getInstanciaLikeARow()
        {
            object[] o = new object[8];
            o[0] = getIdDatoContacto();
            o[1] = getIdContacto();
            //o[2] = getTipo();
            o[2] = DatosContacto.getTipoAsString(getTipo());
            o[3] = getDato();
            o[4] = getNombre();
            o[5] = getCargo();
            o[6] = getObservaciones();

            o[7] = _datoCargado;
            // Ojo con el tamaño del vector

            return o;
        }

        public void carga(Int32 id)
        {
            string sql = "select idDatoContacto, idContacto, tipo, dato, nombre, cargo, observaciones from t_datosContacto where idDatoContacto=" + id;
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("DatosContacto.carga.Exception: " + ex.Message); t = null; }
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
                _idDatoContacto = DB.nextValue_conReintento("idDatoContacto", "t_datosContacto", "DatosContacto.guarda.Exception.re: ");
                sql = "insert into t_datosContacto(idDatoContacto, idContacto, tipo, dato, nombre, cargo, observaciones) values(";
                sql += _idDatoContacto;
                sql += ", " + _idContacto;
                sql += ", " + _tipo;
                sql += ", '" + _dato + "'";
                sql += ", '" + _nombre + "'";
                sql += ", '" + _cargo + "'";
                sql += ", '" + _observaciones + "'";
                sql += ")";
            }
            else
            {
                sql = "update t_datosContacto set ";
                sql += "idContacto=" + _idContacto;
                sql += ", tipo=" + _tipo;
                sql += ", dato='" + _dato + "'";
                sql += ", nombre='" + _nombre + "'";
                sql += ", cargo='" + _cargo + "'";
                sql += ", observaciones='" + _observaciones + "'";
                sql += " where idDatoContacto=" + _idDatoContacto;
            }
            try { DB.ejecutaSQL_conReintento(sql, "DatosContacto.guarda.Exception.re: "); _datoCargado = true; }
            catch (Exception ex) { Log.log("DatosContacto.guarda.Exception: " + ex.Message); }
        }

        public void borra() { borra(_idDatoContacto); }

        public static void borra(Int32 idDatoContactoBorrar)
        {
            string sql = "delete from t_datosContacto where idDatoContacto=" + idDatoContactoBorrar;
            try { DB.ejecutaSQL_CCP(sql); }
            catch (Exception ex) { Log.log("DatosContacto.borra.Exception: " + ex.Message); }
        }

        public static DataTable getDataTableVacia()
        {
            DataTable t = new DataTable();
            t.Columns.Add("idDatoContacto", typeof(Int32));
            t.Columns.Add("idContacto", typeof(Int32));
            //t.Columns.Add("tipo", typeof(Int32));
            t.Columns.Add("tipo", typeof(string));
            t.Columns.Add("dato", typeof(string));
            t.Columns.Add("nombre", typeof(string));
            t.Columns.Add("cargo", typeof(string));
            t.Columns.Add("observaciones", typeof(string));
            t.Columns.Add("datoCargado", typeof(bool));
            return t;
        }

        public static DataTable getDataTable(Int32 idContactoP, Int32 tipoP)
        {
            DataTable t = getDataTableVacia();
            DataTable tSql;
            string sql = "select idDatoContacto, idContacto, tipo, dato, nombre, cargo, observaciones from t_datosContacto where idContacto=" + idContactoP;
            sql += " and tipo=" + tipoP;
            try { tSql = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("DatosContacto.getDataTable.Exception: " + ex.Message); tSql = null; }
            if (tSql != null)
                foreach (DataRow r in tSql.Rows)
                {
                    t.Rows.Add(new DatosContacto(r.ItemArray).getInstanciaLikeARow());
                }
            return t;
        }

        #endregion 

        public enum Tipo { no_determinado, telefono, email, web };

        public static int getTipoAsInt(Tipo vTipo)
        {
            return (int)vTipo;
        }
        public static int getTipoAsInt(string tipo)
        {
            tipo = tipo.Replace("é", "e").Replace(" ", "_").Replace("-","").ToLower();
            Tipo vtipo;
            try { vtipo = (Tipo)Enum.Parse(typeof(Tipo), tipo); }
            catch { vtipo = Tipo.no_determinado; }

            return getTipoAsInt(vtipo);
        }
        public static int getTipoAsIntFromObject(object vTipo)
        {
            int tipoDevolver;
            try
            {
                if (vTipo.GetType() == typeof(string))
                    tipoDevolver = DatosContacto.getTipoAsInt(vTipo.ToString());
                else if (vTipo.GetType() == typeof(DatosContacto.Tipo))
                    tipoDevolver = DatosContacto.getTipoAsInt((DatosContacto.Tipo)vTipo);
                else
                    tipoDevolver = (Int32)vTipo;
            }
            catch { tipoDevolver = 0; }
            return tipoDevolver;
        }
        public static string getTipoAsString(Tipo vTipo)
        {
            return getTipoAsString((int)vTipo);
        }
        public static string getTipoAsString(int vTipo)
        {
            string[] v = { "No determinado", "Teléfono", "e-mail", "Web" };
            return v[vTipo];
        }

        public static Int32 FormVariasOpcionesTipo(Int32 valorInicial)
        {
            Int32 vi = valorInicial >= 0 & valorInicial <= 3 ? valorInicial : 0;

            BC.FormVariasOpciones w = new BC.FormVariasOpciones("Indique modo");
            w.addOpcion((int)BC.Contactos.DatosContacto.Tipo.no_determinado, "No determinado");
            w.addOpcion((int)BC.Contactos.DatosContacto.Tipo.telefono, "Teléfono");
            w.addOpcion((int)BC.Contactos.DatosContacto.Tipo.email, "e-mail");
            w.addOpcion((int)BC.Contactos.DatosContacto.Tipo.web, "Web");

            w.setSelectedValue(vi);

            if (w.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return w.getSelectedValue();
            else
                return vi;
        }


    } // end class
} // end namespace
