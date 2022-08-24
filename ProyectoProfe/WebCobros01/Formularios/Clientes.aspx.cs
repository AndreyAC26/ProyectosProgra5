using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCobros01.Data.BLL;

namespace WebCobros01
{
    public partial class Clientes : Page
    {

        WebCobros01.Data.DAL.DsCobros.p5ClienteDataTable 
            mtaCliente;
          protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
            
        }

        private void CargarDatos()
        {
            cp5Cliente mClientes = new cp5Cliente();
            mtaCliente= mClientes.getClientes();
            gridClientes.DataSource =mtaCliente;
            gridClientes.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarCliente");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var ms = Session["IdCliente"];
                if (ms != null)
                {
                    Response.Redirect("EditarCliente");
                }
            }
            catch
            {

            }
            
            
        }

        protected void gridClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["IdCliente"] =gridClientes.SelectedRow.Cells[1].Text.ToString();
        }
    }
}