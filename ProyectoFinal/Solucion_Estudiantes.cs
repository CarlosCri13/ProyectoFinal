using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Solucion_Estudiantes
    {
        public List<LEstudiantes> Estudiantes = new List<LEstudiantes>();

        public Solucion_Estudiantes()
        {
            Estudiantes = new List<LEstudiantes>();
        }

        // Metodo añadir 

        public void Añadir(LEstudiantes Estudiante)
        {
            Estudiantes.Add(Estudiante);
        }


        // Metodo Aprobar 
        public List<LEstudiantes> Aprobados()
        {
            List<LEstudiantes> aux = new List<LEstudiantes>();
            foreach (LEstudiantes estudiantes in Estudiantes)
            {
                if (estudiantes.Promedio >= 7)
                {
                    aux.Add(estudiantes);
                }
            }
            return aux;
        }

        // Metodo Supletorio
        public List<LEstudiantes> Supletorios()
        {
            List<LEstudiantes> aux = new List<LEstudiantes>();
            foreach (LEstudiantes estudiantes in Estudiantes)
            {
                if (estudiantes.Promedio<=7)
                {
                    aux.Add(estudiantes);
                }
            }
            return aux;
        }
    }
}
