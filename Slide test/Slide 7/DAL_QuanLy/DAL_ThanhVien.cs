using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
    public class DAL_ThanhVien : DBConnect
    {
        public DataTable getThanhVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from thanhvien", conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }

        public bool themThanhVien(DTO_ThanhVien tv)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("insert into thanhvien(TV_Name, TV_Phone, TV_Email) values" +
                    "('{0}', '{1}', '{2}')", tv.ThanhVien_Name, tv.ThanhVien_Phone, tv.ThanhVien_Email);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool suaThanhVien(DTO_ThanhVien tv)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("update thanhvien set TV_Name = '{0}', TV_Phone = '{1}'," +
                    " TV_Phone = '{2}' where TV_ID = {3}", tv.ThanhVien_Name, tv.ThanhVien_Phone, 
                    tv.ThanhVien_Email, tv.ThanhVien_ID);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool xoaThanhVien(int TV_ID)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("delete from thanhvien where TV_ID = {0}", TV_ID);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
