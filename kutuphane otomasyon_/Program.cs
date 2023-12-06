using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace kutuphane_otomasyon_
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Config ayarlar = new Config();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GirisEkranı(ayarlar));
        }
    }
}
