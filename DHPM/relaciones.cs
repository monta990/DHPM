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
    public partial class relaciones : Form
    {
        public relaciones()
        {
            InitializeComponent();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bTejemRefle_Click(object sender, EventArgs e)
        {
            btLimp_Click(sender, e);
            tBa.Text = "1,2,3";
            rTBr.Text = "(1,1)\n(2,2)\n(3,3)";
        }

        private void bTejemSim_Click(object sender, EventArgs e)
        {
            btLimp_Click(sender, e);
            tBa.Text = "1,2,3";
            rTBr.Text = "(1,3)\n(3,1)\n(2,3)\n(3,2)";
        }

        private void bTejemTran_Click(object sender, EventArgs e)
        {
            btLimp_Click(sender, e);
            tBa.Text = "1,2,3";
            rTBr.Text = "(1,2)\n(2,3)\n(1,3)";
        }

        private void bTejemEqui_Click(object sender, EventArgs e)
        {
            btLimp_Click(sender, e); //Llama al boton limpiar para limpieza
            tBa.Text = "1,2,3";
            rTBr.Text = "(1,1)\n(2,2)\n(3,3)\n(1,3)\n(3,1)\n(2,3)\n(3,2)";
        }
        private void btLimp_Click(object sender, EventArgs e)
        {
            tBa.Clear();
            rTBr.Clear();
            lBresRefle.Text = "Esperando datos...";
            lBresSime.Text = "Esperando datos...";
            lBresTran.Text = "Esperando datos...";
            lBresEqui.Text = "Esperando datos...";
        }
        private void tBa_TextChanged(object sender, EventArgs e)
        {

        }
        private void bTgen_Click(object sender, EventArgs e)
        {
            // Algoritmo para determinar una función reflexiva
            String[] elementos = tBa.Text.Split(',') , pares = rTBr.Text.Split('\n');
            lBresRefle.Text = "SI";
            for (int i = 0; i < elementos.Length; i++)
            {
                Boolean Control = false;
                //MessageBox.Show("Elementos en su " + i + " " + pares[i]);
                //MessageBox.Show("("+elementos[i]+","+elementos[i]+")");
                for (int j = 0; j < pares.Length; j++)
                {
                    //MessageBox.Show("(" + elementos[i] + "," + elementos[i] + ") == "+pares[j]);
                    if ("(" + elementos[i] + "," + elementos[i] + ")" == pares[j])
                    {
                        //MessageBox.Show("Si soy ama (" + elementos[i] + "," + elementos[i] + ")");
                        Control = true;
                        break; //Regreso a for de los pares
                    }
                }
                if (Control == false)
                {
                    lBresRefle.Text = "NO";
                    break; //Establece NO en lBresRefle y sale
                }   
            }
            //Fin de Reflexiva
            //Función simetrica
            pares = pares.Select(x => x.Replace("(", string.Empty)).ToArray();
            pares = pares.Select(x => x.Replace(")", string.Empty)).ToArray();
            lBresSime.Text = "SI";
            for (int i = 0; i < pares.Length; i++)
            {
                string[] xy = pares[i].Split(',');
                string yx = xy[1] + "," + xy[0];
                //MessageBox.Show(" "+yx);
                bool Control = false;
                for (int j = 0; j < pares.Length; j++)
                {
                    if (pares[j]==yx)
                    {
                        //MessageBox.Show("Si soy AMA");
                        Control = true;
                        break;
                    }
                }
                if (Control==false)
                {
                    lBresSime.Text="NO";
                    break;
                }
            }
            //Fin de Simetrica
            //Transitiva
            lBresTran.Text = "NO";
            Boolean control1 = false;
            Boolean control2 = false;
            Boolean control3 = false;
            for (int i = 0; i < elementos.Length; i++)
            {
                //MessageBox.Show("Elementos en su " + i + " " + pares[i]);
                //MessageBox.Show("("+elementos[i]+","+elementos[i]+")");
                for (int j = 0; j < pares.Length; j++)
                {
                    //MessageBox.Show("("+elementos[i]+","+elementos[i]+")=="+pares[j]);
                    if (elementos[0] + "," + elementos[1] == pares[j])
                    {
                        control1 = true;
                    }
                    if (elementos[1] + "," + elementos[2] == pares[j])
                    {
                        control2 = true;
                    }
                    if (elementos[0] + "," + elementos[2] == pares[j])
                    {
                        control3 = true;
                    }
                }
                if (control1 == true && control2 == true && control3 == true)
                {
                    lBresTran.Text = "SI";
                }
            }
            //Fin transitiva
            //Equivalente
            if (lBresRefle.Text=="SI")
            {
                lBresEqui.Text="SI";
                lBresSime.Text = "SI";
                lBresTran.Text = "SI";
            }
            else
            {
                lBresEqui.Text = "NO";
            }
            //Fin Equivalente
        }
        private void relaciones_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}