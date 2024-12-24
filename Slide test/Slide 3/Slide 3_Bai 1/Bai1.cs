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

namespace Slide_3_Bai_1
{
    public partial class Bai1 : Form
    {

        public Bai1()
        {
            InitializeComponent();
            listLop();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                cboLop.Items.Add(dtread.GetString(0));
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHS.Text != "" && txtTenHS.Text != "" && txtDiaChi.Text != "" && cboLop.Text != "")
                {
                    SqlConnection db = new SqlConnection(@"Data Source=.;Initial Catalog=QLHOCSINH;Integrated Security=True");
                    db.Open();
                    string insertHS = @"insert into HOCSINH 
                    values('" + txtMaHS.Text + "','" + txtTenHS.Text + "','" + dtpNgaySinh.Value.ToString("yyyy/MM/dd") + "','" + txtDiaChi.Text + "','" + txtDiemTB.Text + "','" + cboLop.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(insertHS, db);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Thieu thong tin");
                }
            }
            catch
            {
                MessageBox.Show("Sai thong tin");
            }
        }

        private void btnLuuLH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLop.Text != "" &&  txtLop.Text != "" && txtSiSo.Text != "")
                {
                    SqlConnection db = new SqlConnection(@"Data Source=.;Initial Catalog=QLHOCSINH;Integrated Security=True");
                    db.Open();
                    string insertLop = @"insert into LOP values('" + txtMaLop.Text + "','" + txtLop.Text + "','" + txtSiSo.Text + "')";
                    SqlCommand cmd = new SqlCommand(insertLop, db);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Thieu thong tin");
                }
            }
            catch
            {
                MessageBox.Show("Sai thong tin");
            }
        }

        private void radHS_CheckedChanged(object sender, EventArgs e)
        {
            grpLop.Enabled = false;
            grpHS.Enabled = true;
        }

        private void radLop_CheckedChanged(object sender, EventArgs e)
        {
            grpHS.Enabled = false;
            grpLop.Enabled = true;
        }

        private void Bai1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHOCSINHDataSet1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter1.Fill(this.qLHOCSINHDataSet1.LOP);
            // TODO: This line of code loads data into the 'qLHOCSINHDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLHOCSINHDataSet.LOP);
            radHS.Checked = true;
            radLop.Checked = true;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lOPTableAdapter.FillBy(this.qLHOCSINHDataSet.LOP);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnXoaHS_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text != "" && txtTenHS.Text != "" && txtDiaChi.Text != "" && cboLop.Text != "")
            {
                SqlConnection db = new SqlConnection(@"Data Source=.;Initial Catalog=QLHOCSINH;Integrated Security=True");
                db.Open();
                string deleteHS = @"delete from HOCSINH
                        where MaHS = '" + txtMaHS.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = deleteHS;
                cmd.Connection = db;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Thieu thong tin");
            }
        }

        private void btnXoaLH_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text != "" && txtLop.Text != "" && txtSiSo.Text != "")
            {
                SqlConnection db = new SqlConnection(@"Data Source=.;Initial Catalog=QLHOCSINH;Integrated Security=True");
                db.Open();
                string deleteLop = @"delete from LOP
                        where MaLop = '" + txtMaLop.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = deleteLop;
                cmd.Connection = db;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Thieu thong tin");
            }
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lOPTableAdapter.FillBy1(this.qLHOCSINHDataSet.LOP);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lOPTableAdapter.FillBy2(this.qLHOCSINHDataSet.LOP);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
