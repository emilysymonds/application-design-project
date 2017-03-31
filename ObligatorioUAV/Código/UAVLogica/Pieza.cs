using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAVLogica
{
    public class Pieza: Nodo
    {
       
        public int precision { get; set; }
        public int min { get; set; }
        public int max { get; set; }
        public int alarma { get; set; }
        public bool estadoAlarma { get; set; }
        public bool estadoAlarmaUrgente { get; set; }

        public Pieza()
        {
            precision = 0;
            min = 0;
            max = 0;
            alarma = 0;
            estadoAlarma = false;
        }

        public Pieza(string marca, string modelo, int precisionP, int minP, int maxP, int alarmaP)
            :base(marca, modelo)
        {
            precision = precisionP;
            min = minP;
            max = maxP;
            alarma = alarmaP;
            estadoAlarma = false;
            estadoAlarmaUrgente = false;
        }

        public override string ToString()
        {
           return "Modelo: " + modelo + " - Marca: " + marca;
        }

       public override bool Equals(Object obj)
        {
            bool iguales;
            if (obj == null || GetType().BaseType != obj.GetType().BaseType)
            {
                iguales = false;
            }
            else
            {
                Pieza unaPieza = (Pieza)obj;
                iguales = (this.marca == unaPieza.marca && this.modelo==unaPieza.modelo);
            }
            return iguales;
        }

        public override int GetHashCode()
        {
           return this.marca.GetHashCode() + this.modelo.GetHashCode();
        }

        public virtual int Tipo() {
            return 0;
        }
        public bool SetearAlarma(int alarma)
        {
            bool retorno = false;
            if ((alarma <= this.max) && (alarma >= this.min))
            {
                this.alarma = alarma;
                retorno = true;
            }
            return retorno;
        }

        
       
    }
}
