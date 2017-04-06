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
    public partial class cuadraticas : Form
    {
        public cuadraticas()
        {
            InitializeComponent();
        }

        private void bTsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int num = this.pBres.Width / 2;
            int num2 = this.pBres.Height / 2;
            e.Graphics.DrawLine(new Pen(Color.Black), num, 0, num, this.pBres.Height);
            e.Graphics.DrawLine(new Pen(Color.Black), 0, num2, this.pBres.Width, num2);
            for (int i = 0; i < this.pBres.Width; i += 10)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), (int)((this.pBres.Width / 2) + i), (int)((this.pBres.Height / 2) - 2), (int)((this.pBres.Width / 2) + i), (int)((this.pBres.Height / 2) + 2));
                e.Graphics.DrawLine(new Pen(Color.Black), (int)((this.pBres.Width / 2) - i), (int)((this.pBres.Height / 2) - 2), (int)((this.pBres.Width / 2) - i), (int)((this.pBres.Height / 2) + 2));
            }
            for (int j = 0; j < this.pBres.Height; j += 10)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), (int)((this.pBres.Width / 2) - 2), (int)((this.pBres.Height / 2) + j), (int)((this.pBres.Width / 2) + 2), (int)((this.pBres.Height / 2) + j));
                e.Graphics.DrawLine(new Pen(Color.Black), (int)((this.pBres.Width / 2) - 2), (int)((this.pBres.Height / 2) - j), (int)((this.pBres.Width / 2) + 2), (int)((this.pBres.Height / 2) - j));
            }
            e.Graphics.TranslateTransform((float)num, (float)num2);
            e.Graphics.ScaleTransform(1f, -1f);
            if ((((((this.tB1.Text.Trim() != "") & (this.tB3.Text.Trim() != "")) & (this.tB2.Text.Trim() != "")) & (this.tB4.Text.Trim() != "")) & (this.tB5.Text.Trim() != "")) & (this.tB6.Text.Trim() != ""))
            {
                float num5 = float.Parse(this.tB1.Text);
                float num6 = float.Parse(this.tB2.Text);
                float num7 = float.Parse(this.tB3.Text);
                float num8 = float.Parse(this.tB4.Text);
                float num9 = float.Parse(this.tB5.Text);
                float num10 = float.Parse(this.tB6.Text);
                for (float k = -1000f; k < 1000f; k += 0.01f)
                {
                    double num11 = (((num5 * k) * k) + (num6 * k)) + num7;
                    e.Graphics.DrawEllipse(new Pen(Color.Blue), k, (float)num11, 1f, 1f);
                    double num12 = (((num8 * k) * k) + (num9 * k)) + num10;
                    e.Graphics.DrawEllipse(new Pen(Color.Red), k, (float)num12, 1f, 1f);
                }
                double num13 = num6 - ((Math.Sqrt((double)((num6 * num6) - ((4f * num5) * num7))) / 2.0) * num5);
                this.tBx11.Text = num13.ToString();
                num13 = -num6 - ((Math.Sqrt((double)((num6 * num6) - ((4f * num5) * num7))) / 2.0) * num5);
                this.tBx12.Text = num13.ToString();
                num13 = num9 - ((Math.Sqrt((double)((num9 * num9) - ((4f * num8) * num10))) / 2.0) * num8);
                this.tBx21.Text = num13.ToString();
                this.tBx22.Text = (-num9 - ((Math.Sqrt((double)((num9 * num9) - ((4f * num8) * num10))) / 2.0) * num8)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pBres.Invalidate();
        }
    }
}
