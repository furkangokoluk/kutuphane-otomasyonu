using Firebase.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database.Query;
using Firebase.Auth;
using Firebase.Storage;
using System.Net;
using System.IO;

namespace kutuphane_otomasyon_
{
    public partial class Uyeİslemleri : Form
    {
        FirebaseClient istemci;
        private UserCredential kimlik;
        FirebaseStorage firebase_depolama;
        private Config ayarlar;
        private int secili_id = -1;
        public Uyeİslemleri(FirebaseClient istemci, UserCredential kullanici_kimligi)
        {
            this.istemci = istemci;
            this.kimlik = kullanici_kimligi;
            ayarlar = new Config();

            firebase_depolama = new FirebaseStorage(ayarlar.FireStorageDomain, new FirebaseStorageOptions
            {
                AuthTokenAsyncFactory = () => kimlik.User.GetIdTokenAsync(),
                ThrowOnCancel = true,
            });

            InitializeComponent();
        }


        public async void uye_listele()
        {
            IReadOnlyCollection<FirebaseObject<Uye>> uyeler = await istemci.Child("Üyeler").OrderByKey().OnceAsync<Uye>();

            DataTable uyeler_table = new DataTable();

            uyeler_table.Columns.Add("Kimlik No", typeof(string));
            uyeler_table.Columns.Add("Adı", typeof(string));
            uyeler_table.Columns.Add("Soyadı", typeof(string));
            uyeler_table.Columns.Add("Tel No", typeof(string));

            foreach (FirebaseObject<Uye> uye in uyeler)
            {
                uyeler_table.Rows.Add(uye.Key, uye.Object.uyeAdi, uye.Object.uyeSoyadi, uye.Object.telNo);
            }

            uyelisteleDgw.DataSource = uyeler_table;
        }


        private void uyeislemMs_Opening(object sender, CancelEventArgs e)
        {
            int x = uyeislemMs.Bounds.Location.X - this.Location.X - uyelisteleDgw.Location.X - 9;
            int y = uyeislemMs.Bounds.Location.Y - this.Location.Y - uyelisteleDgw.Location.Y - 29;

            secili_id = uyelisteleDgw.HitTest(x, y).RowIndex;
            
            uyelisteleDgw.ClearSelection();
            uyelisteleDgw.Rows[secili_id].Selected = true;
        }

        private async void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (secili_id != -1)
            {
                int selected = secili_id;
                string kmlkno = uyelisteleDgw.Rows[selected].Cells["Kimlik No"].Value.ToString();
                string ad = uyelisteleDgw.Rows[selected].Cells["Adı"].Value.ToString();
                string soyad = uyelisteleDgw.Rows[selected].Cells["Soyadı"].Value.ToString();
                string telno = uyelisteleDgw.Rows[selected].Cells["Tel No"].Value.ToString();

                UyeEkleDuzenle uyeDuzenle = new UyeEkleDuzenle(istemci, kimlik);
                uyeDuzenle.adTxt.Text = ad;
                uyeDuzenle.soyadTxt.Text = soyad;
                uyeDuzenle.kimliknoTxt.Text = kmlkno;
                uyeDuzenle.telnoTxt.Text = telno;

                uyeDuzenle.Text = "Üye Bilgilerini Güncelle";
                uyeDuzenle.uyeekleBtn.Text = "Güncelle";

                try
                {
                    string resim_url = await firebase_depolama.Child("ÜyeProfilResimleri")
                                                      .Child(kmlkno)
                                                      .Child("profil.png").GetDownloadUrlAsync();

                    WebClient webistemci = new WebClient();
                    Stream raw_dosya = webistemci.OpenRead(resim_url);
                    Bitmap resim = new Bitmap(raw_dosya);
                    uyeDuzenle.uyeresimPb.Image = resim;

                    raw_dosya.Flush();
                    raw_dosya.Close();
                    istemci.Dispose();

                }
                catch (Exception ex) { }
                finally
                {
                    uyeDuzenle.ShowDialog();
                    uye_listele();
                    uyeDuzenle.Close();
                }
            }
        }

        private async void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (secili_id != -1)
            {
                int selected = secili_id;
                string kmlkno = uyelisteleDgw.Rows[selected].Cells["Kimlik No"].Value.ToString();
                string ad = uyelisteleDgw.Rows[selected].Cells["Adı"].Value.ToString();
                string soyad = uyelisteleDgw.Rows[selected].Cells["Soyadı"].Value.ToString();
                string telno = uyelisteleDgw.Rows[selected].Cells["Tel No"].Value.ToString();

                string mesaj = String.Format("{0} Kimlik Numaralı, {1} {2} İsimli Üyeyi Silmek İstediğinizden Eminmisiniz?!",kmlkno,ad, soyad);

                if(MessageBox.Show(mesaj, "DİKKAT" , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        string resim_url = await firebase_depolama.Child("ÜyeProfilResimleri")
                                                                  .Child(kmlkno)
                                                                  .Child("profil.png").GetDownloadUrlAsync();
                        await firebase_depolama.Child("ÜyeProfilResimleri")
                                               .Child(kmlkno)
                                               .Child("profil.png").DeleteAsync();
                    }
                    catch
                    {
                        await istemci.Child("Üyeler").Child(kmlkno).DeleteAsync();
                        uye_listele();

                        MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
