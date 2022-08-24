using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoProgramado;
using ProyectoProgramado.Data.BLL;
using ProyectoProgramado.Data.DAL;
using ProyectoProgramado.Data.DAL.DsProyectoTableAdapters;

namespace ProyectoProgramado.Data.BLL
{

    public class clsp5Empleado
    {
        private DsProyecto mds = new DsProyecto();
        private EmpleadosTableAdapter mEmpleado = new EmpleadosTableAdapter();

        public DsProyecto.EmpleadosDataTable getEmpleados()
        {
            mEmpleado.Fill(mds.Empleados);
            return mds.Empleados;
        }

        public DsProyecto.EmpleadosRow getEmpleadoxIdEmpleado(int vIdEmpleado)
        {
            mEmpleado.FillByIdEmpleado(mds.Empleados, vIdEmpleado);
            if (mds.Empleados.Rows.Count == 1)
            {
                return (DsProyecto.EmpleadosRow)mds.Empleados.Rows[0];
            }
            else
            {
                DsProyecto.EmpleadosRow mrow = (DsProyecto.EmpleadosRow)mds.Empleados.NewRow();
                return mrow;
            }
        }
        public DsProyecto.EmpleadosRow getEmpleadoxIdentificacion(String vNumero_Identificacion)
        {
            mEmpleado.FillByIdEmpleado(mds.Empleados, vNumero_Identificacion);
            if (mds.Empleados.Rows.Count == 1)
            {
                return (DsProyecto.EmpleadosRow)mds.Empleados.Rows[1];
            }
            else
            {
                DsProyecto.EmpleadosRow mrow = (DsProyecto.EmpleadosRow)mds.Empleados.NewRow();
                return mrow;
            }
        }

        public bool agregarEmpelado(String Numero_Identificacion, String Apellidos, String Nombre,
            String Fecha_Nacimiento, String Departamento, String Estado_Civil, String Tipo,
            String Jefe_Directo, String Estado, String Correo)
        {
            try
            {
                mEmpleado.InsertarEmpleado(Numero_Identificacion, Apellidos, Nombre, Fecha_Nacimiento,
                    Departamento, Estado_Civil, Tipo, Jefe_Directo, Estado, Correo);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}