using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BC;
using LT48;

namespace MAC
{
    /// <summary>
    /// Clase comun para el Módulo de Clases de Artículos (ModuleArticleClass -> MAC)
    /// </summary>
    public class Comun
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

            sqlCheck = "select idArticulo from t_articulos where idArticulo<10";
            sqlDo = @"create table t_articulos(
    idArticulo int not null primary key,   
    codigo nvarchar(25) not null unique,
    referencia nvarchar(50),
    nombre nvarchar(255),
    descripcion nvarchar(max),
    observaciones nvarchar(max),
    imagen nvarchar(255),
    precioT1 float,
    precioT2 float,
    precioT3 float,
    IVA float,
    precioCompra float,
    soloCompra nvarchar(1) not null default ('n'),
    soloVenta nvarchar(1) not null default ('n'),
    activo nvarchar(1) not null default ('s'),
    visible nvarchar(1) not null default ('s'),
    fechaCrea nvarchar(8),
    idUsuarioCrea int,
    stock float,
    stockMin float
    )";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select idFamiliaArticulo from t_familiasArticulos where idFamiliaArticulo<10";
            sqlDo = @"create table t_familiasArticulos(
    idFamiliaArticulo int not null primary key,
    nombre nvarchar(50)
    )";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select idFamiliaArticulo from t_rel_familiasArticulos where idFamiliaArticulo<10";
            sqlDo = @"create table t_rel_familiasArticulos(
    idFamiliaArticulo int,
    idArticulo int,
    constraint pk_familiaArticulos primary key (idFamiliaArticulo, idArticulo)
    )";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select stock from t_articulos where idArticulo<10";
            sqlDo = @"alter table t_articulos add stock float";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select stockMin from t_articulos where idArticulo<10";
            sqlDo = @"alter table t_articulos add stockMin float";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select idArticulo from t_proveedorDeArticulo where idArticulo<10";
            sqlDo = @"create table t_proveedorDeArticulo(
    idArticulo int not null,
    idContacto int not null,
    precio float,
    observaciones nvarchar(max),
    constraint pk_proveedorArticulo primary key (idArticulo, idContacto)
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

            //sqlCheck = "select codTarjeta from t_oleicultores";
            //sqlDo = "alter table t_oleicultores add codTarjeta nvarchar(30) null";

        }
        private static void actualizarBD_Access()
        {
            DataTable t;
            string sqlCheck, sqlDo;
            bool esOk = false;
            DBConexion conexion;

            conexion = new DBConexion(DBConexion.Tipo.Access, @".\" + BC.Comun.nombreBD + ".dat", null, null, BC.Comun.accessKey);
            try { conexion.Abre(); }
            catch (Exception ex) { Log.log("MAC.Comun.actualizarBD_Access.AbrirConexion.Exception: " + ex.Message); }

            sqlCheck = "select idArticulo from t_articulos where idArticulo<10";
            sqlDo = @"create table t_articulos(
    idArticulo int not null primary key,   
    codigo nvarchar(25) not null unique,
    referencia nvarchar(50),
    nombre nvarchar(255),
    descripcion ntext,
    observaciones ntext,
    imagen nvarchar(255),
    precioT1 double,
    precioT2 double,
    precioT3 double,
    IVA double,
    precioCompra double,
    soloCompra nvarchar(1) not null default n,
    soloVenta nvarchar(1) not null default n,
    activo nvarchar(1) not null default s,
    visible nvarchar(1) not null default s,
    fechaCrea nvarchar(8),
    idUsuarioCrea int,
    stock double,
    stockMin double
    )";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select idFamiliaArticulo from t_familiasArticulos where idFamiliaArticulo<10";
            sqlDo = @"create table t_familiasArticulos(
    idFamiliaArticulo int not null primary key,
    nombre nvarchar(50)
    )";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select idFamiliaArticulo from t_rel_familiasArticulos where idFamiliaArticulo<10";
            sqlDo = @"create table t_rel_familiasArticulos(
    idFamiliaArticulo int,
    idArticulo int,
    constraint pk_familiaArticulos primary key (idFamiliaArticulo, idArticulo)
    )";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select stock from t_articulos where idArticulo<10";
            sqlDo = @"alter table t_articulos add stock double";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select stockMin from t_articulos where idArticulo<10";
            sqlDo = @"alter table t_articulos add stockMin double";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select idArticulo from t_proveedorDeArticulo where idArticulo<10";
            sqlDo = @"create table t_proveedorDeArticulo(
    idArticulo int not null,
    idContacto int not null,
    precio float,
    observaciones ntext,
    constraint pk_proveedorArticulo primary key (idArticulo, idContacto)
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
            catch (Exception ex) { Log.log("MAC.Comun.actualizarBD_Access.CerrarConexion.Exception: " + ex.Message); }
        }
        private static void actualizarBD_Access_Sub(string sqlCheck, string sqlDo, DBConexion conexion)
        {
            bool esOk = false;
            DataTable t;
            try { t = DB.getDataTable(sqlCheck, conexion); esOk = true; }
            catch { esOk = false; }
            if (!esOk)
                try { DB.ejecutaSQL(sqlDo, conexion); }
                catch (Exception ex) { Log.log("MAC.Comun.actualizarBD_X_Sub.Exception: " + ex.Message); }
        }
        private static void actualizarBD_SQL_Sub(string sqlCheck, string sqlDo)
        {
            bool esOk = false;
            DataTable t;
            try { t = DB.getDataTable_CCP(sqlCheck); esOk = true; }
            catch { esOk = false; }
            if (!esOk)
                try { DB.ejecutaSQL_CCP(sqlDo); }
                catch (Exception ex) { Log.log("MAC.Comun.actualizarBD_X_Sub.Exception: " + ex.Message); }
        }

    } // end class
} // end namespace
