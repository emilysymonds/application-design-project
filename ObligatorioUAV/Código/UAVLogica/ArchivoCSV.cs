using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace UAVLogica
{
       
    public class ArchivoCSV: Archivo
    {
        private Sistema sistema;
        private string csv;

        public ArchivoCSV() {
            sistema = Sistema.Instance;
            csv = ""; ;
        }
        public ArchivoCSV(string nombre): 
            base(nombre) {
                sistema = Sistema.Instance;

                String path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                System.IO.DirectoryInfo directorio1 = System.IO.Directory.GetParent(path);
                System.IO.DirectoryInfo directorio2 = System.IO.Directory.GetParent(directorio1.ToString());
                System.IO.DirectoryInfo directorio3 = System.IO.Directory.GetParent(directorio2.ToString());
                System.IO.DirectoryInfo directorio4 = System.IO.Directory.GetParent(directorio3.ToString());

                string guardar = System.IO.Path.Combine(directorio4.ToString(), "Logs");
                csv = guardar + @"\" + nombre + ".csv";
                if (!File.Exists(csv))
                {
                    File.Create(csv).Close();
                }                
        }
        public override void AgregarTitulo(Simulacion sim)
        {                  
            List<string> agregar = new List<String>();
            string linea = "";
            string[][] output = new string[][] { new string[] { sim.dron.nroSerie.ToString(), sim.dron.diseñoDron.nombre,
                DateTime.Now.ToString("G"), sim.coordX + ";" + sim.coordY + ";" + sim.coordZ, sim.coordXf + ";" + sim.coordYf + ";" + sim.coordYf } };
            int length = output[0].Length;
            for (int i = 0; i < length; i++)
            {
                if (i == length)
                {
                    linea += output[0][i];
                }
                else
                {
                    linea += output[0][i] + ",";
                }
            }
            
            agregar.Add(linea);
            AgregarLinea(agregar, csv);           
            
        }

        private void AgregarLinea(List<string> columnas, string filePath) {
            string delimiter = ",";
            StringBuilder sb = new StringBuilder();
            foreach (string s in columnas) {
                sb.AppendLine(string.Join(delimiter, s));
            }
           // sb.Length--;
            File.AppendAllText(filePath, sb.ToString());
        }
     

        public override void AgregarAArchivo(Simulacion sim)
        {
            List<Pieza> listaPiezas = sistema.DevolverListaPiezas(sim.dron.diseñoDron.listaNodos);
            int pos = 0;
            List<string> agregar = new List<String>();
            string linea = "";

            linea+=(DateTime.Now.ToString("T")+",");
            foreach (Pieza n in listaPiezas)
            {
                if (n is Velocimetro)
                {
                    Velocimetro p = (Velocimetro)n;
                    int x = p.x;
                    int y = p.y;
                    int z = p.z;
                    linea += ("s") + ",";
                    linea += ("velocímetro") + ",";
                    linea += (x + ";" + y + ";" + z) + ",";
                    pos = pos + 3;
                }
                if (n is Termometro)
                {
                    Termometro p = (Termometro)n;
                    int x = Convert.ToInt32(p.temperatura);
                    linea += ("s") + ",";
                    linea += ("termómetro") + ",";
                    linea += (x.ToString() + ",");
                    pos = pos + 1;
                }
                if (n is Altimetro)
                {
                    Altimetro p = (Altimetro)n;
                    int x = p.altura;
                    linea += ("s" + ",");
                    linea += ("altímetro") + ",";
                    linea += (x.ToString()) + ",";
                    pos = pos + 1;
                }
                if (n is Barometro)
                {
                    Barometro p = (Barometro)n;
                    int x = p.presion;
                    linea += ("s") + ",";
                    linea += ("barómetro") + ",";
                    linea += (x.ToString()) + ",";
                    pos = pos + 1;
                }
                if (n is GPS)
                {
                    GPS p = (GPS)n;
                    int x = p.x;
                    int y = p.y;
                    int z = p.z;
                    linea += ("s") + ",";
                    linea += ("gps") + ",";
                    linea += (x + ";" + y + ";" + z) + ",";                    
                    pos = pos + 3;
                }
                if (n is Acelerometro)
                {
                    Acelerometro p = (Acelerometro)n;
                    int x = p.x;
                    int y = p.y;
                    int z = p.z;
                    linea += ("s") + ",";
                    linea += ("gps") + ",";
                    linea += (x + ";" + y + ";" + z) + ",";
                    pos = pos + 3;
                }
            }
            int index = linea.Length - 1;
            linea.Remove(index);            
            agregar.Add(linea);
            AgregarLinea(agregar, csv);

            string s = "hola,";
            int ind = s.Length - 1;
            s.Remove(ind,1);
        }
    }

}
