using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareadeListas.Modelo
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

{
    public partial class Form1 : Form
{
    private List<Estudiantes> lista = new List<Estudiantes>();
    private List<Estudiantes> listaGrid = new List<Estudiantes>();

    public Form1()
    {
@@ -57,11 + 57,17 @@ private void btnAgregar_Click(object sender, EventArgs e)
                alumno.nombres = this.txtNombres.Text;
                alumno.edad = edad;
                alumno.sexo = this.cmbSexo.Text;
                listaGrid.Add(alumno);

                lista.Add(alumno);
                ListViewItem listaView = new ListViewItem(this.txtMatricula.Text.ToString());
    listaView.SubItems.Add(this.txtApellidos.Text);
    listaView.SubItems.Add(this.txtNombres.Text);
    listaView.SubItems.Add(this.txtEdad.Text);
    listaView.SubItems.Add(this.cmbSexo.Text);
    lstEstudiante.Items.Add(listaView);

                this.gridEstudiante.DataSource = null;
                this.gridEstudiante.DataSource = lista;
                this.gridEstudiante.DataSource = listaGrid;

                this.txtMatricula.Text = "";
                this.txtApellidos.Text = "";
@@ -74,10 +80,10 @@ private void btnAgregar_Click(object sender, EventArgs e)
        private void button2_Click(object sender, EventArgs e)
    {
        this.gridEstudiante.DataSource = null;
        this.gridEstudiante.DataSource = lista.Where(data => data.matricula.ToString() == this.txtFiltrar.Text).ToList();
        this.gridEstudiante.DataSource = listaGrid.Where(data => data.matricula.ToString() == this.txtFiltrar.Text).ToList();

        this.txtMayor.Text = lista.Max(data => data.edad).ToString();
        this.txtMenor.Text = lista.Min(data => data.edad).ToString();
        this.txtMayor.Text = listaGrid.Max(data => data.edad).ToString();
        this.txtMenor.Text = listaGrid.Min(data => data.edad).ToString();
    }

    private void Form1_Load(object sender, EventArgs e)
@@ -86,5 +92,8 @@ private void Form1_Load(object sender, EventArgs e)
        private void label6_Click(object sender, EventArgs e)
    {
    }
    private void lstEstudiante_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
}
}