using System;
using System.Data.SqlClient;

namespace Solmaz_Performans
{
    class SqlConnect
    {
        public SqlConnection Connection()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-C50QDN0\SQLEXPRESS;Initial Catalog=SolmazData;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
