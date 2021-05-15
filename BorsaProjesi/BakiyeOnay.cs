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
    public partial class BakiyeOnay : Form
    {
        public BakiyeOnay()
        {
            InitializeComponent();
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPaneli frm = new AdminPaneli();
            frm.Show();
            this.Visible = false;
        }
        void listele()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            DataSet liste = new DataSet();
            OleDbDataAdapter urunliste = new OleDbDataAdapter("Select kullaniciadi,ad,soyad,bakiye,onay,eklenenpara from kullanicibilgi where onay=0", baglanti);
            urunliste.Fill(liste, "okunan veri");
            dataGridView1.DataSource = liste.Tables["okunan veri"];
    
            baglanti.Close();

        }
        string secili;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilii = dataGridView1.SelectedCells[1].RowIndex;
            secili = dataGridView1.Rows[secilii].Cells[1].Value.ToString();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            /*
          //  int i = 1;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand("update kullanicibilgi set onay = 1  where kullaniciadi =@kullaniciadi ", baglanti);
            //OleDbCommand ekle1 = new OleDbCommand("select bakiye from kullanicibilgi where kullaniciadi=@kullaniciadi" , baglanti);
           // OleDbDataReader sdr = ekle.ExecuteReader();
           
            //Veritabanındaki bakiye degerini cek ve bakiye degiskenine ata
           // int bakiye;
            //int.TryParse(sdr["bakiye"].ToString(), out bakiye);
            //Program.bakiye += bakiye.ToString();
            //Program.bakiye = bakiye.ToString();
            ekle.Parameters.AddWithValue("@kullaniciadi", secili);
            ekle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("kaydoldu");
            BakiyeOnay frm = new BakiyeOnay();
            frm.ShowDialog();
            this.Close();*/
            }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BakiyeOnay_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
