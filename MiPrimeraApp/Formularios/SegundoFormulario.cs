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
    public partial class SegundoFormulario : Form
    {
        public SegundoFormulario()
        {
            InitializeComponent();
        }

        private void SegundoFormulario_Load(object sender, EventArgs e)
        {

        }

        private void btnCicloFor_Click(object sender, EventArgs e)
        {
            CorrerCiclo(1);
        }

        private void CorrerCiclo(byte _opcion)
        {

            switch (_opcion)
            {
                case 1:
                    CicloFor();
                    break;
                
                case 2:
                    CicloWhile();
                    break;

                case 3:
                    CicloDoWhile();
                    break;

                case 4:
                    CicloForeach();
                    break;
            }

        }

        private void CicloFor()
        {

            // MessageBox.Show("Ciclo For");
            int contador = 0;
            for (int i = 0; i < 500; i++)
            {
                contador = i;

            }
            MessageBox.Show(contador.ToString());
            
        }

        private void CicloWhile()
        {
            int i=0;
            while (i < 500)
            {
                i++;
            }
            MessageBox.Show(i.ToString());
        }

        private void CicloDoWhile()
        {
            int i = 0;
            do
            {
                i++;
            } while (i < 500);
            MessageBox.Show(i.ToString());
        }

        private void CicloForeach()
        {
            List<int> mLista = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                mLista.Add(i);
            }

            foreach (int i in mLista)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void btnCicloWhile_Click(object sender, EventArgs e)
        {
            CorrerCiclo(2);
        }

        private void btnCicloDoWhile_Click(object sender, EventArgs e)
        {
            CorrerCiclo(3);
        }

        private void btnCicloForEach_Click(object sender, EventArgs e)
        {
            CorrerCiclo(4);
        }
    }
}
