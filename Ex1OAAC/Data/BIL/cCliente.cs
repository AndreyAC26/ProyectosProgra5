using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex1OAAC.Data.DAL;
using Ex1OAAC.Data.DAL.DsEx1TableAdapters;

namespace Ex1OAAC.Data.BIL
{
    internal class cCliente
    {
        private DsEx1 Eds = new DsEx1();
        private ClienteTableAdapter aCliente = new ClienteTableAdapter();

            public DsEx1.ClienteDataTable GetClientes()
        {
                aCliente.Fill(Eds.Cliente);
                return Eds.Cliente;
        }

        public DsEx1.ClienteRow GetCliente(int dIdCliente)
        {
            aCliente.FillByIdCliente(Eds.Cliente, dIdCliente);
            if(Eds.Cliente.Rows.Count == 1)
            {
                return (DsEx1.ClienteRow)Eds.Cliente.Rows[0];
            }
            else
            {
                DsEx1.ClienteRow cRow = (DsEx1.ClienteRow) Eds.Cliente.NewRow();
                return cRow;
            }
        }

        public void agregarCliente(String dNombre, String dCorreo, DateTime dFechaNacimiento, String dTelefonoCelular, String dTelefonoOficina, decimal dLimiteDeCredito, String dEstado) 
        {
            aCliente.InsertarCliente(dNombre, dCorreo, dFechaNacimiento, dTelefonoCelular, dTelefonoOficina, dLimiteDeCredito, dEstado);
        }

        public void actualizarCliente(String dNombre, String dCorreo, DateTime dFechaNacimiento, String dTelefonoCelular, String dTelefonoOficina, decimal dLimiteDeCredito, String dEstado, int dIdCliente)
        {
            aCliente.ActualizarCliente(dNombre, dCorreo, dFechaNacimiento, dTelefonoCelular, dTelefonoOficina, dLimiteDeCredito, dEstado,dIdCliente);
        }

        public void borrarCliente(int dIdCliente)
        {
            aCliente.BorrarCliente(dIdCliente);
        }


    }
}
