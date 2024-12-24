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

namespace Slide_3_Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listLop();
        }

        void listLop()
        {
            SqlConnection db = new SqlConnection(@"Data Source=.;Initial Catalog=QLHOCSINH;Integrated Security=True");
            db.Open();
            string dsLop = @"select MaLop from LOP";
            SqlCommand cmd = new SqlCommand(dsLop, db);
            SqlDataReader dtread = cmd.ExecuteReader();
            while (dtread.Read())
            {
                cboTenLop.Items.Add(dtread.GetString(0));
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string db = @"Data Source=.;Initial Catalog=QLHOCSINH;Integrated Security=True";
            string query = "select * from HOCSINH";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db);
            DataSet set = new DataSet();
            adapter.Fill(set, "HOCSINH");
            dataGridView1.DataSource = set.Tables["HOCSINH"];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string db = @"Data Source=.;Initial Catalog=QLHOCSINH;Integrated Security=True";
            string query = "select * from HOCSINH";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db);
            DataSet set = new DataSet();
            adapter.Fill(set, "HOCSINH");

            DataRow row = set.Tables["HOCSINH"].NewRow();
            row["MaHS"] = txtMaHS.Text;
            row["TenHS"] = txtTenHS.Text;
            row["NgaySinh"] = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            row["DiaChi"] = txtDiaChi.Text;
            row["DTB"] = txtDiem.Text;
            row["MaLop"] = cboTenLop.Text;
            set.Tables["HOCSINH"].Rows.Add(row);
            dataGridView1.DataSource = set.Tables["HOCSINH"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string db = @"Data Source=.;Initial Catalog=QLHOCSINH;Integrated Security=True";
            string query = "select * from HOCSINH";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db);
            DataSet set = new DataSet();
            adapter.Fill(set, "HOCSINH");

            DataRow row = set.Tables["HOCSINH"].NewRow();
            row["MaHS"] = txtMaHS.Text;
            row["TenHS"] = txtTenHS.Text;
            row["NgaySinh"] = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            row["DiaChi"] = txtDiaChi.Text;
            row["DTB"] = txtDiem.Text;
            row["MaLop"] = cboTenLop.Text;
            set.Tables["HOCSINH"].Rows.Add(row);

            //MessageBox.Show("Cap nhat thanh cong");
            dataGridView1.DataSource = set.Tables["HOCSINH"];
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string db = @"Data Source=.;Initial Catalog=QLHOCSINH;Integrated Security=True";
            string query = "select * from HOCSINH";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db);
            DataSet set = new DataSet();
            adapter.Fill(set, "HOCSINH");

            set.Tables["HOCSINH"].Rows[2].Delete();
            dataGridView1.DataSource = set.Tables["HOCSINH"];
        }
    }
}
