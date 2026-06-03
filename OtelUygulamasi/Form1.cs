using OtelUygulamasi.Entities;

namespace OtelUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void txt_kayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            kayit form3 = new kayit();
            form3.Show();
        }

        private void txt_kiralamageçmişi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gecmis form4 = new Gecmis();
            form4.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
