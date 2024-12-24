using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide_6_Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Show();
        }

        public void Show()
        {
            using(CodeFirstContext codeFirst = new CodeFirstContext())
            {
                dataGridView1.DataSource = codeFirst.ThongTinSaches.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThongTinSach dsSach = new ThongTinSach();
            dsSach.MaSach = txtMaSach.Text;
            dsSach.TieuDe = txtTieuDe.Text;
            dsSach.Gia = int.Parse(txtGia.Text);
            dsSach.SoLuong = int.Parse(txtSoLuong.Text);

            CodeFirstContext objContext = new CodeFirstContext();
            objContext.ThongTinSaches.Add(dsSach);
            objContext.SaveChanges();
            MessageBox.Show("Added Successfully!", "Add", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            clear();
            Show();
        }

        public void clear()
        {
            txtMaSach.Text = "";
            txtTieuDe.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ThongTinSach dsSach = new ThongTinSach();
            dsSach.MaSach = txtMaSach.Text;
            dsSach.TieuDe = txtTieuDe.Text;
            dsSach.Gia = int.Parse(txtGia.Text);
            dsSach.SoLuong = int.Parse(txtSoLuong.Text);

            using(CodeFirstContext codeFirst = new CodeFirstContext())
            {
                ThongTinSach thongtins = codeFirst.ThongTinSaches.Where(x => x.MaSach == dsSach.MaSach).
                    Select(x => x).FirstOrDefault();
                thongtins.MaSach = dsSach.MaSach;
                thongtins.TieuDe = dsSach.TieuDe;
                thongtins.Gia = dsSach.Gia;
                thongtins.SoLuong = dsSach.SoLuong;
                codeFirst.SaveChanges();
            }
            MessageBox.Show("Updated successfully!", "Update", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            clear();
            Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTieuDe.Text = row.Cells[1].Value.ToString();
                txtGia.Text = row.Cells[2].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ThongTinSach dsSach = new ThongTinSach();
            dsSach.MaSach = txtMaSach.Text;
            dsSach.TieuDe = txtTieuDe.Text;
            dsSach.Gia = int.Parse(txtGia.Text);
            dsSach.SoLuong = int.Parse(txtSoLuong.Text);

            using (CodeFirstContext codeFirst = new CodeFirstContext())
            {
                ThongTinSach thongtins = codeFirst.ThongTinSaches.Where(x => x.MaSach == dsSach.MaSach).
                    Select(x => x).FirstOrDefault();
                codeFirst.ThongTinSaches.Remove(thongtins);
                codeFirst.SaveChanges();
            }
            MessageBox.Show("Deleted successfully!", "Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            clear();
            Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            clear();
        }

        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Muon thoat khong?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thoat == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
  