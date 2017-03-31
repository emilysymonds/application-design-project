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
    public class BrokerGPS : Broker
    {
        public BrokerGPS()
        {
        }

        public override string getSelect(ObjPersistente obj)
        {
            return "SELECT * FROM GPS WHERE OIDGPS = " + obj.OID;
        }

        public override string getSelectAll(ObjPersistente obj)
        {
            return "SELECT * FROM GPS";
        }
        public override void getInsert(ObjPersistente obj)
        {
            GPS g = (GPS)obj;

            string sql = "INSERT into GPS(marca, modelo, precision, min, max, alarma, estadoAlarma, x, y, z, OIDGPS) VALUES";
            sql = sql + "('" + g.marca + "',";
            sql = sql + "'" + g.modelo + "',";
            sql = sql + g.precision + ",";
            sql = sql + g.min + ",";
            sql = sql + g.max + ",";
            sql = sql + g.alarma + ",";
            sql = sql + "'" + g.estadoAlarma + "',";
            sql = sql + g.x + ",";
            sql = sql + g.y + ",";
            sql = sql + g.z + ",";
            sql = sql + g.OID + ")";

            SQLConnection.Instance.EjecutarSentencia(sql);
        }

        public override string getDelete(ObjPersistente obj)
        {
            return SQLConnection.Instance.EjecutarSentencia("DELETE FROM GPS WHERE OIDGPS = " + obj.OID);
        }



        public override void getUpdate(ObjPersistente obj)
        {
            GPS g = (GPS)obj;
            string sql = "UPDATE GPS SET ";

            sql = sql + "precision=" + g.precision + ",";
            sql = sql + "min=" + g.min + ",";
            sql = sql + "max=" + g.max + " WHERE OIDGPS = " + g.OID;

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
            int x = d.GetInt32(8);
            int y = d.GetInt32(8);
            int z = d.GetInt32(8);
            int oid = d.GetInt32(9);

            GPS retorno = new GPS(marca, modelo, precision, min, max, alarma, x, y, z);
            retorno.estadoAlarma = estado;
            retorno.OID = oid;
            return retorno;
        }

        public override void getReferencias(ObjPersistente obj)
        {
        }
    }
}
