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
    public partial class SatinAlmaGecmisi : Form
    {
        public SatinAlmaGecmisi()
        {
            InitializeComponent();
            listele();
        }

        private void SatinAlmaGecmisi_Load(object sender, EventArgs e)
        {

        }
        void listele()
        {
            //veritabanı bağlantısı
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            DataSet liste = new DataSet();
            //listelenecek verileri seç
            OleDbDataAdapter urunliste = new OleDbDataAdapter("Select tarih,kuladi,urunadi,fiyat,miktar,faturatutar,alici,kalanpara from fatura  ", baglanti);
            urunliste.Fill(liste, "okunan veri");

            dataGridView1.DataSource = liste.Tables["okunan veri"];
            baglanti.Close();

            //Tabloların isimlerini düzenle
            dataGridView1.Columns[0].HeaderText = "Tarih";

            dataGridView1.Columns[1].HeaderText = "Ürün Sahibi";

            dataGridView1.Columns[2].HeaderText = "Satılan Ürün";

            dataGridView1.Columns[3].HeaderText = "Birim Fiyatı";

            dataGridView1.Columns[4].HeaderText = "Ürün Miktarı";

            dataGridView1.Columns[5].HeaderText = "Fatura Tutarı";

            dataGridView1.Columns[6].HeaderText = "Alıcı Adı";

            dataGridView1.Columns[7].HeaderText = "Alıcının Kalan Parası";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //KullaniciEkrani sayfasına git
            KullaniciEkrani frm = new KullaniciEkrani();
            frm.Show();
            this.Close();
        }

        private void AlisRaporu_Click(object sender, EventArgs e)
        {
            AlisRaporu frm = new AlisRaporu();
            frm.Show();
            this.Close();
        }

        private void SatisRaporu_Click(object sender, EventArgs e)
        {
            SatisRaporu frm = new SatisRaporu();
            frm.Show();
            this.Close();
        }
    }
}
