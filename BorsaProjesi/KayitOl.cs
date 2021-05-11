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
       
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
                // while (true)
                 //{
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
              
                    OleDbCommand sorgu = new OleDbCommand("select kullaniciadi from kullanicibilgi where kullaniciadi=@kullaniciadi", baglanti);
                    sorgu.Parameters.AddWithValue("@kuladi", textBox3.Text);
                    OleDbDataReader rd;
                    rd = sorgu.ExecuteReader();
                    if (rd.Read())
                    {
                        MessageBox.Show("Bu kullanıcı adı önceden alınmış...");
                    }
                    else
                    {
                        OleDbCommand ekle = new OleDbCommand("insert into kullanicibilgi(ad,soyad,kullaniciadi,sifre,tckimlikno,telefon,email,adres) values(@ad,@soyad,@kullaniciadi,@sifre,@tckimlikno,@telefon,@email,@adres)", baglanti);
                        ekle.Parameters.AddWithValue("@ad", textBox1.Text);
                        ekle.Parameters.AddWithValue("@soyad", textBox2.Text);
                        ekle.Parameters.AddWithValue("@kullaniciadi", textBox3.Text);
                        ekle.Parameters.AddWithValue("@sifre", textBox4.Text);
                        ekle.Parameters.AddWithValue("@tckimlikno", textBox5.Text);
                        ekle.Parameters.AddWithValue("@telefon", textBox6.Text);
                        ekle.Parameters.AddWithValue("@email", textBox7.Text);
                        ekle.Parameters.AddWithValue("@adres", textBox8.Text);

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


           // }
         
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }
    }
}
