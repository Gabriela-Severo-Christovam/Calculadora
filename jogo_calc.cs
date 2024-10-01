using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class jogo_calc : Form
    {
        float valor1 = 0;
        string operação = "";

        public jogo_calc()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "1";  // OU FAÇA txtVisor.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "0";
        }

        private void mais_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operação = "Mais";
            txtVisor.Clear();
        }

        private void menos_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operação = "Menos";
            txtVisor.Clear();
        }

        private void vezes_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operação = "Vezes";
            txtVisor.Clear();
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operação = "Divisao";
            txtVisor.Clear();
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (this.operação == "Mais")
            {
                float resultado = valor1 + Convert.ToSingle(txtVisor.Text);
                txtVisor.Text = resultado.ToString();
            }

            if (this.operação == "Menos")
            {
                float resultado = valor1 - Convert.ToSingle(txtVisor.Text);
                txtVisor.Text = resultado.ToString();
            }

            if (this.operação == "Vezes")
            {
                float resultado = valor1 * Convert.ToSingle(txtVisor.Text);
                txtVisor.Text = resultado.ToString();
            }

            if (this.operação == "Divisao")
            {
                float resultado = valor1 / Convert.ToSingle(txtVisor.Text);
                txtVisor.Text = resultado.ToString();
            }

        }

        private void apaga_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
        }

        private void celsiusParaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conversor jogo_conversor = new Conversor();
            jogo_conversor.ShowDialog();
        }
    }
}
