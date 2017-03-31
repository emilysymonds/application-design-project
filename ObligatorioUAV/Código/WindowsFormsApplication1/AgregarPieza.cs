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
    public partial class AgregarPieza : Form
    {
        private Sistema sistema;
        private Pieza unaPieza;
        private bool crear;

        public AgregarPieza()
        {
            sistema = Sistema.Instance;
            crear = true;
            unaPieza = new Pieza();
            InitializeComponent();
            tipoPiezaText.Visible = false;
        }
        public AgregarPieza(Pieza pieza) {
            //si es editar
            sistema = Sistema.Instance;
            crear = false;
            unaPieza = pieza;
            InitializeComponent();
            this.Text = "Editar pieza";
            label7.Text = "Editar pieza";
            btnAgregar.Text = "Editar";
            marcaText.Text = unaPieza.marca;
            modeloText.Text = unaPieza.modelo;
            precisionText.Text = unaPieza.precision.ToString();
            minimoText.Text = unaPieza.min.ToString();
            maximoText.Text = unaPieza.max.ToString();
            marcaText.Enabled = false;
            modeloText.Enabled = false;
            tipoPiezaCombo.Visible = false;
            tipoPiezaCombo.Enabled = false;
            tipoPiezaText.Enabled = false;
           
            if (unaPieza.Tipo() == 2)
            {
                tipoPiezaText.Text = "Velocímetro";
            }
            if (unaPieza.Tipo() == 1)
            {
                tipoPiezaText.Text = "Termómetro";
            }
            if (unaPieza.Tipo() == 3)
            {
                tipoPiezaText.Text = "Altímetro";
            }
            if (unaPieza.Tipo() == 4)
            {
                tipoPiezaText.Text = "Barómetro";
            }
            if (unaPieza.Tipo() == 5)
            {
                tipoPiezaText.Text = "GPS";
            }
            if (unaPieza.Tipo() == 6)
            {
                tipoPiezaText.Text = "Acelerómetro";
            }
           

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                string marca = marcaText.Text.Trim();
                string modelo = "P_" + modeloText.Text.Trim();
                int precision = Convert.ToInt32(precisionText.Text.Trim());
                int min = Convert.ToInt32(minimoText.Text.Trim());
                int max = Convert.ToInt32(maximoText.Text.Trim());
                int tipo = tipoPiezaCombo.SelectedIndex;

                if (crear)
                {
                    if (tipo == 0)
                    {
                        unaPieza = new Termometro(marca, modelo, precision, min, max, 0, 0.0);
                    }
                    if (tipo == 1)
                    {
                        unaPieza = new Velocimetro(marca, modelo, precision, min, max, 0, 0, 0, 0);
                    }
                    if (tipo == 2)
                    {
                        unaPieza = new Altimetro(marca, modelo, precision, min, max, 0, 0);
                    }
                    if (tipo == 3)
                    {
                        unaPieza = new Barometro(marca, modelo, precision, min, max, 0, 0);
                    }
                    if (tipo == 4)
                    {
                        unaPieza = new GPS(marca, modelo, precision, min, max, 0, 0, 0, 0);
                    }
                    if (tipo == 5)
                    {
                        unaPieza = new Acelerometro(marca, modelo, precision, min, max, 0, 0, 0, 0);
                    }

                    if (sistema.AgregarPieza(unaPieza))
                    {
                        MessageBox.Show("Pieza creada existósamente");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una pieza con el modelo y marca ingresados. Debe reingresar los datos");
                        modeloText.Focus();
                        marcaText.Focus();
                    }
                }
                else
                {
                    unaPieza.precision = precision;
                    unaPieza.min = min;
                    unaPieza.max = max;
                    if (unaPieza is Acelerometro)
                        unaPieza.Update();
                    if (unaPieza is Altimetro)
                        unaPieza.Update();
                    if (unaPieza is Barometro)
                        unaPieza.Update();
                    if (unaPieza is GPS)
                        unaPieza.Update();
                    if (unaPieza is Velocimetro)
                        unaPieza.Update();
                    if (unaPieza is Termometro)
                        unaPieza.Update();
                    MessageBox.Show("Pieza editada existósamente");
                    this.Dispose();
                }
            }
            else {
                MessageBox.Show("Faltan ingresar datos");
            }
        }

        //Método que indica si todos los datos ingresados son correctos
        public bool VerificarDatos()
        {
            TextBox[] datos = { marcaText, modeloText, precisionText, maximoText, minimoText };
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

        //Limpia los datos ingresados
        public void Limpiar()
        {
            TextBox[] datos = { marcaText, modeloText, precisionText, maximoText, minimoText };
           
            for (int i = 0; i < datos.Count(); i++)
            {
                datos[i].Text = "";
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tipoPiezaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AgregarPieza_Load(object sender, EventArgs e)
        {
            tipoPiezaCombo.SelectedIndex = 0;
        }

    }
}
