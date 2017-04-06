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
    public partial class lineas : Form
    {
        public lineas()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBhorizontal_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawLine(new Pen(Color.Blue), 0, 0 , 0, pBhorizontal.Height); //linea izquierda
            e.Graphics.DrawLine(new Pen(Color.Blue), pBhorizontal.Width - 1, 0, pBhorizontal.Width - 1, pBhorizontal.Height); //linea derecha
            e.Graphics.DrawLine(new Pen(Color.Blue), 0, pBhorizontal.Height - 1, pBhorizontal.Width, pBhorizontal.Height - 1); //linea abajo
            for (int i = 0; i < pBvertical.Height; i += 10)
            {
                e.Graphics.DrawLine(new Pen(Color.Blue), 0, i, pBhorizontal.Width, i);
            }
        }

        private void pBvertical_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Blue), pBvertical.Width - 1, 0, pBvertical.Width - 1, pBvertical.Height); //linea derecha
            e.Graphics.DrawLine(new Pen(Color.Blue), 0, 0, pBvertical.Width, 0); //linea arriba
            e.Graphics.DrawLine(new Pen(Color.Blue), 0, pBvertical.Height - 1, pBvertical.Width, pBvertical.Height - 1); //linea abajo
            for (int i = 0; i < pBvertical.Width; i+=10)
            {
                e.Graphics.DrawLine(new Pen(Color.Blue), i, 0, i, pBvertical.Height);
            }   
        }

        private void pBcuadricula_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Blue), pBcuadricula.Width-1, 0, pBcuadricula.Width-1, pBcuadricula.Height); //linea derecha
            for (int i = 0; i < pBcuadricula.Width; i += 10)
            {
                e.Graphics.DrawLine(new Pen(Color.Blue), i, 0, i, pBcuadricula.Height);
            }
            e.Graphics.DrawLine(new Pen(Color.Blue), 0,  pBcuadricula.Height-1, pBcuadricula.Width, pBcuadricula.Height-1); //linea abajo
            for (int i = 0; i < pBcuadricula.Height; i += 10)
            {
                e.Graphics.DrawLine(new Pen(Color.Blue), 0, i, pBcuadricula.Width, i);
            }
        }

        private void picBvertical_Paint(object sender, PaintEventArgs e)
        {
            //Crear encuadre
            e.Graphics.DrawLine(new Pen(Color.Blue), 0, 0, 0, picBvertical.Height); //linea izquierda
            e.Graphics.DrawLine(new Pen(Color.Blue), picBvertical.Width - 1, 0, picBvertical.Width - 1, picBvertical.Height); //linea derecha
            e.Graphics.DrawLine(new Pen(Color.Blue), 0, 0, picBvertical.Width, 0); //linea arriba
            e.Graphics.DrawLine(new Pen(Color.Blue), 0, picBvertical.Height - 1, picBvertical.Width, picBvertical.Height - 1); //linea abajo
            //fin crear encuadre
            for (int i = 0; i < picBvertical.Width*2; i+=10)
            {
                e.Graphics.DrawLine(new Pen(Color.Blue), 0, i, i, 0);
            }
        }

        private void pBcruz_Paint(object sender, PaintEventArgs e)
        {
            //Crear encuadre
            e.Graphics.DrawLine(new Pen(Color.Blue), 0, 0, 0, picBvertical.Height); //linea izquierda
            e.Graphics.DrawLine(new Pen(Color.Blue), picBvertical.Width - 1, 0, picBvertical.Width - 1, picBvertical.Height); //linea derecha
            e.Graphics.DrawLine(new Pen(Color.Blue), 0, 0, picBvertical.Width, 0); //linea arriba
            e.Graphics.DrawLine(new Pen(Color.Blue), 0, picBvertical.Height - 1, picBvertical.Width, picBvertical.Height - 1); //linea abajo
            //fin crear encuadre
            for (int i = 0; i < pBcruz.Width * 2; i += 10)
            {
                e.Graphics.DrawLine(new Pen(Color.Blue), 0, i, i, 0);
            }
            for (int i = pBcruz.Width * 2; i > 0; i -=10)
            {
                e.Graphics.DrawLine(new Pen(Color.Blue), pBcruz.Width-i, 0, pBcruz.Width, i);
            }
        }

        private void pBcirculo_Paint(object sender, PaintEventArgs e)
        {
            //Crear encuadre
            e.Graphics.DrawLine(new Pen(Color.Blue), 0, 0, 0, picBvertical.Height); //linea izquierda
            e.Graphics.DrawLine(new Pen(Color.Blue), picBvertical.Width - 1, 0, picBvertical.Width - 1, picBvertical.Height); //linea derecha
            e.Graphics.DrawLine(new Pen(Color.Blue), 0, 0, picBvertical.Width, 0); //linea arriba
            e.Graphics.DrawLine(new Pen(Color.Blue), 0, picBvertical.Height - 1, picBvertical.Width, picBvertical.Height - 1); //linea abajo
            //fin crear encuadre
            for (int i = 0; i < pBcirculo.Width; i += 10) //Izquierda Derecha (1)
            {
                e.Graphics.DrawLine(new Pen(Color.Blue), i, 0, pBcirculo.Width, i);
            }
            for (int j = 0; j < pBcirculo.Width; j += 10) //Derecha Izquieda (2)
            {
                e.Graphics.DrawLine(new Pen(Color.Blue), 0, j, j, pBcirculo.Width);
            }
            for (int k = 0; k < pBcirculo.Width; k += 10) //Abajo Derecha (3)
            {
                e.Graphics.DrawLine(new Pen(Color.Blue), k, pBcirculo.Height, pBcirculo.Width, pBcirculo.Height - k);
            }
            for (int m = 0; m < pBcirculo.Width; m += 10) //Abajo Izquierda (4)
            {
                e.Graphics.DrawLine(new Pen(Color.Blue), 0, pBcirculo.Height - m, m, 0);
            }
        }

        private void pBextra_Paint(object sender, PaintEventArgs e)
        {
            //Crear encuadre
            e.Graphics.DrawLine(new Pen(Color.Blue), 0, 0, 0, pBextra.Height); //linea izquierda
            e.Graphics.DrawLine(new Pen(Color.Blue), pBextra.Width - 1, 0, pBextra.Width - 1, pBextra.Height); //linea derecha
            e.Graphics.DrawLine(new Pen(Color.Blue), 0, 0, pBextra.Width, 0); //linea arriba
            e.Graphics.DrawLine(new Pen(Color.Blue), 0, pBextra.Height - 1, pBextra.Width, pBextra.Height - 1); //linea abajo
            //fin crear encuadre
            e.Graphics.DrawLine(new Pen(Color.Black), 65, 65, 195, 65); //1
            e.Graphics.DrawLine(new Pen(Color.Green), 195, 65, 195, 195); //2
            e.Graphics.DrawLine(new Pen(Color.Blue), 65, 195, 195, 195); //3
            e.Graphics.DrawLine(new Pen(Color.Red), 65, 65, 65, 195); //4
            e.Graphics.DrawLine(new Pen(Color.OrangeRed), 0, 0, pBextra.Width, pBextra.Height); //5
            e.Graphics.DrawLine(new Pen(Color.Violet), 0, pBextra.Width, pBextra.Width, 0); //7
        }

        private void pBextra2_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i <= pBextra2.Height; i += 10)
            {
                //Crear encuadre
                e.Graphics.DrawLine(new Pen(Color.Blue), 0, 0, 0, pBextra2.Height); //linea izquierda
                e.Graphics.DrawLine(new Pen(Color.Blue), pBextra2.Width - 1, 0, pBextra2.Width - 1, pBextra2.Height); //linea derecha
                e.Graphics.DrawLine(new Pen(Color.Blue), 0, 0, pBextra2.Width, 0); //linea arriba
                e.Graphics.DrawLine(new Pen(Color.Blue), 0, pBextra2.Height - 1, pBextra2.Width, pBextra2.Height - 1); //linea abajo
                //fin crear encuadre
                e.Graphics.DrawLine(new Pen(Color.Black), pBextra2.Height / 2, pBextra2.Width / 2, 0, i); //1
                e.Graphics.DrawLine(new Pen(Color.Green), pBextra2.Height / 2, pBextra2.Width / 2, i, 0); //2
                e.Graphics.DrawLine(new Pen(Color.Blue), pBextra2.Height / 2, pBextra2.Width / 2, pBextra2.Width, i); //3
                e.Graphics.DrawLine(new Pen(Color.Red), pBextra2.Height / 2, pBextra2.Width / 2, i, pBextra2.Height); //4
            }
        }
    }
}