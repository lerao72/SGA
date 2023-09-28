using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LT48;
using BC;

namespace MVC
{
    /// <summary>
    /// Clase comun para el Módulo de Clases Varias (ModuleVariousClass -> MVC)
    /// </summary>
    public static class Comun
    {
        public static bool Activo = true; // Esta variable aquí siempre estará activa, y para otros módulos sólo si el módulo está activo.



        public static void actualizarBD(bool esSQLServer)
        {
            if (esSQLServer)
                actualizarBD_SQLServer();
            else
                actualizarBD_Access();
        }
        private static void actualizarBD_SQLServer()
        {
            DataTable t;
            string sqlCheck, sqlDo;
            bool esOk = false;

            sqlCheck = "select idRecordatorio from t_recordatorio where idRecordatorio<10";
            sqlDo = @"create table t_recordatorio(
    idRecordatorio int not null primary key,
    fecha nvarchar(8),
    hora nvarchar(4),
    tarea nvarchar(max),
    tipoVinculado int,
    idVinculado int
    )";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            //sqlCheck = "";
            //sqlDo = @"";
            //actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/
            //sqlCheck = "";
            //sqlDo = @"";
            //actualizarBD_SQL_Sub(sqlCheck, sqlDo);
        }
        private static void actualizarBD_Access()
        {
            DataTable t;
            string sqlCheck, sqlDo;
            bool esOk = false;
            DBConexion conexion;

            conexion = new DBConexion(DBConexion.Tipo.Access, @".\" + BC.Comun.nombreBD + ".dat", null, null, BC.Comun.accessKey);
            try { conexion.Abre(); }
            catch (Exception ex) { Log.log("MCC.Comun.actualizarBD_Access.AbrirConexion.Exception: " + ex.Message); }

            sqlCheck = "select idRecordatorio from t_recordatorio where idRecordatorio<10";
            sqlDo = @"create table t_recordatorio(
    idRecordatorio int not null primary key,
    fecha nvarchar(8),
    hora nvarchar(4),
    tarea ntext,
    tipoVinculado int,
    idVinculado int
    )";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            //sqlCheck = "";
            //sqlDo = @"";
            //actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            //sqlCheck = "";
            //sqlDo = @"";
            //actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            //sqlCheck = "select codTarjeta from t_oleicultores";
            //sqlDo = "alter table t_oleicultores add codTarjeta nvarchar(30) null";

            try { conexion.Cierra(); }
            catch (Exception ex) { Log.log("MVC.Comun.actualizarBD_Access.CerrarConexion.Exception: " + ex.Message); }
        }
        private static void actualizarBD_Access_Sub(string sqlCheck, string sqlDo, DBConexion conexion)
        {
            bool esOk = false;
            DataTable t;
            try { t = DB.getDataTable(sqlCheck, conexion); esOk = true; }
            catch { esOk = false; }
            if (!esOk)
                try { DB.ejecutaSQL(sqlDo, conexion); }
                catch (Exception ex) { Log.log("MVC.Comun.actualizarBD_X_Sub.Exception: " + ex.Message); }
        }
        private static void actualizarBD_SQL_Sub(string sqlCheck, string sqlDo)
        {
            bool esOk = false;
            DataTable t;
            try { t = DB.getDataTable_CCP(sqlCheck); esOk = true; }
            catch { esOk = false; }
            if (!esOk)
                try { DB.ejecutaSQL_CCP(sqlDo); }
                catch (Exception ex) { Log.log("MVC.Comun.actualizarBD_X_Sub.Exception: " + ex.Message); }
        }

    } // end class
} // end namespace
