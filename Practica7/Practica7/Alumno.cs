using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    internal class Alumno
    {
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public string NumeroControl { get; set; }
        public string Fotografia { get; set; } // ruta de la foto
        private List<int> calificaciones;

        public Alumno()
        {
            calificaciones = new List<int>();
        }

        // Agregar calificación validando que sea de 0 a 100
        public bool AgregarCalificacion(int calificacion)
        {
            if (calificacion >= 0 && calificacion <= 100)
            {
                calificaciones.Add(calificacion);
                return true;
            }
            return false;
        }

        // Obtener promedio
        public double ObtenerPromedio()
        {
            if (calificaciones.Count == 0) return 0;
            return calificaciones.Average();
        }

        // Ver si es regular (todas >= 60)
        public bool EsRegular()
        {
            return calificaciones.All(c => c >= 60);
        }

        public List<int> GetCalificaciones()
        {
            return calificaciones;
        }
    }
}
