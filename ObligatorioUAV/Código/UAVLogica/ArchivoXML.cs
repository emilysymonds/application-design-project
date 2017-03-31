using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace UAVLogica
{
    public class ArchivoXML:Archivo
    {
        private Sistema sistema;
        private XDocument xml;
        private string path;

        public ArchivoXML() {
            sistema = Sistema.Instance;
            xml = new XDocument();
            path = "";
        }
        public ArchivoXML(string nombre): 
            base(nombre) {
                xml = new XDocument();
                sistema = Sistema.Instance;

                String path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                System.IO.DirectoryInfo directorio1 = System.IO.Directory.GetParent(path);
                System.IO.DirectoryInfo directorio2 = System.IO.Directory.GetParent(directorio1.ToString());
                System.IO.DirectoryInfo directorio3 = System.IO.Directory.GetParent(directorio2.ToString());
                System.IO.DirectoryInfo directorio4 = System.IO.Directory.GetParent(directorio3.ToString());

                string guardar = System.IO.Path.Combine(directorio4.ToString(), "Logs");
                this.path = guardar;                
        }

        public override void AgregarTitulo(Simulacion sim) {
            xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
            XElement raiz = new XElement("simulacion",
                   new XAttribute("id", sim.dron.nroSerie),
                   new XAttribute("diseno", sim.dron.diseñoDron.nombre),
                   new XAttribute("tinical", DateTime.Now.ToString("G")),
                   new XAttribute("desde", sim.coordX + ";" + sim.coordY + ";" + sim.coordZ),
                   new XAttribute("hasta", sim.coordXf + ";" + sim.coordYf + ";" + sim.coordYf)

            );
            xml.Add(raiz);
            xml.Save(path + @"\"+nombre + ".xml");
        }



        public override void AgregarAArchivo(Simulacion sim) {
            List<Pieza> listaPiezas = sistema.DevolverListaPiezas(sim.dron.diseñoDron.listaNodos);
            int pos = 0;
            string rep = "" + DateTime.Now.ToString() + " ";

            XElement agr = new XElement("lectura",
                   new XAttribute("t", DateTime.Now.ToString("T")));

            foreach (Pieza n in listaPiezas)
            {
                if (n is Velocimetro)
                {
                    Velocimetro p = (Velocimetro)n;
                    int x = p.x;
                    int y = p.y;
                    int z = p.z;
                   
                    XElement agr1 = new XElement("sensor",
                        new XAttribute("tipo", "velocímetro"),
                        new XAttribute("valor", x + ";" + y + ";" + z));
                    agr.Add(agr1);
                    pos = pos + 3;
                }
                if (n is Termometro)
                {
                    Termometro p = (Termometro)n;
                    int x = Convert.ToInt32(p.temperatura);
                    XElement agr2 = new XElement("sensor",
                        new XAttribute("tipo", "termómetro"),
                        new XAttribute("valor", x));
                    agr.Add(agr2);
                    pos = pos + 1;
                }
                if (n is Altimetro)
                {
                    Altimetro p = (Altimetro)n;
                    int x = p.altura;
                    XElement agr3 = new XElement("sensor",
                        new XAttribute("tipo", "altímetro"),
                        new XAttribute("valor", x));
                    agr.Add(agr3);
                    pos = pos + 1;
                }
                if (n is Barometro)
                {
                    Barometro p = (Barometro)n;
                    int x = p.presion;
                    XElement agr4 = new XElement("sensor",
                        new XAttribute("tipo", "barómetro"),
                        new XAttribute("valor", x));
                    agr.Add(agr4);
                    pos = pos + 1;
                }
                if (n is GPS)
                {
                    GPS p = (GPS)n;
                    int x = p.x;
                    int y = p.y;
                    int z = p.z;
                    XElement agr5 = new XElement("sensor",
                        new XAttribute("tipo", "gps"),
                        new XAttribute("valor", x + ";" + y + ";" + z));
                    //xml.Element("simulacion").Element("lectura").Add(agr5);
                    agr.Add(agr5);
                    pos = pos + 3;
                }
                if (n is Acelerometro)
                {
                    Acelerometro p = (Acelerometro)n;
                    int x = p.x;
                    int y = p.y;
                    int z = p.z;
                    XElement agr5 = new XElement("sensor",
                        new XAttribute("tipo", "acelerómetro"),
                        new XAttribute("valor", x + ";" + y + ";" + z));
                    //xml.Element("simulacion").Element("lectura").Add(agr5);
                    agr.Add(agr5);
                    pos = pos + 3;
                } 
            }
            xml.Element("simulacion").Add(agr);
            xml.Save(path + @"\" + nombre + ".xml");
        }
    }
}
