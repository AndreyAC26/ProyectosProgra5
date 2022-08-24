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
    public partial class MenuPrincipalV2 : Form
    {
        public MenuPrincipalV2()
        {
            InitializeComponent();
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se instancia la variable
            MenuPrincipal mMenuPrincipal = new MenuPrincipal();
            //Carga la pantalla de menu principal
            mMenuPrincipal.ShowDialog();
            // mMenuPrincipal.Show();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se instancia la variable
            MenuPrincipal mMenuPrincipal = new MenuPrincipal();
            //se usa la variable con el .MdiParent para usar el formulario dentro del contenedor
            mMenuPrincipal.MdiParent = this;
            //Carga la pantalla de menu principal
            mMenuPrincipal.Show();
            // mMenuPrincipal.Show();
        }

        private void formulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SegundoFormulario mFormulario = new SegundoFormulario();
            mFormulario.MdiParent = this;
            mFormulario.Show();
        }

        private void FuncionDePrueba()
        {
            string mNombre = "";


        }


        // El simbolo de igual es : "=="
        // El simbolo de diferente : "!="
        // El simbolo de Y : "&&"
        // El simbolo de OR : "||"

        private int SumarValores(int _Valor1, int _Valor2, byte opcion)
        {
            if ((opcion == 1) && (_Valor1 == 0))
            {
                return _Valor1 + _Valor2;
            }
            else
            {
                return _Valor1 * _Valor2;
            }
        }

        private void MenuPrincipalV2_Load(object sender, EventArgs e)
        {

        }
    }
}
