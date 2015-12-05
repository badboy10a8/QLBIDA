using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLBIDA
{
    class ketnoi
    {
            public SqlConnection mycn = new SqlConnection();
            public void connect()
            {

                string chuoikn = @"Data Source=QUANGVU-PC;Initial Catalog=QLBD;Integrated Security=True";
                mycn.ConnectionString = chuoikn;
                if (mycn.State != ConnectionState.Open)
                {
                    mycn.Open();
                }
                else
                {
                    mycn.Close();
                }
            }
        }
}
