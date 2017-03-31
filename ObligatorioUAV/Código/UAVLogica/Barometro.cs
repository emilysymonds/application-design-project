using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAVLogica
{
    public class Barometro:Pieza
    {
        //variables de barometro
        public int presion;

        //contructor sin parametros
        public Barometro() {
            presion=0;
        }

         public Barometro(string marca, string modelo, int precisionP, int minP, int maxP, int alarmaP, int presionP) 
            :base(marca, modelo, precisionP, minP, maxP, alarmaP)
        {
            presion = presionP;
        }

         //Método utilizado al momento de editar la pieza
         public void ModificarPresion(int p)
         {
             this.presion = p;
            
         }

         //Método utilizado para mostrar los datos 
         public override string ToString()
         {
             return "Barómetro - " + base.ToString();
         }

         public double ObtenerPresion()
         {
             return presion;
         }
         public override int Tipo()
         {
             return 4;
         }
         public override bool VerificarAlarma(Nodo n)
         {
             Barometro b = (Barometro)n;
             if (b.presion + precision >= alarma)
             {
                 return true;
             }
             else return false;
         }
         public override bool VerificarAlarmaUrgente(Nodo n)
         {
             Barometro b = (Barometro)n;
             if (b.presion + precision >= max || b.presion - precision <= min)
             {
                 return true;

             }
             else return false;
         }
    }
}
