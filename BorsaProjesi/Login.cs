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
           // kayitOl = new KayitOl();
            
        }
        //public KayitOl kayitOl;


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
                baglanti.Open();
                OleDbCommand sorgu = new OleDbCommand("select yetki from kullanicibilgi where kullaniciadi=@kuladi and sifre=@sifre", baglanti);
                sorgu.Parameters.AddWithValue("@kuladi", kullaniciadi.Text);
                sorgu.Parameters.AddWithValue("@sifre", sifre.Text);
                OleDbDataReader rd;
                rd = sorgu.ExecuteReader();


                if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
                {
                    while (rd.Read()) // reader Okuyabiliyorsa
                    {
                        if (rd["yetki"].ToString() == "1") // 1 Rolü Admin'e ait olarak Ayarlanmışdır
                        {
                            // Kullanıcı Rolü 1 ise Admin Ekranı Aç 
                            //_YonetimEkrani_Frm admin = new _YonetimEkrani_Frm();
                            // admin.Show();
                            // this.Hide();
                            MessageBox.Show("admin");
                        }
                        else
                        {
                            // Kullanıcı Rolü 1 dışında ise Kullanıcı Ekranı Aç
                            // Kullanicilar_Frm kul = new Kullanicilar_Frm();
                            //kul.Show();
                            //this.Hide();
                            MessageBox.Show("kullanici");
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
            KayitOl frm = new KayitOl();
            frm.Show();
            this.Visible=false;
        }
    }
}
