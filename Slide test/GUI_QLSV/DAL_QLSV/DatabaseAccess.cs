using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLSV
{
    public class DatabaseAccess
    {
        public static string CheckLogicDTO(TaiKhoan taiKhoan)
        {
            string user = null;
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", taiKhoan.sTaiKhoan);
            cmd.Parameters.AddWithValue("@pass", taiKhoan.sMatKhau);

            cmd.Connection = conn;
            SqlDataReader
        }
    }
}
