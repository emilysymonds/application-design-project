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

    public partial class AgregarDiseño : Form
    {
        private Sistema sistema;
        private Diseño diseño;
        private bool crear;
        private int version;

        public AgregarDiseño()
        {
            sistema = Sistema.Instance;
            InitializeComponent();
            crear=true;
            diseño = new Diseño();
            version = 1;
            CargarListas();
        }
        public AgregarDiseño(Diseño d)
        {
            sistema = Sistema.Instance;
            crear = false;
            InitializeComponent();
            version = d.version + 1;
            diseño = new Diseño(d.nombre, version, d.listaNodos);
            //diseño = d;

            CargarListas();
            txtNombre.Enabled = false;
            this.Text = "Editar Diseño";
            label5.Text = "Piezas utilizadas:";
            label4.Text = "Componentes utilizados:";
            label7.Text = "Editar diseño";
            if (diseño != null)
            {
                txtNombre.Text = diseño.nombre;
                foreach (Nodo n in diseño.listaNodos)
                {
                    if (n is Pieza)
                    {
                        utilizarList.Items.Add(n);
                    }
                    else
                    {
                        utilizarBox2.Items.Add(n);
                    }
                }
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void CargarListas()
        {
            int cantP = sistema.ListaPiezas.Count;
            if (cantP == 0)
            {
                piezasListBox.Items.Add("No se han creado piezas aún.");
            }
            else
            {
                foreach (Pieza p in sistema.ListaPiezas)
                {
                    if (!diseño.listaNodos.Contains(p))
                        piezasListBox.Items.Add(p);
                }
            }

            int cantC = sistema.ListaComp.Count;
            if (cantC == 0)
            {
                compListBox.Items.Add("No se han creado componentes aún.");
            }
            else
            {
                foreach (Componente c in sistema.ListaComp)
                {
                    if (!diseño.listaNodos.Contains(c))
                        compListBox.Items.Add(c);
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo nodo = (Nodo)piezasListBox.SelectedItem;
            bool existe = false;
            if (nodo != null)
            {
                foreach (Nodo n in diseño.listaNodos)
                {
                    if (n.Equals(nodo))
                    {
                        existe = true;
                        MessageBox.Show("Ya utilizó esta pieza", "ERROR");
                    }
                }
                if (!existe)
                {
                    diseño.listaNodos.Add(nodo);
                    utilizarList.Items.Add(piezasListBox.SelectedItem);
                    piezasListBox.Items.RemoveAt(piezasListBox.SelectedIndex);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una pieza", "ERROR");
            }
        }

        

        private void CrearDiseño_Load(object sender, EventArgs e)
        {
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (utilizarList.SelectedIndex > -1)
            {
                diseño.listaNodos.Remove((Nodo)utilizarList.SelectedItem);
                piezasListBox.Items.Add(utilizarList.SelectedItem);
                utilizarList.Items.RemoveAt(utilizarList.SelectedIndex);
            }
            else {
                MessageBox.Show("Debe seleccionar un elemento", "ERROR");
            }
        }

        private void btnAgregarComp_Click(object sender, EventArgs e)
        {
            Nodo nodo = (Nodo)compListBox.SelectedItem;
            bool existe = false;
            if (nodo != null)
            {
                foreach (Nodo n in diseño.listaNodos)
                {
                    if (n.Equals(nodo))
                    {
                        existe = true;
                        MessageBox.Show("Ya utilizó este componente", "ERROR");
                    }
                }

                if (!existe)
                {
                    diseño.listaNodos.Add(nodo);
                    utilizarBox2.Items.Add(compListBox.SelectedItem);
                    compListBox.Items.RemoveAt(compListBox.SelectedIndex);
                }
            }

            else
            {
                MessageBox.Show("Debe seleccionar un componente", "ERROR");
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //CREA EL DISEÑO
            if (txtNombre.Text == "")
            {
                MessageBox.Show("El nombre del diseño no puede ser vacío.", "ERROR");
            }
            else if(utilizarList.Items.Count==0 && utilizarBox2.Items.Count==0){
                MessageBox.Show("Debe utilizar por lo menos una pieza o un componente.", "ERROR");
            }
            else
            {
                if (crear)
                {
                    diseño.nombre = txtNombre.Text;
                    diseño.version = 1;
                }else 
                {
                    diseño.nombre = txtNombre.Text;
                    diseño.version = sistema.ProximoNumeroDis(diseño);
                }
                List<Pieza> lista=sistema.DevolverListaPiezas(diseño.listaNodos);
                bool hayGPS = false;
                bool hayVel = false;
                foreach (Pieza p in lista) {
                    if (p is GPS) {
                        hayGPS = true;
                    }
                    if (p is Velocimetro) {
                        hayVel = true;
                    }
                }
                if (hayGPS && hayVel) {
                    if (sistema.AgregarDiseño(diseño))
                    {
                        MessageBox.Show("Diseño registrado existósamente.");
                        this.Hide();
                        this.Dispose();
                        ConfigurarAlarmas alarm = new ConfigurarAlarmas(diseño, 1);
                        alarm.StartPosition = FormStartPosition.CenterScreen;
                        alarm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un diseño con ese nombre.", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("El diseño debe contener un GPS y un Velocímetro.", "ERROR");
                }
            }
        }

        private void btnQuitar2_Click(object sender, EventArgs e)
        {
            if (utilizarBox2.SelectedIndex > -1)
            {
                diseño.listaNodos.Remove((Nodo)utilizarBox2.SelectedItem);
                compListBox.Items.Add(utilizarBox2.SelectedItem);
                utilizarBox2.Items.RemoveAt(utilizarBox2.SelectedIndex);
            }
            else {
                MessageBox.Show("Debe seleccionar un elemento", "ERROR");
            }

        }

        private void AgregarDiseño_Load(object sender, EventArgs e)
        {
           
        }

    }

}
