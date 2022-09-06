using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Solmaz_Performans
{
    public partial class FrmListele : Form
    {
        public FrmListele()
        {
            InitializeComponent();
        }

        SqlConnect sql = new SqlConnect();
        private void FrmListele_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From MT_Performans ", sql.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
    }
}
