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
    public partial class _Default : Page
    {
        private Alumno alum = null;
        public AlumnoAdmin objAdm = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            CompareValidator1.ValueToCompare = DateTime.Now.ToShortDateString();

            if (!IsPostBack)
            {
                if (Request.QueryString["modo"]!=null && Request.QueryString["id"]!=null)
                {
                    string modo = Request.QueryString["modo"];
                    int id = Convert.ToInt32(Request.QueryString["id"]);

                    try
                    {
                        objAdm = new AlumnoAdmin();
                        alum = objAdm.BuscarAlumno(id);
                        txtNombre.Text = alum.Nombre;
                        txtApellido.Text = alum.Apellido;
                        ddlTipoDocumento.SelectedValue= alum.TipoDocumento;
                        txtDocumento.Text = alum.NroDocumento;
                        ddlSexo.SelectedValue = alum.Sexo;
                        txtFechaNacimiento.Text = alum.FechaNacimiento.ToString("yyyy-MM-dd");
                        txtDomicilio.Text = alum.Domicilio;
                        ddlCarrera.SelectedValue = alum.Carrera;
                        txtFechaIngreso.Text = alum.FechaIngreso.ToString("yyyy-MM-dd");
                    }
                    catch (Exception Ex)
                    {
                        throw new Exception("Error al guardar Alumno.", Ex);
                    }
                }
            }
            CargarLista();
        }

        private void CargarLista()
        {
            try
            {
                objAdm = new AlumnoAdmin();
                gvAlumnos.DataSource = objAdm.ListarAlumno();
                gvAlumnos.DataBind();
            }
            catch (Exception Ex)
            {

                throw new Exception("", Ex);
            }
        }

        private void Limpiar()
        {
            foreach (Control ctrl in PanelForm .Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = "";
                }
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            objAdm = new AlumnoAdmin();
            alum = new Alumno();

            alum.Nombre = txtNombre.Text;
            alum.Apellido = txtApellido.Text;
            alum.TipoDocumento = ddlTipoDocumento.SelectedItem.Text;
            alum.NroDocumento = txtDocumento.Text;
            alum.Sexo = ddlSexo.SelectedItem.Text;
            alum.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            alum.Domicilio = txtDomicilio.Text;
            alum.Carrera = ddlCarrera.SelectedItem.Text;
            alum.FechaIngreso = Convert.ToDateTime(txtFechaIngreso.Text);

            if (objAdm.GuardarAlumno(alum)==true)
            {
                Limpiar();
                CargarLista();
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}