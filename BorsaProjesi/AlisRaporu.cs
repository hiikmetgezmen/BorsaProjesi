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
            DataSet dt = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("Select tarih,urunadi,fiyat,miktar from fatura where tarih between @tarih1 and @tarih2 and alici='" + Program.kullaniciadi + "'", baglanti);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", dateTimePicker1.Value.ToString("d.MM.yyyy"));
            da.SelectCommand.Parameters.AddWithValue("@tarih2", dateTimePicker2.Value.ToString("d.MM.yyyy"));
           
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void indir_Click(object sender, EventArgs e)
        {


                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                for (i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dataGridView1[j, i];
                        xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                }

                xlWorkBook.SaveAs("csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                MessageBox.Show("Excel file created , you can find the file c:\\csharp.net-informations.xls");
            }

            private void releaseObject(object obj)
            {
                try
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                    obj = null;
                }
                catch (Exception ex)
                {
                    obj = null;
                    MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
                }
                finally
                {
                    GC.Collect();
                }
            }
        }
}
