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
    public partial class AgregarComp : Form
    {
        private Sistema sistema;       
        private bool crear;
        private Componente unComp;

        public AgregarComp()
        {
            sistema = Sistema.Instance;            
            crear = true;
            unComp = new Componente();
            InitializeComponent();

            CargarListas();
        }
        public AgregarComp(Componente comp) {
            crear = false;
            sistema = Sistema.Instance;
            unComp = comp;
            InitializeComponent();
            this.Text = "Editar Componente";
            crearButton.Text = "Editar";
            marcaText.Text = unComp.marca;
            marcaText.Enabled = false;
            modeloText.Text = unComp.modelo;
            modeloText.Enabled = false;
            CargarListas();
            foreach (Nodo n in unComp.listaNodos) {
                nuevolistBox.Items.Add(n);
                if (n is Pieza) {
                    piezaslistBox.Items.Remove(n);
                }
                if (n is Componente) {
                    complistBox.Items.Remove(n);
                }
            }
            
        }
        public void CargarListas() {
            int cant = sistema.ListaComp.Count;
            if (cant == 0)
            {
                complistBox.Text=("No se han creado componentes reusables aun");
            }
            else
            {
                foreach (Componente c in sistema.ListaComp)
                {
                    complistBox.Items.Add(c);
                }
                complistBox.Items.Remove(unComp);

            }

            int cant2 = sistema.ListaPiezas.Count;
            if (cant2 == 0)
            {
                piezaslistBox.Text=("No se han creado piezas aun");
            }
            else
            {
                foreach (Pieza c in sistema.ListaPiezas)
                {
                    piezaslistBox.Items.Add(c);
                }

            }
            nuevolistBox.Text=("No se han agregado piezas ni componentes");

        }
        private void AgregarComp_Load(object sender, EventArgs e)
        {
            
        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                string marca = marcaText.Text.Trim();
                string modelo = "C_" + modeloText.Text.Trim();
                unComp.marca = marca;
                unComp.modelo = modelo;
                if (crear == true)
                {
                    if (sistema.AgregarComp(unComp))
                    {
                        MessageBox.Show("Componente creado existósamente.");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un componente con el modelo y marca ingresados. Debe reingresar los datos.");
                        modeloText.Focus();
                        marcaText.Focus();
                    }
                }
                else { 
                    //si edito correctamente
                    unComp.Update();
                    MessageBox.Show("Componente editado exitósamente.");
                    this.Dispose();
                   
                }
            }
            else {
                MessageBox.Show("Faltan ingresar datos.");
            }
        }

        public bool VerificarDatos()
        {
            TextBox[] datos = {marcaText, modeloText};
            bool ok = true;

            foreach (TextBox txt in datos)
            {
                if (txt.Text.Replace(" ", "").Equals("") && txt.Enabled)
                {
                    ok = false;
                }
            }
            if (nuevolistBox.Items.Count == 0) {
                ok = false;
            }
            return ok;
        }

        private void agregarPiezasbutton_Click(object sender, EventArgs e)
        {
            Nodo nueva = (Nodo)piezaslistBox.SelectedItem;
            if (nueva!=null)
            {
                bool existe = false;
                foreach (Nodo n in unComp.listaNodos)
                {
                    if (nueva.Equals(n))
                    {
                        existe = true;
                    }
                }
                if (!existe)
                {
                    unComp.AgregarHijo(nueva);
                    nuevolistBox.Items.Add(piezaslistBox.SelectedItem);
                    piezaslistBox.Items.Remove(nueva);
                }
                else
                {
                    MessageBox.Show("No puede seleccionar la misma pieza nuevamente.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una pieza", "ERROR");
            }
        }

        private void agregarCompButton_Click(object sender, EventArgs e)
        {
           Nodo nuevo = (Nodo)complistBox.SelectedItem;
           if(nuevo!=null){
                bool existe = false;
                foreach (Nodo n in unComp.listaNodos)
                {
                    if (nuevo.Equals(n))
                    {
                        existe = true;
                    }
                    if (nuevo.Equals(this.unComp))
                    {
                        existe = true;
                    }
                }
                if (!existe)
                {
                    unComp.AgregarHijo(nuevo);
                    nuevolistBox.Items.Add((Nodo)complistBox.SelectedItem);
                    complistBox.Items.Remove(nuevo);
                }
                else
                {
                    MessageBox.Show("No puede seleccionar el mismo componente nuevamente.");
                }
            }else
            {
                MessageBox.Show("Debe seleccionar un componente", "ERROR");
            }            
        }

        private void deletebutton1_Click(object sender, EventArgs e)
        {
            int posicion = nuevolistBox.SelectedIndex;
            if (nuevolistBox.SelectedItem is Pieza)
            {
                piezaslistBox.Items.Add(nuevolistBox.SelectedItem);
                unComp.EliminarHijo((Nodo)nuevolistBox.SelectedItem);
                nuevolistBox.Items.Remove(nuevolistBox.SelectedItem);

            }
            else if (nuevolistBox.SelectedItem is Componente)
            {
                complistBox.Items.Add(nuevolistBox.SelectedItem);
                unComp.EliminarHijo((Nodo)nuevolistBox.SelectedItem);
                nuevolistBox.Items.Remove(nuevolistBox.SelectedItem);

            }
            else {
                MessageBox.Show("Debe seleccionar un elemento", "ERROR");
            }
                      
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
