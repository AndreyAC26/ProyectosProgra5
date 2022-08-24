using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCobros01.Data.BLL;
using WebCobros01.Data.DAL;

namespace WebCobros01.Formularios
{
    public partial class EditarCliente : System.Web.UI.Page
    {
        short mIdCliente;
        cp5Cliente mCliente = new cp5Cliente();
        Data.DAL.DsCobros.p5EmpresaDataTable mEmpresas;
        Data.BLL.cp5Empresa mEmpresa = new Data.BLL.cp5Empresa();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            { 
            
            
            }
            else
            {
                CargarDatos();
                try
                {
                    var ms = Session["IdCliente"].ToString();
                    mIdCliente = short.Parse(ms.ToString());
                    CargarCliente();
                }
                catch
                {

                }
            }
        }
        private void CargarDatos()
        {

            mEmpresas = mEmpresa.getEmpresas();
            ddlEmpresas.DataSource = mEmpresas;
            ddlEmpresas.DataBind();
        }

        private void CargarCliente()
        {
            DsCobros.p5ClienteRow mclienterow = mCliente.getClienteXId(mIdCliente);
            if (mclienterow != null)
            {
                txtCorreo.Text = mclienterow.Correo.Trim();
                txtDireccion.Text = mclienterow.Direccion.Trim();
                txtIdentificacion.Text = mclienterow.Identificacion.Trim();
                txtNombre.Text = mclienterow.Nombre.Trim();
                txtTelefono.Text = mclienterow.Telefono.Trim();
                ddlEmpresas.SelectedValue = mclienterow.IdEmpresa.ToString();
            }
        }

        private void fnGuardarCLiente()
        {
            try
            {
                var ms = Session["IdCliente"].ToString();
                mIdCliente = short.Parse(ms.ToString());
                short mIdEmpresa = short.Parse(ddlEmpresas.SelectedItem.Value);
                mCliente.actualizarCliente(mIdCliente, txtNombre.Text.Trim(), txtIdentificacion.Text.Trim(),
                    txtCorreo.Text.Trim(), txtTelefono.Text.Trim(), txtDireccion.Text.Trim());
                 Response.Redirect("Clientes");
            }
            catch
            {

            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Clientes");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            fnGuardarCLiente();
        }
    }
}