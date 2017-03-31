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
    public class BrokerAltimetro : Broker
    {
        public BrokerAltimetro()
        {
        }

        public override string getSelect(ObjPersistente obj)
        {
            return "SELECT * FROM Altimetro WHERE OIDAltimetro = " + obj.OID;
        }

        public override string getSelectAll(ObjPersistente obj)
        {
            return "SELECT * FROM Altimetro";
        }
        public override void getInsert(ObjPersistente obj)
        {
            Altimetro a = (Altimetro)obj;

            string sql = "INSERT into Altimetro(marca, modelo, precision, min, max, alarma, estadoAlarma, altura, OIDAltimetro) VALUES";
            sql = sql + "('" + a.marca + "',";
            sql = sql + "'" + a.modelo + "',";
            sql = sql + a.precision + ",";
            sql = sql + a.min + ",";
            sql = sql + a.max + ",";
            sql = sql + a.alarma + ",";
            sql = sql + "'" + a.estadoAlarma + "',";
            //sql = sql + 0 + ",";
            sql = sql + a.altura + ",";
            sql = sql + a.OID + ")";

            SQLConnection.Instance.EjecutarSentencia(sql);
        }

        public override string getDelete(ObjPersistente obj)
        {
            return SQLConnection.Instance.EjecutarSentencia("DELETE FROM Altimetro WHERE OIDAltimetro = " + obj.OID);
        }



        public override void getUpdate(ObjPersistente obj)
        {
            Altimetro a = (Altimetro)obj;
            string sql = "UPDATE Altimetro SET ";

            sql = sql + "precision=" + a.precision + ",";
            sql = sql + "min=" + a.min + ",";
            sql = sql + "max=" + a.max + " WHERE OIDAltimetro = " + a.OID;

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
            int altura = d.GetInt32(8);
            int oid = d.GetInt32(9);

            Altimetro retorno = new Altimetro(marca, modelo, precision, min, max, alarma, altura);
            retorno.estadoAlarma = estado;
            retorno.OID = oid;
            return retorno;
        }

        public override void getReferencias(ObjPersistente obj)
        {
        }
    }
}
