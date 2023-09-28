using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LT48;

namespace MBC
{
    /// <summary>
    /// Clase comun para el Módulo de Clases de Negocio (ModuleBussinesClass -> MBC)
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

            sqlCheck = "select idAlbaran from t_albaran where idAlbaran<10";
            sqlDo = @"create table t_albaran(
    idAlbaran int not null primary key, 
    idContacto int not null,
    fecha nvarchar(8),
    anio int not null,
    numero int not null,
    pvp float,
    sumaIVA float,
    observaciones nvarchar(max),
    idFactura int  
    )";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select idAlbaranA from t_albaranA where idAlbaranA<10";
            sqlDo = @"create table t_albaranA(
    idAlbaranA int not null primary key,
    idAlbaran int not null,
    agrupado nvarchar(1),
    orden smallint,
    idArticulo int,
    codigo nvarchar(25),
    nombre nvarchar(255),
    cantidad float,
    pvp_ori float,
    dto float,
    pvpTotal float,
    iva float    
    )";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select idFactura from t_albaran where idAlbaran<10";
            sqlDo = @"alter table t_albaran add column idFactura int";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select idFactura from t_factura where idFactura<10";
            sqlDo = @"create table t_factura(
    idFactura int not null primary key, 
    idContacto int not null,
    fecha nvarchar(8),
    anio int not null,
    numero int not null,
    pvp float,
    sumaIVA float,
    observaciones nvarchar(max)
    )";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select idPago from t_pago where idPago<10";
            sqlDo = @"create table t_pago(
    idPago int not null primary key,
    idContacto int not null, 
    serie int,
    patronSerie nvarchar(4),
    fechaPrevista nvarchar(8),
    fechaReal nvarchar(8),
    tipo nvarchar(20),
    descripcion nvarchar(50),
    importe float,
    autopagable nvarchar(1) default ('n'),
    persistente nvarchar(1) default ('n')
    )";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select idCobro from t_cobro where idCobro<10";
            sqlDo = @"create table t_cobro(
    idCobro int not null primary key,
    idContacto int,
    idFactura int,
    fechaPrevista nvarchar(8),
    fechaReal nvarchar(8),
    descripcion nvarchar(50),
    importe float
    )";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

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

            sqlCheck = "select idAlbaran from t_albaran where idAlbaran<10";
            sqlDo = @"create table t_albaran(
    idAlbaran int not null primary key, 
    idContacto int not null,
    fecha nvarchar(8),
    anio int not null,
    numero int not null,
    pvp double,
    sumaIVA double,
    observaciones ntext,
    idFactura int  
    )";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select idAlbaranA from t_albaranA where idAlbaranA<10";
            sqlDo = @"create table t_albaranA(
    idAlbaranA int not null primary key,
    idAlbaran int not null,
    agrupado nvarchar(1),
    orden smallint,
    idArticulo int,
    codigo nvarchar(25),
    nombre nvarchar(255),
    cantidad double,
    pvp_ori double,
    dto double,
    pvpTotal double,
    iva double    
    )";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select idFactura from t_albaran where idAlbaran<10";
            sqlDo = @"alter table t_albaran add column idFactura int";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select idFactura from t_factura where idFactura<10";
            sqlDo = @"create table t_factura(
    idFactura int not null primary key, 
    idContacto int not null,
    fecha nvarchar(8),
    anio int not null,
    numero int not null,
    pvp double,
    sumaIVA double,
    observaciones ntext
    )";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select idPago from t_pago where idPago<10";
            sqlDo = @"create table t_pago(
    idPago int not null primary key,
    idContacto int not null, 
    serie int,
    patronSerie nvarchar(4),
    fechaPrevista nvarchar(8),
    fechaReal nvarchar(8),
    tipo nvarchar(20),
    descripcion nvarchar(50),
    importe double,
    autopagable nvarchar(1) default n,
    persistente nvarchar(1) default n
    )";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select idCobro from t_cobro where idCobro<10";
            sqlDo = @"create table t_cobro(
    idCobro int not null primary key,
    idContacto int,
    idFactura int,
    fechaPrevista nvarchar(8),
    fechaReal nvarchar(8),
    descripcion nvarchar(50),
    importe double
    )";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            //sqlCheck = "";
            //sqlDo = @"";
            //actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            try { conexion.Cierra(); }
            catch (Exception ex) { Log.log("MBC.Comun.actualizarBD_Access.CerrarConexion.Exception: " + ex.Message); }
        }
        private static void actualizarBD_Access_Sub(string sqlCheck, string sqlDo, DBConexion conexion)
        {
            bool esOk = false;
            DataTable t;
            try { t = DB.getDataTable(sqlCheck, conexion); esOk = true; }
            catch { esOk = false; }
            if (!esOk)
                try { DB.ejecutaSQL(sqlDo, conexion); }
                catch (Exception ex) { Log.log("MBC.Comun.actualizarBD_X_Sub.Exception: " + ex.Message); }
        }
        private static void actualizarBD_SQL_Sub(string sqlCheck, string sqlDo)
        {
            bool esOk = false;
            DataTable t;
            try { t = DB.getDataTable_CCP(sqlCheck); esOk = true; }
            catch { esOk = false; }
            if (!esOk)
                try { DB.ejecutaSQL_CCP(sqlDo); }
                catch (Exception ex) { Log.log("MBC.Comun.actualizarBD_X_Sub.Exception: " + ex.Message); }
        }

    } // end class
} // end namespace
