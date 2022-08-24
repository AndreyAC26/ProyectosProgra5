using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCobros.Data.DAL;
using WebCobros.Data.BLL;

namespace WebCobros.Forms
{
    public partial class Empresa : System.Web.UI.Page
    {
        DsCobros.p5empresaDataTable mEmpresas;
        cp5Empresa mEmpresa = new cp5Empresa();

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            mEmpresas = mEmpresa.getEmpresas();
            gridEmpresa.DataSource = mEmpresas;
            gridEmpresa.DataBind();     
            
        }

        protected void gridEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}