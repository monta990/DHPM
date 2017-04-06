using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DHPM
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btInyectiva_Click(object sender, EventArgs e)
        {
            bTlimp_Click(sender, e);
            tBx.Text = ("1,2,3,4,5");
            tBy.Text = ("1,2,3,4,5");
            rTBfx.Text = ("(1,1)\n(2,2)\n(4,3)\n(5,4)");
        }

        private void btSobreyectiva_Click(object sender, EventArgs e)
        {
            bTlimp_Click(sender, e);
            tBx.Text = ("1,2,3,4,5");
            tBy.Text = ("1,2,3");
            rTBfx.Text = ("(1,1)\n(2,2)\n(3,3)");
        }

        private void bTBiyectiva_Click(object sender, EventArgs e)
        {
            bTlimp_Click(sender,e);
            tBx.Text = ("1,2,3,4,5");
            tBy.Text = ("1,2,3,4,5");
            rTBfx.Text = ("(1,1)\n(2,2)\n(3,3)\n(4,4)\n(5,5)");
        }

        private void bTlimp_Click(object sender, EventArgs e)
        {
            tBx.Clear();
            tBy.Clear();
            rTBfx.Clear();
            lbBiyectiva.Text = ("Esperando datos...");
            lbInyectiva.Text = ("Esperando datos...");
            lbSobreyectiva.Text = ("Esperando datos...");
        }

        private void bTgen_Click(object sender, EventArgs e)
        {
            string[] pares = rTBfx.Text.Split('\n');
            string[] arregloY = tBy.Text.Split(',');
            //Eliminamos parentecis izquierdo
            pares = pares.Select(x => x.Replace("(",string.Empty)).ToArray();
            //Eliminamos parentecis derecho
            pares = pares.Select(x => x.Replace(")",string.Empty)).ToArray();
            //Recorrer el conjunto pares
            lbBiyectiva.Text = "NO";
            lbInyectiva.Text = "SI";
            //Encontrar Inyectiva
            for (int i = 0; i < arregloY.Length; i++)
            {
                int cont = 0;
                //Muestra Y en su i
                for (int j = 0; j < pares.Length; j++)
                {
                    string[] y = pares[j].Split(',');
                    //Verifica arregloY con Y de rTBfx
                    if (arregloY[i]==y[1])
                    {
                        //MessageBox.Show("Si soy AMA: "+y[1]);
                        cont++;
                    }
                }
                if (cont > 1)
                {
                    lbInyectiva.Text = "NO";
                    break;
                }
                //MessageBox.Show("Par Ordenado: "+pares[i] +" en el indice: " +i);
                //MessageBox.Show(""+y[1]);
                //Fin de encontrar Inyectiva
            }
            lbSobreyectiva.Text = "SI";
            //Encontrar Sobreyectiva
            for (int i = 0; i < arregloY.Length; i++)
            {
                bool cont = false;
                //Muestra Y en su i
                for (int j = 0; j < pares.Length; j++)
                {
                    string[] y = pares[j].Split(',');
                    //Verifica arregloY con Y de rTBfx
                    if (arregloY[i] == y[1])
                    {
                        //MessageBox.Show("Si soy AMA: "+y[1]);
                        cont=true;
                        break;
                    }
                }
                if (!cont)
                {
                    lbSobreyectiva.Text = "NO";
                    break;
                }
                //MessageBox.Show("Par Ordenado: "+pares[i] +" en el indice: " +i);
                //MessageBox.Show(""+y[1]);
                //Fin de encontrar Inyectiva
                //Verificar biyectiva
                if (lbSobreyectiva.Text=="SI" && lbInyectiva.Text=="SI")
                {
                    lbBiyectiva.Text = "SI";
                }
                //Fin de biyectiva
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
