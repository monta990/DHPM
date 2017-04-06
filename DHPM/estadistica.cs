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
    public partial class estadistica : Form
    {
        public estadistica()
        {
            InitializeComponent();
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            dGVElementos.Rows.Clear();
            dGvAscendentes.Rows.Clear();
            dGvDecendentes.Rows.Clear();
            dGvModa.Rows.Clear();
            dGvAscendentes.Columns[0].Visible = true;
            dGvDecendentes.Columns[0].Visible = true;

            Random rnd = new Random();
            int renglones = Convert.ToInt32(tBElementos.Text);

            if (Convert.ToInt32(tBInferior.Text)< Convert.ToInt32(tBSuperior.Text))
            {
               // btLimpiar_Click(sender, e);
                for (int i = 0; i < renglones; i++)
                {
                    if (chbDecimales.Checked==true) //se verifican si esta marcada al opción de decimales
                    {
                        double numero = Math.Round(rnd.Next(Convert.ToInt32(tBInferior.Text),
                        Convert.ToInt32(tBSuperior.Text)) + rnd.NextDouble(),2);
                        dGVElementos.Rows.Add(numero);
                        dGvAscendentes.Rows.Add(numero);
                        dGvDecendentes.Rows.Add(numero);
                    }
                    else
                    {
                        double n = rnd.Next(Convert.ToInt32(tBInferior.Text),
                        Convert.ToInt32(tBSuperior.Text));

                        dGVElementos.Rows.Add(n);
                        dGvAscendentes.Rows.Add(n);
                        dGvDecendentes.Rows.Add(n);
                    }
                    dGVElementos.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
            else
            {
                MessageBox.Show("Verifica tus limites", "Sabes que son los limites?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tBInferior.Clear();
                tBSuperior.Clear();
                tBInferior.Focus(); 

            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (dGVElementos.Rows.Count >= 1 && dGVElementos.Columns.Count >=1) //Valida que existan datos en elementos para poder calcular
            {
                dGvAscendentes.Sort(dGvAscendentes.Columns[0], ListSortDirection.Ascending);
                dGvDecendentes.Sort(dGvDecendentes.Columns[0], ListSortDirection.Descending);
                dGvAscendentes.Columns[0].Visible = true;
                dGvDecendentes.Columns[0].Visible = true;
                dGvModa.Rows.Clear();
                double sumatoria = 0;
                for (int i = 0; i < dGVElementos.Rows.Count; i++)
                {
                    //MessageBox.Show(dGVElementos[0,i].Value.ToString());
                    sumatoria += double.Parse(dGVElementos[0, i].Value.ToString());
                }
                lbResSum.Text = sumatoria.ToString(); //suma de los valores
                lbResMedia.Text = (sumatoria / dGVElementos.Rows.Count).ToString(); //obtener media
                                                                                    //inicio de mediana
                int index = dGvAscendentes.RowCount / 2; //cantidad entre 2 de elementos acendentes
                double mediana1; //temporal para mediana
                if (Convert.ToInt32(dGVElementos.RowCount) % 2 == 0) //calcular par o impar para mediana
                {
                    mediana1 = Convert.ToDouble(dGvAscendentes[0, index - 1].Value.ToString()) + Convert.ToDouble(dGvAscendentes[0, index].Value.ToString());
                    lbResMediana.Text = Convert.ToString(mediana1 / 2);
                }
                else
                {
                    mediana1 = Convert.ToInt32(dGvAscendentes[0, index].Value.ToString());
                    lbResMediana.Text = Convert.ToString(mediana1);
                }
                //fin de mediana
                //inicio calcular moda
                bool control = false;
                for (int i = 0; i < dGVElementos.Rows.Count; i++)
                {
                    control = false;
                    for (int j = 0; j < dGvModa.Rows.Count; j++)
                    {
                        if (dGVElementos[0, i].Value.ToString() == dGvModa[0, j].Value.ToString())
                        {
                            control = true;
                            dGvModa[1, j].Value = int.Parse(dGvModa[1, j].Value.ToString()) + 1;
                            dGvModa[2, j].Value = double.Parse(dGvModa[0, j].Value.ToString()) * int.Parse(dGvModa[1, j].Value.ToString());
                        }
                    }
                    if (!control)
                    {
                        dGvModa.Rows.Add(dGVElementos[0, i].Value, 1, dGVElementos[0, i].Value); //producto de modas
                    }
                }
                //fin calcular moda
                dGvModa.Sort(dGvModa.Columns[1], ListSortDirection.Descending); //ordena moda
                                                                                //calcular desviación estandar
                double temporal = 0;
                for (int i = 0; i < dGVElementos.Rows.Count; i++)
                {
                    temporal += Math.Pow(double.Parse(dGVElementos[0, i].Value.ToString()) - double.Parse(lbResMedia.Text), 2);
                    //MessageBox.Show(temporal.ToString()); //prueba de variable temporal
                }
                temporal = temporal / dGVElementos.Rows.Count; //dividir entre sus elementos
                                                               //inicio variancia
                lbResVar.Text = Math.Round(temporal, 2).ToString(); //imprimir variancia en el label
                                                                    //fin de variancia
                temporal = Math.Round(Math.Sqrt(temporal), 2); //sacar raiz a dos decimales
                lbResDes.Text = temporal.ToString(); //escribir en label desviación standar
                                                     //fin desviación standard
                if (dGvModa[1, 0].Value.ToString() == dGvModa[1, 1].Value.ToString()) //imprimir moda en label
                {
                    lbResModa.Text = "Varias Modas";
                }
                else
                {
                    lbResModa.Text = Convert.ToString(dGvModa[0, 0].Value.ToString());///fin de imprimir moda en label
                    //lbResModa.Text = dGvModa[1, 1].Value.ToString(); //escribir moda en label
                }
                //inicio de covariancia
                double sumatoria1 = 0;
                double sumatoria2 = 0;
                double sumatoria3 = 0;
                double prom1 = 0;
                double prom2 = 0;
                double prom3 = 0;
                double covar = 0;
                for (int k = 0; k < dGvModa.Rows.Count; k++)
                {
                    sumatoria1 += Double.Parse((dGvModa[0, k].Value.ToString())); //calcular x1
                    sumatoria2 += Double.Parse((dGvModa[1, k].Value.ToString())); //calcular x2
                    sumatoria3 += Double.Parse((dGvModa[2, k].Value.ToString())); //calcular x3
                }
                prom1 = sumatoria1 / dGvModa.Rows.Count; //dividir x1
                prom2 = sumatoria2 / dGvModa.Rows.Count; //dividir x2
                prom3 = sumatoria3 / dGvModa.Rows.Count; //dividir x3
                covar = ((prom3 * prom2) - (prom1)); //obtener covariancia
                lbResCovar.Text = Convert.ToString(Math.Round(covar, 2));
                //fin de covariancia
            }
            else
            {
                MessageBox.Show("Con cuales elementos voy a calcular?", "Con que voy a trabajar?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLimpiar_Click(object sender, EventArgs e) //se limpia todo y se dejan valores default
        {
            dGVElementos.Rows.Clear();
            dGvAscendentes.Rows.Clear();
            dGvDecendentes.Rows.Clear();
            dGvModa.Rows.Clear();
            tBElementos.Clear();
            tBInferior.Clear();
            tBSuperior.Clear();
            lbResCovar.Text = "0.0";
            lbResDes.Text = "0.0";
            lbResMedia.Text = "0.0";
            lbResMediana.Text = "0.0";
            lbResSum.Text = "0.0";
            lbResVar.Text = "0.0";
            lbResModa.Text = "0.0";
            chbDecimales.Checked = false;
            tBElementos.Text = "10";
            tBInferior.Text = "5";
            tBSuperior.Text = "10";
        }

        private void btDefault_Click(object sender, EventArgs e)
        {
            dGVElementos.Rows.Clear();
            dGvAscendentes.Rows.Clear();
            dGvDecendentes.Rows.Clear();
            dGVElementos.Rows.Clear();
            dGvAscendentes.Columns[0].Visible = true;
            dGvDecendentes.Columns[0].Visible = true;

            for (int i = 1; i < 11; i++)
            {
                dGVElementos.Rows.Add((double)i);
                dGvAscendentes.Rows.Add((double)i);
                dGvDecendentes.Rows.Add((double)i);
                dGvAscendentes.Sort(dGvAscendentes.Columns[0], ListSortDirection.Ascending);
                dGvDecendentes.Sort(dGvDecendentes.Columns[0], ListSortDirection.Descending);
                dGVElementos.Rows[i-1].HeaderCell.Value = (i).ToString();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void estadistica_Load(object sender, EventArgs e)
        {

        }
    }
}