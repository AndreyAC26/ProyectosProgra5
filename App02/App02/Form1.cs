using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App02.Clases;

namespace App02
{
    public partial class Form1 : Form
    {

        List<cPersona> mListaPersonas = new List<cPersona>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbFechaNaci_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            inicializar();
            this.Close();
            
        }

        private void inicializar()
        {
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtFecha.Text = DateTime.Now.ToString();
        }

        private void Guardar()
        {
            cPersona mPersona = new cPersona();
            mPersona.Identificacion = txtIdentificacion.Text;
            mPersona.Nombre = txtNombre.Text;
            mPersona.Apellidos = txtApellidos.Text;
            mPersona.FechaNacimiento = txtFecha.Value;
            mListaPersonas.Add(mPersona);
            inicializar();

        }

        private void GuardarUsuario()
        {
            cUsuario mUsuario = new cUsuario();
            mUsuario.Identificacion = txtIdentificacion.Text;
            mUsuario.Nombre = txtNombre.Text;
            mUsuario.Correo = "";
            mUsuario.Password = "";

            cCliente mCliente = new cCliente();


        }

        
    }
}
