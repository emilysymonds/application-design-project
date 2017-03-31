using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAVLogica
{
    public class Componente:Nodo
    {
       
        public List<Nodo> listaNodos { get; set; }

        public Componente() 
        {
            listaNodos = new List<Nodo>();
        }

        public Componente(string marca, string modelo, List<Nodo> listaN) 
            :base (marca, modelo)
        {
            listaNodos = listaN;
        }
        
        public override string ToString()
        {
            string ret = "Componente: Modelo: " + modelo + " - Marca: " + marca + "\n";
            /*foreach (Nodo n in listaNodos)
            {
                ret += n.ToString();
            }*/
             return ret;
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
                Componente unComp = (Componente)obj;
                iguales = (this.marca == unComp.marca && this.modelo == unComp.modelo);
            }
            return iguales;
        }

        public override int GetHashCode()
        {
            return this.modelo.GetHashCode() + this.marca.GetHashCode();
        }

        public override void AgregarHijo(Nodo n)
        {
            listaNodos.Add(n);
        }
        public override void EliminarHijo(Nodo n)
        {
            listaNodos.Remove(n);
        }
    }
}
