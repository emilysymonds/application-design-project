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
    public class BrokerTermometro : Broker
    {
        public BrokerTermometro()
        {
        }

        public override string getSelect(ObjPersistente obj)
        {
            return "SELECT * FROM Termometro WHERE OIDTermometro = " + obj.OID;
        }

        public override string getSelectAll(ObjPersistente obj)
        {
            return "SELECT * FROM Termometro";
        }
        public override void getInsert(ObjPersistente obj)
        {
            Termometro t = (Termometro)obj;

            string sql = "INSERT into Termometro(marca, modelo, precision, min, max, alarma, estadoAlarma, temperatura, OIDTermometro) VALUES";
            sql = sql + "('" + t.marca + "',";
            sql = sql + "'" + t.modelo + "',";
            sql = sql + t.precision + ",";
            sql = sql + t.min + ",";
            sql = sql + t.max + ",";
            sql = sql + t.alarma + ",";
            sql = sql + "'" + t.estadoAlarma + "',";
            sql = sql + t.temperatura + ",";
            sql = sql + t.OID + ")";

            SQLConnection.Instance.EjecutarSentencia(sql);
        }

        public override string getDelete(ObjPersistente obj)
        {
            return SQLConnection.Instance.EjecutarSentencia("DELETE FROM Termometro WHERE OIDTermometro = " + obj.OID);
        }

        public override void getUpdate(ObjPersistente obj)
        {
            Termometro v = (Termometro)obj;
            string sql = "UPDATE Termometro SET ";

            sql = sql + "precision=" + v.precision + ",";
            sql = sql + "min=" + v.min + ",";
            sql = sql + "max=" + v.max + " WHERE OIDTermometro = " + v.OID;

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
            int temperatura = d.GetInt32(8);
            int oid = d.GetInt32(9);

            Termometro retorno = new Termometro(marca, modelo, precision, min, max, alarma, temperatura);
            retorno.estadoAlarma = estado;
            retorno.OID = oid;
            return retorno;
        }

        public override void getReferencias(ObjPersistente obj)
        {
            Termometro t = (Termometro)obj;
            SqlDataReader data = SQLConnection.Instance.EjecutarConsulta("SELECT OIDComponente FROM Termometro WHERE OID = " + t.OID);
            while (data.Read())
            {
                int oid = data.GetInt32(0);
            }
            data.Close();
        }
    }
}

