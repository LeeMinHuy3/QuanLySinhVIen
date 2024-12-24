using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide_7
{
    public partial class Form1 : Form
    {
        BUS_ThanhVien busTV = new BUS_ThanhVien();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text != "" && txtTen.Text != "" && txtSdt.Text != "")
            {
                DTO_ThanhVien tv = new DTO_ThanhVien(0, txtTen.Text, txtSdt.Text, txtEmail.Text);
                if (busTV.themThanhVien(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridView1.DataSource = busTV.getThanhVien();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busTV.getThanhVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                if(txtEmail.Text != "" && txtSdt.Text != "" && txtTen.Text != "")
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    int ID = int.Parse(row.Cells[0].Value.ToString());

                    DTO_ThanhVien tv = new DTO_ThanhVien(ID, txtTen.Text, txtSdt.Text, txtEmail.Text);

                    if (busTV.suaThanhVien(tv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dataGridView1.DataSource = busTV.getThanhVien();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sữa");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            txtTen.Text = row.Cells[1].Value.ToString();
            txtSdt.Text = row.Cells[2].Value.ToString();
            txtEmail.Text = row.Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int ID = int.Parse(row.Cells[0].Value.ToString());
                if (busTV.xoaThanhVien(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridView1.DataSource = busTV.getThanhVien();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }
    }
}
