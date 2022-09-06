using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Solmaz_Performans
{
    public partial class FrmNCTSDosyasi : Form
    {
        public FrmNCTSDosyasi()
        {
            InitializeComponent();
        }

        private SqlConnect sql = new SqlConnect();
        private void FrmNCTSDosyasi_Load(object sender, EventArgs e)
        {
            NCTSDosyasi();
        }
        void NCTSDosyasi()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select top(5)[id],[Beyannameyi Açan],[Gün],[Ay],[Yıl],[Ncts Dosyası],[Departman],[Firma Ünvanı],[Tescil Tarih]from MT_Performans order by[Ncts Dosyası] DESC; ", 
                sql.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
    }
}
