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
    public partial class AdministrarPieza : Form
    {
        private Sistema sistema;
        

        public AdministrarPieza()
        {
            sistema = Sistema.Instance;        
            InitializeComponent();
        }

        private void volverbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AdministrarPieza_Load(object sender, EventArgs e)
        {
           int cant = sistema.ListaPiezas.Count;
           if (cant == 0)
            {
                piezaslistBox.Items.Add("No se han ingresado piezas aun.");
            }
            else
            {
                foreach (Pieza p in sistema.ListaPiezas)
                {
                    piezaslistBox.Items.Add(p);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //crear pieza
            AgregarPieza pieza = new AgregarPieza();
            pieza.StartPosition = FormStartPosition.CenterScreen;
            pieza.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //eliminar pieza
            Pieza selec = (Pieza)piezaslistBox.SelectedItem;
            if (selec != null)
            {
                int posicion = piezaslistBox.SelectedIndex;
                DialogResult result = MessageBox.Show("Está seguro de querer eliminar la pieza?", "Eliminar pieza", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    bool compone = sistema.VerificarPieza(selec);
                    if (compone == false)
                    {
                        sistema.ListaPiezas.RemoveAt(posicion);
                        if (selec is Acelerometro)
                            selec.Delete();
                        if (selec is Altimetro)
                            selec.Delete();
                        if (selec is Barometro)
                            selec.Delete();
                        if (selec is GPS)
                            selec.Delete();
                        if (selec is Velocimetro)
                            selec.Delete();
                        if (selec is Termometro)
                            selec.Delete();
                    }
                    else
                        MessageBox.Show("No puede eliminar la pieza porque forma parte de algún componente o diseño.", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una pieza.");
            }
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            //actualiza la lista
            int items = piezaslistBox.Items.Count;
            while (items > 0)
            {
                piezaslistBox.Items.RemoveAt(items - 1);
                items--;
            }
            int cant = sistema.ListaPiezas.Count;
            if (cant == 0)
            {
                piezaslistBox.Text = "No se han creado piezas aun";
            }
            else
            {
                foreach (Pieza p in sistema.ListaPiezas)
                {
                    piezaslistBox.Items.Add(p);
                }
            }
        }

        private void editarbutton_Click(object sender, EventArgs e)
        {
            //edita la pieza
            Pieza selec = (Pieza)piezaslistBox.SelectedItem;
            if (selec != null)
            {
                AgregarPieza c = new AgregarPieza(selec);
                c.StartPosition = FormStartPosition.CenterScreen;
                c.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Seleccione una pieza");
            }
        }
        
    }
}
