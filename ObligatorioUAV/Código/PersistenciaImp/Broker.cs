using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using UAVLogica;
using Persistencia;

namespace PersistenciaImp
{
    public abstract class Broker
    {
        private ObjPersistente obj { set; get; }

        public Broker()
        {
            obj = null;
        }

        public Broker(ObjPersistente objeto)
        {
            obj = objeto;
        }

        public int ObtenerOID(ObjPersistente obj)
        {
            return SQLConnection.Instance.obtenerID();
        }

        public void Insert(ObjPersistente obj)
        {
            //Obtengo el último id
            obj.OID = SQLConnection.Instance.obtenerID();

            //Ejecuto la consulta.
            this.getInsert(obj);

            //Actualizo el último OID utilizado
            SQLConnection.Instance.EjecutarSentencia("UPDATE OIDActual SET ultimoOID = " + obj.OID);
        }

        public ObjPersistente Select(ObjPersistente obj)
        {
            //Leo la consulta dependiendo del obj que sea
            ObjPersistente ret = new ObjPersistente();
            //Cargo en ret el objpersitente que retorna la consulta
            SqlDataReader read = SQLConnection.Instance.EjecutarConsulta(this.getSelect(obj));
            if (read.Read())
            {
                ret = ReaderToObject(read);
            }
            return ret;
        }

        public string Delete(ObjPersistente obj)
        {
            return this.getDelete(obj);
        }

        public void Update(ObjPersistente obj)
        {
            this.getUpdate(obj);
        }

        public List<ObjPersistente> SelectAll(ObjPersistente obj)
        {
            List<ObjPersistente> ret = new List<ObjPersistente>();
            SqlDataReader reader = null;
            try
            {
                reader = SQLConnection.Instance.EjecutarConsulta(this.getSelectAll(obj));
                while (reader.Read())
                {
                    ObjPersistente nuevo = ReaderToObject(reader);
                    ret.Add(nuevo);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error", e);
            }
            finally
            {
                reader.Close();
                SQLConnection.Instance.Cerrar();
            }
            return ret;
        }

        public abstract void getInsert(ObjPersistente obj);
        public abstract string getSelect(ObjPersistente obj);
        public abstract string getDelete(ObjPersistente obj);
        public abstract void getUpdate(ObjPersistente obj);
        public abstract string getSelectAll(ObjPersistente obj);
        public abstract void getReferencias(ObjPersistente obj);
        protected abstract ObjPersistente ReaderToObject(SqlDataReader d);
    }
}

