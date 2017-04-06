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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void teoriaDeConjuntosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new conjuntos().ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void relacionesYFuncionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new relaciones().ShowDialog();
        }

        private void mainprog_Load(object sender, EventArgs e)
        {

        }

        private void matricesYDeterminantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new matrices().ShowDialog();
        }

        private void estadisticaDescriptivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new estadistica().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Funciones().ShowDialog();
        }

        private void lineasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new lineas().ShowDialog();
        }

        private void ecuacionesCuadraticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new cuadraticas().ShowDialog();
        }

        private void ecuacionesLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new lineales().ShowDialog();
        }

        private void graficaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new graficacion().ShowDialog();
        }

        private void escalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new escalar().ShowDialog();
        }
    }
}
