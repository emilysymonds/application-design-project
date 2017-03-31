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
    public partial class AdministrarComp : Form
    {
        private Sistema sistema;
        

        public AdministrarComp()
        {
            sistema = Sistema.Instance;
            this.Text = "Administrar Componentes";
            InitializeComponent();
        }

        private void volverbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AdministrarComp_Load(object sender, EventArgs e)
        {
            int cant = sistema.ListaComp.Count;
            if (cant == 0)
            {
                complistBox.Items.Add("No se han creado componentes reusables aun");
            }
            else
            {
                foreach (Componente c in sistema.ListaComp)
                {
                    complistBox.Items.Add(c);
                }

            }
        }

        private void agregarbutton_Click(object sender, EventArgs e)
        {
            //agregar componente
            AgregarComp c = new AgregarComp();
            c.StartPosition = FormStartPosition.CenterScreen;
            c.ShowDialog(this);
        }

       
        private void eliminarbutton1_Click(object sender, EventArgs e)
        {
            //eliminar componente
            Componente selec = (Componente)complistBox.SelectedItem;
            if(selec!=null){
                int posicion = complistBox.SelectedIndex;
                DialogResult result = MessageBox.Show("Está seguro de querer eliminar el componente?", "Eliminar componente", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    bool compone = sistema.VerificarComponente(selec);
                    if (compone == false)
                    {
                        sistema.ListaComp.RemoveAt(posicion);
                        selec.Delete();
                    }
                    else
                        MessageBox.Show("No puede eliminar el componente porque forma parte de algún componente o diseño.", "ERROR");

                }
            }
            else
            {
                MessageBox.Show("Seleccione un componente");
            }
        }

        private void modificarbutton1_Click(object sender, EventArgs e)
        {
            //editar componente
            Componente selec = (Componente)complistBox.SelectedItem;
            if(selec!=null){
                AgregarComp c = new AgregarComp(selec);
                c.StartPosition = FormStartPosition.CenterScreen;
                c.ShowDialog(this);
            }else{
                MessageBox.Show("Seleccione un componente");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //ver componente
            Componente selec = (Componente)complistBox.SelectedItem;
            if (selec != null)
            {
                VerComponente v = new VerComponente(selec);
                v.StartPosition = FormStartPosition.CenterScreen;
                v.ShowDialog(this);
            }else
            {
                MessageBox.Show("Seleccione un componente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //actualiza la lista
            int items = complistBox.Items.Count;
            while (items > 0) {
                complistBox.Items.RemoveAt(items-1);
                items--;
            }
            int cant = sistema.ListaComp.Count;
            if (cant == 0)
            {
                complistBox.Text = "No se han creado componentes reusables aún.";
            }
            else
            {
                foreach (Componente c in sistema.ListaComp)
                {
                    complistBox.Items.Add(c);
                }

            }
        }
    }
}
