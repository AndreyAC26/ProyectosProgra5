using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Siempre importar con los using para poder compartir el dataset
using AppPractica.Data.DAL;
using AppPractica.Data.DAL.DsAdminTableAdapters;

namespace AppPractica.Data.BLL
{
    internal class cUsuario
    {
        // inicializamos el DataSet
        private DsAdmin mds = new DsAdmin();
        private UsuarioTableAdapter mUsuario = new UsuarioTableAdapter();
            
        //Muestra todos los usuarios de la tabla
        public DsAdmin.UsuarioDataTable getUsuarios()
        {
            mUsuario.Fill(mds.Usuario);
            return mds.Usuario;

        }
   
        public DsAdmin.UsuarioRow GetUsuario(int vIdUsuario)
        {
            mUsuario.FillByIdUsuario(mds.Usuario, vIdUsuario);
            if(mds.Usuario.Rows.Count==1)
            {
                return (DsAdmin.UsuarioRow)mds.Usuario.Rows[0];

            }
            else
            {
                DsAdmin.UsuarioRow Urow = (DsAdmin.UsuarioRow) mds.Usuario.NewRow();
                return Urow;
            }

        }

        public void agregarUsuario(String Nombre, String Correo, DateTime FechaNacimiento, String Password, DateTime FechaCreado)
            {
            mUsuario.InsertQuery(Nombre, Correo, FechaNacimiento, Password, FechaCreado
                );
        }

        public void ActualizarUsuario(String Nombre, String Correo, DateTime FechaNacimiento, String Password, DateTime FechaCreado, int IdUsuario)
        {
            mUsuario.UpdateQuery(Nombre, Correo, FechaNacimiento, Password, FechaCreado, IdUsuario);
        }

        public void BorrarUsuario(int IdUsuario)
        {
            mUsuario.DeleteQuery(IdUsuario);
        }

    }
}

