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
    public class BrokerVelocimetro : Broker
    {
        public BrokerVelocimetro()
        {
        }

        public override string getSelect(ObjPersistente obj)
        {
            return "SELECT * FROM Velocimetro WHERE OIDVelocimetro = " + obj.OID;
        }

        public override string getSelectAll(ObjPersistente obj)
        {
            return "SELECT * FROM Velocimetro";
        }
        public override void getInsert(ObjPersistente obj)
        {
            Velocimetro v = (Velocimetro)obj;

            string sql = "INSERT into Velocimetro(marca, modelo, precision, min, max, alarma, x, y, z, OIDVelocimetro) VALUES";
            sql = sql + "('" + v.marca + "',";
            sql = sql + "'" + v.modelo + "',";
            sql = sql + v.precision + ",";
            sql = sql + v.min + ",";
            sql = sql + v.max + ",";
            sql = sql + v.alarma + ",";
            sql = sql + v.x + ",";
            sql = sql + v.y + ",";
            sql = sql + v.z + ",";
            sql = sql + v.OID + ")";

            SQLConnection.Instance.EjecutarSentencia(sql);
        }

        public override string getDelete(ObjPersistente obj)
        {
            return SQLConnection.Instance.EjecutarSentencia("DELETE FROM Velocimetro WHERE OIDVelocimetro = " + obj.OID);
        }



        public override void getUpdate(ObjPersistente obj)
        {
            Velocimetro v = (Velocimetro)obj;
            string sql = "UPDATE Velocimetro SET ";

            sql = sql + "precision=" + v.precision + ",";
            sql = sql + "min=" + v.min + ",";
            sql = sql + "max=" + v.max + " WHERE OIDVelocimetro = " + v.OID;

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

            Velocimetro retorno = new Velocimetro(marca, modelo, precision, min, max, alarma, x, y, z);
            retorno.OID = oid;
            return retorno;
        }

        public override void getReferencias(ObjPersistente obj)
        {
        }
    }
}

