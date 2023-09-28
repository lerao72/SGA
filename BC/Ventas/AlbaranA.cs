using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LT48;

namespace BC.Ventas
{
    public class AlbaranA
    {
        #region Zona generada automaticamente

        private Int32 _idAlbaranA;
        private Int32 _idAlbaran;
        private string _agrupado;
        private Int32 _orden;
        private Int32 _idArticulo;
        private string _codigo;
        private string _nombre;
        private Double _cantidad;
        private Double _pvp_ori;
        private Double _dto;
        private Double _pvpTotal;
        private Double _iva;

        public bool _datoCargado = false;



        public AlbaranA() { inicializa(); }
        public AlbaranA(object[] o) { instanciaFromVector(o); }
        public AlbaranA(Int32 id) { carga(id); }



        public Int32 getIdAlbaranA() { return _idAlbaranA; }
        public void setIdAlbaranA(Int32 valor) { _idAlbaranA = valor; }

        public Int32 getIdAlbaran() { return _idAlbaran; }
        public void setIdAlbaran(Int32 valor) { _idAlbaran = valor; }

        public string getAgrupado() { return _agrupado; }
        public void setAgrupado(string valor) { _agrupado = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 1); }

        public Int32 getOrden() { return _orden; }
        public void setOrden(Int32 valor) { _orden = valor; }

        public Int32 getIdArticulo() { return _idArticulo; }
        public void setIdArticulo(Int32 valor) { _idArticulo = valor; }

        public string getCodigo() { return _codigo; }
        public void setCodigo(string valor) { _codigo = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 25); }

        public string getNombre() { return _nombre; }
        public void setNombre(string valor) { _nombre = Conversiones.getStringWidhtLenghtLessThan(Conversiones.quitarComillas(valor), 255); }

        public double getCantidad() { return _cantidad; }
        public void setCantidad(double valor) { _cantidad = valor; }

        public double getPvp_ori() { return _pvp_ori; }
        public void setPvp_ori(double valor) { _pvp_ori = valor; }

        public double getDto() { return _dto; }
        public void setDto(double valor) { _dto = valor; }

        public double getPvpTotal() { return _pvpTotal; }
        public void setPvpTotal(double valor) { _pvpTotal = valor; }

        public double getIva() { return _iva; }
        public void setIva(double valor) { _iva = valor; }




        public void inicializa()
        {
            _idAlbaranA = -1;
            _idAlbaran = -1;
            _agrupado = "";
            _orden = 1;
            _idArticulo = -1;
            _codigo = "";
            _nombre = "";
            _cantidad = 1.0;
            _pvp_ori = 0.0;
            _dto = 0.0;
            _pvpTotal = 0.0;
            _iva = 0.0;

            _datoCargado = false;
        }

        public void instanciaFromVector(object[] o)
        {
            setIdAlbaranA(Conversiones.toInt(o[0]));
            setIdAlbaran(Conversiones.toInt(o[1]));
            setAgrupado(Conversiones.toString(o[2]));
            setOrden(Conversiones.toInt(o[3]));
            setIdArticulo(Conversiones.toInt(o[4]));
            setCodigo(Conversiones.toString(o[5]));
            setNombre(Conversiones.toString(o[6]));
            setCantidad(Conversiones.toDouble(o[7]));
            setPvp_ori(Conversiones.toDouble(o[8]));
            setDto(Conversiones.toDouble(o[9]));
            setPvpTotal(Conversiones.toDouble(o[10]));
            setIva(Conversiones.toDouble(o[11]));
            try { _datoCargado = (bool)o[12]; }
            catch { _datoCargado = true; }
        }

        public object[] getInstanciaLikeARow()
        {
            object[] o = new object[13];
            o[0] = getIdAlbaranA();
            o[1] = getIdAlbaran();
            o[2] = getAgrupado();
            o[3] = getOrden();
            o[4] = getIdArticulo();
            o[5] = getCodigo();
            o[6] = getNombre();
            o[7] = getCantidad();
            o[8] = getPvp_ori();
            o[9] = getDto();
            o[10] = getPvpTotal();
            o[11] = getIva();

            o[12] = _datoCargado;
            // Ojo con el tamaño del vector

            return o;
        }

        public void carga(Int32 id)
        {
            string sql = "select idAlbaranA, idAlbaran, agrupado, orden, idArticulo, codigo, nombre, cantidad, pvp_ori, dto, pvpTotal, iva from t_albaranA where idAlbaranA=" + id;
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("AlbaranA.carga.Exception: " + ex.Message); t = null; }
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
                _idAlbaranA = DB.nextValue_conReintento("idAlbaranA", "t_albaranA", "AlbaranA.guarda.Exception.Re1: ");
                sql = "insert into t_albaranA(idAlbaranA, idAlbaran, agrupado, orden, idArticulo, codigo, nombre, cantidad, pvp_ori, dto, pvpTotal, iva) values(";
                sql += _idAlbaranA;
                sql += ", " + _idAlbaran;
                sql += ", '" + _agrupado + "'";
                sql += ", " + _orden;
                sql += ", " + _idArticulo;
                sql += ", '" + _codigo + "'";
                sql += ", '" + _nombre + "'";
                sql += ", " + _cantidad.ToString().Replace(",", ".");
                sql += ", " + _pvp_ori.ToString().Replace(",", ".");
                sql += ", " + _dto.ToString().Replace(",", ".");
                sql += ", " + _pvpTotal.ToString().Replace(",", ".");
                sql += ", " + _iva.ToString().Replace(",", ".");
                sql += ")";
            }
            else
            {
                sql = "update t_albaranA set ";
                sql += "idAlbaran=" + _idAlbaran;
                sql += ", agrupado='" + _agrupado + "'";
                sql += ", orden=" + _orden;
                sql += ", idArticulo=" + _idArticulo;
                sql += ", codigo='" + _codigo + "'";
                sql += ", nombre='" + _nombre + "'";
                sql += ", cantidad=" + _cantidad.ToString().Replace(",", ".");
                sql += ", pvp_ori=" + _pvp_ori.ToString().Replace(",", ".");
                sql += ", dto=" + _dto.ToString().Replace(",", ".");
                sql += ", pvpTotal=" + _pvpTotal.ToString().Replace(",", ".");
                sql += ", iva=" + _iva.ToString().Replace(",", ".");
                sql += " where idAlbaranA=" + _idAlbaranA;
            }
            try { DB.ejecutaSQL_conReintento(sql, "AlbaranA.guarda.Exception.Re2: "); _datoCargado = true; }
            catch (Exception ex) { Log.log("AlbaranA.guarda.Exception: " + ex.Message); }
        }

        public void borra()
        {
            borra(_idAlbaranA);
            _datoCargado = false;
        }

        public static void borra(Int32 idAlbaranABorrar)
        {
            string sql = "delete from t_albaranA where idAlbaranA=" + idAlbaranABorrar;
            try { DB.ejecutaSQL_CCP(sql); }
            catch (Exception ex) { Log.log("AlbaranA.borra.Exception: " + ex.Message); }
        }

        public static DataTable getDataTableVacia()
        {
            DataTable t = new DataTable();
            t.Columns.Add("idAlbaranA", typeof(Int32));
            t.Columns.Add("idAlbaran", typeof(Int32));
            t.Columns.Add("agrupado", typeof(string));
            t.Columns.Add("orden", typeof(Int32));
            t.Columns.Add("idArticulo", typeof(Int32));
            t.Columns.Add("codigo", typeof(string));
            t.Columns.Add("nombre", typeof(string));
            t.Columns.Add("cantidad", typeof(Double));
            t.Columns.Add("pvp_ori", typeof(Double));
            t.Columns.Add("dto", typeof(Double));
            t.Columns.Add("pvpTotal", typeof(Double));
            t.Columns.Add("iva", typeof(Double));
            t.Columns.Add("datoCargado", typeof(bool));
            return t;
        }

        public static DataTable getDataTable(Int32 idAlbaranP)
        {
            DataTable t = getDataTableVacia();
            DataTable tSql;
            string sql = "select idAlbaranA, idAlbaran, agrupado, orden, idArticulo, codigo, nombre, cantidad, pvp_ori, dto, pvpTotal, iva from t_albaranA where idAlbaran=" + idAlbaranP;
            sql += " order by orden asc";
            try { tSql = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("AlbaranA.getDataTable.Exception: " + ex.Message); tSql = null; }
            if (tSql != null)
                foreach (DataRow r in tSql.Rows)
                {
                    t.Rows.Add(new AlbaranA(r.ItemArray).getInstanciaLikeARow());
                }
            return t;
        }

        public static DataTable getDataTableDesdeFactura(Int32 idFacturaP)
        {
            DataTable t = getDataTableVacia();
            DataTable tSql;
            string sql = "select a.idAlbaranA, a.idAlbaran, a.agrupado, a.orden, a.idArticulo, a.codigo, a.nombre, a.cantidad, a.pvp_ori, a.dto, a.pvpTotal, a.iva from t_albaranA a inner join t_albaran b on a.idAlbaran=b.idAlbaran where";
            sql += " b.idFactura=" + idFacturaP;
            sql += " order by b.anio asc, b.numero asc, a.orden asc";
            try { tSql = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("AlbaranA.getDataTableDesdeFactura.Exception: " + ex.Message); tSql = null; }
            if (tSql != null)
                foreach (DataRow r in tSql.Rows)
                {
                    t.Rows.Add(new AlbaranA(r.ItemArray).getInstanciaLikeARow());
                }
            return t;
        }

        #endregion 

    } // end class
} // end namespace
