using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using LT48;

namespace BC.Varios
{
    public class Recordatorio
    {
        public enum Tipo { Agenda = 0, Contacto = 1 };

        #region Zona generada automaticamente

        private Int32 _idRecordatorio;
        private string _fecha;
        private string _hora;
        private string _tarea;
        private Int32 _tipoVinculado;
        private Int32 _idVinculado;

        public bool _datoCargado = false;



        public Recordatorio() { inicializa(); }
        public Recordatorio(object[] o) { instanciaFromVector(o); }
        public Recordatorio(Int32 id) { carga(id); }



        public Int32 getIdRecordatorio() { return _idRecordatorio; }
        public void setIdRecordatorio(Int32 valor) { _idRecordatorio = valor; }

        public string getFecha() { return _fecha; }
        public void setFecha(object valor)
        {
            if (valor.ToString() != "")
                _fecha = Conversiones.toFechaUniversal(valor);
            else
                _fecha = "";
        }
        public string getFechaAsString() { return _fecha == "" ? _fecha : Conversiones.fechaUniversal_to_fechaESP(_fecha); }
        public DateTime getFechaAsDateTime() { return _fecha == "" ? DateTime.Now : Conversiones.fechaUniversal_to_DateTime(_fecha); }

        public string getHora() { return _hora; }
        public string getHoraAsString() { return getHoraAsString_static(_hora); }
        public static string getHoraAsString_static(string valor)
        {
            return valor != "" ? valor.Substring(0, 2) + ":" + valor.Substring(2, 2) : "Todo el día";
        }
        public int getHora_hora()
        {
            if (_hora == "")
                return 0;
            else
                return Conversiones.toInt(_hora.Substring(0, 2));
        }
        public int getHora_minutos()
        {
            if (_hora == "")
                return 0;
            else
                return Conversiones.toInt(_hora.Substring(2, 2));
        }
        public void setHora(string valor)
        {
            // Quitamos (si los hubiere, los dos puntos)
            string strHoraPoner = valor.Replace(":", "").ToUpper();

            if (strHoraPoner == "" || strHoraPoner == "TODO EL DÍA")
                strHoraPoner = "";
            else
            {
                if (strHoraPoner.Length == 4)
                {
                    int _parteHora, _parteMinutos;
                    try
                    {
                        _parteHora = Convert.ToInt16(strHoraPoner.Substring(0, 2));
                        _parteMinutos = Convert.ToInt16(strHoraPoner.Substring(2, 2));

                        bool esOk = _parteHora >= 0 && _parteHora < 24 && _parteMinutos >= 0 && _parteMinutos < 60;
                        strHoraPoner = esOk ? strHoraPoner : "";
                    }
                    catch { strHoraPoner = ""; }
                }
                else
                    strHoraPoner = "";

            }
            _hora = strHoraPoner;
        }
        public void setHora(int hora, int minutos)
        {
            if (hora >= 0 && hora < 24 && minutos >= 0 && minutos < 60)
                _hora = hora.ToString("00") + minutos.ToString("00");
            else
                _hora = "";
        }

        public string getTarea() { return _tarea; }
        public void setTarea(string valor) { _tarea = Conversiones.quitarComillas(valor); }

        public Int32 getTipoVinculado() { return _tipoVinculado; }
        public void setTipoVinculado(Int32 valor) { _tipoVinculado = getTipoAsInt(valor); }
        public void setTipoVinculado(Tipo valor) { _tipoVinculado = (int)valor; }

        public Int32 getIdVinculado() { return _idVinculado; }
        public void setIdVinculado(Int32 valor) { _idVinculado = valor; }




        public void inicializa()
        {
            _idRecordatorio = -1;
            _fecha = "";
            _hora = "";
            _tarea = "";
            _tipoVinculado = 0;
            _idVinculado = -1;

            _datoCargado = false;
        }

        public void instanciaFromVector(object[] o)
        {
            setIdRecordatorio(Conversiones.toInt(o[0]));
            setFecha(o[1]);
            setHora(Conversiones.toString(o[2]));
            setTarea(Conversiones.toString(o[3]));
            setTipoVinculado(Conversiones.toInt(o[4]));
            setIdVinculado(Conversiones.toInt(o[5]));
            try { _datoCargado = (bool)o[6]; }
            catch { _datoCargado = true; }
        }

        public object[] getInstanciaLikeARow()
        {
            object[] o = new object[7];
            o[0] = getIdRecordatorio();
            o[1] = getFechaAsString();
            o[2] = getHora();
            o[3] = getTarea();
            o[4] = getTipoVinculado();
            o[5] = getIdVinculado();

            o[6] = _datoCargado;
            // Ojo con el tamaño del vector

            return o;
        }

        public void carga(Int32 id)
        {
            string sql = "select idRecordatorio, fecha, hora, tarea, tipoVinculado, idVinculado from t_recordatorio where idRecordatorio=" + id;
            DataTable t;
            try { t = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("TareasProgramadas.carga.Exception: " + ex.Message); t = null; }
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
                _idRecordatorio = DB.nextValue_conReintento("idRecordatorio", "t_recordatorio", "TareasProgramadas.guarda.Exception.Re1: ");
                sql = "insert into t_recordatorio(idRecordatorio, fecha, hora, tarea, tipoVinculado, idVinculado) values(";
                sql += _idRecordatorio;
                sql += ", '" + _fecha + "'";
                sql += ", '" + _hora + "'";
                sql += ", '" + _tarea + "'";
                sql += ", " + _tipoVinculado;
                sql += ", " + _idVinculado;
                sql += ")";
            }
            else
            {
                sql = "update t_recordatorio set ";
                sql += "fecha='" + _fecha + "'";
                sql += ", hora='" + _hora + "'";
                sql += ", tarea='" + _tarea + "'";
                sql += ", tipoVinculado=" + _tipoVinculado;
                sql += ", idVinculado=" + _idVinculado;
                sql += " where idRecordatorio=" + _idRecordatorio;
            }
            try { DB.ejecutaSQL_conReintento(sql, "TareasProgramadas.guarda.Exception.Re2: "); _datoCargado = true; }
            catch (Exception ex) { Log.log("TareasProgramadas.guarda.Exception: " + ex.Message); }
        }

        public void borra() { borra(_idRecordatorio); _datoCargado = false; }
        public static void borra(Int32 idRecordatorioBorrar)
        {
            string sql = "delete from t_recordatorio where idRecordatorio=" + idRecordatorioBorrar;
            try { DB.ejecutaSQL_CCP(sql); }
            catch (Exception ex) { Log.log("Recordatorio.borra.Exception: " + ex.Message); }
        }

        public static DataTable getDataTableVacia()
        {
            DataTable t = new DataTable();
            t.Columns.Add("idRecordatorio", typeof(Int32));
            t.Columns.Add("fecha", typeof(string));
            t.Columns.Add("hora", typeof(string));
            t.Columns.Add("tarea", typeof(string));
            t.Columns.Add("tipoVinculado", typeof(Int32));
            t.Columns.Add("idVinculado", typeof(Int32));
            t.Columns.Add("datoCargado", typeof(bool));
            return t;
        }

        public static DataTable getDataTable(string fechaP)
        {
            DataTable t = getDataTableVacia();
            DataTable tSql;
            string sql = "select idRecordatorio, fecha, hora, tarea, tipoVinculado, idVinculado from t_recordatorio where fecha='" + fechaP + "'";
            sql += " order by fecha asc, hora asc";
            try { tSql = DB.getDataTable_CCP(sql); }
            catch (Exception ex) { Log.log("TareasProgramadas.getDataTable.Exception: " + ex.Message); tSql = null; }
            if (tSql != null)
                foreach (DataRow r in tSql.Rows)
                {
                    t.Rows.Add(new Recordatorio(r.ItemArray).getInstanciaLikeARow());
                }
            return t;
        }

        #endregion



        public static Int32 getTipoAsInt(Tipo valor) { return (Int32)valor; }
        public static Int32 getTipoAsInt(Int32 valor)
        {
            // Esta función la utilizamos para asegurarnos que el valor es correcto y caso 
            // de no serlo, que se devuelva el tipo por defecto
            Tipo aux;
            try { aux = (Tipo)valor; }
            catch { aux = Tipo.Agenda; }
            return (Int32)aux;
        }
        public static string getTipoAsString(Int32 tipo)
        {
            Tipo aux = (Tipo)tipo;
            return getTipoAsString(aux);
        }
        public static string getTipoAsString(Tipo tipo)
        {
            return tipo.ToString();
        }



        private static DataTable t_recordatoriosHoy = null;
        public static void recargarAgendaHoy()
        {
            DateTime hoy = DateTime.Now;
            bool esPrimeraVez = t_recordatoriosHoy == null;
            t_recordatoriosHoy = getDataTable(hoy.ToString("yyyyMMdd"));

            if (t_recordatoriosHoy.Rows.Count > 0)
            {
                // Si no es la primera vez, eliminamos los eventos todo el día
                int ord_hora = t_recordatoriosHoy.Columns["hora"].Ordinal;
                if (!esPrimeraVez)
                {
                    Int32 i = 0;
                    Int32 numFilas = t_recordatoriosHoy.Rows.Count;
                    while (i < numFilas)
                    {
                        if (t_recordatoriosHoy.Rows[i].ItemArray[ord_hora].ToString() == "")
                        {
                            t_recordatoriosHoy.Rows.RemoveAt(i);
                            numFilas--;
                        }
                        else
                            i++;
                    }
                } // if (!esPrimeraVez
            } // if (t_recordatoriosHoy
        }
        public static void aniadeAgendaHoy(Recordatorio recordatorioParam)
        {
            if (t_recordatoriosHoy == null)
                recargarAgendaHoy();

            // Quitamos si ya estuviera
            Int32 i = 0;
            Int32 numFilas = t_recordatoriosHoy.Rows.Count;
            while (i < numFilas)
            {
                Recordatorio aux = new Recordatorio(t_recordatoriosHoy.Rows[i].ItemArray);
                if (aux.getIdRecordatorio() == recordatorioParam.getIdRecordatorio())
                {
                    t_recordatoriosHoy.Rows.RemoveAt(i);
                    numFilas--;
                }
                else
                    i++;
            }
            t_recordatoriosHoy.Rows.Add(recordatorioParam.getInstanciaLikeARow());
        }
        public static void comprobarAgendaHoy()
        {
            if (t_recordatoriosHoy == null)
                recargarAgendaHoy();

            DateTime ahora = DateTime.Now;
            Int32 ahora_h_m = ahora.Hour * 100 + ahora.Minute;

            Int32 i=0;
            Int32 numFilas = t_recordatoriosHoy.Rows.Count;

            while (i < numFilas)
            {
                DataRow r = t_recordatoriosHoy.Rows[i];

                Recordatorio recordatorio = new Recordatorio(r.ItemArray);
                Int32 recordatorio_h_m = recordatorio.getHora_hora() * 100 + recordatorio.getHora_minutos();

                if (ahora_h_m >= recordatorio_h_m)
                {
                    numFilas--;
                    t_recordatoriosHoy.Rows.RemoveAt(i);
                    BC.Comun.GeneraEnvioAInterfazComun("abrir_recordatorio", recordatorio);
                }
                else
                    i++;
            }
        }

    } // end class
} // end namespace
