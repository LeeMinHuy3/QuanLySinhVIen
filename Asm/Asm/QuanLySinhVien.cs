using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asm
{
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nu");
            Display();
        }

        public void Display()
        {
            using(Entities entity = new Entities())
            {
                List<StdInfo> stdList = new List<StdInfo>();
                stdList = entity.STUDENTs.Select(x => new StdInfo
                {
                    MaSV = x.MASV,
                    Ten = x.Hoten,
                    Email = x.Email,
                    Sdt = x.Sdt,
                    GioiTinh = x.Gioitinh,
                    DiaChi = x.Diachi
                }).ToList();
                dgvQuanLySV.DataSource = stdList;
            }
        }

        private void dgvQuanLySV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQuanLySV.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells[0].Value.ToString();
                txtTenSV.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtSdt.Text = row.Cells[3].Value.ToString();
                cboGioiTinh.SelectedItem = row.Cells[4].Value.ToString();
                txtDiaChi.Text = row.Cells[5].Value.ToString();
            }
        }

        public void clear()
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            cboGioiTinh.SelectedIndex = -1;
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            // Kiểm tra xem số điện thoại không được để trống
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Số điện thoại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra xem số điện thoại chỉ chứa số và bắt đầu bằng số 0
            if (!phoneNumber.StartsWith("0") || !phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0 và chỉ chứa các ký tự số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidateEmail(string email)
        {
            // Kiểm tra xem email không được để trống
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra xem email có kết thúc bằng "@gmail.com"
            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email phải kết thúc bằng '@gmail.com'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidateMASV(string masv)
        {
            // Kiểm tra xem chuỗi bắt đầu bằng 'pd' và theo sau 'pd' là chỉ chứa số
            if (!masv.StartsWith("pd"))
            {
                MessageBox.Show("Mã sinh viên phải bắt đầu bằng 'pd'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string numbers = masv.Substring(2); // Lấy phần số sau 'pd'
            if (!numbers.All(char.IsDigit))
            {
                MessageBox.Show("Sau 'pd' phải là các chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            if (!ValidateMASV(txtMaSV.Text))
                return;

            if (!ValidatePhoneNumber(txtSdt.Text))
                return;

            if (!ValidateEmail(txtEmail.Text))
                return;

            STUDENT info = new STUDENT();
            info.MASV = txtMaSV.Text;
            info.Hoten = txtTenSV.Text;
            info.Email = txtEmail.Text;
            info.Sdt = txtSdt.Text;
            info.Gioitinh = cboGioiTinh.SelectedItem + "";
            info.Diachi = txtDiaChi.Text;

            using(Entities entity = new Entities())
            {
                entity.STUDENTs.Add(info);
                entity.SaveChanges();
            }

            MessageBox.Show("Thêm sinh viên thành công!", "Add", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            clear();
            Display();
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            STUDENT info = new STUDENT();
            info.MASV = txtMaSV.Text;
            info.Hoten = txtTenSV.Text;
            info.Email = txtEmail.Text;
            info.Sdt = txtSdt.Text;
            info.Gioitinh = cboGioiTinh.SelectedItem.ToString();
            info.Diachi = txtDiaChi.Text;

            DialogResult result = MessageBox.Show("Bạn có muốn xóa sinh viên này không?", "Question", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (Entities entity = new Entities())
                {
                    STUDENT std = entity.STUDENTs.Where(x => x.MASV == info.MASV).
                        Select(x => x).FirstOrDefault();
                    entity.STUDENTs.Remove(std);
                    entity.SaveChanges();
                }
                MessageBox.Show("Xóa sinh viên thành công!", "Delete", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                clear();
                Display();
            }
        }

        private void btnCapNhatSV_Click(object sender, EventArgs e)
        {
            if (!ValidateMASV(txtMaSV.Text))
                return;

            if (!ValidatePhoneNumber(txtSdt.Text))
                return;

            if (!ValidateEmail(txtEmail.Text))
                return;

            STUDENT info = new STUDENT();
            info.MASV = txtMaSV.Text;
            info.Hoten = txtTenSV.Text;
            info.Email = txtEmail.Text;
            info.Sdt = txtSdt.Text;
            info.Gioitinh = cboGioiTinh.SelectedItem+ "";
            info.Diachi = txtDiaChi.Text;

            using (Entities entity = new Entities())
            {
                STUDENT std = entity.STUDENTs.Where(x => x.MASV == info.MASV).
                    Select(x => x).FirstOrDefault();
                std.Hoten = info.Hoten;
                std.Email = info.Email;
                std.Sdt = info.Sdt;
                std.Gioitinh = info.Gioitinh;
                std.Diachi = info.Diachi;
                entity.SaveChanges();
            }
            MessageBox.Show("Cập nhật sinh viên thành công!", "Update", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            clear();
            Display();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLySinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Hiển thị hộp thoại xác nhận trước khi tắt form
                DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
