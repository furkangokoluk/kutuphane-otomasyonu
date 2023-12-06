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


namespace kutuphane_otomasyon_
{
    public partial class KitaplariGor : Form
    {
        FirebaseClient istemci;
        private UserCredential kimlik;
        private int secili_id = -1;
        public KitaplariGor(FirebaseClient istemci, UserCredential kimlik)
        {
            this.istemci = istemci;
            InitializeComponent();
            this.kimlik = kimlik;
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

            kitaplisteleDgw.DataSource = kitaplar_table;
        }

        private void kitapgörMs_Opening(object sender, CancelEventArgs e)
        {
            int x = kitapgörMs.Bounds.Location.X - this.Location.X - kitaplisteleDgw.Location.X - 9;
            int y = kitapgörMs.Bounds.Location.Y - this.Location.Y - kitaplisteleDgw.Location.Y - 29;

            secili_id = kitaplisteleDgw.HitTest(x, y).RowIndex;

            kitaplisteleDgw.ClearSelection();
            kitaplisteleDgw.Rows[secili_id].Selected = true;
        }

        private async void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (secili_id != -1)
            {
                int selected = secili_id;
                string kitaptürü = kitaplisteleDgw.Rows[selected].Cells["Kitap Türü"].Value.ToString();
                string kitapadı = kitaplisteleDgw.Rows[selected].Cells["Kitap Adı"].Value.ToString();


                KitapEkleDuzenle kitapDuzenle = new KitapEkleDuzenle(istemci, kimlik);
                kitapDuzenle.kitaptürüTxt.Text = kitaptürü;
                kitapDuzenle.kitapadıTxt.Text = kitapadı;


                kitapDuzenle.Text = "Kitap Bilgilerini Güncelle";
                kitapDuzenle.kitapekleBtn.Text = "Güncelle";

                kitap_listele();
                kitapDuzenle.ShowDialog();
            }
            kitap_listele();
        }

        private async void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (secili_id != -1)
            {
                int selected = secili_id;
                string kitaptürü = kitaplisteleDgw.Rows[selected].Cells["Kitap Türü"].Value.ToString();
                string kitapadı = kitaplisteleDgw.Rows[selected].Cells["Kitap Adı"].Value.ToString();

                string mesaj = String.Format("{0} İsimli Kitabı Silmek İstediğinizden Eminmisiniz?!", kitapadı);

                if (MessageBox.Show(mesaj, "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                    await istemci.Child("Kitaplar").Child(kitaptürü).DeleteAsync();
                    kitap_listele();

                    MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}

