using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using UAVLogica;

namespace PersistenciaImp
{
    public class PersistenciaImpl : IPersistencia
    {
        private Broker GetBroker(ObjPersistente obj)
        {
            if (obj is Acelerometro)
                return new BrokerAcelerometro();
            if (obj is Altimetro)
                return new BrokerAltimetro();
            if (obj is Barometro)
                return new BrokerBarometro();
            if (obj is GPS)
                return new BrokerGPS();
            if (obj is Termometro)
                return new BrokerTermometro();
            if (obj is Velocimetro)
                return new BrokerVelocimetro();
            if (obj is Componente)
                return new BrokerComponente();
            if (obj is Diseño)
                return new BrokerDiseño();
            return null;
        }

        public int ObtenerOID(ObjPersistente obj)
        {
            Broker br = GetBroker(obj);
            return br.ObtenerOID(obj);
        }

        public void Insert(ObjPersistente obj)
        {
            Broker br = GetBroker(obj);
            br.Insert(obj);
        }

        public ObjPersistente Select(ObjPersistente obj)
        {
            Broker br = GetBroker(obj);
            return br.Select(obj);

        }

        public string Delete(ObjPersistente obj)
        {
            Broker br = GetBroker(obj);
            return br.Delete(obj);
        }

        public void Update(ObjPersistente obj)
        {
            Broker br = GetBroker(obj);
            br.Update(obj);
        }

        public List<ObjPersistente> SelectAll(ObjPersistente obj)
        {
            Broker br = GetBroker(obj);
            return br.SelectAll(obj);

        }

        public void CargarReferencias(ObjPersistente obj)
        {
            Broker br = GetBroker(obj);
            br.getReferencias(obj);
        }
    }
}


