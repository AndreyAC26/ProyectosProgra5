using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EX2OAAC.Data.DAL;
using EX2OAAC.Data.DAL.DsExamenTableAdapters;

namespace EX2OAAC.Data.BLL
{
    public class csArticulos
    {
        private DsExamen mds = new DsExamen();
        private ArticulosTableAdapter mArticulos = new ArticulosTableAdapter();

        public DsExamen.ArticulosDataTable getArticulos()
        {
            mArticulos.Fill(mds.Articulos);
            return mds.Articulos;
        }

        public bool insertarArticulo(String vCodigo, String vDescripcion, String vMarca,
            String vCategoria, decimal vPrecio_Venta)
        {
            try
            {
                mArticulos.InsertarArticulo(vCodigo, vDescripcion, vMarca, vCategoria, vPrecio_Venta);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}