using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCobros.Data.BLL;
using WebCobros.Data.DAL;
using WebCobros;

namespace WebCobros.Forms
{
    public partial class AgregarCliente : System.Web.UI.Page
    {
        Data.DAL.DsCobros.p5EmpresaDataTable mEmpresas;
        Data.BLL.cp5Empresa mEmpresa = new Data.BLL.cp5Empresa();

        protected void Page_Load(object sender, EventArgs e)
        {
            //CargarDatosEmpresa();
        }

        private void CargarDatosEmpresa()
        {
            mEmpresas = mEmpresa.getEmpresas();
            ddlEmpresas.DataSource = mEmpresas;
            ddlEmpresas.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            fnAgregarCliente();
        }

        protected void btnCancelar_click(object sender, EventArgs e)
            {
                Response.Redirect("Clientes");
            }

        private void fnAgregarCliente()
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