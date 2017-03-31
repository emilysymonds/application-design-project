using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace UAVLogica
{
    public class Sistema : IObservable
    {
        private static Sistema instance;
        public List<Pieza> ListaPiezas { get; set; }
        public List<Componente> ListaComp { get; set; }
        public List<Diseño> ListaDeDiseños { get; set; }
        public List<Dron> ListaDeDrones { get; set; }
        private List<IObserver> ListaDeObservadores;
        private List<Simulacion> ListaSimulaciones{ get; set; }

        public Sistema() {
            ListaPiezas = new List<Pieza>();
            ListaComp = new List<Componente>();
            ListaDeDiseños = new List<Diseño>();
            ListaDeDrones = new List<Dron>();
            ListaDeObservadores = new List<IObserver>();
            ListaSimulaciones = new List<Simulacion>();
        }

        public static Sistema Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Sistema();
                }
                return instance;
            }
        }

        //OBSERVADORES
        public void AgregarObservador(IObserver o)
        {
            this.ListaDeObservadores.Add(o);
        }

        public void EliminarObservador(IObserver o)
        {
            this.ListaDeObservadores.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver observer in ListaDeObservadores)
            {
                observer.Update(this);
            }
        }

        //PIEZAS
        public bool AgregarPieza(Pieza p)
        {
            //verifico que no exista esa pieza
            foreach (Pieza item in ListaPiezas)
            {
                if (item.Equals(p))
                {
                    return false;
                }
            }
            ListaPiezas.Add(p);
            if (p is Acelerometro)
            {
                Acelerometro a = (Acelerometro)p;
                a.Insert();
            }
            if (p is Altimetro)
            {
                Altimetro a = (Altimetro)p;
                a.Insert();
            }
            if (p is Barometro)
            {
                Barometro b = (Barometro)p;
                b.Insert();
            }
            if (p is GPS)
            {
                GPS g = (GPS)p;
                g.Insert();
            }
            if (p is Termometro)
            {
                Termometro t = (Termometro)p;
                t.Insert();
            }
            if (p is Velocimetro)
            {
                Velocimetro v = (Velocimetro)p;
                v.Insert();
            }
            return true;
        }

        public bool VerificarPieza(Pieza p) {

            foreach (Componente c in ListaComp) {
                foreach (Nodo n in c.listaNodos) {
                    if (n is Pieza) {
                        if (n.Equals(p)) {
                            return true;
                        }
                    }
                   
                }
            }
            foreach (Diseño d in ListaDeDiseños)
            {
                foreach (Nodo n in d.listaNodos)
                {
                    if (n is Pieza)
                    {
                        if (n.Equals(p))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    
        //COMPONENTES
        public bool AgregarComp(Componente c) {
            foreach (Componente item in ListaComp)
            {
                if (item.Equals(c))
                {
                    return false;
                }
            }
            ListaComp.Add(c);
            c.Insert();
            return true;
        }

        public bool VerificarComponente(Componente p)
        {

            foreach (Componente c in ListaComp)
            {
                foreach (Nodo n in c.listaNodos)
                {
                    if (n is Componente)
                    {
                        if (n.Equals(p))
                        {
                            return true;
                        }
                    }

                }
            }
            foreach (Diseño d in ListaDeDiseños)
            {
                foreach (Nodo n in d.listaNodos)
                {
                    if (n is Componente)
                    {
                        if (n.Equals(p))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        //DISEÑOS
      
        public bool AgregarDiseño(Diseño d)
        {
            bool existe = false;
            foreach (Diseño diseño in ListaDeDiseños)
            {
                if (diseño.Equals(d))
                existe = true;
            }
            if (!existe){
                this.ListaDeDiseños.Add(d);
                d.Insert();
            }
            
            return !existe;
        }

        public int ProximoNumeroDis(Diseño d)
        {
            int version = 1;
            foreach (Diseño dis in ListaDeDiseños) {
                if (dis.nombre == d.nombre) {
                    version++;
                }
            }
            return version;
        } 

        public void DarBajaDiseño(Diseño d)
        {
            foreach (Diseño diseño in ListaDeDiseños)
            {
                if (diseño.Equals(d))
                this.ListaDeDiseños.Remove(d);
                d.Delete();
            }
        }


        //DRONES
        public int ProximoNumeroDron()
        {
            return Dron.GetProxNro();
        }


        public bool AgregarDron(Dron d) {
            bool existe = false;
            foreach (Dron dr in ListaDeDrones)
            {
                if (dr.Equals(d))
                    existe = true; 
            }
            if (!existe)
                this.ListaDeDrones.Add(d);
            return !existe;
        }

        //SIMULACION
        public int ProximoNumeroSimulacion()
        {
            return Simulacion.GetProxNro();
        }
        public bool AgregarSimulacion(Simulacion s)
        {
            bool existe = false;
            foreach (Simulacion sim in ListaSimulaciones)
            {
                if (sim.Equals(s))
                    existe = true;
            }
            if (!existe)
                this.ListaSimulaciones.Add(s);
            return !existe;
        }

        public List<Pieza> DevolverListaPiezas(List<Nodo> listaN) {
            List<Nodo> aux = new List<Nodo>();
            List<Pieza> listp = new List<Pieza>();

            foreach(Nodo n in listaN){
                aux = AgregarALista(n, aux);
            }
            foreach(Nodo nodo in aux){
                listp.Add((Pieza)nodo);
            }
            return listp;
        }
        public List<Nodo> AgregarALista(Nodo n,List<Nodo> aux) {
            if (n is Pieza)
            {
                aux.Add(n);
            }
            else
            {
                Componente c = (Componente)n;
                foreach (Nodo nodo in c.listaNodos)
                {
                    AgregarALista(nodo, aux);
                }
            }
            return aux;
            
        }

        public void ActualizarValores(Pieza n, int x, int y, int z){
            if (n is Termometro) {
                Termometro p = (Termometro)n;
                if (p.temperatura != x){
                    p.ModificarTermometro(x);
                    Notify();
                }
            } 
            if (n is Velocimetro)
            {
                Velocimetro p = (Velocimetro)n;
                if (p.x != x || p.y != y || p.z != z)
                {
                    p.ModificarVelocidad(x, y, z);
                    Notify();
                }
            }
            if (n is Altimetro)
            {
                Altimetro p = (Altimetro)n;
                if (p.altura != x)
                {
                    p.ModificarAltimetro(x);
                    Notify();
                }
            }
            if (n is Barometro)
            {
                Barometro p = (Barometro)n;
                if (p.presion != x)
                {
                    p.ModificarPresion(x);
                    Notify();
                }
            }
            if (n is GPS)
            {
                GPS p = (GPS)n;
                if (p.x != x || p.y != y || p.z != z){
                    p.ModificarCoord(x, y, z);
                    Notify();
                }
            }
            if (n is Acelerometro)
            {
                Acelerometro p = (Acelerometro)n;
                if (p.x != x || p.y != y || p.z != z)
                {
                    p.ModificarAceleracion(x, y, z);
                    Notify();
                }
            }
        }
        public void VerificarAlarma(Nodo n) {
            Pieza p = (Pieza)n;
            /*bool estadoAnterior = p.estadoAlarma;*/
            bool estadoActual = n.VerificarAlarma(n);
            if (estadoActual == true)
            {
                p.estadoAlarma = true;
                Notify();
            }
            else {
                p.estadoAlarma = false;
                Notify();
            }
        }

        public void VerificarAlarmaUrgente(Nodo n)
        {
            Pieza p = (Pieza)n;
            bool estadoActual = n.VerificarAlarmaUrgente(n);
            if (estadoActual == true)
            {
                p.estadoAlarmaUrgente = true;
                Notify();
            }
            else
            {
                p.estadoAlarmaUrgente = false;
                Notify();
            }
        }

        public void AgregarDatos()
        {
            Pieza p1 = new Termometro("CELKEL", "P_TERM123", 1, 2, 45, 40, 20.0);
            Pieza p2 = new Termometro("FIX", "P_TERM124", 2, 25, 35, 30, 20.0);
            Pieza p3 = new Termometro("RETREK", "P_TERM125", 2, 0, 40, 35, 21.0);
            Pieza p4 = new Altimetro("POTUD", "P_ALT123", 3, 5, 50, 40, 10);
            Pieza p5 = new Altimetro("KILD", "P_ALT124", 5, 10, 60, 40, 16);
            Pieza p6 = new Barometro("CELKEL", "P_BAR123", 1, 30, 60, 50, 35);
            Pieza p7 = new Velocimetro("FIX", "P_VEL123", 4, 15, 80, 60, 20, 40, 30);
            Pieza p8 = new Velocimetro("RETREK", "P_VEL124", 3, 5, 50, 45, 10, 20, 26);
            Pieza p9 = new GPS("POTUD", "P_GPS123", 2, 70, 100, 90, 73, 86, 80);
            Pieza p10 = new GPS("KILD", "P_GPS124", 2, 30, 90, 70, 35, 40, 50);
            Pieza p11 = new Acelerometro("JVD", "P_ACE124", 2, 30, 90, 70, 35, 40, 50);

            Pieza p12 = new GPS("HHH", "P_GPS124", 2, 30, 90, 70, 0, 0, 0);
            Pieza p13 = new Velocimetro("JVD", "P_VEL124", 2, 30, 90, 70, 0, 0, 0);
            //Pieza p14 = new Acelerometro("JVD", "P_ACE124", 2, 30, 90, 70, 35, 40, 50);


            this.AgregarPieza(p1);
            this.AgregarPieza(p2);
            this.AgregarPieza(p3);
            this.AgregarPieza(p4);
            this.AgregarPieza(p5);
            this.AgregarPieza(p6);
            this.AgregarPieza(p7);
            this.AgregarPieza(p8);
            this.AgregarPieza(p9);
            this.AgregarPieza(p10);
            this.AgregarPieza(p11);

            this.AgregarPieza(p12);
            this.AgregarPieza(p13);

            //creo un componente formado por 3 piezas
            List<Nodo> nodos1 = new List<Nodo>();
            nodos1.Add(p1);
            nodos1.Add(p4);
            nodos1.Add(p7);
            Componente c1 = new Componente("GGTOR", "C_COMP123", nodos1);
            this.AgregarComp(c1);

            //creo un componente formado por 2 piezas y 1 componente
            List<Nodo> nodos2 = new List<Nodo>();
            nodos2.Add(p4);
            nodos2.Add(p2);
            nodos2.Add(c1);
            Componente c2 = new Componente("DSMOG", "C_COMP124", nodos2);
            this.AgregarComp(c2);

            //creo un disenio
            List<Nodo> nodos3 = new List<Nodo>();
            nodos3.Add(p6);
            nodos3.Add(p10);
            nodos3.Add(c1);
            Diseño d1 = new Diseño("DIS1", 1, nodos3);
            this.AgregarDiseño(d1);

            //creo un disenio
            List<Nodo> nodos4 = new List<Nodo>();
            nodos4.Add(p5);
            nodos4.Add(p3);
            nodos4.Add(p9);
            nodos4.Add(p6);
            nodos4.Add(p8);
            Diseño d2 = new Diseño("DIS2", 1, nodos4);
            this.AgregarDiseño(d2);

            //creo un disenio version 2
            List<Nodo> nodos5 = new List<Nodo>();
            nodos5.Add(p5);
            nodos5.Add(p3);
            nodos5.Add(p9);
            nodos5.Add(p8);
            nodos5.Add(c2);
            Diseño d3 = new Diseño("DIS1", 2, nodos5);
            this.AgregarDiseño(d3);

            //creo un disenio
            List<Nodo> nodos6 = new List<Nodo>();
            nodos6.Add(p5);
            nodos6.Add(p7);
            nodos6.Add(p10);
            nodos6.Add(p11);
            Diseño d4 = new Diseño("DIS3", 1, nodos6);
            this.AgregarDiseño(d4);

            //creo un disenio
            List<Nodo> nodos7 = new List<Nodo>();
            nodos7.Add(p12);
            nodos7.Add(p13);
            
            Diseño d5 = new Diseño("DIS4", 1, nodos7);
            this.AgregarDiseño(d5);


            //creo drones
            int serie = this.ProximoNumeroDron();
            Dron dr1 = new Dron(10, serie, "Verde", "Sony", 500, d1);
            Dron dr2 = new Dron(30, serie, "Rojo", "Casio", 900, d2);
            Dron dr3 = new Dron(20, serie, "Azul", "Casio", 700, d1);
            Dron dr4 = new Dron(8, serie, "Verde", "Dell", 200, d4);
            Dron dr5 = new Dron(80, serie, "Verde", "Dell", 200, d5);

            this.AgregarDron(dr1);
            this.AgregarDron(dr2); 
            this.AgregarDron(dr3);
            this.AgregarDron(dr4);
            this.AgregarDron(dr5);

        }       
    }

}
    

