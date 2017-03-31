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

    public partial class ConfigurarAlarmas : Form
    {

        private Sistema sistema;
        private Diseño d;
        private int opcion;
        private Simulacion sim;

        public ConfigurarAlarmas(Diseño diseño, int o)
        {
            sistema = Sistema.Instance;
            d = diseño;
            InitializeComponent();
            label3.Text = "";
            label4.Text = "";
            opcion = o;
            foreach (Nodo n in d.listaNodos)
            {
                CargarLista(n);
            }
            if (opcion == 2) {
                button2.Text = "Continuar";
            }
        }
        public ConfigurarAlarmas(Diseño diseño, int o, Simulacion s)
        {
            sistema = Sistema.Instance;
            d = diseño;
            InitializeComponent();
            label3.Text = "";
            label4.Text = "";
            opcion = o;
            foreach (Nodo n in d.listaNodos)
            {
                CargarLista(n);
            }
            if (opcion == 2)
            {
                button2.Text = "Continuar";
            }
            sim = s;
        }
       


        public void CargarLista(Nodo n)
        {
            if (n is Pieza)
            {
                utilizarList.Items.Add(n);
            }
            else {
                Componente c = (Componente)n;
                foreach (Nodo nodo in c.listaNodos) {
                    CargarLista(nodo);
                }
            }
        }

        

        private void utilizarList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (utilizarList.SelectedIndex > -1)
            {
                Pieza pieza = (Pieza)utilizarList.SelectedItem;
                label3.Text = pieza.min.ToString();
                label4.Text = pieza.max.ToString();
                alarmaText.Text = pieza.alarma.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Setear el valor de la alarma de la pieza
            if (utilizarList.SelectedIndex > -1)
            {
                Pieza pieza = (Pieza)utilizarList.SelectedItem;
                pieza.alarma = Convert.ToInt32(alarmaText.Text);
                if (pieza.SetearAlarma(Convert.ToInt32(alarmaText.Text)))
                {
                    utilizarList.Items.RemoveAt(utilizarList.SelectedIndex);
                    label3.Text = "0";
                    label4.Text = "0";
                    alarmaText.Text = "0";
                }
                else
                {
                    MessageBox.Show("La alarma debe de estar dentro de los rangos de valores máximo y mínimo", "ERROR");
                    alarmaText.Text = "0";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                if (opcion == 2)
                {
                    //si es una simulacion
                    MessageBox.Show("Ha seteado las alarmas exitósamente.");
                    this.Dispose();
                    ConsolaAdministrativa consola = new ConsolaAdministrativa(sim);
                    consola.StartPosition = FormStartPosition.CenterScreen;
                    consola.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Ha seteado las alarmas exitósamente.");
                    //si se esta creando el diseño
                    this.Dispose();
                }
            }
            else {
                MessageBox.Show("Error. Debe ingresar valores a todas las alarmas y verificar que estén dentro del máximo y mínimo.");
            }


        }

        private bool VerificarDatos() {
            bool ok = true;
            foreach(Pieza p in utilizarList.Items){
                if (!p.SetearAlarma(p.alarma)) { 
                   ok=false;
                }
            }
            return ok;
        }
        private void ConfigurarAlarmas_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }

}
