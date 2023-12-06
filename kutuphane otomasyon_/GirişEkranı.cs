using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using kutuphane_otomasyon_.Kontroller;
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
    public partial class GirisEkranı : Form
    {
        private string AuthDomain, ApiKey;
        private Config ayarlar;
        private KullaniciGiris user;
        private KullanıcıKayıt newUser;
        private FirebaseAuthClient client;
        public GirisEkranı(Config ayarlar)
        {
            InitializeComponent();

            this.AuthDomain = ayarlar.AuthDomain;
            this.ApiKey = ayarlar.ApiKey;
            this.ayarlar = ayarlar;

            user = new KullaniciGiris();
            newUser = new KullanıcıKayıt();

            GirisYapBtn_Click(this, EventArgs.Empty);

            this.user.girisBtn.Click += GirisBtn_Click;
            this.newUser.k_olusturBtn.Click += K_olusturBtn_Click;


            FirebaseAuthConfig config = new FirebaseAuthConfig
            {
                ApiKey = ApiKey,
                AuthDomain = AuthDomain,
                Providers = new FirebaseAuthProvider[]{new EmailProvider()},
               
            };

           this.client = new FirebaseAuthClient(config);
        }

        private async void GirisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                user.girisBtn.Enabled = false;
                user.girisPb.Visible = true;

                UserCredential kullanici_kimligi = await client.SignInWithEmailAndPasswordAsync(this.user.emailTxt.Text.Trim(),
                                                                                                this.user.sifreTxt.Text.Trim());

                this.Hide();

                AnaPencere anaPencere = new AnaPencere(kullanici_kimligi);
                anaPencere.Show();
            }

            catch (Exception exc) 
            {
                user.girisBtn.Enabled = true;
                user.girisPb.Visible = false;

                MessageBox.Show("Hata:" + exc.Message, "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                user.girisBtn.Enabled = true;
                user.girisPb.Visible = false;
            }
        }

        private async void K_olusturBtn_Click(object sender, EventArgs e)
        {
            if (newUser.yeniSifreTxt.Text == newUser.tyeniSifreTxt.Text)
            {
                try
                {
                    newUser.k_olusturBtn.Enabled = false;
                    newUser.kayitPb.Visible = true;

                    var kullanici_kimligi = await client.CreateUserWithEmailAndPasswordAsync(this.newUser.yeniEmailTxt.Text.Trim(),
                                                                                        this.newUser.yeniSifreTxt.Text.Trim());
                    MessageBox.Show("Kullancı Başarıyla Oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GirisYapBtn_Click(this, EventArgs.Empty);
                }

                catch (Exception exc)
                {
                    newUser.k_olusturBtn.Enabled = true;
                    newUser.kayitPb.Visible = false;

                    MessageBox.Show("Hata:" + exc.Message, "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    newUser.k_olusturBtn.Enabled = true;
                    newUser.kayitPb.Visible = false;
                }
            }

            else
                MessageBox.Show("Şifreler Eşleşmiyor!!!", "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void GirisYapBtn_Click(object sender, EventArgs e)
        {
            YeniKullanıcıBtn.ForeColor = Color.Black;
            YeniKullanıcıBtn.BackColor = Color.Gainsboro;
            GirisYapBtn.ForeColor = Color.Teal;
            GirisYapBtn.BackColor = Color.White;
            panel1.Controls.Clear();
            panel1.Controls.Add(user);
        }

        private void YeniKullanıcıBtn_Click(object sender, EventArgs e)
        {
            GirisYapBtn.ForeColor = Color.Black;
            GirisYapBtn.BackColor = Color.Gainsboro;
            YeniKullanıcıBtn.ForeColor = Color.Teal;
            YeniKullanıcıBtn.BackColor = Color.White;
            panel1.Controls.Clear();
            panel1.Controls.Add(newUser);
        }
    }
}
