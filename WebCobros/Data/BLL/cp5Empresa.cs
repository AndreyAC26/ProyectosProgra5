using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCobros.Data.DAL;
using WebCobros.Data.DAL.DsCobrosTableAdapters;

namespace WebCobros.Data.BLL
{
    public class cp5Empresa
    {
        private DsCobros mds = new DsCobros();
        private p5EmpresaTableAdapter mEmpresa = new p5EmpresaTableAdapter();
            
        public DsCobros.p5EmpresaDataTable getEmpresas()
        {
           mEmpresa.Fill(mds.p5Empresa);
            return mds.p5Empresa;
        }

        public DsCobros.p5EmpresaRow getEmpresaXIdEmpresa(short vIdEmpresa)
        {
            mEmpresa.FillByIdEmpresa(mds.p5Empresa, vIdEmpresa);
            if(mds.p5Empresa.Rows.Count == 1)
            {
                return (DsCobros.p5EmpresaRow)mds.p5Empresa.Rows[0];
            }
            else
            {
                DsCobros.p5EmpresaRow mrow = (DsCobros.p5EmpresaRow) mds.p5Empresa.NewRow();
                return mrow;
            }


        }

        public bool agregarEmpresa(String vEmpresa, String vCorreo, String vTelefono, String vDireccion)
        {
            try
            { 
            mEmpresa.InsertarEmpresa(vEmpresa, vCorreo, vTelefono, vDireccion);
            return true;
            }
            catch(Exception e)
            {
                return false;
            }
            }

        public bool ActualizarEmpresa(String vEmpresa, String vCorreo, String vTelefono, String vDireccion, short vIdEmpresa)
        {
            try
            { 
            mEmpresa.UpdateQuery(vEmpresa, vCorreo, vTelefono, vDireccion, vIdEmpresa);
                return true;
            }
            catch (Exception e)
            { 
                return false;
            }
        }

        public bool BorrarEmpresa(short vIdEmpresa)
        {
            try
            { 
            mEmpresa.DeleteQuery(vIdEmpresa);
                return true;
            }
            catch (Exception e)
            { 
                return false;
            }
        }
    
    }
}