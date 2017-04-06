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
    public partial class conjuntos : Form
    {
        public conjuntos()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void conjuntos_Load(object sender, EventArgs e)
        {

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bLim_Click(object sender, EventArgs e)
        {
            this.tBA.Clear();
            this.tBB.Clear();
            this.tBac.Clear();
            this.tBalb.Clear();
            this.tBanb.Clear();
            this.tBaub.Clear();
            this.tBaxb.Clear();
            this.tBbc.Clear();
            this.tBbla.Clear();
            this.tBbxa.Clear();
        }

        private void bGen_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tBA.Text+" "+tBB.Text); //Une tBA + tBB
            //tBaub.Text = tBA.Text +" , "+ tBB.Text;
            //tBaxb.Text = "("+tBA.Text + " , " + tBB.Text+")";
            //tBbxc.Text = "("+tBB.Text + " , " + tBA.Text+")";
            string[] conjuntoA = tBA.Text.Split(',');
            string[] conjuntoB = tBB.Text.Split(',');
            // Inicia el algoritmo para la union
            tBaub.Text = tBA.Text;
            Boolean control = false;
            for (int i = 0; i < conjuntoB.Length; i++) //Conteo arreglo B
            {
                control = false;
                for (int j = 0; j < conjuntoA.Length; j++) //Conteo arreglo A
                {
                    if (conjuntoB[i]==conjuntoA[j])
                    {
                        control = true;
                        //MessageBox.Show("Este elemento esta en el conjunto A: "+conjuntoB[i]);
                    }
                }
                if (control == false)
                {
                    tBaub.Text +="," +conjuntoB[i]+ ",";
                }
                //MessageBox.Show("["+i+"] "+conjuntoB [i]);
                //tBaub.Text = conjuntoA[i];
            }
            //Finaliza el algoritmo para la union
            // Inicia el algoritmo para la intersección
            tBanb.Clear();
            for (int i = 0; i < conjuntoA.Length; i++) //Conteo arreglo A
            {
                control = false;
                for (int j = 0; j < conjuntoB.Length; j++) //Conteo arreglo B
                {
                    if (conjuntoA[i] == conjuntoB[j])
                    {
                        control = true;
                        //MessageBox.Show("Este elemento esta en el conjunto A: "+conjuntoB[i]);
                    }
                }
                if (control == true)
                {
                    tBanb.Text += conjuntoA[i]+",";
                }
                //MessageBox.Show("["+i+"] "+conjuntoB [i]);
                //tBaub.Text = conjuntoA[i];
            }
            //Finaliza el algoritmo para la intersección
            //Algoritmo B-A
            tBbla.Clear();
            for (int i = 0; i < conjuntoB.Length; i++) //Conteo arreglo B
            {
                control = false;
                for (int j = 0; j < conjuntoA.Length; j++) //Conteo arreglo A
                {
                    if (conjuntoB[i] == conjuntoA[j])
                    {
                        control = true;
                        //MessageBox.Show("Este elemento esta en el conjunto A: "+conjuntoB[i]);
                    }
                }
                if (control == false)
                {
                    tBbla.Text += conjuntoB[i] +",";
                }
                //MessageBox.Show("["+i+"] "+conjuntoB [i]);
                //tBaub.Text = conjuntoA[i];
            }
            //Fin Algoritmo B-A
            //Algoritmo A-B
            tBalb.Clear();
            for (int i = 0; i < conjuntoA.Length; i++) //Conteo arreglo A
            {
                control = false;
                for (int j = 0; j < conjuntoB.Length; j++) //Conteo arreglo B
                {
                    if (conjuntoA[i] == conjuntoB[j])
                    {
                        control = true;
                        //MessageBox.Show("Este elemento esta en el conjunto A: "+conjuntoB[i]);
                    }
                }
                if (control == false)
                {
                    tBalb.Text += conjuntoA[i] + ",";
                }
                //MessageBox.Show("["+i+"] "+conjuntoB [i]);
                //tBaub.Text = conjuntoA[i];
            }
            //Fin Algoritmo A-B
            //Inicio AxB
            tBaxb.Clear();
            for (int i = 0; i < conjuntoA.Length; i++)
            {
                for (int j = 0; j < conjuntoB.Length; j++)
                {
                    tBaxb.Text += "(" + conjuntoA[i] + "," + conjuntoB[j] + "),";
                    //MessageBox.Show("(" + conjuntoA[i] + "," + conjuntoB[j] + ")");
                }
            }
            //Fin AxB
            //Inicio BxA
            tBbxa.Clear();
            for (int i = 0; i < conjuntoB.Length; i++)
            {
                for (int j = 0; j < conjuntoA.Length; j++)
                {
                    tBbxa.Text += "(" + conjuntoB[i] + "," + conjuntoA[j] + "),";
                    //MessageBox.Show("(" + conjuntoB[i] + "," + conjuntoA[j] + ")");
                }
            }
            //Fin BxA
            // Inicia el algoritmo para la union
            // Inicio Ac
            //tBaub.Text = tBA.Text;
            tBac.Clear();
            for (int i = 0; i < conjuntoB.Length; i++) //Conteo arreglo B
            {
                control = false;
                for (int j = 0; j < conjuntoA.Length; j++) //Conteo arreglo A
                {
                    if (conjuntoB[i] == conjuntoA[j])
                    {
                        control = true;
                        //MessageBox.Show("Este elemento esta en el conjunto A: "+conjuntoB[i]);
                    }
                }
                if (control == false)
                {
                    tBac.Text += conjuntoB[i]+ ",";
                }
                //MessageBox.Show("["+i+"] "+conjuntoB [i]);
                //tBaub.Text = conjuntoA[i];
            }
            //Finaliza Ac
            //Inicio Bc
            tBaub.Text = tBA.Text;
            tBbc.Clear();
            for (int i = 0; i < conjuntoA.Length; i++) //Conteo arreglo B
            {
                control = false;
                for (int j = 0; j < conjuntoB.Length; j++) //Conteo arreglo A
                {
                    if (conjuntoA[i] == conjuntoB[j])
                    {
                        control = true;
                        //MessageBox.Show("Este elemento esta en el conjunto A: "+conjuntoB[i]);
                    }
                }
                if (control == false)
                {
                    tBbc.Text += conjuntoA[i] + ",";
                }
                //MessageBox.Show("["+i+"] "+conjuntoA [i]);
                //tBaub.Text = conjuntoB[i];
            }
            //Finaliza Bc
            //Remover ultima coma
            //tBaub.Text = tBaub.Text.Remove(tBaub.TextLength - 1);
            //tBanb.Text = tBanb.Text.Remove(tBanb.TextLength - 1);
            //tBalb.Text = tBalb.Text.Remove(tBalb.TextLength - 1);
            //tBbla.Text = tBbla.Text.Remove(tBbla.TextLength - 1);
            //tBac.Text = tBac.Text.Remove(tBac.TextLength - 1);
            //tBbc.Text = tBbc.Text.Remove(tBbc.TextLength - 1);
            //tBaxb.Text = tBaxb.Text.Remove(tBaxb.TextLength - 1);
            //tBbxa.Text = tBbxa.Text.Remove(tBbxa.TextLength - 1);
            //Fin de remover ultima coma
        }

        private void bPred_Click(object sender, EventArgs e)
        {
            tBA.Text = "1,2,3";
            tBB.Text = "3,4,5";
        }
    }
}