using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAVLogica
{
    public class Dron
    {
        public int cantidad { get; set; }
        public int nroSerie { get; set; }
        public string color { get; set; }
        public string modeloControl { get; set; }
        public int precio { get; set; }
        public Diseño diseñoDron { get; set; }
        private static int proxNroDron = 100;

        private int ProxNroDron
        {
            get { return proxNroDron; }
            set { proxNroDron = value; }
        }

        public Dron()
        {
            nroSerie = proxNroDron;
            proxNroDron++;
            cantidad = 0;
            color="";
            modeloControl = "";
            precio = 0;
            diseñoDron = new Diseño();
        }

        public Dron(int cant, int nro, string colorDron, string control, int precioDron, Diseño diseño) 
        {
            nroSerie = proxNroDron;
            proxNroDron++;
            cantidad = cant;
            color = colorDron;
            modeloControl = control;
            precio = precioDron;
            diseñoDron = diseño;
               
        }

        public Diseño ObtenerDiseño()
        {
            return this.diseñoDron;
        }

        public static int GetProxNro()
        {
            return proxNroDron;
        }

        public override string ToString()
        {
            return "Dron número: " + nroSerie + " - Diseño: " + diseñoDron + " - Precio: " + precio;
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
                Dron unDron = (Dron)obj;
                iguales = (this.nroSerie == unDron.nroSerie);
            }
            return iguales;
        }

        public override int GetHashCode()
        {
            return this.nroSerie.GetHashCode();
        }
    }
}
