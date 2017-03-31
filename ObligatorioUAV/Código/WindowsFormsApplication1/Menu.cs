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
    public partial class Menu : Form
    {
        private Sistema sistema;

        public Menu()
        {
            sistema = Sistema.Instance;
            
            InitializeComponent();

        }

        private void diseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            sistema.AgregarDatos();
        }

        private void piezaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarPieza pieza = new AdministrarPieza();
            pieza.StartPosition = FormStartPosition.CenterScreen;
            pieza.ShowDialog(this);
        }

        private void componenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarComp comp = new AdministrarComp();
            comp.StartPosition = FormStartPosition.CenterScreen;
            comp.ShowDialog(this);
        }

        private void crearDiseñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarDiseño diseño = new AdministrarDiseño();
            diseño.StartPosition = FormStartPosition.CenterScreen;
            diseño.ShowDialog(this);

        }

        private void crearDroneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarDron dron = new AdministrarDron();
            dron.StartPosition = FormStartPosition.CenterScreen;
            dron.ShowDialog(this);
        }

        private void iniciarSimulaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioSimulacion sim = new InicioSimulacion();
            sim.StartPosition = FormStartPosition.CenterScreen;
            sim.ShowDialog(this);
        }


    }
    
}
