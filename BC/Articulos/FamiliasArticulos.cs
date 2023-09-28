using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LT48;

namespace BC.Articulos
{
    public class FamiliasArticulos
    {
        #region Zona generada automaticamente

        private Int32 _idFamiliaArticulo;
        private string _nombre;

        public bool _datoCargado = false;



        public FamiliasArticulos() { inicializa(); }
        public FamiliasArticulos(object[] o) { instanciaFromVector(o); }
        public FamiliasArticulos(Int32 id) { carga(id); }



        public Int32 getIdFamiliaArticulo() { return _idFamiliaArticulo; }
        public void setIdFamiliaArticulo(Int32 valor) { _idFamiliaArticulo = valor; }

        public string getNombre() { return _nombre; }
        public void setNombre(string valor) { _nombre = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 50); }




        public void inicializa()
        {
            _idFamiliaArticulo = -1;
            _nombre = "";

            _datoCargado = false;
        }

        public void instanciaFromVector(object[] o)
        {
            setIdFamiliaArticulo(Conversiones.toInt(o[0]));
            setNombre(Conversiones.toString(o[1]));
            try { _datoCargado = (bool)o[2]; }
            catch { _datoCargado = true; }
        }

        public object[] getInstanciaLikeARow()
        {
            object[] o = new object[3];
            o[0] = getIdFamiliaArticulo();
            o[1] = getNombre();

            o[2] = _datoCargado;
            // Ojo con el tamaño del vector

            return o;
        }

        public void carga(Int32 id)
        {
            string sql = "select idFamiliaArticulo, nombre from t_familiasArticulos where idFamiliaArticulo=" + id;
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("FamiliasArticulos.carga.Exception: " + ex.Message); t = null; }
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
                _idFamiliaArticulo = DB.nextValue_conReintento("idFamiliaArticulo", "t_familiasArticulos", "FamiliasArticulos.guarda.Exception.Re1: ");
                sql = "insert into t_familiasArticulos(idFamiliaArticulo, nombre) values(";
                sql += _idFamiliaArticulo;
                sql += ", '" + _nombre + "'";
                sql += ")";
            }
            else
            {
                sql = "update t_familiasArticulos set ";
                sql += "nombre='" + _nombre + "'";
                sql += " where idFamiliaArticulo=" + _idFamiliaArticulo;
            }
            try { DB.ejecutaSQL_conReintento(sql, "FamiliasArticulos.guarda.Exception.Re2: "); _datoCargado = true; }
            catch (Exception ex) { Log.log("FamiliasArticulos.guarda.Exception: " + ex.Message); }
        }

        public static DataTable getDataTableVacia()
        {
            DataTable t = new DataTable();
            t.Columns.Add("idFamiliaArticulo", typeof(Int32));
            t.Columns.Add("nombre", typeof(string));
            t.Columns.Add("datoCargado", typeof(bool));
            return t;
        }

        public static DataTable getDataTable(string nombreP)
        {
            DataTable t = getDataTableVacia();
            DataTable tSql;
            string sql = "select idFamiliaArticulo, nombre from t_familiasArticulos where nombre='" + nombreP + "'";
            try { tSql = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("FamiliasArticulos.getDataTable.Exception: " + ex.Message); tSql = null; }
            if (tSql != null)
                foreach (DataRow r in tSql.Rows)
                {
                    t.Rows.Add(new FamiliasArticulos(r.ItemArray).getInstanciaLikeARow());
                }
            return t;
        }

        #endregion 

        public static Int32 FormVariasOpcionesFamiliasArticulos(Int32 idArticuloP, bool paraAniadir)
        {
            BC.FormVariasOpciones w = new BC.FormVariasOpciones("Indique familia");

            string sql;
            if (paraAniadir)
            {
                sql = "select idFamiliaArticulo, nombre from t_familiasArticulos";
                sql += " where idFamiliaArticulo not in(";
                sql += " select idFamiliaArticulo from t_rel_familiasArticulos where idArticulo=" + idArticuloP;
                sql += ") order by nombre asc";
            }
            else
            {
                sql = "select r.idFamiliaArticulo, f.nombre from t_rel_familiasArticulos r";
                sql += " left join t_familiasArticulos f on r.idFamiliaArticulo=f.idFamiliaArticulo";
                sql += " where r.idArticulo=" + idArticuloP;
                sql += " order by nombre asc";
            }

            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("FamiliasArticulos.FormVariasOpcionesFamiliasArticulos.Exception: " + ex.Message); t = null; }

            if (t != null && t.Rows.Count > 0)
                foreach (DataRow r in t.Rows)
                    w.addOpcion(
                        Conversiones.toInt(r.ItemArray[0]),
                        r.ItemArray[1].ToString()
                        );

            if (w.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return w.getSelectedValue();
            else
                return -1;
        }
    } // end class
} // end namespace
