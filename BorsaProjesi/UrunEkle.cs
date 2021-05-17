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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //veritabanı baglantisi
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            object sel = comboBox1.SelectedValue;
          //kutuları boş bırakırsa hata ver
            if (comboBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" )
            {
                //eklenecek ürün bilgilerini gir
                    OleDbCommand ekle = new OleDbCommand("insert into urun(urunadi,fiyat,miktar,kullaniciadi) values(@urunadi,@fiyat,@miktar,@kullaniciadi)", baglanti);
                     ekle.Parameters.AddWithValue("@urunadi",comboBox1.GetItemText(comboBox1.SelectedItem));
                    ekle.Parameters.AddWithValue("@fiyat", textBox2.Text);
                    ekle.Parameters.AddWithValue("@miktar", textBox3.Text);
                    ekle.Parameters.AddWithValue("@kullaniciadi", Program.kullaniciadi); 


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

        private void button2_Click(object sender, EventArgs e)
        {
            //KullaniciEkrani sayfasına git
            KullaniciEkrani frm = new KullaniciEkrani();
            frm.Show();
            this.Close();
        }
    }
}
