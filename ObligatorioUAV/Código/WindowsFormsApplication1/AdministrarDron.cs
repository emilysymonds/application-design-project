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
    public partial class AdministrarDron : Form
    {
        private Sistema sistema;
       

        public AdministrarDron()
        {
            sistema = Sistema.Instance;
            InitializeComponent();
            CargarLista();
        }
       
        public void CargarLista()
        {
            if (sistema.ListaDeDiseños.Count == 0)
            {
                listDrones.Items.Add("No hay drones ingresados en el sistema.");
            }
            else
            {
                foreach (Dron d in sistema.ListaDeDrones)
                {
                    listDrones.Items.Add(d);
                }
            }
        }

        public void Limpiar()
        {
            listDrones.Items.Clear();
        }

        public void Actualizar()
        {
            Limpiar();
            foreach (Dron d in sistema.ListaDeDrones)
            {
                listDrones.Items.Add(d);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void agregarbutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            AgregarDron dron = new AgregarDron();
            dron.StartPosition = FormStartPosition.CenterScreen;
            dron.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void AdministrarDron_Load(object sender, EventArgs e)
        {
           
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            //actualiza la lista
            int items = listDrones.Items.Count;
            while (items > 0)
            {
                listDrones.Items.RemoveAt(items - 1);
                items--;
            }
            int cant = sistema.ListaDeDrones.Count;
            if (cant == 0)
            {
                listDrones.Text = "No se han creado drones aún.";
            }
            else
            {
                foreach (Dron p in sistema.ListaDeDrones)
                {
                    listDrones.Items.Add(p);
                }
            }
        }

        private void elimiarbutton_Click(object sender, EventArgs e)
        {
            //eliminar dron
            Dron selec = (Dron)listDrones.SelectedItem;
            if (selec != null)
            {
                int posicion = listDrones.SelectedIndex;
                DialogResult result = MessageBox.Show("Está seguro de querer eliminar el dron?", "Eliminar dron", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    sistema.ListaDeDrones.RemoveAt(posicion);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un dron.", "ERROR");
            }
        }

        private void editarbutton_Click(object sender, EventArgs e)
        {
            //editar dron
            Dron selec = (Dron)listDrones.SelectedItem;
            if (selec != null)
            {
                AgregarDron dron = new AgregarDron(selec);
                dron.StartPosition = FormStartPosition.CenterScreen;
                dron.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un dron.");
            }
            
        }
    }
}

