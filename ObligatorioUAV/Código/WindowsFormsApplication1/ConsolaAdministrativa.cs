using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAVLogica;



namespace WindowsFormsApplication1
{
    public partial class ConsolaAdministrativa : Form, IObserver
    {
        private Sistema sistema;
        private Simulacion sim;
        private List<TextBox> listaTextBoxes = new List<TextBox>();
        private Timer timer = new Timer();
        private Timer timer2 = new Timer();
        private Timer timer3 = new Timer();
        private static bool estadoAnterior;
        private static bool estadoDespues;
        private static Pieza nodoLocal;
        private static int veces = 0;
        private static int segundos = 0;
        private static bool auto;
        private int tabindex = 50;
        private Archivo archivoXML;
        private Archivo archivoCSV;

        public ConsolaAdministrativa(Simulacion s)
        {
            sistema = Sistema.Instance;
            sim = s;
            InitializeComponent();
            nodoLocal = new Pieza();
            sistema.AgregarObservador(this);
            if (sim.dron.nroSerie == 100)
            {
                modificar.Visible = false;
                sim100.Visible = true;
                sim2.Visible = false;
                sim100.Text = "Simulación automática de 68 segundos";
                auto = true;
            }
            else if (sim.dron.nroSerie == 101) {
                modificar.Visible = false;
                sim100.Visible = false;
                sim2.Visible = true;
                auto = true;
            }
            else
            {
                sim100.Visible = false;
                sim2.Visible = true;
                auto = false;
                modificar.Visible = true;
                sim2.Text = "Simulación manual";

            }
            int n = CantidadPiezas(s.dron.diseñoDron.listaNodos);
            List<Pieza> listaPiezas = sistema.DevolverListaPiezas(s.dron.diseñoDron.listaNodos);
            TextBox[] textBoxes = new TextBox[n];
            Label[] labels = new Label[n];
            Label[] labels1 = new Label[n];
            int x = 12;
            int y = 44;
            int x2 = 334;
            int y2 = 41;
            int x3=370;
            int width = 35;
            int height = 13;
            int i=0;
            
            foreach (Pieza nodo in listaPiezas)
            {
                textBoxes[i] = new TextBox();
                labels1[i] = new Label();
                textBoxes[i].SetBounds(x2, y2, width, height);
                labels1[i].SetBounds(x3,y2,25,height);
                textBoxes[i].AutoSize = true;
                textBoxes[i].TextAlign = HorizontalAlignment.Center;
                labels1[i].AutoSize = true;
                labels1[i].Font = new Font(labels1[i].Font.FontFamily, 10);
                CargarValores(textBoxes[i], labels1[i], nodo, x2, y2,width, height);
                y2 += 25;              

                labels[i] = new Label();
                labels[i].SetBounds(x, y, width, height);
                y += 25;
                labels[i].Text = nodo.ToString();
                labels[i].AutoSize = true;
                labels[i].Font = new Font(labels[i].Font.FontFamily, 9);
                i++;
            }           
            for (int j = 0; j < n; j++)
            {
                this.Controls.Add(textBoxes[j]);
                this.Controls.Add(labels1[j]);
                this.Controls.Add(labels[j]);
            }
            //timer cada 30 hace reporte
            timer.Tick += new EventHandler(timer_Tick); 
            timer.Interval = (30000) * (1);             
            timer.Enabled = true;                       
            timer.Start();

            //si es simulacion automatica
            if (auto == true)
            {
                //timer cada 4 segundos cambia valores
                timer3.Tick += new EventHandler(timer3_Tick);
                timer3.Interval = (4000) * (1);
                timer3.Enabled = true;
                timer3.Start();
            }

            //crea el nombre del archivo
            string fecha = DateTime.Now.ToString("s");
            fecha = fecha.Replace("-", "");
            fecha = fecha.Replace(":", "");
            fecha = fecha.Replace("T", "");
            string nombreArchivo = sim.dron.nroSerie.ToString() + fecha;

            //crea los archivos a exportar
            archivoXML = new ArchivoXML(nombreArchivo);
            archivoCSV = new ArchivoCSV(nombreArchivo);

            archivoXML.AgregarTitulo(sim);
            archivoCSV.AgregarTitulo(sim);

            //agrega al archivo los valores iniciales
            archivoCSV.AgregarAArchivo(sim);
            archivoXML.AgregarAArchivo(sim);

        }

        //timer cada 4 segundos que cambia valores de los sensores
        //Simulación automática
        void timer3_Tick(object sender, EventArgs e)
        {
            bool cambio = false;   
            segundos += 4;
            List<Pieza> listaPiezas = sistema.DevolverListaPiezas(sim.dron.diseñoDron.listaNodos);
            bool final = false;
            foreach (Pieza n in listaPiezas)
            {
                if (n is Velocimetro)
                {
                    Velocimetro p = (Velocimetro)n;
                    if (sim.dron.nroSerie == 100)
                    {
                        if (segundos == 4)
                        {
                            sistema.ActualizarValores(n, 24, 35, 29);
                            cambio = true;

                        }
                        if (segundos == 8)
                        {//entra en alarma
                            sistema.ActualizarValores(n, 17, 35, 29);
                            cambio = true;

                        }//sale de alarma
                        if (segundos == 12)
                        {
                            sistema.ActualizarValores(n, 28, 45, 30);
                            cambio = true;

                        }
                        else if (segundos == 36)
                        {
                            sistema.ActualizarValores(n, 39, 57, 46);
                            cambio = true;

                        }
                        else if (segundos <= 64)
                        {//entra en alarma urgente, termina la simulacion y se destruye el dron
                            sistema.ActualizarValores(n, p.x + 1, p.y + 3, p.z + 2);
                            cambio = true;

                        }
                    }
                    else if (sim.dron.nroSerie == 101) {
                        if (segundos == 8) {
                            sistema.ActualizarValores(n, 12, 25, 36);
                            cambio = true;

                        }
                        if (segundos == 12)
                        {
                            sistema.ActualizarValores(n, 20, 30, 42);
                            cambio = true;

                        }
                        if (segundos == 16)
                        {//entra en alarma urgente
                            sistema.ActualizarValores(n, 20, 33, 47);
                            cambio = true;

                        }
                        if (segundos == 20)
                        {//sale de alarma urgente
                            sistema.ActualizarValores(n, 20, 33, 45);
                            cambio = true;

                        }
                        if (segundos == 24)
                        {
                            sistema.ActualizarValores(n, 20, 33, 40);
                            cambio = true;

                        }
                    }
                   
                    
                }
                if (n is Termometro)
                {
                    Termometro p = (Termometro)n;
                    if (sim.dron.nroSerie == 100){
                        if (segundos == 28)
                        {
                            sistema.ActualizarValores(n, 35, 0, 0);
                            cambio = true;

                        }
                        else if(segundos<52)
                        {
                            sistema.ActualizarValores(n, Convert.ToInt32(p.temperatura)+1, 0, 0);
                            cambio = true;

                        }//entra en alarma urgente
                        else if (segundos >= 52 && segundos < 60) {
                            sistema.ActualizarValores(n, Convert.ToInt32(p.temperatura) + 2, 0, 0);
                            cambio = true;

                        }
                        else if (segundos == 60) {
                            //sale de alarma urgente
                            sistema.ActualizarValores(n, 40, 0, 0);
                            cambio = true;

                        }
                      
                    }
                    else if (sim.dron.nroSerie == 101) {
                        if (segundos == 8)
                        {
                            sistema.ActualizarValores(n, 28, 0, 0);
                            cambio = true;

                        }else if (segundos <= 28) {
                            sistema.ActualizarValores(n, Convert.ToInt32(p.temperatura)+2, 0, 0);
                            cambio = true;

                        }
                        else if (segundos == 32) { 
                            sistema.ActualizarValores(n, 36, 0, 0);
                            cambio = true;

                        }
                        else  if (segundos == 36) { 
                            sistema.ActualizarValores(n, 30, 0, 0);
                            cambio = true;

                        }
                    }
                }
                if (n is Altimetro)
                {
                    Altimetro p = (Altimetro)n;
                    if (sim.dron.nroSerie == 100)
                    {
                        if (segundos == 16)
                        {
                            sistema.ActualizarValores(n, 20, 0, 0);
                            cambio = true;

                        }
                        else if (segundos == 40)
                        {
                            sistema.ActualizarValores(n, 28, 0, 0);
                            cambio = true;

                        }
                        else if (segundos == 44)
                        {
                            sistema.ActualizarValores(n, 32, 0, 0);
                            cambio = true;

                        }
                        else if (segundos == 48)
                        {//entra en alarma urgente
                            sistema.ActualizarValores(n, 48, 0, 0);
                            cambio = true;

                        }
                        else if (segundos == 52)
                        {
                            sistema.ActualizarValores(n, 44, 0, 0);
                            cambio = true;

                        }
                    }
                    else if (sim.dron.nroSerie == 101)
                    {
                        if (segundos <= 40)
                        {
                            sistema.ActualizarValores(n, p.altura + 3, 0, 0);
                            cambio = true;
                        }

                    }
                }
                if (n is Barometro)
                {
                    Barometro p = (Barometro)n;
                    if (sim.dron.nroSerie == 100)
                    {
                        if (segundos == 4)
                        {
                            sistema.ActualizarValores(n, 39, 0, 0);
                            cambio = true;

                        }
                        else if (segundos == 8)
                        {//entra en alarma
                            sistema.ActualizarValores(n, 50, 0, 0);
                            cambio = true;

                        }//sale de alarma
                        else if (segundos == 16)
                        {
                            sistema.ActualizarValores(n, 48, 0, 0);
                            cambio = true;

                        }
                        else if (segundos == 32)
                        {
                            sistema.ActualizarValores(n, 47, 0, 0);
                            cambio = true;

                        }
                    }
                    else if (sim.dron.nroSerie == 101)
                    {
                        if (segundos <= 40){
                            sistema.ActualizarValores(n, p.presion+2, 0, 0);
                            cambio = true;
                        }
                        if (segundos == 44) {
                            //entra en alarma urgente
                            sistema.ActualizarValores(n, 60, 0, 0);
                            cambio = true;

                        }
                        if (segundos == 48)
                        {//sale de alarma
                            sistema.ActualizarValores(n, 50, 0, 0);
                            cambio = true;

                        }
                    }
                }
                if (n is GPS)
                {
                    GPS p = (GPS)n;
                    if (sim.dron.nroSerie == 100)
                    {
                        if (segundos == 28)
                        {
                            sistema.ActualizarValores(n, 50, 61, 69);
                            cambio = true;

                        }
                        else if (segundos == 12)
                        {
                            sistema.ActualizarValores(n, 40, 47, 46);
                            cambio = true;

                        }
                        else if (segundos == 48)
                        {
                            sistema.ActualizarValores(n, 53, 61, 65);
                            cambio = true;

                        }
                    }
                    else if (sim.dron.nroSerie == 101) {
                        if (segundos == 8)
                        {
                            sistema.ActualizarValores(n, 74, 84, 80);
                            cambio = true;

                        }
                        if (segundos == 12)
                        {//entra en alarma
                            sistema.ActualizarValores(n, 80, 89, 75);
                            cambio = true;

                        }
                        if (segundos == 16)
                        {//entra en alarma urgente
                            sistema.ActualizarValores(n, 81, 83, 70);
                            cambio = true;

                        }
                        if (segundos == 20)
                        {
                            sistema.ActualizarValores(n, 84, 80, 73);
                            cambio = true;

                        }
                        if (segundos == 28)
                        {
                            sistema.ActualizarValores(n, 87, 80, 73);
                            cambio = true;

                        }
                        if (segundos == 36)
                        {
                            sistema.ActualizarValores(n, 87, 79, 73);
                            cambio = true;

                        }
                        if (segundos == 44)
                        {//llega al final 
                            sistema.ActualizarValores(n, 87, 79, 75);
                            cambio = true;

                        }
                    
                    }
                    //fijarse si llego al final, terminar la simulacion
                    if (sim.coordXf == p.x && sim.coordYf == p.y && sim.coordZf == p.z)
                    {
                        timer.Stop();
                        timer2.Stop();
                        timer3.Stop();
                        MessageBox.Show("Dron llegó a destino correctamente.");
                        sim.AgregarReporte("Dron llegó a destino correctamente.");
                        archivoXML.AgregarAArchivo(sim);
                        archivoCSV.AgregarAArchivo(sim);
                        this.Dispose();
                        final = true;                        
                        Reporte r = new Reporte(sim);
                        r.StartPosition = FormStartPosition.CenterScreen;
                        r.ShowDialog();
                    }

                }
                if (final == false)
                {
                    sistema.VerificarAlarma(n);
                    sistema.VerificarAlarmaUrgente(n);
                    //si esta en alarma urgente inicia un timer de 5 segundos 
                    bool estado = n.estadoAlarmaUrgente;
                    if (estado == true)
                    {
                        nodoLocal = n;
                        estadoAnterior = n.estadoAlarmaUrgente;
                        timer2.Tick += new EventHandler(timer2_Tick); 
                        timer2.Interval = (5000) * (1);              
                        timer2.Enabled = true;                       
                        timer2.Start();

                    }
                }
            }
            //actualiza los archivos cada vez que hay un cambio
            if (cambio == true)
            {
                archivoXML.AgregarAArchivo(sim);
                archivoCSV.AgregarAArchivo(sim);
            }




        }
        //timer cada 30 actualiza el reporte de los valores de los sensores
        void timer_Tick(object sender, EventArgs e)
        {
            List<Pieza> listaPiezas = sistema.DevolverListaPiezas(sim.dron.diseñoDron.listaNodos);
            int pos = 0;
            string rep=""+DateTime.Now.ToString()+ " ";

            sim.AgregarReporte(rep);
            foreach (Pieza n in listaPiezas)
            {
                if (n is Velocimetro)
                {
                    int x = Convert.ToInt32(listaTextBoxes[pos].Text);
                    int y = Convert.ToInt32(listaTextBoxes[pos + 1].Text);
                    int z = Convert.ToInt32(listaTextBoxes[pos + 2].Text);
                    rep = "     " + n.ToString() + "\n";
                    sim.AgregarReporte(rep);
                    rep="           Vectores: x = " + x + "; y = " + y + "; z = " + z + "\n";

                    sim.AgregarReporte(rep);
                    pos = pos + 3;
                }
                if (n is Termometro)
                {
                    int x = Convert.ToInt32(listaTextBoxes[pos].Text);
                    rep = "     " + n.ToString() + "\n";
                    sim.AgregarReporte(rep);
                    rep = "         Temperatura: " + x + " º \n";
                    sim.AgregarReporte(rep);
                    pos = pos + 1;
                }
                if (n is Altimetro)
                {
                    int x = Convert.ToInt32(listaTextBoxes[pos].Text);
                    rep = "     " + n.ToString() + "\n";
                    sim.AgregarReporte(rep);
                    rep="           Altura: " + x + "\n";
                    sim.AgregarReporte(rep);
                    pos = pos + 1;
                }
                if (n is Barometro)
                {
                    int x = Convert.ToInt32(listaTextBoxes[pos].Text);
                    rep = "     " + n.ToString() + "\n";
                    sim.AgregarReporte(rep);
                    rep="           Presión: " + x + "\n";
                    sim.AgregarReporte(rep);
                    pos = pos + 1;
                }
                if (n is GPS)
                {
                    int x = Convert.ToInt32(listaTextBoxes[pos].Text);
                    int y = Convert.ToInt32(listaTextBoxes[pos + 1].Text);
                    int z = Convert.ToInt32(listaTextBoxes[pos + 2].Text);
                    rep = "     " + n.ToString() + "\n";
                    sim.AgregarReporte(rep); 
                    rep="           Coordenadas: x = " + x + "; y = " + y + "; z = " + z + "\n";
                    sim.AgregarReporte(rep);
                    pos = pos + 3;
                }
                if (n is Acelerometro)
                {
                    int x = Convert.ToInt32(listaTextBoxes[pos].Text);
                    int y = Convert.ToInt32(listaTextBoxes[pos + 1].Text);
                    int z = Convert.ToInt32(listaTextBoxes[pos + 2].Text);
                    rep = "     " + n.ToString() + "\n";
                    sim.AgregarReporte(rep);
                    rep = "           Coordenadas: x = " + x + "; y = " + y + "; z = " + z + "\n";
                    sim.AgregarReporte(rep);
                    pos = pos + 3;
                }
                if (n.estadoAlarmaUrgente == true)
                {
                    rep = "         - EN ALARMA URGENTE - ";
                    sim.AgregarReporte(rep);

                }else if (n.estadoAlarma == true) {
                    rep = "         - EN ALARMA - ";
                    sim.AgregarReporte(rep);
                }
                sim.AgregarReporte("");
               
                
            }
            //actualiza los archivos
            archivoXML.AgregarAArchivo(sim);
            archivoCSV.AgregarAArchivo(sim);
            
       
           
        }
        //devuleve la cantidad de piezas que hay en una lista de nodos
        public int CantidadPiezas(List<Nodo> list) {
            int cant = 0;
            foreach (Nodo n in list) {
                cant += Suma(n);
            }
            return cant;
        }

        public int Suma(Nodo n) {
            int res = 0;
            if (n is Pieza)
            {
                return 1;
            }
            else
            {
                Componente c = (Componente)n;
                foreach (Nodo nodo in c.listaNodos)
                {
                    res+= Suma(nodo);
                }
                return res;
            }           
        }

        //carga los valores de los labels y las cajas de texto creadas en el constructor
        public void CargarValores(TextBox t, Label l, Pieza n, int x, int y, int width, int height) {
            
            if(n is Termometro){
                Termometro p = (Termometro)n;
                t.Text = System.Convert.ToString(p.ObtenerTemperatura());
                l.Text = "°";
                t.TabIndex = tabindex;
                listaTextBoxes.Add(t);
                tabindex++;
            }
            if (n is Velocimetro)
            {
                TextBox[] textNuevos = new TextBox[2];
                Velocimetro p = (Velocimetro)n;
                t.Text = System.Convert.ToString(p.x);
                t.TabIndex = tabindex;
                tabindex++;
                listaTextBoxes.Add(t);
                textNuevos[0] = new TextBox();
                textNuevos[0].SetBounds(x+40, y, width, height);
                textNuevos[0].AutoSize = true;
                textNuevos[0].TextAlign = HorizontalAlignment.Center;
                textNuevos[0].Text=System.Convert.ToString(p.y);
                textNuevos[0].TabIndex = tabindex;
                listaTextBoxes.Add(textNuevos[0]);
                tabindex++;

                textNuevos[1] = new TextBox();
                textNuevos[1].SetBounds(x + 80, y, width, height);
                textNuevos[1].AutoSize = true;
                textNuevos[1].TextAlign = HorizontalAlignment.Center;
                textNuevos[1].Text = System.Convert.ToString(p.z);
                textNuevos[0].TabIndex = tabindex;
                tabindex++;

                listaTextBoxes.Add(textNuevos[1]);

                for (int j = 0; j < 2; j++)
                {
                    this.Controls.Add(textNuevos[j]);                    
                }
                
            }
            if (n is Altimetro)
            {
                Altimetro p = (Altimetro)n;
                t.Text = System.Convert.ToString(p.ObtenerAltura());
                l.Text = "mts";
                t.TabIndex = tabindex;
                listaTextBoxes.Add(t);
                tabindex++;
            }
            if (n is Barometro)
            {
                Barometro p = (Barometro)n;
                t.Text = System.Convert.ToString(p.ObtenerPresion());
                l.Text = "hPa";
                t.TabIndex = tabindex;
                listaTextBoxes.Add(t);
                tabindex++;
            }
            if (n is GPS)
            {
                TextBox[] textNuevos = new TextBox[2];
                GPS p = (GPS)n;
                t.Text = System.Convert.ToString(p.x);
                t.TabIndex = tabindex;
                tabindex++;

                listaTextBoxes.Add(t);
                textNuevos[0] = new TextBox();
                textNuevos[0].SetBounds(x + 40, y, width, height);
                textNuevos[0].AutoSize = true;
                textNuevos[0].TextAlign = HorizontalAlignment.Center;
                textNuevos[0].Text = System.Convert.ToString(p.y);
                textNuevos[0].TabIndex = tabindex;
                listaTextBoxes.Add(textNuevos[0]);
                tabindex++;

                textNuevos[1] = new TextBox();
                textNuevos[1].SetBounds(x + 80, y, width, height);
                textNuevos[1].AutoSize = true;
                textNuevos[1].TextAlign = HorizontalAlignment.Center;
                textNuevos[1].Text = System.Convert.ToString(p.z);
                textNuevos[0].TabIndex = tabindex;
                tabindex++;

                listaTextBoxes.Add(textNuevos[1]);
                for (int j = 0; j < 2; j++)
                {
                    this.Controls.Add(textNuevos[j]);
                }

            }
            if (n is Acelerometro)
            {
                TextBox[] textNuevos = new TextBox[2];
                Acelerometro p = (Acelerometro)n;
                t.Text = System.Convert.ToString(p.x);
                t.TabIndex = tabindex;
                tabindex++;

                listaTextBoxes.Add(t);
                textNuevos[0] = new TextBox();
                textNuevos[0].SetBounds(x + 40, y, width, height);
                textNuevos[0].AutoSize = true;
                textNuevos[0].TextAlign = HorizontalAlignment.Center;
                textNuevos[0].Text = System.Convert.ToString(p.y);
                textNuevos[0].TabIndex = tabindex;
                listaTextBoxes.Add(textNuevos[0]);
                tabindex++;

                textNuevos[1] = new TextBox();
                textNuevos[1].SetBounds(x + 80, y, width, height);
                textNuevos[1].AutoSize = true;
                textNuevos[1].TextAlign = HorizontalAlignment.Center;
                textNuevos[1].Text = System.Convert.ToString(p.z);
                textNuevos[0].TabIndex = tabindex + 2;
                tabindex++;

                listaTextBoxes.Add(textNuevos[1]);
                for (int j = 0; j < 2; j++)
                {
                    this.Controls.Add(textNuevos[j]);
                }

            }                      
        }

        //actualiza los valores de los sensores cuando es llamado
        public void Update(IObservable o)
        {
            List<Pieza> listaPiezas = sistema.DevolverListaPiezas(sim.dron.diseñoDron.listaNodos);
            int pos = 0;
            int posTxt = 0;
            foreach (Pieza n in listaPiezas)
            {
                if (n is Velocimetro)
                {
                    Velocimetro p = (Velocimetro)n;
                    listaTextBoxes[posTxt].Text = p.x.ToString();
                    listaTextBoxes[posTxt + 1].Text = p.y.ToString();
                    listaTextBoxes[posTxt + 2].Text = p.z.ToString();
                    posTxt = posTxt + 3;
                }
                if (n is Termometro)
                {
                    Termometro p = (Termometro)n;
                    listaTextBoxes[posTxt].Text = p.temperatura.ToString();
                    posTxt = posTxt + 1;

                }
                if (n is Altimetro)
                {
                    Altimetro p = (Altimetro)n;
                    listaTextBoxes[posTxt].Text = p.altura.ToString();
                    posTxt = posTxt + 1;
                }
                if (n is Barometro)
                {
                    Barometro p = (Barometro)n;
                    listaTextBoxes[posTxt].Text = p.presion.ToString();
                    posTxt = posTxt + 1;
                }
                if (n is GPS)
                {
                    GPS p = (GPS)n;
                    listaTextBoxes[posTxt].Text = p.x.ToString();
                    listaTextBoxes[posTxt + 1].Text = p.y.ToString();
                    listaTextBoxes[posTxt + 2].Text = p.z.ToString();
                    posTxt = posTxt + 3;
                }
                if (n is Acelerometro)
                {
                    Acelerometro p = (Acelerometro)n;
                    listaTextBoxes[posTxt].Text = p.x.ToString();
                    listaTextBoxes[posTxt + 1].Text = p.y.ToString();
                    listaTextBoxes[posTxt + 2].Text = p.z.ToString();
                    posTxt = posTxt + 3;
                }
                pos++;
            }
        }

        private void ConsolaAdministrativa_Load(object sender, EventArgs e)
        {           
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            timer.Stop();
            timer2.Stop();
            this.Hide();
        }

       

        //boton de modificar manualmente
        private void button1_Click(object sender, EventArgs e)
        {
            List<Pieza> listaPiezas = sistema.DevolverListaPiezas(sim.dron.diseñoDron.listaNodos);
            List<TextBox> aux = new List<TextBox>();
            
            //copia la lista de TextBoxes a una lista nueva 
            foreach (TextBox t in listaTextBoxes){
                TextBox tx = new TextBox();
                string valor = t.Text;
                tx.Text = valor;
                aux.Add(tx);
            }

            int pos = 0;
            
            foreach (Pieza n in listaPiezas)
            {
                if (n is Velocimetro)
                {
                    int x = Convert.ToInt32(aux[pos].Text);
                    int y = Convert.ToInt32(aux[pos+1].Text);
                    int z = Convert.ToInt32(aux[pos+2].Text);
                    sistema.ActualizarValores(n, x, y, z);
                    pos = pos + 3;
                }
                if (n is Termometro)
                {
                    int x=  Convert.ToInt32(aux[pos].Text);
                    sistema.ActualizarValores(n, x, 0, 0);
                    pos = pos + 1;
                }
                if (n is Altimetro)
                {
                    int x = Convert.ToInt32(aux[pos].Text);
                    sistema.ActualizarValores(n, x, 0, 0);
                    pos = pos + 1;

                }
                if (n is Barometro)
                {
                    int x = Convert.ToInt32(aux[pos].Text);
                    sistema.ActualizarValores(n, x, 0, 0);
                    pos = pos + 1;
                }
                if (n is Acelerometro)
                {
                    int x = Convert.ToInt32(aux[pos].Text);
                    int y = Convert.ToInt32(aux[pos + 1].Text);
                    int z = Convert.ToInt32(aux[pos + 2].Text);
                    sistema.ActualizarValores(n, x, y, z);
                    pos = pos + 3;
                }
                if (n is GPS)
                {
                    int x = Convert.ToInt32(aux[pos].Text);
                    int y = Convert.ToInt32(aux[pos + 1].Text);
                    int z = Convert.ToInt32(aux[pos + 2].Text);
                    sistema.ActualizarValores(n, x, y, z);
                    pos = pos + 3;
                    //fijarse si llego al final, terminar la simulacion
                    if (sim.coordXf == x && sim.coordYf == y && sim.coordZf == z) {
                        timer.Stop();
                        timer2.Stop();
                        MessageBox.Show("Dron llegó a destino correctamente.");
                        sim.AgregarReporte("Dron llegó a destino correctamente.");

                        archivoXML.AgregarAArchivo(sim);
                        archivoCSV.AgregarAArchivo(sim);

                        this.Dispose();
                        Reporte r = new Reporte(sim);
                        r.StartPosition = FormStartPosition.CenterScreen;
                        r.ShowDialog();
                    }
                }
                
                sistema.VerificarAlarma(n);
                sistema.VerificarAlarmaUrgente(n);
                bool estado = n.estadoAlarmaUrgente;
                if (estado == true)
                {
                    nodoLocal = n;
                    estadoAnterior = n.estadoAlarmaUrgente;
                    timer2.Tick += new EventHandler(timer2_Tick); // Everytime timer ticks, timer_Tick will be called
                    timer2.Interval = (5000) * (1);              // Timer will tick every 5 seconds
                    timer2.Enabled = true;                       // Enable the timer
                    timer2.Start();
                    
                }
            }
            //actualiza los archivos cada vez que hay un cambio
            archivoXML.AgregarAArchivo(sim);
            archivoCSV.AgregarAArchivo(sim);

        }

        //timer de alarma urgente
        void timer2_Tick(object sender, EventArgs e) {
            estadoDespues = nodoLocal.estadoAlarmaUrgente;
            if (estadoAnterior == estadoDespues) {
                timer2.Stop();
                timer.Stop();
                timer3.Stop();
                if (veces == 0)
                {
                    MessageBox.Show("La alarma excedió los 5 segundos. Se destruirá el dron.", "ERROR");
                    sim.dron.cantidad--;
                    sim.AgregarReporte("La alarma urgente excedió los 5 segundos.");
                    sim.AgregarReporte("Pieza: "+nodoLocal.ToString());
                    sim.AgregarReporte("Dron destruido.");
                    this.Dispose();
                    Reporte r = new Reporte(sim);
                    r.StartPosition = FormStartPosition.CenterScreen;
                    r.ShowDialog();
            
                }
                veces++;
                this.Dispose();
            }
            timer2.Stop();
        }


        private void verPanel_Click(object sender, EventArgs e)
        {
            Piloto p = new Piloto(sim);
            p.StartPosition = FormStartPosition.CenterScreen;
            p.Show(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
    }

}


