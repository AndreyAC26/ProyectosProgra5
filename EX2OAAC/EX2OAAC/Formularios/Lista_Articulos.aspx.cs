using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EX2OAAC.Data.BLL;

namespace EX2OAAC.Formularios
{
    public partial class Lista_Articulos : System.Web.UI.Page
    {
        Data.DAL.DsExamen.ArticulosDataTable mtaArticulo;

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            csArticulos csArticulos = new csArticulos();
            mtaArticulo = csArticulos.getArticulos();
            gridArticulos.DataSource = mtaArticulo;
            gridArticulos.DataBind();
        }


    }
}