using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class LEstudiantes
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Curso { set; get;  }
        public string Paralelo { set; get; }
        public int Promedio { set; get; }

        public LEstudiantes()
        {
        }

        public LEstudiantes(string nombre, string apellido, string curso, string paralelo, int promedio)
        {
            Nombre = nombre;
            Apellido = apellido;
            Curso = curso;
            Paralelo = paralelo;
            Promedio = promedio;
        }


    }
}
