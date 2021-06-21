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
    public partial class UrunOnay : Form
    {
        public UrunOnay()
        {
            InitializeComponent();
            listele();
        }
        string secili;
        int kalan = 0, fatura = 0, para,alinanurun=0;
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
        {
            //veri tabanı bağlantısı
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            //hangi ürünlerin listeleneceğini seç
            DataSet liste = new DataSet();
            OleDbDataAdapter urunliste = new OleDbDataAdapter("Select kullaniciadi,urunadi,fiyat,miktar from urun where onay=0", baglanti);
            urunliste.Fill(liste, "okunan veri");
            dataGridView1.DataSource = liste.Tables["okunan veri"];
            baglanti.Close();

        }
        private void UrunOnay_Load(object sender, EventArgs e)
        {
            //tüm satırı seç
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void onay_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            //urunu onayla
            OleDbCommand ekle = new OleDbCommand("update urun set onay = 1 where urunadi =@urunadi", baglanti);
            ekle.Parameters.AddWithValue("@urunadi", secili);
            ekle.ExecuteNonQuery();

            OleDbCommand sorgu = new OleDbCommand("Select alici,tarih,fiyat,miktar from istek where urunadi=@urunadi and fiyat>=@fiyat and alici<>@alici order by tarih", baglanti);
            sorgu.Parameters.AddWithValue("urunadi",Program.urun);
            sorgu.Parameters.AddWithValue("@fiyat", Convert.ToInt32(Program.fiyat));
            sorgu.Parameters.AddWithValue("@alici", Program.urunsahibi);
            OleDbDataReader rd = sorgu.ExecuteReader();

           

            if (rd.HasRows) // Gelen Data var ise 
            {
                while (rd.Read()) // reader Okuyabiliyorsa
                {
                    Program.alici = rd["alici"].ToString();
                    Program.istekpara = rd["fiyat"].ToString();
                    Program.istekmiktar = rd["miktar"].ToString();
                   
                    
                    OleDbCommand sorgu1 = new OleDbCommand("Select bakiye from kullanicibilgi where kullaniciadi=@kullaniciadi", baglanti);
                     sorgu1.Parameters.AddWithValue("@kullaniciadi",Program.alici);
                     OleDbDataReader rd1 = sorgu1.ExecuteReader();
                    while (rd1.Read()) // reader Okuyabiliyorsas
                    {
                        Program.para = rd1["bakiye"].ToString();
                   
                    if (Convert.ToInt32(Program.istekmiktar)>= Convert.ToInt32(Program.miktar))
                    {
                    //alıcı ne kadar odeyecek
                    fatura = int.Parse(Program.fiyat) * int.Parse(Program.miktar);
                    kalan = 0;
                    alinanurun = Convert.ToInt32(Program.miktar);
                    }
                    else
                    {
                    //alıcı ne kadar odeyecek
                    fatura = int.Parse(Program.fiyat) * int.Parse(Program.istekmiktar); 
                    //satıcıda ne kadar urun kaldığını gosterme
                    kalan = int.Parse(Program.miktar) - int.Parse(Program.istekmiktar);
                    alinanurun = Convert.ToInt32(Program.istekmiktar);
                    }

                        //alıcının ne kadar parası kaldı
                        para = int.Parse(Program.para) - fatura;
                        Program.para = para.ToString();




                        // Seçilen satırdaki kullanıcının ürün miktarını güncelleme
                        OleDbCommand guncelle1 = new OleDbCommand("update urun set miktar=@miktar where kullaniciadi=@kullaniciadi", baglanti);
                        guncelle1.Parameters.AddWithValue("@miktar", kalan);
                        guncelle1.Parameters.AddWithValue("@kullaniciadi", Program.urunsahibi);



                        // seçilen satırdaki kullanıcının bakiyesini guncelleme
                        OleDbCommand guncelle2 = new OleDbCommand("update kullanicibilgi set bakiye = bakiye+@bakiye where kullaniciadi=@kullaniciadi", baglanti);
                        guncelle2.Parameters.AddWithValue("@bakiye", fatura);
                        guncelle2.Parameters.AddWithValue("@kullaniciadi", Program.urunsahibi);



                        // kullanıcının bakiyesini guncelleme
                        OleDbCommand guncelle = new OleDbCommand("update kullanicibilgi set bakiye=@bakiye where kullaniciadi='" + Program.kullaniciadi + "'", baglanti);
                        guncelle.Parameters.AddWithValue("@bakiye", para);


                        //fatura Çıkarma
                        OleDbCommand ekle1 = new OleDbCommand("insert into fatura(kuladi,faturatutar,alici,miktar,urunadi,kalanpara,fiyat,tarih) values(@kuladi,@faturatutar,@alicii,@miktari,@urunadii,@kalanparai,@fiyati,@tarihi)", baglanti);
                        ekle1.Parameters.AddWithValue("@kuladi", Program.urunsahibi);
                        ekle1.Parameters.AddWithValue("@faturatutar", fatura);
                        ekle1.Parameters.AddWithValue("@alicii", Program.alici);
                        ekle1.Parameters.AddWithValue("@miktari",alinanurun);
                        ekle1.Parameters.AddWithValue("@urunadii", Program.urun);
                        ekle1.Parameters.AddWithValue("@kalanparai", para);
                        ekle1.Parameters.AddWithValue("@fiyati", Convert.ToInt32(Program.fiyat));//string ifadeyi integer ifadeye dönüştürüp veri tabanına aktarma
                        ekle1.Parameters.AddWithValue("@tarihi", DateTime.Now.ToString("d.MM.yyyy"));//tarih formatı

                    

                        guncelle2.ExecuteNonQuery();
                        guncelle1.ExecuteNonQuery();
                        ekle1.ExecuteNonQuery();
                        guncelle.ExecuteNonQuery();
                    }
                }
            }

            else 

            {
                rd.Close();
            }

            baglanti.Close();
            MessageBox.Show("Onaylandı.");
            UrunOnay frm = new UrunOnay();
            frm.ShowDialog();
            this.Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            AdminPaneli frm = new AdminPaneli();
            frm.Show();
            this.Visible = false;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }
    }
}


