using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAVLogica
{
    public class Acelerometro:Pieza
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Acelerometro()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Acelerometro(string marca, string modelo, int precisionP, int minP, int maxP, int alarmaP, int auxX, int auxY, int auxZ)
        :base(marca, modelo, precisionP, minP, maxP, alarmaP)
        {
            x = auxX;
            y = auxY;
            z = auxZ;         
        }

        //Modificar aceleracion
        public void ModificarAceleracion(int xN, int yN, int zN)
        {
            this.x = xN;
            this.y = yN;
            this.z = zN;
        }

        //Método utilizado para mostrar los datos 
        public override string ToString()
        {
            return "Acelerómetro - " + base.ToString();
        }

        public string ObtenerAceleracion()
        {
            return " x="+x+", y="+y+", z="+z;
        }
        public override int Tipo()
        {
            return 6;
        }

        public override bool VerificarAlarma(Nodo n)
        {
            Acelerometro v = (Acelerometro)n;
            if (v.x + precision >= alarma || v.y + precision >= alarma || v.z + precision >= alarma)
            {
                return true;
            }
            else return false;
        }

        public override bool VerificarAlarmaUrgente(Nodo n)
        {
            Acelerometro v = (Acelerometro)n;
            if (v.x + precision >= max || v.y + precision >= max || v.z + precision >= max ||  v.x - precision <= min || v.y - precision <= min || v.z - precision <= min)
            {
                return true;
            }
            else return false;
        }
        
    }
}
