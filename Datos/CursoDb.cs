using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class CursoDb : ConexionDb
    {
        SqlCommand cmd = null;

        public List<VerCurso> ListarPorCursoA(int idCurso)
        {
            List<VerCurso> Lista = null;
            VerCurso obj = null;
            try
            {
                cmd = new SqlCommand();
                SqlDataReader dr;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SpCursoListarAlumno";
                cmd.Parameters.AddWithValue("@idCurso", idCurso);
                cmd.CommandTimeout = 180;
                Conectar();
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Lista = new List<VerCurso>();
                    obj = new VerCurso();
                    obj.IdCurso = Convert.ToInt32(dr[0]);
                    obj.NombreCurso = dr[1].ToString();
                    obj.Anio = Convert.ToInt32(dr[2].ToString());
                    obj.Semestre = Convert.ToInt32(dr[3]);
                    obj.Turno = dr[4].ToString();
                    obj.Alum = new Alumno();
                    obj.Alum.Nombre= dr[5].ToString();
                    obj.Alum.Apellido= dr[6].ToString();

                    Lista.Add(obj);

                }
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al guardar alumno.", Ex);
            }
            finally
            {
                Desconectar();
            }
            return Lista;
        }

        public List<VerCurso> ListarPorCursoP(int idCurso)
        {
            List<VerCurso> Lista = null;
            VerCurso obj = null;
            try
            {
                cmd = new SqlCommand();
                SqlDataReader dr;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SpCursoListarProfesor";
                cmd.Parameters.AddWithValue("@idCurso", idCurso);
                cmd.CommandTimeout = 180;
                Conectar();
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Lista = new List<VerCurso>();
                    obj = new VerCurso();
                    obj.IdCurso = Convert.ToInt32(dr[0]);
                    obj.NombreCurso = dr[1].ToString();
                    obj.Anio = Convert.ToInt32(dr[2].ToString());
                    obj.Semestre = Convert.ToInt32(dr[3]);
                    obj.Turno = dr[4].ToString();
                    obj.Prof = new Profesor();
                    obj.Prof.Nombre = dr[5].ToString();
                    obj.Prof.Apellido = dr[6].ToString();

                    Lista.Add(obj);

                }
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al guardar alumno.", Ex);
            }
            finally
            {
                Desconectar();
            }
            return Lista;
        }
        
        public List<Curso> ListarCurso()
        {
            List<Curso> Lista = null;
            Curso obj = null;

            try
            {
                cmd = new SqlCommand();
                SqlDataReader dr;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SpCursoListar";
                cmd.CommandTimeout = 180;
                Conectar();
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();

                Lista = new List<Curso>();

                while (dr.Read())
                {
                    obj = new Curso();
                    obj.IdCurso = Convert.ToInt32(dr[0]);
                    obj.NombreCurso = dr[1].ToString();
                    obj.Anio = Convert.ToInt32(dr[2].ToString());
                    obj.Semestre = Convert.ToInt32(dr[3]);
                    obj.Turno = dr[4].ToString();
                    Lista.Add(obj);

                }
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al listar curso.", Ex);
            }
            finally
            {
                Desconectar();
            }
            return Lista;
        }

    }
}
