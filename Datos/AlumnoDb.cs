using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    public class AlumnoDb : ConexionDb
    {
        SqlCommand cmd = null;

        public bool GuardarAlumno(Alumno alum)
        {
            bool respuesta = false;

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SpAlumnoInsertar";
                cmd.CommandTimeout = 180;
                cmd.Parameters.AddWithValue("@Nombre",alum.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", alum.Apellido);
                cmd.Parameters.AddWithValue("@TipoDocumento", alum.TipoDocumento);
                cmd.Parameters.AddWithValue("@Documento", alum.NroDocumento);
                cmd.Parameters.AddWithValue("@FechaNacimiento", alum.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", alum.Sexo);
                cmd.Parameters.AddWithValue("@Domicilio", alum.Domicilio);
                cmd.Parameters.AddWithValue("@FechaIngreso", alum.FechaIngreso);
                cmd.Parameters.AddWithValue("@Carrera", alum.Carrera);
                Conectar();
                cmd.Connection = conn;

                if (cmd.ExecuteNonQuery()>0)
                {
                    respuesta = true;
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
            return respuesta;
        }

        public List<Alumno> ListarAlumno()
        {
            List<Alumno> lista=null;
            Alumno alum = null;

            try
            {
                cmd = new SqlCommand();
                SqlDataReader dr;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SpAlumnoListar";
                cmd.CommandTimeout = 180;
                Conectar();
                cmd.Connection = conn;
                dr=cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    lista = new List<Alumno>();

                    while (dr.Read())
                    {
                        alum = new Alumno();
                        alum.IdAlumno = Convert.ToInt32(dr["IdAlumno"]);
                        alum.Nombre = dr["Nombre"].ToString();
                        alum.Apellido = dr["Apellido"].ToString();
                        alum.TipoDocumento = dr["TipoDocumento"].ToString();
                        alum.NroDocumento = dr["Documento"].ToString();
                        alum.Sexo = dr["Sexo"].ToString();
                        alum.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                        alum.Domicilio = dr["Domicilio"].ToString(); ;
                        alum.Carrera = dr["Carrera"].ToString();
                        alum.FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]);
                        lista.Add(alum);
                    }
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
            return lista;
        }

        public Alumno BuscarAlumno(int id)
        {
            Alumno alum = null;

            try
            {
                cmd = new SqlCommand();
                SqlDataReader dr;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SpAlumnoBuscarPorId";
                cmd.Parameters.AddWithValue("@idAlumno", id);
                cmd.CommandTimeout = 180;
                Conectar();
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    alum = new Alumno();
                    alum.IdAlumno = Convert.ToInt32(dr["IdAlumno"]);
                    alum.Nombre = dr["Nombre"].ToString();
                    alum.Apellido = dr["Apellido"].ToString();
                    alum.TipoDocumento = dr["TipoDocumento"].ToString();
                    alum.NroDocumento = dr["Documento"].ToString();
                    alum.Sexo = dr["Sexo"].ToString();
                    alum.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                    alum.Domicilio = dr["Domicilio"].ToString(); ;
                    alum.Carrera = dr["Carrera"].ToString();
                    alum.FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]);
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
            return alum;
        }
    }
}
