using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCobros.Data.DAL;
using WebCobros.Data.DAL.DsCobrosTableAdapters;

namespace WebCobros.Data.BLL
{
    public class cp5Factura
    {
        private DsCobros mds = new DsCobros();
        private p5FacturaTableAdapter mFactura = new p5FacturaTableAdapter();

        public DsCobros.p5FacturaDataTable GetP5Facturas()
        {
            mFactura.Fill(mds.p5Factura);
            return mds.p5Factura;
        }

        public DsCobros.p5FacturaRow GetP5Factura(short vNumeroFactura)
        {
            mFactura.FillByNumeroFactura(mds.p5Factura, vNumeroFactura);
            if (mds.p5Factura.Rows.Count == 1)
            {
                return (DsCobros.p5FacturaRow)mds.p5Factura.Rows[0];
            }
            else
            {
                DsCobros.p5FacturaRow mrow = (DsCobros.p5FacturaRow)mds.p5Factura.NewRow();
                return mrow;
            }
        }

      

        public void ActualizarFactura(String Estado, Decimal Saldo, Decimal MontoInicial, DateTime FechaVence, DateTime FechaFactura, int NumeroFactura,short IdCliente, short IdEmpresa)
        {
            mFactura.ActualizarFactura(Estado, Saldo, MontoInicial, FechaVence, FechaFactura, NumeroFactura, IdCliente, IdEmpresa);
        }

        public void BorrarFactura(short vIdFactura)
        {
            mFactura.BorrarFactura(vIdFactura);
        }
    }
}