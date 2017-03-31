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
    public class BrokerComponente : Broker
    {
        public BrokerComponente()
        {
        }

        public override string getSelect(ObjPersistente obj)
        {
            return "SELECT * FROM Componente WHERE OIDComponente = " + obj.OID;
        }

        public override string getSelectAll(ObjPersistente obj)
        {
            return "SELECT * FROM Componente";
        }
        public override void getInsert(ObjPersistente obj)
        {
            Componente c = (Componente)obj;

            string sql = "INSERT into Componente(marca, modelo, OIDComponente) VALUES";
            sql = sql + "('" + c.marca + "',";
            sql = sql + "'" + c.modelo + "',";
            sql = sql + c.OID + ")";

            foreach (Nodo n in c.listaNodos)
            {
                if (n is Pieza)
                {
                    string sqlComp = "INSERT into Pieza_Componente(OIDComponente, OIDPieza) values";
                    sqlComp = sqlComp + "(" + c.OID + ",";
                    sqlComp = sqlComp + n.OID + ")";
                    SQLConnection.Instance.EjecutarSentencia(sqlComp);
                }
                if (n is Componente)
                {
                    string sqlComp = "INSERT into Componente_Componente(OIDComponente, OIDComponenteS) values";
                    sqlComp = sqlComp + "(" + c.OID + ",";
                    sqlComp = sqlComp + n.OID + ")";
                    SQLConnection.Instance.EjecutarSentencia(sqlComp);
                }
            }

            SQLConnection.Instance.EjecutarSentencia(sql);
        }

        public override string getDelete(ObjPersistente obj)
        {
            return SQLConnection.Instance.EjecutarSentencia("DELETE FROM Componente WHERE OIDComponente = " + obj.OID);

        }


        public override void getUpdate(ObjPersistente obj)
        {
            Componente c = (Componente)obj;
            string sqlCompP = "DELETE FROM Pieza_Componente WHERE OIDComponente = " + c.OID;
            SQLConnection.Instance.EjecutarSentencia(sqlCompP);
            string sqlCompC = "DELETE FROM Componente_Componente WHERE OIDComponente = " + c.OID;
            SQLConnection.Instance.EjecutarSentencia(sqlCompC);

            foreach (Nodo n in c.listaNodos)
            {
                if (n is Pieza)
                {
                    string sqlComp = "INSERT into Pieza_Componente(OIDComponente, OIDPieza) values";
                    sqlComp = sqlComp + "(" + c.OID + ",";
                    sqlComp = sqlComp + n.OID + ")";
                    SQLConnection.Instance.EjecutarSentencia(sqlComp);
                }
                if (n is Componente)
                {
                    string sqlComp = "INSERT into Componente_Componente(OIDComponente, OIDComponenteS) values";
                    sqlComp = sqlComp + "(" + c.OID + ",";
                    sqlComp = sqlComp + n.OID + ")";
                    SQLConnection.Instance.EjecutarSentencia(sqlComp);
                }
            }
        }

        protected override ObjPersistente ReaderToObject(SqlDataReader d)
        {

            string marca = d.GetString(0);
            string modelo = d.GetString(1);
            int diseño = d.GetInt32(2);
            int oid = d.GetInt32(3);

            Componente retorno = new Componente(marca, modelo, null);
            retorno.OID = oid;
            return retorno;
        }

        public override void getReferencias(ObjPersistente obj)
        {
        }
    }
}
