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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace BorsaProjesi
{
    public partial class AlisRaporu : Form
    {
        public AlisRaporu()
        {
            InitializeComponent();
            listele();
        }
        void listele()
        {
            //veritabanı bağlantısı
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            DataSet liste = new DataSet();
            //listelenecek verileri seç
            OleDbDataAdapter urunliste = new OleDbDataAdapter("Select tarih,urunadi,fiyat,miktar from fatura where alici='" + Program.kullaniciadi + "'", baglanti);
            urunliste.Fill(liste, "okunan veri");

            dataGridView1.DataSource = liste.Tables["okunan veri"];
            baglanti.Close();

            //Tabloların isimlerini düzenle
            dataGridView1.Columns[0].HeaderText = "Tarih";

            dataGridView1.Columns[1].HeaderText = "Satılan Ürün";

            dataGridView1.Columns[2].HeaderText = "Birim Fiyatı";

            dataGridView1.Columns[3].HeaderText = "Ürün Miktarı";

        }
        private void Sorgula_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            DataSet dt1 = new DataSet();
            //tarihler arasındaki verileri listele
            OleDbDataAdapter da = new OleDbDataAdapter("Select tarih,urunadi,fiyat,miktar from fatura where tarih between @tarih1 and @tarih2 and kuladi='" + Program.kullaniciadi + "'", baglanti);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", dateTimePicker1.Value.ToString("d.MM.yyyy"));
            da.SelectCommand.Parameters.AddWithValue("@tarih2", dateTimePicker2.Value.ToString("d.MM.yyyy"));
           
            da.Fill(dt1,"veri");
            dataGridView1.DataSource = dt1.Tables["veri"];
            baglanti.Close();
            
            //Tabloların isimlerini düzenle
            dataGridView1.Columns[0].HeaderText = "Tarih";

            dataGridView1.Columns[1].HeaderText = "Satılan Ürün";

            dataGridView1.Columns[2].HeaderText = "Birim Fiyatı";

            dataGridView1.Columns[3].HeaderText = "Ürün Miktarı";
        }

        private void indir_Click(object sender, EventArgs e)
        {
            //DataGriview içindekiverileri excele atama
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);

            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            int StartCol = 1;

            int StartRow = 1;

            for (int j = 0; j< dataGridView1.Columns.Count; j++)
            {

                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];

                myRange.Value2 = dataGridView1.Columns[j].HeaderText;

            }

            StartRow++;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    try
                    {

                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];

                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;

                    }

                    catch
                    {

                        MessageBox.Show("Hata");

                    }

                }

            }
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            //KullaniciEkrani sayfasına git
            SatinAlmaGecmisi frm = new SatinAlmaGecmisi();
            frm.Show();
            this.Close();
        }
    }
}
