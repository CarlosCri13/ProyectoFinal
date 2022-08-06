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
            estudiantes.Promedio = Convert.ToInt32(msktPromedio.Text);

            solucion_Estudiantes.Añadir(estudiantes);
            MessageBox.Show("Datos ingresados correctamente");
        }

        private void btnMostrarL_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.solucion_Estudiantes2 = solucion_Estudiantes;
        }


    }
}
