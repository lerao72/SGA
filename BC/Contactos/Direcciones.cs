using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LT48;

namespace BC.Contactos
{
    public class Direcciones
    {
        #region Zona generada automaticamente

        private Int32 _idDireccion;
        private Int32 _idContacto;
        private Int32 _tipo;
        private string _cp;
        private string _localidad;
        private string _provincia;
        private string _pais;
        private string _direccion;

        public bool _datoCargado = false;



        public Direcciones() { inicializa(); }
        public Direcciones(object[] o) { instanciaFromVector(o); }
        public Direcciones(Int32 id) { carga(id); }



        public Int32 getIdDireccion() { return _idDireccion; }
        public void setIdDireccion(Int32 valor) { _idDireccion = valor; }

        public Int32 getIdContacto() { return _idContacto; }
        public void setIdContacto(Int32 valor) { _idContacto = valor; }

        public Int32 getTipo() { return _tipo; }
        //public void setTipo(Int32 valor) { _tipo = valor; }
        public void setTipo(object valor) { _tipo = getTipoAsIntFromObject(valor); }

        public string getCp() { return _cp; }
        public void setCp(string valor) { _cp = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 10); }

        public string getLocalidad() { return _localidad; }
        public void setLocalidad(string valor) { _localidad = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 100); }

        public string getProvincia() { return _provincia; }
        public void setProvincia(string valor) { _provincia = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 100); }

        public string getPais() { return _pais; }
        public void setPais(string valor) { _pais = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 100); }

        public string getDireccion() { return _direccion; }
        public void setDireccion(string valor) { _direccion = Conversiones.quitarComillas(valor); }




        public void inicializa()
        {
            _idDireccion = -1;
            _idContacto = -1;
            _tipo = 0;
            _cp = "";
            _localidad = "";
            _provincia = "";
            _pais = "";
            _direccion = "";

            _datoCargado = false;
        }

        public void instanciaFromVector(object[] o)
        {
            setIdDireccion(Conversiones.toInt(o[0]));
            setIdContacto(Conversiones.toInt(o[1]));
            //setTipo(Conversiones.toInt(o[2]));
            setTipo(o[2]);
            setCp(Conversiones.toString(o[3]));
            setLocalidad(Conversiones.toString(o[4]));
            setProvincia(Conversiones.toString(o[5]));
            setPais(Conversiones.toString(o[6]));
            setDireccion(Conversiones.toString(o[7]));
            try { _datoCargado = (bool)o[8]; }
            catch { _datoCargado = true; }
        }

        public object[] getInstanciaLikeARow()
        {
            object[] o = new object[9];
            o[0] = getIdDireccion();
            o[1] = getIdContacto();
            //o[2] = getTipo();
            o[2] = Direcciones.getTipoAsString(getTipo());
            o[3] = getCp();
            o[4] = getLocalidad();
            o[5] = getProvincia();
            o[6] = getPais();
            o[7] = getDireccion();

            o[8] = _datoCargado;
            // Ojo con el tamaño del vector

            return o;
        }

        public void carga(Int32 id)
        {
            string sql = "select idDireccion, idContacto, tipo, cp, localidad, provincia, pais, direccion from t_direcciones where idDireccion=" + id;
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Direcciones.carga.Exception: " + ex.Message); t = null; }
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
                _idDireccion = DB.nextValue_conReintento("idDireccion", "t_direcciones", "Direcciones.guarda.Exception.re:" );
                sql = "insert into t_direcciones(idDireccion, idContacto, tipo, cp, localidad, provincia, pais, direccion) values(";
                sql += _idDireccion;
                sql += ", " + _idContacto;
                sql += ", " + _tipo;
                sql += ", '" + _cp + "'";
                sql += ", '" + _localidad + "'";
                sql += ", '" + _provincia + "'";
                sql += ", '" + _pais + "'";
                sql += ", '" + _direccion + "'";
                sql += ")";
            }
            else
            {
                sql = "update t_direcciones set ";
                sql += "idContacto=" + _idContacto;
                sql += ", tipo=" + _tipo;
                sql += ", cp='" + _cp + "'";
                sql += ", localidad='" + _localidad + "'";
                sql += ", provincia='" + _provincia + "'";
                sql += ", pais='" + _pais + "'";
                sql += ", direccion='" + _direccion + "'";
                sql += " where idDireccion=" + _idDireccion;
            }
            try { DB.ejecutaSQL_conReintento(sql, "Direcciones.guarda.Exception.re: "); _datoCargado = true; }
            catch (Exception ex) { Log.log("Direcciones.guarda.Exception: " + ex.Message); }
        }

        public void borra() { borra(_idDireccion); }
        
        public static void borra(Int32 idDireccionBorrar)
        {
            string sql = "delete from t_direcciones where idDireccion=" + idDireccionBorrar;
            try { DB.ejecutaSQL_CCP(sql); }
            catch (Exception ex) { Log.log("Direcciones.borra.Exception: " + ex.Message); }
        }

        public static DataTable getDataTableVacia()
        {
            DataTable t = new DataTable();
            t.Columns.Add("idDireccion", typeof(Int32));
            t.Columns.Add("idContacto", typeof(Int32));
            //t.Columns.Add("tipo", typeof(Int32));
            t.Columns.Add("tipo", typeof(string));
            t.Columns.Add("cp", typeof(string));
            t.Columns.Add("localidad", typeof(string));
            t.Columns.Add("provincia", typeof(string));
            t.Columns.Add("pais", typeof(string));
            t.Columns.Add("direccion", typeof(string));
            t.Columns.Add("datoCargado", typeof(bool));
            return t;
        }

        public static DataTable getDataTable(Int32 idContactoP)
        {
            DataTable t = getDataTableVacia();
            DataTable tSql;
            string sql = "select idDireccion, idContacto, tipo, cp, localidad, provincia, pais, direccion from t_direcciones where idContacto=" + idContactoP;
            try { tSql = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("Direcciones.getDataTable.Exception: " + ex.Message); tSql = null; }
            if (tSql != null)
                foreach (DataRow r in tSql.Rows)
                {
                    t.Rows.Add(new Direcciones(r.ItemArray).getInstanciaLikeARow());
                }
            return t;
        }

        #endregion 

        public enum Tipo { no_determinada, predeterminada, delegacion, almacen, particular };
        public static System.Drawing.Color[] v_color_tipo = { 
                                                                System.Drawing.Color.White,
                                                                System.Drawing.Color.PaleGreen,
                                                                System.Drawing.Color.PaleTurquoise,
                                                                System.Drawing.Color.LightYellow,
                                                                System.Drawing.Color.LightSalmon
                                                            };

        public static int getTipoAsInt(Tipo vTipo)
        {
            return (int)vTipo;
        }
        public static int getTipoAsInt(string tipo)
        {
            tipo = tipo.Replace("ó", "o").Replace("é", "e").Replace(" ", "_").ToLower();
            Tipo vtipo;
            try { vtipo = (Tipo)Enum.Parse(typeof(Tipo), tipo); }
            catch { vtipo = Tipo.no_determinada; }

            return getTipoAsInt(vtipo);
        }
        public static int getTipoAsIntFromObject(object vTipo)
        {
            Int32 tipoDevolver;
            try
            {
                if (vTipo.GetType() == typeof(string))
                    tipoDevolver = Direcciones.getTipoAsInt(vTipo.ToString());
                else if (vTipo.GetType() == typeof(Direcciones.Tipo))
                    tipoDevolver = Direcciones.getTipoAsInt((Direcciones.Tipo)vTipo);
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
            string[] v = { "No determinada", "Predeterminada", "Delegación", "Almacén", "Particular" };
            return v[vTipo];
        }

        public static Int32 FormVariasOpcionesTipo(Int32 valorInicial)
        {
            Int32 vi = valorInicial >= 0 & valorInicial <= 4 ? valorInicial : 0;

            BC.FormVariasOpciones w = new BC.FormVariasOpciones("Indique modo");
            w.addOpcion((int)BC.Contactos.Direcciones.Tipo.no_determinada, "No determinada");
            w.addOpcion((int)BC.Contactos.Direcciones.Tipo.predeterminada, "Predeterminada");
            w.addOpcion((int)BC.Contactos.Direcciones.Tipo.delegacion, "Delegación");
            w.addOpcion((int)BC.Contactos.Direcciones.Tipo.almacen, "Almacén");
            w.addOpcion((int)BC.Contactos.Direcciones.Tipo.particular, "Particular");

            w.setSelectedValue(vi);

            if (w.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return w.getSelectedValue();
            else
                return vi;
        }



        public static Direcciones getDireccionPredeterminadaDe(Int32 idContacto)
        {
            Direcciones aux;

            string sql = "select idDireccion, idContacto, tipo, cp, localidad, provincia, pais, direccion from t_direcciones";
            sql += " where idContacto=" + idContacto;
            string sqlAux = " and tipo=" + getTipoAsInt(Tipo.predeterminada);

            DataTable t;
            try { t = DB.getDataTable_CCP(sql + sqlAux); }
            catch (Exception ex) { Log.log("Direcciones.getDireccionPredeterminadaDe.Exception1: " + ex.Message); t = null; }
            if (t != null && t.Rows.Count > 0)
                aux = new Direcciones(t.Rows[0].ItemArray);
            else
            {
                try { t = DB.getDataTable_CCP(sql); }
                catch (Exception ex) { Log.log("Direcciones.getDireccionPredeterminadaDe.Exception2: " + ex.Message); t = null; }
                if (t != null && t.Rows.Count > 0)
                    aux = new Direcciones(t.Rows[0].ItemArray);
                else
                    aux = new Direcciones();
            }

            return aux;
        }

    } // end class
} // end namespace
