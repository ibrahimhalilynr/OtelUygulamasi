using OtelUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OtelUygulamasi
{
    public partial class giris : Form
    {
        OtelContext db = new OtelContext();
        public giris()
        {
            InitializeComponent();
        }
        Guvenliksifresi pass = new Guvenliksifresi();
        private void btn_passgrs_Click(object sender, EventArgs e)
        {
            string sifre = txt_pass.Text;
            pass = db.Guvenliksifresis.FirstOrDefault(x => x.Guvenliksifresi1 == sifre);
            if (pass != null) 
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Güvenlik şifresi yanlış.");
                return;
            }
        }
    }
}
