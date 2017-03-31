using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAVLogica
{
    public class Termometro:Pieza
    {
        //variables de termometro
        public double temperatura;

        //contructor sin parametros
        public Termometro() {
          temperatura=0.0;
        }

         public Termometro(string marca, string modelo, int precisionP, int minP, int maxP, int alarmaP, double temp) 
            :base(marca, modelo, precisionP, minP, maxP, alarmaP)
        {
            temperatura = temp;
        }

         //Método utilizado al momento de editar la pieza
         public void ModificarTermometro(double temperatura)
         {
             this.temperatura = temperatura;
            
         }

         //Método utilizado para mostrar los datos 
         public override string ToString()
         {
             return "Termómetro - " + base.ToString();
         }

         public double ObtenerTemperatura()
         {
             return temperatura;
         }

         public override int Tipo()
         {
             return 1;
            
         }

         public override bool VerificarAlarma(Nodo n)
         {
             Termometro t = (Termometro)n;
             if (t.temperatura + precision >= alarma)
             {
                 return true;
             }
             else return false;
         }

         public override bool VerificarAlarmaUrgente(Nodo n)
         {
             Termometro t = (Termometro)n;
             if ((t.temperatura + precision >= max) || (t.temperatura - precision <= min))
             {
                 return true;

             }
             else return false;
         }
    }
}
