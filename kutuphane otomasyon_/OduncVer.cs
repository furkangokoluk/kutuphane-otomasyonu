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

namespace kutuphane_otomasyon_
{

    public partial class OduncVer : Form
    {
        FirebaseClient istemci;
        public OduncVer(FirebaseClient istemci)
        {
            this.istemci = istemci;
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

            uyeoduncDgw.DataSource = uyeler_table;
        }

        public async void kitap_listele()
        {
            IReadOnlyCollection<FirebaseObject<Kitap>> kitaplar = await istemci.Child("Kitaplar").OrderByKey().OnceAsync<Kitap>();

            DataTable kitaplar_table = new DataTable();

            kitaplar_table.Columns.Add("Kitap Türü", typeof(string));
            kitaplar_table.Columns.Add("Kitap Adı", typeof(string));


            foreach (FirebaseObject<Kitap> kitap in kitaplar)
            {
                kitaplar_table.Rows.Add(kitap.Key, kitap.Object.kitapAdi);
            }

            kitapoduncDgw.DataSource = kitaplar_table;
        }

        private void uyeoduncDgw_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            oduncuyenoTxt.Text = uyeoduncDgw.Rows[e.RowIndex].Cells["Kimlik No"].Value.ToString();
        }

        private void kitapoduncDgw_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            odunckitapTxt.Text = kitapoduncDgw.Rows[e.RowIndex].Cells["Kitap Adı"].Value.ToString();
        }



        private async void oduncverBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Odunc yeniodunc = new Odunc();
              //  yeniodunc.oduncUye = oduncuyenoTxt.Text;
                yeniodunc.oduncKitap = odunckitapTxt.Text;
                yeniodunc.oduncVerilis = verilistrhTxt.Text;
                yeniodunc.oduncTeslim = teslimtrhTxt.Text;

                await istemci.Child("Ödünçler").Child(oduncuyenoTxt.Text).PutAsync(yeniodunc);
                MessageBox.Show("Ödünç Verme İşlemi Başarıyla Tamamlandı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex.Message, "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
