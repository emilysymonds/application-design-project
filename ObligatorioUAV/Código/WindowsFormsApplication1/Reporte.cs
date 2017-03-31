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
    public partial class Reporte : Form
    {
        private Sistema sistema;
        private Simulacion sim;

        public Reporte(Simulacion s)
        {
            sistema = Sistema.Instance;
            sim = s;
            InitializeComponent();
            labelSimulacion.Text = s.nroSimulacion.ToString();
            labelDron.Text = s.dron.nroSerie.ToString();

            foreach (string r in sim.reportes)
            {
                listReporte.Items.Add(r);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
