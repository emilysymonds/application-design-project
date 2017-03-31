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

    public partial class AdministrarDiseño : Form
    {
        private Sistema sistema;
        
        public AdministrarDiseño()
        {
            sistema = Sistema.Instance;
            InitializeComponent();
            CargarLista();
        }

        private void agregarbutton_Click(object sender, EventArgs e)
        {

        }

        public void CargarLista()
        {
            if (sistema.ListaDeDiseños.Count == 0)
            {
              listDiseños.Items.Add("No se han creado diseños aun");
                
            }
            else
            {
                foreach (Diseño d in sistema.ListaDeDiseños)
                {
                    listDiseños.Items.Add(d);
                }
            }
        }

        public void Limpiar()
        {
            listDiseños.Items.Clear();
        }

        public void Actualizar()
        {
            Limpiar();
            foreach (Diseño d in sistema.ListaDeDiseños)
            {
                listDiseños.Items.Add(d);
            }
        }

        private void volverbutton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void AdministrarDiseño_Load(object sender, EventArgs e)
        {
            
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            //crear diseño
            this.Dispose();
            AgregarDiseño dis = new AgregarDiseño();
            dis.StartPosition = FormStartPosition.CenterScreen;
            dis.ShowDialog();
           
        }

        private void modificarbutton1_Click(object sender, EventArgs e)
        {

        }

        private void elimiarbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            //actualiza la lista
            int items = listDiseños.Items.Count;
            while (items > 0)
            {
                listDiseños.Items.RemoveAt(items - 1);
                items--;
            }
            int cant = sistema.ListaComp.Count;
            if (cant == 0)
            {
                listDiseños.Text = "No se han creado diseños aún";
            }
            else
            {
                foreach (Diseño d in sistema.ListaDeDiseños)
                {
                    listDiseños.Items.Add(d);
                }

            }
        }

        private void editarbutton_Click(object sender, EventArgs e)
        {
            if (listDiseños.SelectedIndex > -1)
            {
                this.Dispose();
                AgregarDiseño diseño = new AgregarDiseño((Diseño)listDiseños.SelectedItem);
                diseño.StartPosition = FormStartPosition.CenterScreen;
                diseño.ShowDialog();
            }
            else
                MessageBox.Show("Debe seleccionar un diseño para poder modificarlo", "ERROR");
      
        }

    }

}
