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
    public partial class kiralama : Form
    {
        OtelContext db = new OtelContext();
        Musteri muster = new Musteri();
        public kiralama(int id)
        {
            InitializeComponent();
            db_rooms.DataSource = db.Oda.ToList();
            muster = db.Musteris.FirstOrDefault(x => x.Musteriid == id);
        }

        Odum oda = new Odum();
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void db_rooms_DoubleClick(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells[0].FormattedValue);
            oda = db.Oda.FirstOrDefault(x => x.Odaid == id);
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            if (oda.Odaid == null)
            {
                MessageBox.Show("Lütfen bir oda seçiniz.");
                return;
            }
            int startd = date_basla.Value.Day;
            int startm = date_basla.Value.Month;

            int endd = date_bitis.Value.Day;
            int endm = date_bitis.Value.Month;

            int totalday = 0;

            if (startm != endm) 
            {
                int mcount = endm - startm;

                totalday += mcount * 30;

            }
            

            totalday += endd - startd;
            txt_fiyat.Text = (totalday * oda.Fiyat).ToString();

        }

            

        Entities.Rezervasyon rez = new Entities.Rezervasyon();

        private void btn_kirala_Click(object sender, EventArgs e)
        {
            if (muster == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.");
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            if (oda.Durum == false)
            {
                MessageBox.Show("Bu oda zaten kiralanmış.");
                return;
            }
            else if (date_basla.Value > date_bitis.Value)
            {
                MessageBox.Show("Lütfen geçerli bir tarih aralığı seçiniz.");
                return;
            }
            else
            {
                if (txt_fiyat.Text == "0")
                {
                    MessageBox.Show("Lütfen geçerli bir fiyat hesaplayınız.");
                    return;
                }
                else
                {

                    if (yes.Checked)
                    {
                        rez.Musteriid = muster.Musteriid;
                        rez.Odaid = oda.Odaid;
                        rez.Giristarihi = DateOnly.FromDateTime(date_bitis.Value);
                        rez.Cikistarihi = DateOnly.FromDateTime(date_basla.Value);
                        rez.Toplamucret = Convert.ToDecimal(txt_fiyat.Text);
                        oda.Durum = false;
                       
                        db.Rezervasyons.Add(rez);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Ödeme Yapınız.");
                        return;

                    }
                }
            }

        }
    }
}
