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

    public partial class Form2 : Form
    {
        OtelContext db = new OtelContext();
        Musteri musteri = new Musteri();
        public Form2()
        {
            InitializeComponent();
            dataGridView2.DataSource = db.Musteris.ToList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells[0].EditedFormattedValue);

            musteri = db.Musteris.FirstOrDefault(x => x.Musteriid == id);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (musteri.Musteriid < 1)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.");
                return;
            }
            else  
            {
                this.Hide();
                kiralama form3 = new kiralama(musteri.Musteriid);
                form3.Show();
                musteri = null;
            }

            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            musteri = null;

        }
    }
}