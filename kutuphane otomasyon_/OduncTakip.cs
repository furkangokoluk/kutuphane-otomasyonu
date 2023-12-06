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
    public partial class OduncTakip : Form
    {
        FirebaseClient istemci;
        public OduncTakip(FirebaseClient istemci)
        {
            this.istemci = istemci;
            InitializeComponent();
        }

        public async void odunc_listele()
        {
            IReadOnlyCollection<FirebaseObject<Odunc>> oduncler = await istemci.Child("Ödünçler").OrderByKey().OnceAsync<Odunc>();

            DataTable oduncler_table = new DataTable();

            oduncler_table.Columns.Add("Üye Kimlik No", typeof(string));
            oduncler_table.Columns.Add("Kitap Adı", typeof(string));
            oduncler_table.Columns.Add("Veriliş Tarihi", typeof(string));
            oduncler_table.Columns.Add("Teslim Tarihi", typeof(string));

            foreach (FirebaseObject<Odunc> odunc in oduncler)
            {
                oduncler_table.Rows.Add( odunc.Key, odunc.Object.oduncKitap, odunc.Object.oduncVerilis, odunc.Object.oduncTeslim);
            }

            odunctakipDgw.DataSource = oduncler_table;
        }
    }
}
