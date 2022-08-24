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
    public partial class EditarCliente : System.Web.UI.Page
    {
        short mIdCliente;
        cp5Cliente mCliente = new cp5Cliente();
        Data.DAL.DsCobros.p5EmpresaDataTable mEmpresas;
        Data.BLL.cp5Empresa mEmpresa = new Data.BLL.cp5Empresa();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {

            }
            else
            {
                CargarDatos();
                try
                {
                    var ms = Session["IdCliente"].ToString();
                    mIdCliente = Int16.Parse(ms.ToString());
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
            DsCobros.p5ClienteRow mClienterow = mCliente.getClientexIdCliente(mIdCliente);
            if(mClienterow != null)
            {
                txtCorreo.Text = mClienterow.Correo.Trim();
                txtDireccion.Text = mClienterow.Direccion.Trim();
                txtIdentificacion.Text = mClienterow.Identificacion.Trim();
                txtNombre.Text = mClienterow.Nombre.Trim();
                txtTelefono.Text = mClienterow.Telefono.Trim();
                ddlEmpresas.SelectedValue = mClienterow.IdEmpresa.ToString();
            }
        }

        private void fnGuardarCLiente()
        {
            try
            {
                var ms = Session["IdCliente"].ToString();
                mIdCliente = short.Parse(ms.ToString());

                short mIdEmpresa = short.Parse(ddlEmpresas.SelectedItem.Value);
                mCliente.ActualizarCliente(mIdCliente, txtNombre.Text.Trim(), txtIdentificacion.Text.Trim(),
                txtCorreo.Text.Trim(), txtTelefono.Text.Trim(), txtDireccion.Text.Trim());
                Response.Redirect("Clientes");
            }
            catch
            {

            }
        }

    }
}