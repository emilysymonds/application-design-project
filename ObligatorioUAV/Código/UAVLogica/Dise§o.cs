using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace UAVLogica
{
    public class Diseño: ObjPersistente
    {
        public string nombre { get; set; }
        public int version { get; set; }
        public List<Nodo> listaNodos { get; set; }
     
        public Diseño() 
        {
            nombre = "";
            version = 0;
            listaNodos = new List<Nodo>();
        }

     

        public Diseño(string nomDiseño, int versionDiseño, List<Nodo> listaP)
        {

            nombre = nomDiseño;

            version = versionDiseño;

            listaNodos = listaP;

        }

        public void EditarDiseño(string nomDiseño, int versionDiseño, List<Nodo> listaP)
        {

            nombre = nomDiseño;

            version = versionDiseño;

            listaNodos = listaP;

        }
        
        public override string ToString()
        {
            return "Nombre del diseño: " + nombre + " - Versión: " + version+".0";
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
                Diseño unDiseño= (Diseño)obj;
                if (this.nombre == unDiseño.nombre)
                {
                    iguales = (this.version == unDiseño.version && this.nombre==unDiseño.nombre);
                }
                else { 
                    iguales = false;
                }
            }
            return iguales;
        }

        public override int GetHashCode()
        {
            return this.nombre.GetHashCode();
        }

       }
}
