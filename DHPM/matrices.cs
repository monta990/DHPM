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
    public partial class matrices : Form //esto tiene mas lineas de verificación que codigo de calculo
    {
        Random rnd = new Random(); //random tiene error no usa el ultimo numero indicado, fix mas abajo
        public matrices()
        {
            InitializeComponent();
        }
        private void tSbSalir_Click(object sender, EventArgs e) //boton salir
        {
            this.Close();
        }
        private void tSbGenerar_Click(object sender, EventArgs e) //boton generar
        {
            dGV1.Columns.Clear();
            dGV2.Columns.Clear();
            dGVres.Columns.Clear();
            if (tBLimInfe.Text == "" || tBLimSup.Text == "" || tBColumnas.Text== "" || tBRenglones.Text == "") //veifica que limites no esten en blanco y sean solo numeros
            {
                MessageBox.Show("Limite Inferior y/o Superior, columnas y/o renglones estan en blanco", "Sabes leer y escribir?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try //verifica que no existan letras en limites, columnas y renglones
                {
                
                    if (int.Parse(tBColumnas.Text) > 0 && int.Parse(tBRenglones.Text) > 0) //Verifica si columnas o rengloes son negativos
                    {
                        int c = int.Parse(tBColumnas.Text); //cantidad de columnas
                        int r = int.Parse(tBRenglones.Text); //cantidad de renglones
                        if (Convert.ToInt32(tBLimInfe.Text) <= Convert.ToInt32(tBLimSup.Text)) //verifica limites
                        {
                            for (int i = 0; i < c; i++) //agrega la columnas
                            {
                                dGV1.Columns.Add("C" + i, "C" + (i + 1)); //titulos
                                dGV2.Columns.Add("C" + i, "C" + (i + 1)); //titulos
                                dGVres.Columns.Add("C" + i, "C" + (i + 1)); //titulos
                            }
                            for (int i = 0; i < r; i++) //agrega las filas
                            {
                                dGV1.Rows.Add();
                                dGV2.Rows.Add();
                                dGVres.Rows.Add();
                            }
                            for (int i = 0; i < c; i++)
                            {
                                for (int j = 0; j < r; j++)
                                {
                                    if (cBdecimales.Checked == true) //agrega dos decimales
                                    {
                                        double numero1 = Math.Round(rnd.Next(Convert.ToInt32(tBLimInfe.Text), //matriz uno
                                        Convert.ToInt32(tBLimSup.Text) + 1) + rnd.NextDouble(), 2); //con mas 1 se corrigue el ultimo random
                                        double numero2 = Math.Round(rnd.Next(Convert.ToInt32(tBLimInfe.Text), //matriz dos
                                        Convert.ToInt32(tBLimSup.Text) + 1) + rnd.NextDouble(), 2); //con mas 1 se corrigue el ultimo random
                                        dGV1[i, j].Value = numero1; //matriz uno
                                        dGV2[i, j].Value = numero2; //matriz dos
                                    }
                                    else //sin decimales
                                    {
                                        dGV1[i, j].Value = rnd.Next(int.Parse(tBLimInfe.Text), int.Parse(tBLimSup.Text) + 1); //matriz uno, con mas 1 se corrigue el ultimo random
                                        dGV2[i, j].Value = rnd.Next(int.Parse(tBLimInfe.Text), int.Parse(tBLimSup.Text) + 1); //matriz dos, con mas 1 se corrigue el ultimo random
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
                    }
                    else
                    {
                        MessageBox.Show("Solo numeros positivos en columnas y renglones", "No seas negativo", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mensaje si columnas o rengloes son negativos
                        tBColumnas.Clear();
                        tBRenglones.Clear();
                        tBColumnas.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Solo numeros en los limites, en columnas y renglones", "Sabes que son los numeros?", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Mensaje si letras en lo campos
                    tBLimInfe.Clear();
                    tBLimSup.Clear();
                    tBLimInfe.Focus();
                }
            }
        }
        private void btnCalc_Click(object sender, EventArgs e) //suma las dos matrices en la tercera
        {
            if (dGV1.Columns.Count >= 1 && dGV2.Columns.Count >= 1) //verifica que exista culumna en matriz 1 y 2 para poder calcular
            {
                try
                {
                    for (int i = 0; i < dGVres.Columns.Count; i++)
                    {
                        for (int j = 0; j < dGVres.Rows.Count; j++)
                        {
                            dGVres[i, j].Value = double.Parse(dGV1[i, j].Value.ToString()) + double.Parse(dGV2[i, j].Value.ToString()); //suma a la tercera matriz
                        }
                    }
                }
                catch (Exception)
                {
                    dGVres.Columns.Clear();
                    MessageBox.Show("Solo numeros en las matrices 1 y 2", "Sabes que son los numeros?", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Mensaje si letras en lo campos
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
        private void tSbLimpiar_Click(object sender, EventArgs e) //limpia todo y deja 0 en matriz de 3x3
        {
            tBColumnas.Text = "3";
            tBRenglones.Text = "3";
            tBLimInfe.Text = "0";
            tBLimSup.Text = "0";
            cBdecimales.Checked = false; //falsea el check de decimales
            cBfatiga.Checked = false; //falsea el check de fatiga
            tSbGenerar_Click(sender, e); //llama a generar
        }

        private void dGV2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}