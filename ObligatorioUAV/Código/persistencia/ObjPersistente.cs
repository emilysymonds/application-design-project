using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ObjPersistente
    {
        private int oid;
        public static IPersistencia ip;


        public ObjPersistente()
        {
        }

        public static IPersistencia IP
        {
            set { ip = value; }
        }

        public int OID
        {
            get { return oid; }
            set { oid = value; }
        }

        public int ObtenerOID()
        {
            return ip.ObtenerOID(this);
        }

        public void Insert()
        {
            ip.Insert(this);

        }

        public ObjPersistente Select()
        {
            return ip.Select(this);

        }

        public string Delete()
        {
            return ip.Delete(this);

        }

        public void Update()
        {
            ip.Update(this);
        }

        public List<ObjPersistente> SelectAll()
        {
            return ip.SelectAll(this);

        }

        public void CargarReferencias()
        {
            ip.CargarReferencias(this);
        }
    }
}

