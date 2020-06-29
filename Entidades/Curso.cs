using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public int Anio { get; set; }
        public int Semestre { get; set; }
        public string Turno { get; set; }
        public Alumno Alum { get; set; }
        public Profesor Prof { get; set; }

        public Curso()
        {
            this.Alum = new Alumno();
            this.Prof = new Profesor();
        }
    }
}
