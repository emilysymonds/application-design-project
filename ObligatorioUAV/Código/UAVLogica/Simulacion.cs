using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAVLogica
{
    public class Simulacion
    {
        public int nroSimulacion;
        public int alarma { get; set; }
        public int coordX { get; set; }
        public int coordY { get; set; }
        public int coordZ { get; set; }
        public int coordXf { get; set; }
        public int coordYf { get; set; }
        public int coordZf { get; set; }
        public int velocidadX { get; set; }
        public int velocidadY { get; set; }
        public int velocidadZ { get; set; }
        public Dron dron { get; set; }
        public List<string> reportes { get; set; }
        private static int proxNro = 100;

        private int ProxNro
        {
            get { return proxNro; }
            set { proxNro = value; }
        }
        
        public Simulacion() 
        {
            nroSimulacion = proxNro;
            proxNro++;
            alarma = 0;
            coordX = 0;
            coordY = 0;
            coordZ = 0;
            coordXf = 0;
            coordYf = 0;
            coordZf = 0;
            velocidadX = 0;
            velocidadY = 0;
            velocidadZ = 0;            
            dron = new Dron();
            reportes = new List<string>();
        }

        public Simulacion(int alarmaS, int coorX, int coorY, int coorZ, int coorXf, int coorYf, int coorZf, int velX, int velY, int velZ, Dron d) 
        {
            nroSimulacion = proxNro;
            proxNro++;
            alarma = alarmaS;
            coordX = coorX;
            coordY = coorY;
            coordZ = coorZ;
            coordXf = coorXf;
            coordYf = coorYf;
            coordZf = coorZf;
            velocidadX = velX;
            velocidadY = velY;
            velocidadZ = velZ;
            dron = d;
            reportes = new List<string>();
        }

        public void AgregarReporte(string texto) {
            string ret = texto;
            reportes.Add(ret);
        }

        public override string ToString()
        {
            return "";
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
                Simulacion unaSimulacion = (Simulacion)obj;
                iguales = (this.nroSimulacion == unaSimulacion.nroSimulacion);
            }
            return iguales;
        }

        public override int GetHashCode()
        {
            return this.nroSimulacion.GetHashCode();
        }
        public static int GetProxNro()
        {
            return proxNro;
        }
    }
}
