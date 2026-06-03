using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        OtelContext db = new OtelContext();
        

        private void back_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show(); 

            txt_adres.Clear();
            txt_name.Clear();
            txt_surname.Clear();
            txt_Tc.Clear();
            txt_tel.Clear();
            this.Close();

        }

        private void txt_kayit_Click(object sender, EventArgs e)
        {
            try 
            {
                string tc = txt_Tc.Text;

                Musteri m = db.Musteris.FirstOrDefault(m => m.Tc == tc);

                if (m != null)
                {
                    MessageBox.Show("Bu TC numarası zaten kayıtlı.");
                    return;
                }

                string tel = txt_tel.Text;
                Musteri telefon = db.Musteris.FirstOrDefault(m => m.Telefon == tel);

                if (telefon != null)
                {
                    MessageBox.Show("Bu telefon numarası zaten kayıtlı.");
                    return;
                }

                Musteri musteri = new Musteri
                { 
                    Tc = txt_Tc.Text,
                    Ad = txt_name.Text,
                    Soyad = txt_surname.Text,
                    Adres = txt_adres.Text,
                    Telefon = label.Text
                };

                db.Musteris.Add(musteri);
                db.SaveChanges();

                MessageBox.Show("Kayıt başarılı!"); 

                txt_adres.Clear();
                txt_name.Clear();
                txt_surname.Clear();
                txt_tel.Clear();
                txt_Tc.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu. Lütfen bilgilerinizi kontrol edin ve tekrar deneyin.");
            }

        }
    }
}
