using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using BC;
using LT48;



namespace MCC
{
    /// <summary>
    /// Clase comun para el Módulo de Clases de Contactos (ModuleContactClass -> MCC)
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

            sqlCheck = "select idContacto from t_contactos where idContacto<10";
            sqlDo = @"create table t_contactos(
    idContacto int not null primary key,   
    codigo nvarchar(15),
    activo nvarchar(1) not null default ('s'),
    visible nvarchar(1) not null default ('s'),
    nifCif nvarchar(20),
    razonSocial nvarchar(255) not null,
    nombreComercial nvarchar(255),
    observaciones nvarchar(max),
    aplicaIVA nvarchar(1) not null default ('s'),
    tipoFormaMePaga smallint,
    tipoFormaLePago smallint,
    tarifa smallint not null default 1,
    descuento float,
    fechaCrea nvarchar(8),
    idUsuarioCrea int,
    esProveedor nvarchar(1) default('s'),
    esCliente nvarchar(1) default('s')
    )";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select idDireccion from t_direcciones where idDireccion<10";
            sqlDo = @"create table t_direcciones(
    idDireccion int not null primary key,
    idContacto int,
    tipo smallint default 0,
    cp nvarchar(10),
    localidad nvarchar(100),
    provincia nvarchar(100),
    pais nvarchar(100),
    direccion nvarchar(max)
    )";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select idDatoContacto from t_datosContacto where idDatoContacto<10";
            sqlDo = @"create table t_datosContacto(
    idDatoContacto int not null primary key,
    idContacto int,
    tipo smallint default 0,
    dato nvarchar(255),
    nombre nvarchar(100),
    cargo nvarchar(50),
    observaciones nvarchar(255)
    )";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select idCuenta from t_cuentas where idCuenta<10";
            sqlDo = @"create table t_cuentas(
    idCuenta int not null primary key,
    idContacto int,
    banco nvarchar(50),
    iban nvarchar(34),
    swift nvarchar(11),
    pago nvarchar(1) default ('n'),
    cobro nvarchar(1) default ('n')
    )";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select tarifa from t_contactos where idContacto<10";
            sqlDo = @"alter table t_contactos add tarifa smallint not null default 1";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select descuento from t_contactos where idContacto<10";
            sqlDo = @"alter table t_contactos add descuento float";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select esProveedor from t_contactos where idContacto<10";
            sqlDo = @"alter table t_contactos add esProveedor nvarchar(1) default('n')";
            actualizarBD_SQL_Sub(sqlCheck, sqlDo);

            /****************************************************/

            sqlCheck = "select esCliente from t_contactos where idContacto<10";
            sqlDo = @"alter table t_contactos add esCliente nvarchar(1) default('n')";
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

            sqlCheck = "select idContacto from t_contactos where idContacto<10";
            sqlDo = @"create table t_contactos(
    idContacto int not null primary key,   
    codigo nvarchar(15),
    activo nvarchar(1) not null default s,
    visible nvarchar(1) not null default s,
    nifCif nvarchar(20),
    razonSocial nvarchar(255) not null,
    nombreComercial nvarchar(255),
    observaciones ntext,
    aplicaIVA nvarchar(1) not null default s,
    tipoFormaMePaga smallint,
    tipoFormaLePago smallint,
    tarifa smallint not null default 1,
    descuento double,
    fechaCrea nvarchar(8),
    idUsuarioCrea int,
    esProveedor nvarchar(1) default n,
    esCliente nvarchar(1) default n
    )";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select idDireccion from t_direcciones where idDireccion<10";
            sqlDo = @"create table t_direcciones(
    idDireccion int not null primary key,
    idContacto int,
    tipo smallint default 0,
    cp nvarchar(10),
    localidad nvarchar(100),
    provincia nvarchar(100),
    pais nvarchar(100),
    direccion ntext
    )";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select idDatoContacto from t_datosContacto where idDatoContacto<10";
            sqlDo = @"create table t_datosContacto(
    idDatoContacto int not null primary key,
    idContacto int,
    tipo smallint default 0,
    dato nvarchar(255),
    nombre nvarchar(100),
    cargo nvarchar(50),
    observaciones nvarchar(255)
    )";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select idCuenta from t_cuentas where idCuenta<10";
            sqlDo = @"create table t_cuentas(
    idCuenta int not null primary key,
    idContacto int,
    banco nvarchar(50),
    iban nvarchar(34),
    swift nvarchar(11),
    pago nvarchar(1) default n,
    cobro nvarchar(1) default n
    )";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select tarifa from t_contactos where idContacto<10";
            sqlDo = @"alter table t_contactos add tarifa smallint not null default 1";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select descuento from t_contactos where idContacto<10";
            sqlDo = @"alter table t_contactos add descuento double";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select esProveedor from t_contactos where idContacto<10";
            sqlDo = @"alter table t_contactos add esProveedor nvarchar(1) default n";
            actualizarBD_Access_Sub(sqlCheck, sqlDo, conexion);

            /****************************************************/

            sqlCheck = "select esCliente from t_contactos where idContacto<10";
            sqlDo = @"alter table t_contactos add esCliente nvarchar(1) default n";
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
            catch (Exception ex) { Log.log("MCC.Comun.actualizarBD_Access.CerrarConexion.Exception: " + ex.Message); }
        }
        private static void actualizarBD_Access_Sub(string sqlCheck, string sqlDo, DBConexion conexion)
        {
            bool esOk = false;
            DataTable t;
            try { t = DB.getDataTable(sqlCheck, conexion); esOk = true; }
            catch { esOk = false; }
            if (!esOk)
                try { DB.ejecutaSQL(sqlDo, conexion); }
                catch (Exception ex) { Log.log("MCC.Comun.actualizarBD_X_Sub.Exception: " + ex.Message); }
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
