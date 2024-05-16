using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 8;
            int b = 15;
            int c = 4;

            double delta = b * b - 4 * a * c;

            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show($"As raízes da equação quadrática são:\\na1 = {a1}\\na2 = {a2}\", \"Raízes da Equação Quadrática");
            MessageBox.Show("A fórmula de Bhaskara resolve equações quadráticas de segundo grau. Onde a, b e c são coeficientes da equação.  A fórmula é assim:\r\ndelta = b*b - 4*a*c;\r\na1 = (-b + raiz(delta)) / (2 * a);\r\na2 = (-b - raiz(delta)) / (2 * a);");

        }
    }
}
