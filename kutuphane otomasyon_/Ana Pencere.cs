using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyon_
{

    public partial class AnaPencere : Form
    {
        private UserCredential kullanıcı_kimligi;
        private FirebaseClient firebaseIstemci;
        private Config ayarlar;
        public AnaPencere(UserCredential kullanici_kimligi)
        {
            InitializeComponent();
            ayarlar = new Config();

            this.kullanıcı_kimligi = kullanici_kimligi;

            this.Text = this.Text + " | " + kullanici_kimligi.User.Info.Email;

            try
            {
                firebaseIstemci = new FirebaseClient(ayarlar.FireBaseDomain,
                                                     new FirebaseOptions
                                                     {
                                                         AuthTokenAsyncFactory = () => kullanici_kimligi.User.GetIdTokenAsync()
                                                     });
            }
            catch(Exception exc) 
            {
                MessageBox.Show("Hata:" + exc.Message, "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnaPencere_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Kitap ekle
        private async void KitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkleDuzenle newkitap = new KitapEkleDuzenle(firebaseIstemci, kullanıcı_kimligi);
            newkitap.ShowDialog();
        }
        
        // Üye ekle
        private void uyeekleBtn_Click(object sender, EventArgs e)
        {
            UyeEkleDuzenle newuye = new UyeEkleDuzenle(firebaseIstemci, kullanıcı_kimligi);
            newuye.ShowDialog();
        }

        // Kitapları Gör
        private void ktplarıgörBtn_Click(object sender, EventArgs e)
        {
            KitaplariGor viewkitap = new KitaplariGor(firebaseIstemci, kullanıcı_kimligi);

            viewkitap.kitap_listele();         
            viewkitap.Show();
        }

        // Kullanıcı İşlemleri
        private void KullaniciIslemleriBtn_Click(object sender, EventArgs e)
        {
            Uyeİslemleri viewuye = new Uyeİslemleri(firebaseIstemci, kullanıcı_kimligi);
            viewuye.uye_listele();
            viewuye.Show();
        }

        // Ödünç Ver
        private void oduncverBtn_Click(object sender, EventArgs e)
        {
            OduncVer viewodunc = new OduncVer(firebaseIstemci);
            viewodunc.uye_listele();
            viewodunc.kitap_listele();
            viewodunc.Show();
        }

        // Ödünç Takip
        private void odunctakipBtn_Click(object sender, EventArgs e)
        {
            OduncTakip viewoduncler = new OduncTakip(firebaseIstemci);
            viewoduncler.odunc_listele();
            viewoduncler.Show();
        }
    }
}
