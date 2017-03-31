using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAVLogica
{
    public class Altimetro:Pieza
    {
        //variables de altimetro
        public int altura{get; set;}

        //contructor sin parametros
        public Altimetro() {
          altura=0;
        }

         public Altimetro(string marca, string modelo, int precisionP, int minP, int maxP, int alarmaP, int alt) 
            :base(marca, modelo, precisionP, minP, maxP, alarmaP)
        {
            altura = alt;
        }

         //Editar la pieza
         public void ModificarAltimetro(int alt)
         {
             this.altura = alt;
            
         }

         //Método utilizado para mostrar los datos 
         public override string ToString()
         {
             return "Altímetro - " + base.ToString();
         }

         public double ObtenerAltura()
         {
             return altura;
         }

         public override int Tipo()
         {
             return 3;
         }
         public override bool VerificarAlarma(Nodo n)
         {
             Altimetro a = (Altimetro)n;
             if (a.altura + precision >= alarma)
             {
                 return true;

             }
             else return false;
         }

         public override bool VerificarAlarmaUrgente(Nodo n)
         {
             Altimetro a = (Altimetro)n;
             if ((a.altura + precision >= max) || (a.altura - precision <= min))
             {
                 return true;

             }
             else return false;
         }
    }
}
