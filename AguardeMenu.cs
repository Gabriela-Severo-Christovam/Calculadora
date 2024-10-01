namespace Calculadora
{
    public partial class frmcalculadora : Form
    {
        public frmcalculadora()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (pgbCarregando.Value >= 100)
            {
                tmr_pbg.Enabled = false;
                jogo_calc Jogo_calculadora = new jogo_calc();
                Jogo_calculadora.ShowDialog();
            }
            else
            {
                pgbCarregando.Value = pgbCarregando.Value + 10;
            }

        }

        private void frmcalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
