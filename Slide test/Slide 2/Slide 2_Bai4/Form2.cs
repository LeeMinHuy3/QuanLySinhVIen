using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide_2
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        void tinh()
        {
            int a = int.Parse(txtChiSoCu.Text);
            int b = int.Parse(txtChiSoMoi.Text);
            int c = b - a;
            txtTieuThu.Text = c.ToString();
            if (c <= 50)
            {
                txtTongTien.Text = (c * 500).ToString();
                txtTrongDinhMuc.Text = c.ToString();
                txtVuotDinhMuc.Text = "";
            }
            else if (c > 50)
            {
                int d = c - 50;
                txtTongTien.Text = ((50 * 500) + (d * 1000)).ToString();
                txtTrongDinhMuc.Text = "50";
                txtVuotDinhMuc.Text = d.ToString();
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            tinh();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && txtChiSoCu.Text != "" && txtChiSoMoi.Text != "" && txtTongTien.Text != "")
            {
                txtThongTin.Text = comboBox1.Text + Environment.NewLine + "So kw tieu thu : " + txtTieuThu.Text +
                    Environment.NewLine + "Tong tien : " + txtTongTien.Text;
            }
            else
            {
                MessageBox.Show("Thieu thong tin");
            }
        }
    }
}
