using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAVLogica
{
    public abstract class Archivo
    {
        public string nombre { get; set; }

        public Archivo()
        {
            nombre = "";
        }
        public Archivo(string n)
        {
            this.nombre = n;
        }
        public abstract void AgregarTitulo(Simulacion sim);

        public abstract void AgregarAArchivo(Simulacion sim);
        
    }
}
