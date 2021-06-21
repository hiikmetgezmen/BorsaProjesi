﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BorsaProjesi
{
    public partial class İstekUrun : Form
    {
        public İstekUrun()
        {
            InitializeComponent();
        }

        private void Don_Click(object sender, EventArgs e)
        {
            //KullaniciEkrani sayfasına git
            KullaniciEkrani frm = new KullaniciEkrani();
            frm.Show();
            this.Close();
        }

        private void SatinAl_Click(object sender, EventArgs e)
        {
            //veritabanı baglantisi
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            object sel = urunsec.SelectedValue;
            //kutuları boş bırakırsa hata ver
            if (urunsec.Text != "" && fiyat.Text != "" && miktar.Text != "")
            {
                //eklenecek ürün bilgilerini gir
                OleDbCommand ekle = new OleDbCommand("insert into istek(urunadi,fiyat,miktar,alici,tarih) values(@urunadi,@fiyat,@miktar,@alici,@tarih)", baglanti);
                ekle.Parameters.AddWithValue("@urunadi", urunsec.GetItemText(urunsec.SelectedItem));
                ekle.Parameters.AddWithValue("@fiyat", fiyat.Text);
                ekle.Parameters.AddWithValue("@miktar", miktar.Text);
                ekle.Parameters.AddWithValue("@alici", Program.kullaniciadi);
                ekle.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("d.MM.yyyy"));

                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Admin onayı bekleniyor...");
                KullaniciEkrani frm = new KullaniciEkrani();
                frm.Show();
                this.Close();

            }


            else
            {
                MessageBox.Show("Lütfen boş kutu bırakmayınız...");

            }
        }
    }
}
