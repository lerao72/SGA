using System;
using System.Collections.Generic;
using System.Text;
using LT48;
using System.Data;

namespace BC.Articulos
{
    public class SelectorDeArticulos : Selector
    {
        public delegate void DelegadoArticuloSeleccionado(Articulos articuloSeleccionado);
        public event DelegadoArticuloSeleccionado ArticuloSeleccionado;



        /// <summary>
        /// No llamar: procedimiento interno
        /// </summary>
        public override void cargarGrid()
        {
            _cargandoGrid = true;
            try
            {
                string txtFiltro = w.tb_filtro.Text.Trim();
                txtFiltro = LT48.Conversiones.quitarComillas(txtFiltro);

                string sql = "select idArticulo, codigo, nombre from t_articulos";
                sql += " where activo='s'";
                sql += " and visible='s'";
                if (txtFiltro != "")
                {
                    sql += " and (codigo='" + txtFiltro + "'";
                    sql += " or referencia='" + txtFiltro + "'";
                    sql += " or nombre like '%" + txtFiltro + "%'";
                    sql += ")";
                }
                sql += " order by nombre asc";

                DataTable t;
                try { t = DB.getDataTable_CCP(sql); }
                catch (Exception ex) { Log.log("SelectorDeArticulos.cargarGrid.Exception: " + ex.Message); t = null; }

                if (t != null)
                {
                    w.grid.DataSource = t;

                    try { w.grid.Columns["idArticulo"].Visible = false; }
                    catch { ;}

                    BC.Comun.grid_tituloAnchoColumna(w.grid, "codigo", "#", 75);
                    BC.Comun.grid_tituloColumna(w.grid, "nombre", "Artículo");

                    if (w.grid.Rows.Count > 0)
                        w.grid.CurrentCell = w.grid.Rows[0].Cells["nombre"];
                }
            }
            catch { ;}
            _cargandoGrid = false;
        }

        /// <summary>
        /// No llamar: procedimiento interno
        /// </summary>
        public override void seleccionar()
        {
            if (w.grid.CurrentRow != null)
            {
                Int32 idArticulo = LT48.Conversiones.toIntWN(w.grid.CurrentRow.Cells["idArticulo"].Value);
                Articulos articulo = new Articulos(idArticulo);
                try { ArticuloSeleccionado(articulo); }
                catch { ;}

                w.Close();
            }
        }
        
    } // end class
} // end namespace
