using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // veritabanını kullanabilmemiz için kütüphane ekleme

namespace BorsaProjesi
{
    public partial class Bakiye : Form
    {
        public Bakiye()
        {
            InitializeComponent();
        }
        private void Bakiye_Load(object sender, EventArgs e)
        {
           
        }
        private void GeriDon_Click(object sender, EventArgs e)
        {
            //KullaniciEkrani sayfasına git
            KullaniciEkrani frm = new KullaniciEkrani();
            frm.Show();
            this.Close();
        }

        private void ParaEkle_Click(object sender, EventArgs e)
        {
            //Veritabanını tanımla
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            //Bakiye onayı istemek için eklenen parayı güncelle eğer onay'ı 0'a eşitleyerek admin onayı istedik
            OleDbCommand guncelle = new OleDbCommand("update kullanicibilgi set onay=0,eklenenpara=@eklenenpara where kullaniciadi='" + Program.kullaniciadi + "'", baglanti);
            guncelle.Parameters.AddWithValue("@eklenenpara", Miktar.Text);//eklenen paraya textbox'taki değeri ata
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Admin onayı bekleniyor...");
            //KullaniciEkrani sayfasına git
            KullaniciEkrani frm = new KullaniciEkrani();
            frm.Show();
            this.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //KayitOl sayfasına git
            Doviz frm = new Doviz();
            frm.Show();
            this.Close();
            
        }
    }
}
