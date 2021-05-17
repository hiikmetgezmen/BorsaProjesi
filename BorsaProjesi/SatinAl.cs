
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
    public partial class SatinAl : Form
    {
        public SatinAl()
        {
            InitializeComponent();
            listele();
        }
        int kalan = 0,fatura=0,para;
        private void button1_Click(object sender, EventArgs e)
        {
            //veritabanı bağlantısı
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
                baglanti.Open();
            //satın alınmak istenen ürünün miktarı mevcut ürün miktarından fazla ise uyarı ver
            if (int.Parse(textBox1.Text) <= int.Parse(Program.miktar))
            {
                //alıcı ne kadar odeyecek
                fatura = int.Parse(Program.fiyat) * int.Parse(textBox1.Text);
                if(fatura<=int.Parse(Program.para))
                {
                 //alıcının ne kadar parası kaldı
                para = int.Parse(Program.para) - fatura;
                Program.para = para.ToString();

                //satıcıda ne kadar urun kaldığını gosterme
                kalan = int.Parse(Program.miktar) - int.Parse(textBox1.Text);


                // Seçilen satırdaki kullanıcının ürün miktarını güncelleme
                OleDbCommand guncelle1 = new OleDbCommand("update urun set miktar=@miktar where kullaniciadi=@kullaniciadi", baglanti);
                guncelle1.Parameters.AddWithValue("@miktar", kalan);
                guncelle1.Parameters.AddWithValue("@kullaniciadi", Program.urunsahibi);



                // seçilen satırdaki kullanıcının bakiyesini guncelleme
                OleDbCommand guncelle2 = new OleDbCommand("update kullanicibilgi set bakiye = bakiye+@bakiye where kullaniciadi=@kullaniciadi", baglanti);
                    
                guncelle2.Parameters.AddWithValue("@bakiye", fatura);
                guncelle2.Parameters.AddWithValue("@kullaniciadi", Program.urunsahibi);



                // kullanıcının bakiyesini guncelleme
                OleDbCommand guncelle = new OleDbCommand("update kullanicibilgi set bakiye=@bakiye where kullaniciadi='"+Program.kullaniciadi+"'", baglanti);
                guncelle.Parameters.AddWithValue("@bakiye", para);


                //fatura Çıkarma
                OleDbCommand ekle = new OleDbCommand("insert into fatura(kuladi,faturatutar,alici,miktar,urunadi,kalanpara,fiyat,tarih) values(@kuladi,@faturatutar,@alici,@miktar,@urunadi,@kalanpara,@fiyat,@tarih)", baglanti);
                ekle.Parameters.AddWithValue("@kuladi", Program.urunsahibi);
                ekle.Parameters.AddWithValue("@faturatutar", fatura);
                ekle.Parameters.AddWithValue("@alici", Program.kullaniciadi);
                ekle.Parameters.AddWithValue("@miktar", textBox1.Text);
                ekle.Parameters.AddWithValue("@urunadi", Program.urun);
                ekle.Parameters.AddWithValue("@kalanpara",para);
                ekle.Parameters.AddWithValue("@fiyat", Convert.ToInt32(Program.fiyat));//string ifadeyi integer ifadeye dönüştürüp veri tabanına aktarma
                ekle.Parameters.AddWithValue("@tarih",dateTimePicker1.Value.ToString("d.MM.yyyy"));//tarih formatı



                guncelle2.ExecuteNonQuery();
                guncelle1.ExecuteNonQuery();
                ekle.ExecuteNonQuery();
                guncelle.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("kaydoldu");
                SatinAl frm = new SatinAl();
                frm.Show();
                this.Close();
                }
                else
                {
                MessageBox.Show("Yetersiz bakiye");
                }
            }
            else
            {
                MessageBox.Show("Yeteri kadar ürün yok");
            }

              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //KullaniciEkrani sayfasına git
            KullaniciEkrani frm = new KullaniciEkrani();
            frm.Show();
            this.Close();
        }
        string secili;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview'de satır seçme
            int secilii = dataGridView1.SelectedCells[1].RowIndex;
            secili = dataGridView1.Rows[secilii].Cells[1].Value.ToString();
            Program.urunsahibi = dataGridView1.Rows[secilii].Cells[0].Value.ToString();
            Program.urun = dataGridView1.Rows[secilii].Cells[1].Value.ToString();
            Program.fiyat = dataGridView1.Rows[secilii].Cells[2].Value.ToString();
            Program.miktar = dataGridView1.Rows[secilii].Cells[3].Value.ToString();

        }
        void listele()
        {//veritabanı bağlantısı
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            //datgridview'de listelenecek verileri seç
            DataSet liste = new DataSet();
            OleDbDataAdapter urunliste = new OleDbDataAdapter("Select kullaniciadi,urunadi,fiyat,miktar from urun where onay=1 and kullaniciadi <>'" + Program.kullaniciadi+"'", baglanti);
           //bakiyeyi göster
            OleDbDataAdapter bakiyegoster = new OleDbDataAdapter("Select bakiye from kullanicibilgi where kullaniciadi ='" + Program.kullaniciadi + "'", baglanti);
            urunliste.Fill(liste, "okunan veri");
            bakiyegoster.Fill(liste, "okunan veri 2");
            dataGridView1.DataSource = liste.Tables["okunan veri"];
            dataGridView2.DataSource = liste.Tables["okunan veri 2"];
            Program.para = dataGridView2.Rows[0].Cells[0].Value.ToString();//Sahip olunan parayı Program sınıfındaki para'ya aktar
            baglanti.Close();

        }

        private void SatinAl_Load(object sender, EventArgs e)
        {
            //tüm satırı seçme
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
