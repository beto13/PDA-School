using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VerCurso : Curso
    {
        public string VerAlumno
        {
            get { return this.Alum.Nombre + " " + this.Alum.Apellido; }
        }

        public string VerProfesor
        {
            get { return this.Prof.Nombre + " " + this.Prof.Apellido; }
        }
    }
}
