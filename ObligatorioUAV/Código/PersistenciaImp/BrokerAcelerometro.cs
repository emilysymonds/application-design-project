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
    public class BrokerAcelerometro : Broker
    {
        public BrokerAcelerometro()
        {
        }

        public override string getSelect(ObjPersistente obj)
        {
            return "SELECT * FROM Acelerometro WHERE OIDAcelerometro = " + obj.OID;
        }

        public override string getSelectAll(ObjPersistente obj)
        {
            return "SELECT * FROM Acelerometro";
        }
        public override void getInsert(ObjPersistente obj)
        {
            Acelerometro a = (Acelerometro)obj;

            string sql = "INSERT into Acelerometro(marca, modelo, precision, min, max, alarma, x, y, z, OIDAcelerometro) VALUES";
            sql = sql + "('" + a.marca + "',";
            sql = sql + "'" + a.modelo + "',";
            sql = sql + a.precision + ",";
            sql = sql + a.min + ",";
            sql = sql + a.max + ",";
            sql = sql + a.alarma + ",";
            sql = sql + a.x + ",";
            sql = sql + a.y + ",";
            sql = sql + a.z + ",";
            sql = sql + a.OID + ")";

            SQLConnection.Instance.EjecutarSentencia(sql);
        }

        public override string getDelete(ObjPersistente obj)
        {
            return SQLConnection.Instance.EjecutarSentencia("DELETE FROM Acelerometro WHERE OIDAcelerometro = " + obj.OID);
        }



        public override void getUpdate(ObjPersistente obj)
        {
            Acelerometro v = (Acelerometro)obj;
            string sql = "UPDATE Acelerometro SET ";

            sql = sql + "precision=" + v.precision + ",";
            sql = sql + "min=" + v.min + ",";
            sql = sql + "max=" + v.max + " WHERE OIDAcelerometro = " + v.OID;

            SQLConnection.Instance.EjecutarSentencia(sql);
        }

        protected override ObjPersistente ReaderToObject(SqlDataReader d)
        {
            string marca = d.GetString(0);
            string modelo = d.GetString(1);
            int precision = d.GetInt32(2);
            int min = d.GetInt32(3);
            int max = d.GetInt32(4);
            int alarma = d.GetInt32(5);
            int x = d.GetInt32(6);
            int y = d.GetInt32(7);
            int z = d.GetInt32(8);
            int oid = d.GetInt32(9);

            Acelerometro retorno = new Acelerometro(marca, modelo, precision, min, max, alarma, x, y, z);
            retorno.OID = oid;
            return retorno;
        }

        public override void getReferencias(ObjPersistente obj)
        {
        }
    }
}

