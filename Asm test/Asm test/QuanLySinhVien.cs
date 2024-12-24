using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asm_test
{
    public partial class QuanLySinhVien : Form
    {
        string connString = "Data Source=.;Initial Catalog=FPL_DaoTao;Integrated Security=True";
        public QuanLySinhVien()
        {
            InitializeComponent();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nu");
            Display();
        }

        public void Display()
        {
            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string querry = "select * from student";
                SqlCommand cmd = new SqlCommand(querry, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvQuanLySV.DataSource = table;
            }
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string ten = txtTenSV.Text;
            string email = txtEmail.Text;
            string sdt = txtSdt.Text;
            string gioiTinh = cboGioiTinh.Items.ToString();
            string diaChi = txtDiaChi.Text;

            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "insert into student (MASV, Hoten, Email, Sdt, Gioitinh, Diachi)" +
                    "values (@MASV, @Hoten, @Email, @Sdt, @Gioitinh, @Diachi)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MASV", maSV);
                cmd.Parameters.AddWithValue("@Hoten", ten);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Sdt", sdt);
                cmd.Parameters.AddWithValue("@Gioitinh", gioiTinh);
                cmd.Parameters.AddWithValue("@Diachi", diaChi);
            }
            Display();
        }
    }
}
