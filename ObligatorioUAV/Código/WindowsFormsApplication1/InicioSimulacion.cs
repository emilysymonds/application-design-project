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
    public partial class InicioSimulacion : Form
    {
        private Sistema sistema;
        private Simulacion sim;

        public InicioSimulacion()
        {
            sistema = Sistema.Instance;
            sim = new Simulacion();
            InitializeComponent();
        }

        private void volverbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dron selec = (Dron)listDrones.SelectedItem;
            if (VerificarDatos())
            {
                if (selec != null && selec.cantidad>0)
                {
                    sim.nroSimulacion = sistema.ProximoNumeroSimulacion();
                    sim.dron = selec;
                    sim.coordX = Convert.ToInt32(xi.Text);
                    sim.coordY = Convert.ToInt32(yi.Text);
                    sim.coordZ = Convert.ToInt32(zi.Text);
                    sim.coordXf = Convert.ToInt32(xf.Text);
                    sim.coordYf = Convert.ToInt32(yf.Text);
                    sim.coordZf = Convert.ToInt32(zf.Text);
                    sim.velocidadX = Convert.ToInt32(xv.Text);
                    sim.velocidadY = Convert.ToInt32(yv.Text);
                    sim.velocidadZ = Convert.ToInt32(zv.Text);
                    if (sistema.AgregarSimulacion(sim))
                    {
                        this.Dispose();
                        ConfigurarAlarmas alarm = new ConfigurarAlarmas(sim.dron.diseñoDron, 2, sim);
                        alarm.StartPosition = FormStartPosition.CenterScreen;
                        alarm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Error.");
                    }
                }
                else
                {
                    if (selec == null)
                    {
                        MessageBox.Show("Seleccione un dron.");
                    }else {
                        MessageBox.Show("No quedan drones de ese modelo.");
                    }
                }
            }
            else {
                MessageBox.Show("Verifique los datos. Valores pueden exceder límites permitidos.");
            }
            
        }

        public bool VerificarDatos()
        {
            TextBox[] datos = { xi,yi,xi,xf,yf,zf,xv,yv,zv };
            bool ok = true;

            foreach (TextBox txt in datos)
            {
                if (txt.Text.Replace(" ", "").Equals("") && txt.Enabled)
                {
                    ok = false;
                }
            }
            if (ok == true)
            {
                Dron selec = (Dron)listDrones.SelectedItem;
                List<Pieza> lista = sistema.DevolverListaPiezas(selec.diseñoDron.listaNodos);
                int max, min;
                foreach (Pieza p in lista)
                {
                    if (p is GPS)
                    {
                        max = p.max;
                        min = p.min;
                        if (Convert.ToInt32(xf.Text) + p.precision >= max || Convert.ToInt32(yf.Text) + p.precision >= max || Convert.ToInt32(zf.Text) + p.precision >= max || Convert.ToInt32(xf.Text) - p.precision <= min || Convert.ToInt32(yf.Text) - p.precision <= min || Convert.ToInt32(zf.Text) - p.precision <= min)
                        {
                            ok = false;
                        }

                        if (Convert.ToInt32(xi.Text) + p.precision >= max || Convert.ToInt32(yi.Text) + p.precision >= max || Convert.ToInt32(zi.Text) + p.precision >= max || Convert.ToInt32(xi.Text) - p.precision <= min || Convert.ToInt32(yi.Text) - p.precision <= min || Convert.ToInt32(zi.Text) - p.precision <= min)
                        {
                            ok = false;
                        }
                        else
                        {
                            GPS g = (GPS)p;
                            g.x = Convert.ToInt32(xi.Text);
                            g.y = Convert.ToInt32(yi.Text);
                            g.z = Convert.ToInt32(zi.Text);
                        }
                    }
                    if (p is Velocimetro)
                    {
                        max = p.max;
                        min = p.min;
                        if (Convert.ToInt32(xv.Text) + p.precision >= max || Convert.ToInt32(yv.Text) + p.precision >= max || Convert.ToInt32(zv.Text) + p.precision >= max || Convert.ToInt32(xv.Text) - p.precision <= min || Convert.ToInt32(yv.Text) - p.precision <= min || Convert.ToInt32(zv.Text) - p.precision <= min)
                        {
                            ok = false;
                        }
                        else
                        {
                            Velocimetro g = (Velocimetro)p;
                            g.x = Convert.ToInt32(xv.Text);
                            g.y = Convert.ToInt32(yv.Text);
                            g.z = Convert.ToInt32(zv.Text);
                        }
                    }
                }
            }
            
            return ok;
        }
        private void InicioSimulacion_Load(object sender, EventArgs e)
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

        private void listDrones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dron selec = (Dron)listDrones.SelectedItem;
            List<Pieza>lista=sistema.DevolverListaPiezas(selec.diseñoDron.listaNodos);
                foreach (Pieza p in lista) {
                    if (p is GPS) { 
                        GPS n = (GPS)p;
                        xi.Text = n.x.ToString();
                        yi.Text = n.y.ToString();
                        zi.Text = n.z.ToString();
                    }
                    if (p is Velocimetro)
                    {
                        Velocimetro n = (Velocimetro)p;
                        xv.Text = n.x.ToString();
                        yv.Text = n.y.ToString();
                        zv.Text = n.z.ToString();
                    }
                }
                if (selec.nroSerie == 100)
                {
                    xf.Text = Convert.ToString(50);
                    yf.Text = Convert.ToString(67);
                    zf.Text = Convert.ToString(39);
                    xf.Enabled = false;
                    yf.Enabled = false;                    
                    zf.Enabled = false;
                    xi.Enabled = false;
                    yi.Enabled = false;
                    zi.Enabled = false;
                    xv.Enabled = false;
                    yv.Enabled = false;
                    zv.Enabled = false;
                    
                }
                else if (selec.nroSerie == 101)
                {
                    xf.Text = Convert.ToString(87);
                    yf.Text = Convert.ToString(79);
                    zf.Text = Convert.ToString(75);
                    xf.Enabled = false;
                    yf.Enabled = false;
                    zf.Enabled = false;
                    xi.Enabled = false;
                    yi.Enabled = false;
                    zi.Enabled = false;
                    xv.Enabled = false;
                    yv.Enabled = false;
                    zv.Enabled = false;
                 
                }
                else {
                    xf.Text = "0";
                    yf.Text = "0";
                    zf.Text = "0";
                    /*xi.Text = "";
                    yi.Text = "";
                    zi.Text = "";
                    xv.Text = "";
                    zv.Text = "";
                    yv.Text = "";*/
                    xi.Enabled = true;
                    xf.Enabled = true;
                    xv.Enabled = true;
                    yi.Enabled = true;
                    yf.Enabled = true;
                    yv.Enabled = true;
                    zi.Enabled = true;
                    zf.Enabled = true;
                    zv.Enabled = true;
                }
        }
    }
}
