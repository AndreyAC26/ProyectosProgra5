using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCobros.Data.DAL;
using WebCobros.Data.DAL.DsCobrosTableAdapters;

namespace WebCobros.Data.BLL
{
    public class cp5Cliente
    {
        private DsCobros mds = new DsCobros();
        private p5ClienteTableAdapter mCliente = new p5ClienteTableAdapter();

        public DsCobros.p5ClienteDataTable getClientes()
        {
            mCliente.Fill(mds.p5Cliente);
            return mds.p5Cliente;
        }


        public DsCobros.p5ClienteRow getClientexIdCliente(short vIdCliente)
        {
            mCliente.FillByIdCliente(mds.p5Cliente, vIdCliente);
            if (mds.p5Cliente.Rows.Count == 1)
            {
                return (DsCobros.p5ClienteRow)mds.p5Cliente.Rows[0];
            }
            else
            {
                DsCobros.p5ClienteRow mrow = (DsCobros.p5ClienteRow)mds.p5Cliente.NewRow();
                return mrow;
            }
        }


        public bool agregarCliente(short vIdEmpresa,String vNombre, String vIdentificacion, String vCorreo, String vTelefono, String vDireccion)
        {
            try
            { 
            mCliente.InsertarCliente(vIdEmpresa, vNombre, vIdentificacion, vCorreo, vTelefono, vDireccion);
            return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
         

        public bool ActualizarCliente(short vIdEmpresa, String vNombre, String vIdentificacion, String vCorreo, String vTelefono, String vDireccion, short vIdCliente)
        {
            try { 
            mCliente.ActualizarCliente(vIdEmpresa, vNombre, vIdentificacion, vCorreo, vTelefono, vDireccion, vIdCliente);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool BorrarCliente(short vIdCliente)
        {
            try
            { 
            mCliente.BorrarCliente(vIdCliente);
                return true;
            }
            catch (Exception e)
            { 
                return false; 
            }
        }
    }
}