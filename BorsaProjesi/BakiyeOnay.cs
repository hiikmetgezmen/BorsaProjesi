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
        string secili;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridview'de bir kaydı seçme
            int secilii = dataGridView1.SelectedCells[1].RowIndex;
            secili = dataGridView1.Rows[secilii].Cells[1].Value.ToString();
            //3.sütundaki secili kaydı Program sınıfındaki bakiyee'ye ata
            Program.bakiyee = dataGridView1.Rows[secilii].Cells[3].Value.ToString();
            //4.sütundaki secili kaydı Program sınıfındaki eklenenpara'ya ata
            Program.eklenenpara = dataGridView1.Rows[secilii].Cells[4].Value.ToString();
        }
        void listele()
        {
            //veritabanı bağlantısı
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            DataSet liste = new DataSet();
            //Datagridview'de listelenecek alanları sql sorgusuyla ekleme
            OleDbDataAdapter urunliste = new OleDbDataAdapter("Select kullaniciadi,ad,soyad,bakiye,eklenenpara from kullanicibilgi where onay=0", baglanti);
            urunliste.Fill(liste, "okunan veri");
            dataGridView1.DataSource = liste.Tables["okunan veri"];
            baglanti.Close();

        }
        public int bakiye, toplam=0,x=0,y=0;
        private void Onayla_Click(object sender, EventArgs e)
        {
            //veritabanı bağlantısı
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            x = int.Parse(Program.bakiyee);
            y = int.Parse(Program.eklenenpara);
            toplam = x + y;//Mevcut bakiye ile eklenen parayı topla

            //Yeni bakiye miktarını güncelle ve onayı 1 yaparak bakiye onayı ver
            OleDbCommand ekle = new OleDbCommand("update kullanicibilgi set bakiye=@bakiye,eklenenpara=0,onay=1 where kullaniciadi=@kullaniciadi", baglanti);
            ekle.Parameters.AddWithValue("@bakiye", toplam.ToString());
            ekle.Parameters.AddWithValue("@kullaniciadi", secili);

            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Onaylandı");
            BakiyeOnay frm = new BakiyeOnay();
            frm.ShowDialog();
            this.Close();

        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            AdminPaneli frm = new AdminPaneli();
            frm.Show();
            this.Visible = false;
        }

        private void BakiyeOnay_Load(object sender, EventArgs e)
        {
            //datagridview'de tüm satırı seç
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
    }
}
