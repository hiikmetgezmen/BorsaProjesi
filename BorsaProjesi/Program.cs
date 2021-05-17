using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaProjesi
{
    static class Program
    {
        //Program boyunca kullanabileceğim veriler
        public static string kullaniciadi { get; set; }
        public static string bakiyee { get; set; }
        public static string eklenenpara { get; set; }
        public static string urunsahibi { get; set; }
        public static string urun { get; set; }
        public static string fiyat { get; set; }
        public static string miktar { get; set; }
        public static string para { get; set; }
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
