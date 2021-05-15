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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilii = dataGridView1.SelectedCells[1].RowIndex;
            secili = dataGridView1.Rows[secilii].Cells[1].Value.ToString();
        }
        void listele()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            DataSet liste = new DataSet();
            OleDbDataAdapter urunliste = new OleDbDataAdapter("Select kullaniciadi,urunadi,fiyat,miktar,onay from urun where onay=0", baglanti);
            urunliste.Fill(liste, "okunan veri");
            dataGridView1.DataSource = liste.Tables["okunan veri"];
            baglanti.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand("update urun set onay = 1 where urunadi =@urunadi ", baglanti);

            ekle.Parameters.AddWithValue("@urunadi", secili);
            ekle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Onaylandı.");
             UrunOnay frm = new UrunOnay();
            frm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPaneli frm = new AdminPaneli();
            frm.Show();
            this.Visible = false;
        }

        private void UrunOnay_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
