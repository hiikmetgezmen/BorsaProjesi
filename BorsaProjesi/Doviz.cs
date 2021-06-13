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
using System.Xml;

namespace BorsaProjesi
{
    public partial class Doviz : Form
    {
        public Doviz()
        {
            InitializeComponent();
        }

        public double toplam = 0,komisyon=0;
        public void DovizGoster()
        {
            try
            {
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
                
                if(comboBox1.SelectedItem == "USD")
                {
                    decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                    ParaBirimi.Text = comboBox1.SelectedItem.ToString();
                    guncel.Text = dolar.ToString();
                    //Program.parabirimi = dolar.ToString();
                   
                }
                else if(comboBox1.SelectedItem=="EUR")
                {
                    decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
                    ParaBirimi.Text = comboBox1.SelectedItem.ToString();
                    guncel.Text = euro.ToString();
                   // Program.parabirimi = guncel.Text;
                }
                else if (comboBox1.SelectedItem == "GBP")
                {
                    decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));
                    ParaBirimi.Text = comboBox1.SelectedItem.ToString();
                    guncel.Text = sterlin.ToString();
                   
                } 
                    Program.parabirimi = guncel.Text;
                if(Miktar.Text != "" && Program.parabirimi != "")
                {
                    toplam = double.Parse(Miktar.Text) * double.Parse(Program.parabirimi);
                    komisyon = toplam * 0.01;
                    Komisyon.Text = komisyon.ToString();
                    toplam -= komisyon;
                    Toplam.Text = toplam.ToString();
                    Program.doviz = toplam.ToString();
                }
            }
            catch (XmlException xml)
            {
                timer1.Stop();
                MessageBox.Show(xml.ToString());
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
                timer1.Interval = 5000;
                DovizGoster();
        }

        private void Doviz_Load(object sender, EventArgs e)
        {
                timer1.Start();
        }

      

        private void GeriDon_Click_1(object sender, EventArgs e)
        {
            //KullaniciEkrani sayfasına git
            Bakiye frm = new Bakiye();
            frm.Show();
            this.Close();
        }

        private void ParaEkle_Click_1(object sender, EventArgs e)
        {
            //Veritabanını tanımla
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = vt.mdb");
            baglanti.Open();
            if(Miktar.Text !="" && comboBox1.Text != "")
            {
            //Bakiye onayı istemek için eklenen parayı güncelle eğer onay'ı 0'a eşitleyerek admin onayı istedik
            OleDbCommand guncelle = new OleDbCommand("update kullanicibilgi set onay=0,eklenenpara=@eklenenpara where kullaniciadi='" + Program.kullaniciadi + "'", baglanti);
            guncelle.Parameters.AddWithValue("@eklenenpara", Program.doviz);//eklenen paraya textbox'taki değeri ata
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("%1 komisyon kesildi.");
            MessageBox.Show("Admin onayı bekleniyor...");
            //KullaniciEkrani sayfasına git
            KullaniciEkrani frm = new KullaniciEkrani();
            frm.Show();
            this.Close();
            }
            else
            {
            MessageBox.Show("Boş kutu bırakmayınız..");
            }

        }
      
    }
}
