using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        Solucion_Estudiantes solucion_Estudiantes = new Solucion_Estudiantes();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlmacenar_Click(object sender, EventArgs e)
        {
            LEstudiantes estudiantes = new LEstudiantes();

            estudiantes.Nombre = txtNombreL.Text;
            estudiantes.Apellido = txtApellidoL.Text;
            estudiantes.Curso = txtCursoL.Text;
            estudiantes.Paralelo = txtParaleloL.Text;
            estudiantes.Promedio = Convert.ToInt32(mtxtPromedio.Text);

            solucion_Estudiantes.Añadir(estudiantes);
            MessageBox.Show("Datos ingresados correctamente");
        }

        private void btnMostrarL_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.solucion_Estudiantes2 = solucion_Estudiantes;
        }

        private void btnAprovadosL_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            form3.solucion_Estudiantes3 = solucion_Estudiantes;
        }

        private void btnSuspensoL_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            form4.solucion_Estudiantes4 = solucion_Estudiantes;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreL.Text = " ";
            txtApellidoL.Text = " ";
            txtCursoL.Text = " ";
            txtParaleloL.Text = " ";
            mtxtPromedio.Text = " ";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
