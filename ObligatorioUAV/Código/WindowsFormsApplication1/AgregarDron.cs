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
    public partial class AgregarDron : Form
    {
        private Sistema sistema;
        private bool crear;
        private Dron unDron;

        public AgregarDron()
        {
            sistema = Sistema.Instance;
            InitializeComponent();
            label8.Text = sistema.ProximoNumeroDron().ToString();
            foreach (Diseño d in sistema.ListaDeDiseños)
            {
                comboDiseños.Items.Add(d);
            }
            crear = true;
            unDron = new Dron();
            comboDiseños.SelectedIndex = 0;
        }
        public AgregarDron(Dron d) {
            crear = false;
            sistema = Sistema.Instance;
            unDron = d;
            InitializeComponent();
            this.Text = "Editar Dron";
            btnAgregar.Text = "Editar";
            label8.Text = unDron.nroSerie.ToString();
            modeloText.Text = unDron.modeloControl;
            cantidadText.Text = unDron.cantidad.ToString();
            precioText.Text = unDron.precio.ToString();
            colorText.Text = unDron.color;
            int index = 0;
            foreach (Diseño dis in sistema.ListaDeDiseños)
            {
                comboDiseños.Items.Add(dis);
                if (dis.Equals(unDron.diseñoDron)) {
                    comboDiseños.SelectedIndex=index;
                }
                index++;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AgregarDron_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                int nroSerie = Convert.ToInt32(label8.Text);
                string color = colorText.Text.Trim();
                int cant =Convert.ToInt32(cantidadText.Text);
                int precio = Convert.ToInt32(precioText.Text);
                string modelo= modeloText.Text;
                Diseño dis = (Diseño)comboDiseños.SelectedItem;
                unDron.nroSerie = nroSerie;
                unDron.color = color;
                unDron.cantidad = cant;
                unDron.precio = precio;
                unDron.modeloControl = modelo;
                unDron.diseñoDron = dis;

                if (crear == true)
                {
                    if (sistema.AgregarDron(unDron))
                    {
                        MessageBox.Show("Dron creado existósamente.");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error.", "Error");
                    }
                }
                else
                {
                    //si se quiere editar el dron
                    MessageBox.Show("Dron editado existósamente.");
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Faltan ingresar datos.");
            }
        }

        public bool VerificarDatos()
        {
            TextBox[] datos = { cantidadText, modeloText, colorText, precioText };
            bool ok = true;

            foreach (TextBox txt in datos)
            {
                if (txt.Text.Replace(" ", "").Equals("") && txt.Enabled)
                {
                    ok = false;
                }
            }
           
            return ok;
        }

    }
}

