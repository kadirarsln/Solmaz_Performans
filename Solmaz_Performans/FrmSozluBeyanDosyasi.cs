using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Solmaz_Performans
{
    public partial class FrmSozluBeyanDosyasi : Form
    {
        public FrmSozluBeyanDosyasi()
        {
            InitializeComponent();
        }

        private SqlConnect sql = new SqlConnect();
        private void FrmSozluBeyanDosyasi_Load(object sender, EventArgs e)
        {
            SozluBeyanDosyasiListele();
        }

        void SozluBeyanDosyasiListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter(
                    "select top(5)[id],[Beyannameyi Açan],[Gün],[Ay],[Yıl],[Sözlü Beyan Dosya],[Departman],[Firma Ünvanı],[Tescil Tarih]from MT_Performans order by[Sözlü Beyan Dosya] DESC,[Beyannameyi Açan] ASC",
                    sql.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
    }
}
