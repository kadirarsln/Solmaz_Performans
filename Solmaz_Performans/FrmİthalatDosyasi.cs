using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Solmaz_Performans
{
    public partial class FrmİthalatDosyasi : Form
    {
        public FrmİthalatDosyasi()
        {
            InitializeComponent();
        }
        SqlConnect sql = new SqlConnect();
        private void FrmİthalatDosyasi_Load(object sender, EventArgs e)
        {
            İthalatDosyasiListele();
        }
        void İthalatDosyasiListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select top(10)[id],[Beyannameyi Açan],[Gün],[Ay],[Yıl],[İthalat Dosyası],[Departman],[Firma Ünvanı],[Tescil Tarih]from MT_Performans order by[İthalat Dosyası] DESC,[Beyannameyi Açan] ASC ",
                sql.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
    }
}
