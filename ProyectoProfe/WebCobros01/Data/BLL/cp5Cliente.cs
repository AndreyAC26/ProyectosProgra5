using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCobros01.Data.DAL;
using WebCobros01.Data.DAL.DsCobrosTableAdapters;

namespace WebCobros01.Data.BLL
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


        public DsCobros.p5ClienteDataTable getClientesXIdEmpresa(short vIdEmpresa)
        {
            mCliente.FillByIdEmpresa(mds.p5Cliente,vIdEmpresa);
            return mds.p5Cliente;
        }


        public DsCobros.p5ClienteRow getClienteXId(short vIdCliente)
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

        public bool agregarCliente(short vIdEmpresa,String vNombre,
            String vIdentificacion,String vCorreo,String vTelefono,
            String vDireccion)
        {
            try
            {
                mCliente.InsertarCliente(vIdEmpresa, vNombre, vIdentificacion, vCorreo,
                vTelefono, vDireccion);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool actualizarCliente(short vIdCliente, String vNombre,
            String vIdentificacion, String vCorreo, String vTelefono,
            String vDireccion)
        {
            try
            {
                mCliente.UpdateCliente(vNombre, vIdentificacion, vCorreo, vTelefono,
                    vDireccion, vIdCliente);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool borrarCliente(short vIdCliente)
        {
            try
            {
                mCliente.DeleteCliente(vIdCliente);
                return true;
            }
            catch  (Exception e)
            { return false;}
        }



    }
}