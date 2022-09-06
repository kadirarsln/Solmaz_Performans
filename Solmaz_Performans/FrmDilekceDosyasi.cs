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
    public partial class FrmDilekceDosyasi : Form
    {
        public FrmDilekceDosyasi()
        {
            InitializeComponent();
        }

        private SqlConnect sql = new SqlConnect();
        private void FrmDilekceDosyasi_Load(object sender, EventArgs e)
        {
            DilekceDosyasiListele();
        }

        void DilekceDosyasiListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter(
                    "select top(38) [id],[Beyannameyi Açan],[Gün],[Ay],[Yıl],[Dilekçe Dosya],[Departman],[Firma Ünvanı],[Tescil Tarih]from MT_Performans order by [Dilekçe Dosya] DESC, [Beyannameyi Açan] ASC",
                    sql.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
    }
}
