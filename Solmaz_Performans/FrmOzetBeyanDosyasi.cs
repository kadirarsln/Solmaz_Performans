using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Solmaz_Performans
{
    public partial class FrmOzetBeyanDosyasi : Form
    {
        public FrmOzetBeyanDosyasi()
        {
            InitializeComponent();
        }
        SqlConnect sql = new SqlConnect();
        private void FrmOzetBeyanDosyasi_Load(object sender, EventArgs e)
        {
            OzetBeyanDosyasiListele();
        }

        void OzetBeyanDosyasiListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter(
                    "select top(5)[id],[Beyannameyi Açan],[Gün],[Ay],[Yıl],[Özetbeyan Dosya],[Departman],[Firma Ünvanı],[Tescil Tarih]from MT_Performans order by [Özetbeyan Dosya] DESC,[Beyannameyi Açan] ASC",
                    sql.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
    }
}
