using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Solmaz_Performans
{
    public partial class FrmSBIFDosyasi : Form
    {
        public FrmSBIFDosyasi()
        {
            InitializeComponent();
        }

        private SqlConnect sql = new SqlConnect();
        private void FrmSBIFDosyasi_Load(object sender, EventArgs e)
        {
            SBIFDosyasiListele();
        }

        void SBIFDosyasiListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter(
                    "select top(10)[id],[Beyannameyi Açan],[Gün],[Ay],[Yıl],[SBIF Dosyası],[Departman],[Firma Ünvanı],[Tescil Tarih]from MT_Performans order by[SBIF Dosyası] DESC,[Beyannameyi Açan] ASC",
                    sql.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
            
        }
    }
}
