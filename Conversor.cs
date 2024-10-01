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
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void converter_Click(object sender, EventArgs e)
        {
            double converter;
            float celsius = Convert.ToSingle(textBox_convert.Text);
            converter = celsius * 1.8 + 32;
            lbl_resposta.Text = converter.ToString("0.00");
        }


        private void apagar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
