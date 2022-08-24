using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCobros.Data.BLL;
using WebCobros.Data.DAL;

namespace WebCobros.Forms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WebCobros.Data.DAL.DsCobros.p5ClienteDataTable mtaCliente =
            new WebCobros.Data.DAL.DsCobros.p5ClienteDataTable();

        DsCobros.p5ClienteDataTable mClientes;
        cp5Cliente mCliente = new cp5Cliente();

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            mClientes = mCliente.getClientes();
            gridClientes.DataSource = mClientes;
            gridClientes.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarCliente");
        }

        

        protected void gridClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            Session["IdCliente"] = gridClientes.SelectedRow.Cells[1].Text.ToString();

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        { 
        
            try 
	            {	        
		             Response.Redirect("EditarCliente");
	            }
	        catch 
	            {

	
	            }
           
        }
    }
}