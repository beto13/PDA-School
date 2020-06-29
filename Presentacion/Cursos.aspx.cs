using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class Cursos : System.Web.UI.Page
    {
        CursoAdmin objAdmin = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarCombo();
                Listar();
            }
        }

        private void Listar()
        {
            try
            {
                objAdmin = new CursoAdmin();
                List<VerCurso> lista2 = objAdmin.ListarPorCursoA(Convert.ToInt32(ddlCurso.SelectedValue));
                gvCursosA.DataSource = lista2;
                gvCursosA.DataBind();

                objAdmin = new CursoAdmin();
                List<VerCurso> listaP = objAdmin.ListarPorCursoP(Convert.ToInt32(ddlCurso.SelectedValue));
                gvCursoP.DataSource = listaP;
                gvCursoP.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LlenarCombo()
        {
            try
            {
                objAdmin = new CursoAdmin();
                List<Curso> lista = objAdmin.ListarCurso();
                var PropertyInfos = lista.First().GetType().GetProperties();

                foreach (var prop in PropertyInfos)
                {
                    if (prop.Name == "IdCurso")
                    {
                        ddlCurso.DataValueField = prop.Name;
                    }
                    else if (prop.Name == "NombreCurso")
                    {
                        ddlCurso.DataTextField = prop.Name;
                    }
                }
                ddlCurso.DataSource = lista;
                ddlCurso.DataBind();
            }
            catch (Exception Ex)
            {

                throw new Exception("", Ex);
            }
        }

        protected void ddlCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar();
        }
    }
}