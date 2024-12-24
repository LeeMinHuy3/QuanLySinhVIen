using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLSV
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=.;Initial Catalog=QLHOCSINH;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
}
