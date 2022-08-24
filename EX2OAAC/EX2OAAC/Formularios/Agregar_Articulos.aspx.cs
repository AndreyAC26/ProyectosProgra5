using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EX2OAAC.Data.BLL;

namespace EX2OAAC.Formularios
{
    public partial class Agregar_Articulos : System.Web.UI.Page
    {
 
        Data.DAL.DsExamen.ArticulosDataTable mArticulos;
        Data.BLL.csArticulos mArticulo = new Data.BLL.csArticulos();

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            fnAgregarArticulo();
            borrarControles();

        }

        private void fnAgregarArticulo()
        {
            try
            {
                csArticulos mArticulo = new csArticulos();
                decimal mPrecioVenta = decimal.Parse(txtPrecioVenta.Text.Trim());
                mArticulo.insertarArticulo(txtCodigo.Text.Trim(), txtDescripcion.Text.Trim(),
                    txtMarca.Text.Trim(), txtCategoria.Text.Trim(), mPrecioVenta);

            }
            catch
            {

            }
        }

        private void borrarControles()
        {

            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtCategoria.Text = "";
            txtPrecioVenta.Text = "";
        } 

        }
    }