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
    public partial class VerComponente : Form
    {
        private Sistema sistema;
        private Componente comp;

        public VerComponente(Componente c)
        {
            sistema = Sistema.Instance;
            comp = c;
            InitializeComponent();
        }
       
        private void VerComponente_Load(object sender, EventArgs e)
        {
            marcalabel.Text = comp.marca;
            modelolabel.Text = comp.modelo;
            int cant = comp.listaNodos.Count;
            if (cant == 0)
            {
                piezaslistBox.Text = "No tiene componentes";         
            }
            else
            {
                foreach (Nodo p in comp.listaNodos)
                {
                    piezaslistBox.Items.Add(p);
                }
                

            }
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
