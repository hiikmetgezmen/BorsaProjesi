using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaProjesi
{
    static class Program
    {
        public static string kullaniciadi { get; set; }
          public static string bakiye { get; set; }
        public static string onay { get; set; }
        //  , Soyad, Kullaniciadi, Sifre, Tckimlikno, Telefon, Email ,Adres;
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }



    }
}
