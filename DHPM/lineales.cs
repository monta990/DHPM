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
    public partial class lineales : Form
    {
        public lineales()
        {
            InitializeComponent();
        }

        private void bTresolver_Click(object sender, EventArgs e)
        {
            tBb2.Invalidate();
            label10.Text = txtBb1.Text;
            label11.Text = txtBb2.Text;
        }

        private void bTsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBres_Paint(object sender, PaintEventArgs e)
        {                                           // X    Y    X   Y
            e.Graphics.DrawLine(new Pen(Color.Black), 500, 500, 500, 0); //1
            e.Graphics.DrawLine(new Pen(Color.Black), 0, 250, 1000, 250); //2
                                                                          //Crear encuadre
            e.Graphics.DrawLine(new Pen(Color.Black), 0, 0, 0, tBb2.Height); //linea izquierda
            e.Graphics.DrawLine(new Pen(Color.Black), tBb2.Width - 1, 0, tBb2.Width - 1, tBb2.Height); //linea derecha
            e.Graphics.DrawLine(new Pen(Color.Black), 0, 0, tBb2.Width, 0); //linea arriba
            e.Graphics.DrawLine(new Pen(Color.Black), 0, tBb2.Height - 1, tBb2.Width, tBb2.Height - 1); //linea abajo
            //fin crear encuadre                                           
            for (int i = 0; i < tBb2.Width; i+=10)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), tBb2.Width / 2 + i, tBb2.Height / 2 + 5, tBb2.Width / 2 + i, tBb2.Height / 2 - 5); //centro derecha
                e.Graphics.DrawLine(new Pen(Color.Black), tBb2.Width / 2 - i, tBb2.Height / 2 + 5, tBb2.Width / 2 - i, tBb2.Height / 2 - 5); //centro izquierda
                e.Graphics.DrawLine(new Pen(Color.Black), tBb2.Width / 2 - 5, tBb2.Height / 2 - i, tBb2.Width / 2 + 5, tBb2.Height / 2 - i); //centro arriba
                e.Graphics.DrawLine(new Pen(Color.Black), tBb2.Width / 2 - 5, tBb2.Height / 2 + i, tBb2.Width / 2 + 5, tBb2.Height / 2 + i); //centro abajo
            }
            if (txtBm1.Text.Trim()=="") //m1
            {
                txtBm1.Text = "1";
            }
            if (txtBb1.Text.Trim() == "") //b1
            {
                txtBb1.Text = "0";
            }
            if (txtBm2.Text.Trim() == "") //b2
            {
                txtBm2.Text = "2";
            }
            if (txtBb2.Text.Trim() == "") //m2
            {
                txtBb2.Text = "0";
            }
            e.Graphics.TranslateTransform(tBb2.Width / 2, tBb2.Height / 2);
            e.Graphics.ScaleTransform(1,-1);
            float y=0.0f;
            for (int x =- tBb2.Width; x < tBb2.Width; x++)
            {//                  M           X               B
                y = float.Parse(txtBm1.Text) * x + float.Parse(txtBb1.Text);
                e.Graphics.DrawEllipse(new Pen(Color.Red), x, y,1,1);
                y = float.Parse(txtBm2.Text) * x + float.Parse(txtBb2.Text);
                e.Graphics.DrawEllipse(new Pen(Color.Blue), x, y, 1, 1);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}