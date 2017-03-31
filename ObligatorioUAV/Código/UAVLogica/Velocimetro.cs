using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAVLogica
{
    public class Velocimetro:Pieza
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Velocimetro()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Velocimetro(string marca, string modelo, int precisionP, int minP, int maxP, int alarmaP, int auxX, int auxY, int auxZ)
        :base(marca, modelo, precisionP, minP, maxP, alarmaP)
        {
            x = auxX;
            y = auxY;
            z = auxZ;         
        }

        //Modificar velocidad
        public void ModificarVelocidad(int xN, int yN, int zN)
        {
            this.x = xN;
            this.y = yN;
            this.z = zN;
        }

        //Método utilizado para mostrar los datos 
        public override string ToString()
        {
            return "Velocímetro - "+ base.ToString();
        }

        public string ObtenerVelocidad()
        {
            return " x="+x+", y="+y+", z="+z;
        }
        
        public override int Tipo()
        {
            return 2;
        }

        public override bool VerificarAlarma(Nodo n)
        {
            Velocimetro v = (Velocimetro)n;
            if (v.x + precision >= alarma || v.y + precision >= alarma || v.z + precision >= alarma)
            {
                return true;
            }
            else return false;
        }
        public override bool VerificarAlarmaUrgente(Nodo n)
        {
            Velocimetro v = (Velocimetro)n;
            if (v.x + precision >= max || v.y + precision >= max || v.z + precision >= max  || v.x - precision <= min || v.y - precision <= min || v.z - precision <= min)
            {
                return true;

            }
            else return false;
        }
        
    }
}
