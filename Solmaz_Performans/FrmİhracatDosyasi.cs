using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Solmaz_Performans
{
    public partial class FrmİhracatDosyasi : Form
    {
        public FrmİhracatDosyasi()
        {
            InitializeComponent();
        }

        private SqlConnect sql = new SqlConnect();
        private void FrmİhracatDosyasi_Load(object sender, EventArgs e)
        {
            İhracatDosyasıListele();
        }

        void İhracatDosyasıListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter(
                    "select top(10)[id],[Beyannameyi Açan],[Gün],[Ay],[Yıl],[İhracat Dosyası],[Departman],[Firma Ünvanı],[Tescil Tarih]from MT_Performans order by[İhracat Dosyası] DESC,[Beyannameyi Açan] ASC",
                    sql.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
    }
}
