namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_pgb_Tick(object sender, EventArgs e)
        {
            pgbCarregando.Value = pgbCarregando.Value = 1;

            if (pgbCarregando.Value == 0)
            {
                timer_pgb.Enabled = false;
            }
        }
    }
}
