using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class CursoAdmin
    {
        CursoDb objDb = new CursoDb();

        public List<VerCurso> ListarPorCursoA(int idCurso)
        {
            return objDb.ListarPorCursoA(idCurso);
        }

        public List<VerCurso> ListarPorCursoP(int idCurso)
        {
            return objDb.ListarPorCursoP(idCurso);
        }

        public List<Curso> ListarCurso()
        {
            return objDb.ListarCurso();
        }
    }
}
