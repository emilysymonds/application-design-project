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
    public partial class Piloto : Form, IObserver
    {
        private Sistema sistema;
        private Simulacion sim;
        private List<TextBox> listaTextBoxes = new List<TextBox>();
        private Timer timer2 = new Timer();
        private List<Button> buttons = new List<Button>();
        private List<Label> lables = new List<Label>();
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private List<PictureBox> pictureAlarma = new List<PictureBox>();

        public Piloto(Simulacion s)
        {
            sistema = Sistema.Instance;
            sim = s;
            InitializeComponent();
            sistema.AgregarObservador(this);
            int n = CantidadPiezas(s.dron.diseñoDron.listaNodos);
            List<Pieza> listaPiezas = sistema.DevolverListaPiezas(s.dron.diseñoDron.listaNodos);
            TextBox[] textBoxes = new TextBox[n];
            Label[] labels = new Label[n];
            Label[] labels1 = new Label[n];
            int x = 12;
            int y = 44;
            int x2 = 334;
            int y2 = 41;
            int x3 = 370;
            int x4 = 470;
            int width = 35;
            int height = 13;
            int i = 0;
            foreach (Pieza nodo in listaPiezas)
            {
                textBoxes[i] = new TextBox();
                labels1[i] = new Label();
                textBoxes[i].SetBounds(x2, y2, width, height);
                labels1[i].SetBounds(x3, y2, 25, height);
                textBoxes[i].AutoSize = true;
                textBoxes[i].TextAlign = HorizontalAlignment.Center;
                labels1[i].AutoSize = true;
                labels1[i].Font = new Font(labels1[i].Font.FontFamily, 10);
                CargarValores(textBoxes[i], labels1[i], nodo, x2, y2, width, height);
                textBoxes[i].Enabled = false;
                

                labels[i] = new Label();
                labels[i].SetBounds(x, y, width, height);
                labels[i].Text = nodo.ToString();
                labels[i].AutoSize = true;
                labels[i].Font = new Font(labels[i].Font.FontFamily, 9);
                lables.Add(labels[i]);

                PictureBox newAlarma = new PictureBox();
                pictureAlarma.Add(newAlarma);
                newAlarma.Image = global::WindowsFormsApplication1.Properties.Resources.siren;
                newAlarma.SetBounds(x4, y2, 15, 15);
                newAlarma.AutoSize = true;
                newAlarma.Visible = false;
                this.Controls.Add(newAlarma);

                PictureBox newPicture = new PictureBox();
                pictureBoxes.Add(newPicture);
                newPicture.Image = global::WindowsFormsApplication1.Properties.Resources.important;
                newPicture.SetBounds(x4, y2, 15, 15);
                newPicture.AutoSize = true;
                newPicture.Visible = false;
                this.Controls.Add(newPicture);


                y2 += 25;
                i++;
                y += 25;
            }

            

            for (int j = 0; j < n; j++)
            {
                this.Controls.Add(textBoxes[j]);
                this.Controls.Add(labels1[j]);
                this.Controls.Add(labels[j]);
               
            }

            //timer cada un segundo actualiza los valores
            timer2.Tick += new EventHandler(timer_Tick); 
            timer2.Interval = (1000) * (1);              
            timer2.Enabled = true;                       
            timer2.Start();         

           
           
        }
        //cada 1 segundo lama al update que actualiza los valores de los sensores
        void timer_Tick(object sender, EventArgs e)
        {
            this.Update();
        }
       //devuelve la cantidad de piezas en una lista de nodos
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

        //carga los valores de los labels y textboxes para cada pieza
        public void CargarValores(TextBox t, Label l, Pieza n, int x, int y, int width, int height) {
            
            if(n is Termometro){
                Termometro p = (Termometro)n;
                t.Text = System.Convert.ToString(p.ObtenerTemperatura());
                l.Text = "°";
                listaTextBoxes.Add(t);
            }
            if (n is Velocimetro)
            {
                TextBox[] textNuevos = new TextBox[2];
                Velocimetro p = (Velocimetro)n;
                t.Text = System.Convert.ToString(p.x);
                listaTextBoxes.Add(t);
                textNuevos[0] = new TextBox();
                textNuevos[0].SetBounds(x+40, y, width, height);
                textNuevos[0].AutoSize = true;
                textNuevos[0].TextAlign = HorizontalAlignment.Center;
                textNuevos[0].Text=System.Convert.ToString(p.y);
                listaTextBoxes.Add(textNuevos[0]);
                textNuevos[0].Enabled = false;

                textNuevos[1] = new TextBox();
                textNuevos[1].SetBounds(x + 80, y, width, height);
                textNuevos[1].AutoSize = true;
                textNuevos[1].TextAlign = HorizontalAlignment.Center;
                textNuevos[1].Text = System.Convert.ToString(p.z);
                listaTextBoxes.Add(textNuevos[1]);
                textNuevos[1].Enabled = false;

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
                listaTextBoxes.Add(t);
            }
            if (n is Barometro)
            {
                Barometro p = (Barometro)n;
                t.Text = System.Convert.ToString(p.ObtenerPresion());
                l.Text = "hPa";
                listaTextBoxes.Add(t);
            }
            if (n is GPS)
            {
                TextBox[] textNuevos = new TextBox[2];
                GPS p = (GPS)n;
                t.Text = System.Convert.ToString(p.x);
                listaTextBoxes.Add(t);
                textNuevos[0] = new TextBox();
                textNuevos[0].SetBounds(x + 40, y, width, height);
                textNuevos[0].AutoSize = true;
                textNuevos[0].TextAlign = HorizontalAlignment.Center;
                textNuevos[0].Text = System.Convert.ToString(p.y);
                listaTextBoxes.Add(textNuevos[0]);
                textNuevos[0].Enabled = false;

                textNuevos[1] = new TextBox();
                textNuevos[1].SetBounds(x + 80, y, width, height);
                textNuevos[1].AutoSize = true;
                textNuevos[1].TextAlign = HorizontalAlignment.Center;
                textNuevos[1].Text = System.Convert.ToString(p.z);
                listaTextBoxes.Add(textNuevos[1]);
                textNuevos[1].Enabled = false;
                
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
                listaTextBoxes.Add(t);
                textNuevos[0] = new TextBox();
                textNuevos[0].SetBounds(x + 40, y, width, height);
                textNuevos[0].AutoSize = true;
                textNuevos[0].TextAlign = HorizontalAlignment.Center;
                textNuevos[0].Text = System.Convert.ToString(p.y);
                listaTextBoxes.Add(textNuevos[0]);
                textNuevos[0].Enabled = false;

                textNuevos[1] = new TextBox();
                textNuevos[1].SetBounds(x + 80, y, width, height);
                textNuevos[1].AutoSize = true;
                textNuevos[1].TextAlign = HorizontalAlignment.Center;
                textNuevos[1].Text = System.Convert.ToString(p.z);
                listaTextBoxes.Add(textNuevos[1]);
                textNuevos[1].Enabled = false;

                for (int j = 0; j < 2; j++)
                {
                    this.Controls.Add(textNuevos[j]);
                }
            }
        }

        //actualiza los valores de los sensores
        public void Update(IObservable o)
        {
           
            List<Pieza> listaPiezas = sistema.DevolverListaPiezas(sim.dron.diseñoDron.listaNodos);
            int pos = 0;
            int posTxt = 0;
            foreach (Pieza n in listaPiezas)
            {
                
                if (n.estadoAlarmaUrgente == true)
                {
                    lables[pos].ForeColor = System.Drawing.Color.Red;
                    pictureBoxes[pos].Visible = true;
                    pictureAlarma[pos].Visible = false;
                }
                else {
                    lables[pos].ForeColor = System.Drawing.Color.Black;
                    pictureBoxes[pos].Visible = false;
                    if (n.estadoAlarma == true)
                    {
                        pictureAlarma[pos].Visible = true;
                    }
                    else
                    {
                        pictureAlarma[pos].Visible = false;
                    }
                }

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

        private void Piloto_Load(object sender, EventArgs e)
        {

        }
    }
}
