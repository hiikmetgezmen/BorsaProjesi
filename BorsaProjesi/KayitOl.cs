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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
           
        }
    
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }

        private void kaydol_Click(object sender, EventArgs e)
        {
            //veritabanı bağlantısı
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            //kutuların boş girilmesini engelle
            if (ad.Text != "" && Soyad.Text != "" && kullaniciAdi.Text != "" && sifre.Text != "" && tcno.Text != "" && telefon.Text != "" && email.Text != "" && adres.Text != "")
            {
                //sql ile hangi verileri dolduracağımızı seç
                OleDbCommand sorgu = new OleDbCommand("select kullaniciadi from kullanicibilgi where kullaniciadi=@kullaniciadi", baglanti);
                sorgu.Parameters.AddWithValue("@kuladi", kullaniciAdi.Text);
                OleDbDataReader rd;
                rd = sorgu.ExecuteReader();
                if (rd.Read())//eğer kullanıcı adı zaten varsa yeni kullanıcı adı iste
                {
                    MessageBox.Show("Bu kullanıcı adı önceden alınmış...");
                }
                else
                {
                    //sorgu ile veritabanına verileri ekle
                    OleDbCommand ekle = new OleDbCommand("insert into kullanicibilgi(ad,soyad,kullaniciadi,sifre,tckimlikno,telefon,email,adres) values(@ad,@soyad,@kullaniciadi,@sifre,@tckimlikno,@telefon,@email,@adres)", baglanti);
                    ekle.Parameters.AddWithValue("@ad", ad.Text);
                    ekle.Parameters.AddWithValue("@soyad", Soyad.Text);
                    ekle.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi.Text);
                    ekle.Parameters.AddWithValue("@sifre", sifre.Text);
                    ekle.Parameters.AddWithValue("@tckimlikno", tcno.Text);
                    ekle.Parameters.AddWithValue("@telefon", telefon.Text);
                    ekle.Parameters.AddWithValue("@email", email.Text);
                    ekle.Parameters.AddWithValue("@adres", adres.Text);

                    ekle.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("kaydoldu");
                    Login frm = new Login();
                    frm.Show();
                    this.Close();
                }
            }


            else
            {
                MessageBox.Show("Lütfen boş kutu bırakmayınız...");

            }

        }
    }
}
