using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class AlumnoAdmin
    {
        AlumnoDb AlumDb = new AlumnoDb();

        public bool GuardarAlumno(Alumno alum)
        {
            return AlumDb.GuardarAlumno(alum);
        }

        public List<Alumno> ListarAlumno()
        {
            return AlumDb.ListarAlumno();
        }

        public Alumno BuscarAlumno(int id)
        {
            return AlumDb.BuscarAlumno(id);
        }
    }
}
