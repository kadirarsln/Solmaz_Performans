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
    public partial class FrmDigerDosyasi : Form
    {
        public FrmDigerDosyasi()
        {
            InitializeComponent();
        }
        SqlConnect sql = new SqlConnect();
        private void FrmDigerDosyasi_Load(object sender, EventArgs e)
        {
            DigerDosyasiListele();
        }

        void DigerDosyasiListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter(
                    "select top(5)[id],[Beyannameyi Açan],[Gün],[Ay],[Yıl],[Diğer Dosyası],[Departman],[Firma Ünvanı],[Tescil Tarih]from MT_Performans order by[Diğer Dosyası] DESC,[Beyannameyi Açan] ASC",
                    sql.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
    }
}

