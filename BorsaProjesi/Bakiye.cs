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
    public partial class Bakiye : Form
    {
        public Bakiye()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            
            if (textBox1.Text != "" )
            {
                OleDbCommand ekle = new OleDbCommand("update kullanicibilgi set eklenenpara=@eklenenpara where kullaniciadi = '"+ Program.kullaniciadi+"'", baglanti);
              //OleDbCommand ekle = new OleDbCommand("insert into kullanicibilgi(eklenenpara) values(@eklenenpara)", baglanti);
                
                 ekle.Parameters.AddWithValue("@eklenenpara",textBox1.Text);
                 ekle.ExecuteNonQuery();
                 baglanti.Close();
                 MessageBox.Show("Admin onayı bekleniyor...");
                KullaniciEkrani frm = new KullaniciEkrani();
                frm.ShowDialog();
                this.Close();
                
            }

            else
            {
                MessageBox.Show("Lütfen boş kutu bırakmayınız...");

            }
           
        }
    }
}
