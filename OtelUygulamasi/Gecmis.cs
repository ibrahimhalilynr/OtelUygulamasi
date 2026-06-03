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
    public partial class Gecmis : Form
    {
        OtelContext db = new OtelContext();
        Rezervasyon gecmis = new Rezervasyon();
        public Gecmis()
        {
            InitializeComponent();
            dataGridView1.DataSource =db.Rezervasyons.ToList();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
