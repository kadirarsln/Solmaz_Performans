using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Solmaz_Performans
{
    public partial class FrmKalemSayisi : Form
    {
        public FrmKalemSayisi()
        {
            InitializeComponent();
        }

        SqlConnect sql = new SqlConnect();
        private void FrnKalemSayisi_Load(object sender, EventArgs e)
        {
            KalemSayisi();
        }

        void KalemSayisi()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter(
                    "select top(5)[id],[Beyannameyi Açan],[Gün],[Ay],[Yıl],[Kalem Sayısı],[Departman],[Firma Ünvanı],[Tescil Tarih]from MT_Performans order by [Kalem Sayısı] DESC;",
                    sql.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
    }
}
