using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraApp.Formularios
{
    public partial class MenuPrincipal : Form
    {

        String Nombre;
        String Correo;
        byte Edad;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            InicializarVariables();
        }

        private void InicializarVariables()
        {
            Nombre = "";
            Correo = "";
            Edad = 0;

            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtEdad.Text = "0";
            txtNombre.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancerlar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
            Nombre = txtNombre.Text.Trim();
            Correo = txtCorreo.Text.Trim();
            Edad = byte.Parse(txtEdad.Text.Trim());
            MessageBox.Show("El resultado de la suma es: " + Sumar100(Edad).ToString());
                InicializarVariables();
            }
            catch (Exception ex) {
                //Muestra el mensaje de error
                MessageBox.Show(ex.Message.ToString());
            }
            }


        private int Sumar100(byte Valor)
        {
            return Valor + 100;
        }

        private void btnCargarFormulario_Click(object sender, EventArgs e)
        {
            SegundoFormulario segundoFormulario = new SegundoFormulario();
            segundoFormulario.ShowDialog();
        }
    }
}
