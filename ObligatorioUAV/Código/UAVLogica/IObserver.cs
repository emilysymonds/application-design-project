using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAVLogica
{
    public interface IObserver
    {
        void Update(IObservable o);
    }
}
