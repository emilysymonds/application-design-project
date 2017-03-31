using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistencia
{
    public interface IPersistencia
    {
        void Insert(ObjPersistente obj);
        int ObtenerOID(ObjPersistente obj);
        ObjPersistente Select(ObjPersistente obj);
        List<ObjPersistente> SelectAll(ObjPersistente obj);
        void CargarReferencias(ObjPersistente obj);
        void Update(ObjPersistente obj);
        string Delete(ObjPersistente obj);
    }
}
