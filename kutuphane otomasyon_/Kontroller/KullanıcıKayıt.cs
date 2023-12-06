using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyon_.Kontroller
{
    public partial class KullanıcıKayıt : UserControl
    {
        public KullanıcıKayıt()
        {
            InitializeComponent();
        }

        private void yeniGosterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (yeniGosterCb.Checked)
                yeniSifreTxt.PasswordChar = '\0';
            else
                yeniSifreTxt.PasswordChar = '*';
        }

        private void tYeniGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (tYeniGoster.Checked)
                tyeniSifreTxt.PasswordChar = '\0';
            else
                tyeniSifreTxt.PasswordChar = '*';
        }
    }
}
