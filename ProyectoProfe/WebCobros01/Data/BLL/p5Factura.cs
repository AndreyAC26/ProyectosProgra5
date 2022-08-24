using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCobros01.Data.DAL;
using WebCobros01.Data.DAL.DsCobrosTableAdapters;

namespace WebCobros01.Data.BLL
{
    
    public class p5Factura
    {
        private DsCobros mds = new DsCobros();
        private p5FacturaTableAdapter mFactura = new p5FacturaTableAdapter();


        public DsCobros.p5FacturaDataTable getFacturasXFecha(DateTime vFechaInicial, DateTime vFechaFinal)
        {
            mFactura.FillByFechas(mds.p5Factura, vFechaInicial, vFechaFinal);
            return mds.p5Factura;
        }

    }
}