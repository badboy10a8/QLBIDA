using System.Data;
using System.Data.SqlClient;

namespace QLBIDA
{
    class Ketnoi
    {
            public SqlConnection Mycn = new SqlConnection();
            public void Connect()
            {

                string chuoikn = @"Data Source=QUANGVU-PC;Initial Catalog=QLBD;Integrated Security=True";
                Mycn.ConnectionString = chuoikn;
                if (Mycn.State != ConnectionState.Open)
                {
                    Mycn.Open();
                }
                else
                {
                    Mycn.Close();
                }
            }
        }
}
