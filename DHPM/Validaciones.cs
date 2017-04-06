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
    public partial class Validaciones : Form
    {
        Random rnd = new Random(); //random tiene error no usa el ultimo numero indicado, fix mas abajo
        public Validaciones()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (dGV2.Columns.Count >= 1) //verifica que exista culumna en matriz 1 y 2 para poder calcular
            {
                try
                {
                    for (int i = 0; i < dGVres.Columns.Count; i++)
                    {
                        for (int j = 0; j < dGVres.Rows.Count; j++)
                        {
                            dGVres[i, j].Value = double.Parse(tBMult.Text) * double.Parse(dGV2[i, j].Value.ToString()); //suma a la tercera matriz
                        }
                    }
                }
                catch (Exception)
                {
                    dGVres.Columns.Clear();
                    MessageBox.Show("Solo numeros en las matriz 1 y cantidad a multiplicar", "Sabes que son los numeros?", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Mensaje si letras en lo campos
                    int c = int.Parse(tBColumnas.Text); //cantidad de columnas
                    int r = int.Parse(tBRenglones.Text); //cantidad de renglones
                    for (int i = 0; i < c; i++) //agrega la columnas despues de borrar
                    {
                        dGVres.Columns.Add("C" + i, "C" + (i + 1)); //titulos
                    }
                    for (int i = 0; i < r; i++) //agrega las filas despues de borrar
                    {
                        dGVres.Rows.Add(); //agrega lineas
                    }
                }
            }
            else
            {
                MessageBox.Show("Genera datos para poder calcular", "Sin datos?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tSbGenerar_Click(object sender, EventArgs e)
        {
            dGV2.Columns.Clear();
            dGVres.Columns.Clear();
            if (tBMult.Text.Trim() == "" || tBColumnas.Text.Trim() == "" || tBRenglones.Text.Trim() == "" || tBLimInfe.Text.Trim() == "" || tBLimSup.Text.Trim() == "")
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                try
                {
                    double escalar = double.Parse(tBMult.Text);
                    int columnas = int.Parse(tBColumnas.Text);
                    int renglones = int.Parse(tBRenglones.Text);
                    double inferior = double.Parse(tBLimInfe.Text);
                    double superior = double.Parse(tBLimSup.Text);
                    if (columnas < 1 || renglones < 1)
                    {
                        MessageBox.Show("Error: colmnas y valores deben positivos");
                    }
                    else
                    {
                        //posiblemte truena
                        if (inferior <= superior) //verifica limites
                        {
                            for (int i = 0; i < columnas; i++) //agrega la columnas
                            {
                                dGV2.Columns.Add("C" + i, "C" + (i + 1)); //titulos
                                dGVres.Columns.Add("C" + i, "C" + (i + 1)); //titulos
                            }
                            for (int i = 0; i < renglones; i++) //agrega las filas
                            {
                                dGV2.Rows.Add();
                                dGVres.Rows.Add();
                            }
                            for (int i = 0; i < columnas; i++)
                            {
                                for (int j = 0; j < renglones; j++)
                                {
                                    if (cBdecimales.Checked == true) //agrega dos decimales
                                    {
                                        //double numero2 = Math.Round(rnd.Next(Convert.ToInt32(tBLimInfe.Text), Convert.ToInt32(tBLimSup.Text) + 1) + rnd.NextDouble(), 2); //con mas 1 se corrigue el ultimo random
                                        dGV2[i, j].Value = Math.Round(rnd.Next(Convert.ToInt32(inferior), Convert.ToInt32(superior) + Convert.ToInt32(inferior)) + rnd.NextDouble(), 2);
                                        //dGV2[i, j].Value = numero2; //matriz dos
                                    }
                                    else //sin decimales
                                    {
                                        dGV2[i, j].Value = Math.Round(rnd.Next(Convert.ToInt32(inferior), Convert.ToInt32(superior) + Convert.ToInt32(inferior)) + rnd.NextDouble());
                                        //dGV2[i, j].Value = Convert.ToInt32(Math.Round(rnd.NextDouble() * (sup - infe) + infe, 2)); //matriz dos, con mas 1 se corrigue el ultimo random
                                        //MessageBox.Show("Generado."+ dGV2[i, j].Value);
                                    }
                                }
                            }
                            if (cBfatiga.Checked == true) //ahorra la fatiga y calcula por ti
                            {
                                btnCalc_Click(sender, e); //llama a calcular
                            }
                        }
                        else
                        {
                            MessageBox.Show("Verifica tus limites", "Sabes que son los limites?", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Mensaje si limites al revez
                            tBLimInfe.Clear();
                            tBLimSup.Clear();
                            tBLimInfe.Focus();
                        }
                        MessageBox.Show("Todo bien");
                        //posiblemente truen
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Algun tipo de dato esta mal");
                }
            }
        }

        private void tSbLimpiar_Click(object sender, EventArgs e)
        {
            tBColumnas.Text = "3";
            tBRenglones.Text = "3";
            tBLimInfe.Text = "0";
            tBLimSup.Text = "0";
            tBMult.Text = "0";
            cBdecimales.Checked = false; //falsea el check de decimales
            cBfatiga.Checked = false; //falsea el check de fatiga
            tSbGenerar_Click(sender, e); //llama a generar
        }

        private void tSbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBMult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
