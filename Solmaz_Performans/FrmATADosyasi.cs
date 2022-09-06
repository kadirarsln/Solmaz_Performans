using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Solmaz_Performans
{
    public partial class FrmATADosyasi : Form
    {
        public FrmATADosyasi()
        {
            InitializeComponent();
        }

        SqlConnect sql = new SqlConnect();
        private void FrmATADosyasi_Load(object sender, EventArgs e)
        {
            ATADosyasiListele();
        }

        void ATADosyasiListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter(
                    "select top(10)[id],[Beyannameyi Açan],[Gün],[Ay],[Yıl],[ATA Dosyası],[Departman],[Firma Ünvanı],[Tescil Tarih]from MT_Performans order by[ATA Dosyası] DESC,[Beyannameyi Açan] ASC",
                    sql.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
    }
}
