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
    public partial class FrmAntrepoDosyasi : Form
    {
        public FrmAntrepoDosyasi()
        {
            InitializeComponent();
        }

        private SqlConnect sql = new SqlConnect();
        private void FrmAntrepoDosyasi_Load(object sender, EventArgs e)
        {
            AntrepoDosyasiListele();
        }

        void AntrepoDosyasiListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select top(5)[id],[Beyannameyi Açan],[Gün],[Ay],[Yıl],[Antrepo Dosyası],[Departman],[Firma Ünvanı],[Tescil Tarih]from MT_Performans order by[Antrepo Dosyası] DESC;", 
                sql.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
    }
}
