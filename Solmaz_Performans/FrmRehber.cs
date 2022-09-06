using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Solmaz_Performans
{
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }

        private SqlConnect sql = new SqlConnect();
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            RehberListele();
        }

        void RehberListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select distinct [Departman],[Firma Ünvanı] from MT_Performans order by[Firma Ünvanı] ASC ",
                sql.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
    }
}
