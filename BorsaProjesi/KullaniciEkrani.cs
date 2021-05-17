using System;
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
    public partial class KullaniciEkrani : Form
    {
        public KullaniciEkrani()
        {
            InitializeComponent();
            listele();
        }
        void listele()
        {
            //veritabanı bağlantısı
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            //dataridview'de hangi verilerin listeleneceğini seç
            DataSet liste = new DataSet();
            OleDbDataAdapter urunliste = new OleDbDataAdapter("Select urunadi,fiyat,miktar from urun where onay = 1 and  kullaniciadi='"+Program.kullaniciadi+"'", baglanti);
            urunliste.Fill(liste, "okunan veri"); 
            dataGridView1.DataSource = liste.Tables["okunan veri"];
            baglanti.Close();
            
        }
        private void KullaniciEkrani_Load(object sender, EventArgs e)
        {
            
        }

        private void KullaniciEkrani_Load_1(object sender, EventArgs e)
        {
         //labele kullanıcı adını yazdırma
        label2.Text = Program.kullaniciadi;
        }


        private void urunekle_Click(object sender, EventArgs e)
        {
            //UrunEkle sayfasına git
            UrunEkle frm = new UrunEkle();
            frm.Show();
            this.Close();
        }

        private void satinal_Click(object sender, EventArgs e)
        {
             //SatinAl sayfasına git
            SatinAl frm = new SatinAl();
            frm.Show();
            this.Close();
        }

        private void paraekle_Click(object sender, EventArgs e)
        {
            //Bakiye sayfasına git
            Bakiye frm = new Bakiye();
            frm.Show();
            this.Close();
        }

        private void fatura_Click(object sender, EventArgs e)
        {
            //SatinAlmaGecmisi sayfasına git
            SatinAlmaGecmisi frm = new SatinAlmaGecmisi();
            frm.Show();
            this.Close();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            //Login sayfasına git
            Login frm = new Login();
            frm.Show();
            this.Close();
        }
    }
}

          
        