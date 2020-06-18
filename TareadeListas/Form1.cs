using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaListas.Modelo;

namespace TareaListas
{
    public partial class Form1 : Form
    {
        private List<Estudiantes> listaGrid = new List<Estudiantes>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Numero de matricula ingresada no valida...

            if (!(int.TryParse(this.txtMatricula.Text, out int matricula)))
            {
                MessageBox.Show("Numero de matricula ingresada no valida...");
                this.txtMatricula.Focus();
            }
            else if (this.txtApellidos.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar los apellidos del estudiante...");
                this.txtApellidos.Focus();
            }
            else if (this.txtNombres.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar los nombres del estudiante...");
                this.txtNombres.Focus();
            }
            else if (!(int.TryParse(this.txtEdad.Text, out int edad)))
            {
                MessageBox.Show("Edad ingresada no valida...");
                this.txtEdad.Focus();
            }
            else if (this.cmbSexo.Text == "")
            {
                MessageBox.Show("Debe seleccionar el sexo del estudiante...");
                this.cmbSexo.Focus();
            }
            else
            {
                Estudiantes alumno = new Estudiantes();
                alumno.matricula = matricula;
                alumno.apellidos = this.txtApellidos.Text;
                alumno.nombres = this.txtNombres.Text;
                alumno.edad = edad;
                alumno.sexo = this.cmbSexo.Text;
                listaGrid.Add(alumno);

                ListViewItem listaView = new ListViewItem(this.txtMatricula.Text.ToString());
                listaView.SubItems.Add(this.txtApellidos.Text);
                listaView.SubItems.Add(this.txtNombres.Text);
                listaView.SubItems.Add(this.txtEdad.Text);
                listaView.SubItems.Add(this.cmbSexo.Text);
                lstEstudiante.Items.Add(listaView);

                this.gridEstudiante.DataSource = null;
                this.gridEstudiante.DataSource = listaGrid;

                this.txtMatricula.Text = "";
                this.txtApellidos.Text = "";
                this.txtNombres.Text = "";
                this.txtEdad.Text = "";
                this.cmbSexo.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.gridEstudiante.DataSource = null;
            this.gridEstudiante.DataSource = listaGrid.Where(data => data.matricula.ToString() == this.txtFiltrar.Text).ToList();

            this.txtMayor.Text = listaGrid.Max(data => data.edad).ToString();
            this.txtMenor.Text = listaGrid.Min(data => data.edad).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label6_Click(object sender, EventArgs e)
        {
        }
        private void lstEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}   