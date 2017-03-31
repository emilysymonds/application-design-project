using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAVLogica;
using Persistencia;
using System.Data.Common;
using System.Data.SqlClient;

namespace PersistenciaImp
{
    public class BrokerBarometro : Broker
    {
        public BrokerBarometro()
        {
        }

        public override string getSelect(ObjPersistente obj)
        {
            return "SELECT * FROM Barometro WHERE OIDBarometro = " + obj.OID;
        }

        public override string getSelectAll(ObjPersistente obj)
        {
            return "SELECT * FROM Barometro";
        }
        public override void getInsert(ObjPersistente obj)
        {
            Barometro b = (Barometro)obj;

            string sql = "INSERT into Barometro(marca, modelo, precision, min, max, alarma, estadoAlarma, presion, OIDBarometro) VALUES";
            sql = sql + "('" + b.marca + "',";
            sql = sql + "'" + b.modelo + "',";
            sql = sql + b.precision + ",";
            sql = sql + b.min + ",";
            sql = sql + b.max + ",";
            sql = sql + b.alarma + ",";
            sql = sql + "'" + b.estadoAlarma + "',";
            sql = sql + b.presion + ",";
            sql = sql + b.OID + ")";

            SQLConnection.Instance.EjecutarSentencia(sql);
        }

        public override string getDelete(ObjPersistente obj)
        {
            return SQLConnection.Instance.EjecutarSentencia("DELETE FROM Barometro WHERE OIDBarometro = " + obj.OID);
        }



        public override void getUpdate(ObjPersistente obj)
        {
            Barometro b = (Barometro)obj;
            string sql = "UPDATE Barometro SET ";

            sql = sql + "precision=" + b.precision + ",";
            sql = sql + "min=" + b.min + ",";
            sql = sql + "max=" + b.max + " WHERE OIDBarometro = " + b.OID;

            SQLConnection.Instance.EjecutarSentencia(sql);
        }

        protected override ObjPersistente ReaderToObject(SqlDataReader d)
        {

            int comp = d.GetInt32(0);
            string marca = d.GetString(1);
            string modelo = d.GetString(2);
            int precision = d.GetInt32(3);
            int min = d.GetInt32(4);
            int max = d.GetInt32(5);
            int alarma = d.GetInt32(6);
            bool estado = d.GetBoolean(7);
            int presion = d.GetInt32(8);
            int oid = d.GetInt32(9);

            Barometro retorno = new Barometro(marca, modelo, precision, min, max, alarma, presion);
            retorno.estadoAlarma = estado;
            retorno.OID = oid;
            return retorno;
        }

        public override void getReferencias(ObjPersistente obj)
        {
        }
    }
}
