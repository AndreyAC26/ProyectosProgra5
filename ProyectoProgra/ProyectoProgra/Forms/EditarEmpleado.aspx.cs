using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoProgra.Data.BLL;
using ProyectoProgra.Data.DAL;

namespace ProyectoProgra.Forms
{
    public partial class EditarEmpleado : System.Web.UI.Page
    {
        int mIdEmpleado;
        clsP5Empleado mEmpleado = new clsP5Empleado();
        Data.DAL.DsProyecto.EmpleadosDataTable mEmpleados;
        Data.BLL.clsP5Empleado mJefeDirecto = new Data.BLL.clsP5Empleado();

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            mEmpleados = mJefeDirecto.getEmpleados();
            ddlListaJefe.DataSource = mEmpleados;
            ddlListaJefe.DataBind();
        }

        protected void ddlListaJefe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Empleados");
        }

    }
}