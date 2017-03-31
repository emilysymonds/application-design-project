using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAVLogica
{
    
        public interface IObservable
        {
            void AgregarObservador(IObserver o);

            void EliminarObservador(IObserver o);

            void Notify();
        }
    
}
