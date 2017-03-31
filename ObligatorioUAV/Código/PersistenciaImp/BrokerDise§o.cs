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
    public class BrokerDiseño : Broker
    {
        public BrokerDiseño()
        {
        }

        public override string getSelect(ObjPersistente obj)
        {
            return "SELECT * FROM Diseño WHERE OIDDiseño = " + obj.OID;
        }

        public override string getSelectAll(ObjPersistente obj)
        {
            return "SELECT * FROM Diseño";
        }
        public override void getInsert(ObjPersistente obj)
        {
            Diseño d = (Diseño)obj;

            string sql = "INSERT into Diseño(nombre, version, OIDDiseño) VALUES";
            sql = sql + "('" + d.nombre + "',";
            sql = sql + d.version + ",";
            sql = sql + d.OID + ")";

            foreach (Nodo n in d.listaNodos)
            {
                if (n is Pieza)
                {
                    string sqlComp = "INSERT into Pieza_Diseño(OIDPieza, OIDDiseño) values";
                    sqlComp = sqlComp + "(" + n.OID + ",";
                    sqlComp = sqlComp + d.OID + ")";
                    SQLConnection.Instance.EjecutarSentencia(sqlComp);
                }
                if (n is Componente)
                {
                    string sqlComp = "INSERT into Componente_Diseño(OIDComponente, OIDDiseño) values";
                    sqlComp = sqlComp + "(" + n.OID + ",";
                    sqlComp = sqlComp + d.OID + ")";
                    SQLConnection.Instance.EjecutarSentencia(sqlComp);
                }
            }

            SQLConnection.Instance.EjecutarSentencia(sql);
        }

        public override string getDelete(ObjPersistente obj)
        {
            string sql = "DELETE FROM Componente_Diseño WHERE OIDDiseño = " + obj.OID;
            SQLConnection.Instance.EjecutarSentencia(sql);
            string sql2 = "DELETE FROM Pieza_Diseño WHERE OIDDiseño = " + obj.OID;
            SQLConnection.Instance.EjecutarSentencia(sql2);
            return SQLConnection.Instance.EjecutarSentencia("DELETE FROM Diseño WHERE OID = " + obj.OID);
        }



        public override void getUpdate(ObjPersistente obj)
        {
            Diseño d = (Diseño)obj;
            string sqlP = "DELETE FROM Pieza_Diseño WHERE OIDDiseño = " + d.OID;
            SQLConnection.Instance.EjecutarSentencia(sqlP);
            string sqlC = "DELETE FROM Componente_Diseño WHERE OIDDiseño = " + d.OID;
            SQLConnection.Instance.EjecutarSentencia(sqlC);

            foreach (Nodo n in d.listaNodos)
            {
                if (n is Pieza)
                {
                    string sqlComp = "INSERT into Pieza_Diseño(OIDPieza, OIDDiseño) values";
                    sqlComp = sqlComp + "(" + n.OID + ",";
                    sqlComp = sqlComp + d.OID + ")";
                    SQLConnection.Instance.EjecutarSentencia(sqlComp);
                }
                if (n is Componente)
                {
                    string sqlComp = "INSERT into Componente_Diseño(OIDComponente, OIDDiseño) values";
                    sqlComp = sqlComp + "(" + n.OID + ",";
                    sqlComp = sqlComp + d.OID + ")";
                    SQLConnection.Instance.EjecutarSentencia(sqlComp);
                }
            }
        }

        protected override ObjPersistente ReaderToObject(SqlDataReader d)
        {
            string nombre = d.GetString(0);
            int version = d.GetInt32(1);
            int dron = d.GetInt32(3);
            int oid = d.GetInt32(4);

            Diseño retorno = new Diseño(nombre, version, null);
            retorno.OID = oid;
            return retorno;
        }

        public override void getReferencias(ObjPersistente obj)
        {
        }
    }
}

