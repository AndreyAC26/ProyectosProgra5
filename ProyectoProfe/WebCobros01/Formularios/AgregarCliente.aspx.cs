using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCobros01.Data.BLL;

namespace WebCobros01
{ 
    //Data.DAL.DsCobros.p5EmpresaDataTable mEmpresas;
    //    Data.BLL.cp5Empresa mEmpresa = new Data.BLL.cp5Empresa();
    public partial class AgregarCliente : Page
    {
        Data.DAL.DsCobros.p5EmpresaDataTable mEmpresas;
        Data.BLL.cp5Empresa mEmpresa = new Data.BLL.cp5Empresa();
        protected void Page_Load(object sender, EventArgs e)
        {

            CargarDatos();
        }

        private void CargarDatos()
        {
            
            mEmpresas = mEmpresa.getEmpresas();
            ddlEmpresas.DataSource = mEmpresas;
            ddlEmpresas.DataBind();
        }

        protected void ddlEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            fnAgregarCLiente();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Clientes");
        }

        private void fnAgregarCLiente()
        {
            try
            { 
            cp5Cliente mCliente = new cp5Cliente();
            short mIdEmpresa = short.Parse(ddlEmpresas.SelectedItem.Value);
            mCliente.agregarCliente(mIdEmpresa, txtNombre.Text.Trim(), txtIdentificacion.Text.Trim(),
                txtCorreo.Text.Trim(), txtTelefono.Text.Trim(), txtDireccion.Text.Trim());
                Response.Redirect("Clientes");
            }
            catch
            {

            }
        }
    }
}