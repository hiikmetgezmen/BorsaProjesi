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
      //  OleDbConnection connection = Login.connection;
       // public static string KullaniciAdi { get; set; }
        void listele()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            DataSet liste = new DataSet();
            OleDbDataAdapter urunliste = new OleDbDataAdapter("Select urunadi,fiyat,miktar from urun where onay = 1 and kullaniciadi='"+Program.kullaniciadi+"'", baglanti);
            urunliste.Fill(liste, "okunan veri"); 

            dataGridView1.DataSource = liste.Tables["okunan veri"];
            baglanti.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunEkle frm = new UrunEkle();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        private void KullaniciEkrani_Load(object sender, EventArgs e)
        {
            
        }

        private void KullaniciEkrani_Load_1(object sender, EventArgs e)
        {
        label2.Text = Program.kullaniciadi;
        label1.Text = Program.bakiye;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        Bakiye frm = new Bakiye();
            frm.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SatinAl frm = new SatinAl();
            frm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }
    }
}
