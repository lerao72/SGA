using System;
using System.Collections.Generic;
using System.Text;
using LT48;
using System.Data;

namespace BC.Contactos
{
    public class SelectorDeContactos : Selector
    {
        public delegate void DelegadoContactoSeleccionado(Contactos contactoSeleccionado);
        public event DelegadoContactoSeleccionado ContactoSeleccionado;

        /// <summary>
        /// Condicidión adicional que ha de ser del tipo " and idContacto not in (select idContacto from condición)"
        /// </summary>
        public string sqlCondNotIn = "";



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

                string sql = "select idContacto, codigo, razonSocial from t_contactos";
                sql += " where activo='s'";
                sql += " and visible='s'";
                if (txtFiltro != "")
                {
                    sql += " and (codigo='" + txtFiltro + "'";
                    sql += " or razonSocial like '%" + txtFiltro + "%'";
                    sql += " or nombreComercial like '%" + txtFiltro + "%'";
                    sql += ")";
                }
                if (sqlCondNotIn != "")
                    sql += sqlCondNotIn;

                sql += " order by razonsocial asc";

                DataTable t;
                try { t = DB.getDataTable_CCP(sql); }
                catch (Exception ex) { Log.log("SelectorDeContactos.cargarGrid.Exception: " + ex.Message); t = null; }

                if (t != null)
                {
                    w.grid.DataSource = t;

                    try { w.grid.Columns["idContacto"].Visible = false; }
                    catch { ;}

                    BC.Comun.grid_tituloAnchoColumna(w.grid, "codigo", "#", 75);
                    BC.Comun.grid_tituloColumna(w.grid, "razonSocial", "Contacto");

                    if (w.grid.Rows.Count > 0)
                        w.grid.CurrentCell = w.grid.Rows[0].Cells["razonSocial"];
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
                Int32 idContacto = LT48.Conversiones.toIntWN(w.grid.CurrentRow.Cells["idContacto"].Value);
                Contactos contacto = new Contactos(idContacto);
                try { ContactoSeleccionado(contacto); }
                catch { ;}

                w.Close();
            }
        }

    } // end class
}
