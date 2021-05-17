using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace BorsaProjesi
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //veritabanı bağlantısı (OleDb olmasının sebebi Access veritabanı kullanmam)
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
                baglanti.Open();
                //kullaniciadi ve sifreyi iste
                OleDbCommand sorgu = new OleDbCommand("select yetki from kullanicibilgi where kullaniciadi=@kullaniciadi and sifre=@sifre", baglanti);
                sorgu.Parameters.AddWithValue("kullaniciadi", kullaniciadi.Text);
                sorgu.Parameters.AddWithValue("sifre", sifre.Text);
                OleDbDataReader rd = sorgu.ExecuteReader();
                Program.kullaniciadi = kullaniciadi.Text;//kullanici adini Program sınıfındaki kulllaniciadi'na aktar
              
                
                if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
                {
                    while (rd.Read()) // reader Okuyabiliyorsa
                    { 
                         
                        if (rd["yetki"].ToString() == "1") // 1 Rolü Admin'e ait olarak Ayarlanmışdır
                        {
                            ////Admin sayfasına git
                            AdminPaneli frm = new AdminPaneli();
                            frm.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            //KullaniciEkrani sayfasına git
                            KullaniciEkrani frm = new KullaniciEkrani();
                            frm.ShowDialog();
                            this.Visible = false;
                        }
                    }
                }

                else /// Reader SATIR döndüremiyorsa K.Adı Parola Yanlış Demekdir
                {
                    rd.Close();
                    MessageBox.Show("Kullanıcı Adı veya Parola Geçersizdir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            

             catch // Bağlantı açamayıp Sorgu Çalıştıramıyorsa Veritabanına Ulaşamıyor Demekdir
                {
                MessageBox.Show("DB ye ulaşılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //KayitOl sayfasına git
            KayitOl frm = new KayitOl();
            frm.Show();
            this.Visible=false;
        }
    }
}
