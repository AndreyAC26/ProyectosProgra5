using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCobros01.Data.DAL;
using WebCobros01.Data.DAL.DsCobrosTableAdapters;

namespace WebCobros01.Data.BLL
{
    public class cp5Empresa
    {
        private DsCobros mds = new DsCobros();
        private p5EmpresaTableAdapter mEmpresa = new p5EmpresaTableAdapter();

        // DataSet
        // DataTable 
        // DataRow
        //TablaAdapter


        public DsCobros.p5EmpresaDataTable getEmpresas()
        {
            mEmpresa.Fill(mds.p5Empresa);
            return mds.p5Empresa;
        }


        public DsCobros.p5EmpresaRow getEmpresaXIdEmpresa(short vIdEmpresa)
        {
            mEmpresa.FillByIdEmpresa(mds.p5Empresa, vIdEmpresa);
            if(mds.p5Empresa.Rows.Count==1)
            {
                return  (DsCobros.p5EmpresaRow) mds.p5Empresa.Rows[0];
            }
            else
            {
                DsCobros.p5EmpresaRow mrow = (DsCobros.p5EmpresaRow)mds.p5Empresa.NewRow();
                return mrow;
            }
        }


        public void agregarEmpresa(String vEmpresa, String vCorreo,
            String vTelefono,String vDireccion)
        {
            mEmpresa.InsertarEmpresa(vEmpresa,vCorreo,vTelefono,vDireccion);
        }


        public void ActualizarEmpresa(String vEmpresa, String vCorreo,
            String vTelefono,String vDireccion,short vIdEmpresa)
        {
            mEmpresa.UpdateQuery(vEmpresa, vCorreo, vTelefono, vDireccion,vIdEmpresa);
        }

        public void BorrarEmpresa(short vIdEmpresa)
        {
            mEmpresa.DeleteQuery(vIdEmpresa);
        }
   }
}