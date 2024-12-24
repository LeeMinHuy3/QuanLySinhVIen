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

namespace Asm
{
    public partial class QuanLyDiem : Form
    {
        int grdList = -1;
        public QuanLyDiem()
        {
            InitializeComponent();
            Display();
            txtTiengAnh.Text = "0";
            txtTinHoc.Text = "0";
            txtGDTC.Text = "0";
            TinhDiem();
        }

        public void Display()
        {
            using(Entities entity = new Entities())
            {
                List<StdGrade> gradeList = new List<StdGrade>();
                /*gradeList = entity.GRADEs.Join(entity.STUDENTs,
                    x => x.MASV,
                    y => y.MASV,
                    (GRADE, STUDENT) => new
                    {
                        MaTim = STUDENT.MASV,
                        Tienganh = GRADE.Tienganh,
                        Tinhoc = GRADE.Tinhoc,
                        GDTC = GRADE.GDTC,
                        ID = GRADE.ID
                    }).Select(x => new StdGrade
                    {
                        MaSV = x.MaTim,
                        Id = x.ID,
                        TiengAnh = x.Tienganh,
                        TinHoc = x.Tinhoc,
                        Gdtc = x.GDTC
                    }).ToList();*/
                gradeList = entity.GRADEs.Select(x => new StdGrade
                {
                    Id = x.ID,
                    MaSV = x.MASV,
                    TiengAnh = x.Tienganh,
                    TinHoc = x.Tinhoc,
                    Gdtc = x.GDTC
                }).ToList();
                dgvQuanLyDiem.DataSource = gradeList;
            }
        }

        private void dgvQuanLyDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQuanLyDiem.Rows[e.RowIndex];
                lblID.Text = row.Cells[0].Value.ToString();
                txtTimMaSV.Text = row.Cells[1].Value.ToString();
                txtTiengAnh.Text = row.Cells[2].Value.ToString();
                txtTinHoc.Text = row.Cells[3].Value.ToString();
                txtGDTC.Text = row.Cells[4].Value.ToString();
                TinhDiem();
                grdList = e.RowIndex;
            }
        }

        public void clear()
        {
            lblID.Text = "";
            txtTimMaSV.Text = "";
            txtTiengAnh.Text = "";
            txtTinHoc.Text = "";
            txtGDTC.Text = "";
            lblDiemTB.Text = "";
        }

        public double TinhDiem()
        {
            double diemAnh = double.Parse(txtTiengAnh.Text);
            double diemTin = double.Parse(txtTinHoc.Text);
            double diemGD = double.Parse(txtGDTC.Text);
            double diemTB = (diemAnh + diemTin + diemGD) / 3;
            lblDiemTB.Text = diemTB.ToString();
            return diemTB;
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

        private void btnThemDiem_Click(object sender, EventArgs e)
        {
            if (!ValidateMASV(txtTimMaSV.Text))
                return;

            GRADE grd = new GRADE();
            grd.MASV = txtTimMaSV.Text;
            try
            {
                if(double.Parse(txtTiengAnh.Text) >= 0 && double.Parse(txtTiengAnh.Text) <= 10
                    && double.Parse(txtTinHoc.Text) >= 0 && double.Parse(txtTinHoc.Text) <= 10
                    && double.Parse(txtGDTC.Text) >= 0 && double.Parse(txtGDTC.Text) <= 10)
                {
                    grd.Tienganh = double.Parse(txtTiengAnh.Text);
                    grd.Tinhoc = double.Parse(txtTinHoc.Text);
                    grd.GDTC = double.Parse(txtGDTC.Text);
                }
                else
                {
                    MessageBox.Show("Điểm số phải nhập từ 0 tới 10!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Điểm số phải nhập bằng số!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }
            

            using (Entities entity = new Entities())
            {
                var stdExit = entity.STUDENTs.Where(x => x.MASV == grd.MASV).FirstOrDefault();
                if (stdExit != null)
                {
                    var gradeExit = entity.GRADEs.Where(x => x.MASV == grd.MASV).FirstOrDefault();
                    if (gradeExit == null)
                    {
                        entity.GRADEs.Add(grd);
                        entity.SaveChanges();
                        MessageBox.Show("Thêm sinh viên thành công!", "Add", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        TinhDiem();
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên đã có điểm!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sinh viên không tồn tại! Hãy thêm sinh viên", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }

            clear();
            Display();
        }

        private void btnXoaDiem_Click(object sender, EventArgs e)
        {
            if (!ValidateMASV(txtTimMaSV.Text))
                return;

            GRADE grd = new GRADE();
            grd.MASV = txtTimMaSV.Text;
            grd.Tienganh = double.Parse(txtTiengAnh.Text);
            grd.Tinhoc = double.Parse(txtTinHoc.Text);
            grd.GDTC = double.Parse(txtGDTC.Text);

            using (Entities entity = new Entities())
            {
                GRADE std = entity.GRADEs.Where(x => x.MASV == grd.MASV).
                    Select(x => x).FirstOrDefault();
                entity.GRADEs.Remove(std);
                entity.SaveChanges();
            }
            MessageBox.Show("Xóa sinh viên thành công!", "Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            clear();
            Display();
        }

        private void btnCapNhatDiem_Click(object sender, EventArgs e)
        {
            if (!ValidateMASV(txtTimMaSV.Text))
                return;

            GRADE grd = new GRADE();
            grd.MASV = txtTimMaSV.Text;
            try
            {
                if (double.Parse(txtTiengAnh.Text) >= 0 && double.Parse(txtTiengAnh.Text) <= 10
                    && double.Parse(txtTinHoc.Text) >= 0 && double.Parse(txtTinHoc.Text) <= 10
                    && double.Parse(txtGDTC.Text) >= 0 && double.Parse(txtGDTC.Text) <= 10)
                {
                    grd.Tienganh = double.Parse(txtTiengAnh.Text);
                    grd.Tinhoc = double.Parse(txtTinHoc.Text);
                    grd.GDTC = double.Parse(txtGDTC.Text);
                }
                else
                {
                    MessageBox.Show("Điểm số phải nhập từ 0 tới 10!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Điểm số phải nhập bằng số!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }

            using (Entities entity = new Entities())
            {
                GRADE std = entity.GRADEs.Where(x => x.MASV == grd.MASV).
                    Select(x => x).FirstOrDefault();
                std.Tienganh = grd.Tienganh;
                std.Tinhoc = grd.Tinhoc;
                std.GDTC = grd.GDTC;
                entity.SaveChanges();
            }
            MessageBox.Show("Cập nhật sinh viên thành công", "Update", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            clear();
            Display();
        }

        private void btnTimMaSV_Click(object sender, EventArgs e)
        {
            if (!ValidateMASV(txtTimMaSV.Text))
                return;
            GRADE grd = new GRADE();
            grd.MASV = txtTimMaSV.Text;

            using(Entities entity = new Entities())
            {
                var stdExit = entity.STUDENTs.Where(x => x.MASV == grd.MASV).FirstOrDefault();
                if(stdExit != null)
                {
                    var gradeExit = entity.GRADEs.Where(x => x.MASV == grd.MASV).FirstOrDefault();
                    if (gradeExit != null)
                    {
                        lblID.Text = gradeExit.ID.ToString();
                        txtTiengAnh.Text = gradeExit.Tienganh.ToString();
                        txtTinHoc.Text = gradeExit.Tinhoc.ToString();
                        txtGDTC.Text = gradeExit.GDTC.ToString();
                        TinhDiem();
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên chưa có điểm! Hãy thêm điểm", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sinh viên không tồn tại! Hãy thêm sinh viên", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            

            /*string MaTim = txtTimMaSV.Text;
            DataGridViewRow tim = null;
            foreach(DataGridViewRow row in dgvQuanLyDiem.Rows)
            {
                if(row.Cells[1].Value != null && row.Cells[1].Value.ToString() == MaTim)
                {
                    tim = row;
                    break;
                }
            }

            if(tim != null)
            {
                lblID.Text = tim.Cells[1].Value.ToString();
                txtTiengAnh.Text = tim.Cells[2].Value.ToString();
                txtTinHoc.Text = tim.Cells[3].Value.ToString();
                txtGDTC.Text = tim.Cells[4].Value.ToString();
                int rowIndex = tim.Index;
                int colIndex = 1;
                dgvQuanLyDiem.CurrentCell = dgvQuanLyDiem.Rows[rowIndex].Cells[colIndex];
            }
            else
            {
                MessageBox.Show("Không thấy sinh viên");
            }*/
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void QuanLyDiem_FormClosing(object sender, FormClosingEventArgs e)
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

        private void next_Click(object sender, EventArgs e)
        {
            
            using(Entities entity = new Entities())
            {
                var stdList = entity.GRADEs.ToList();
                if(grdList < stdList.Count - 1)
                {
                    grdList++;
                    DataGridViewRow row = dgvQuanLyDiem.Rows[grdList];
                    lblID.Text = row.Cells[0].Value.ToString();
                    txtTimMaSV.Text = row.Cells[1].Value.ToString();
                    txtTiengAnh.Text = row.Cells[2].Value.ToString();
                    txtTinHoc.Text = row.Cells[3].Value.ToString();
                    txtGDTC.Text = row.Cells[4].Value.ToString();
                    TinhDiem();
                    dgvQuanLyDiem.CurrentCell = dgvQuanLyDiem.Rows[grdList].Cells[0];
                }
                else
                {
                    MessageBox.Show("Cuối danh sách!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
        }

        private void last_Click(object sender, EventArgs e)
        {
            using (Entities entity = new Entities())
            {
                var stdList = entity.GRADEs.ToList();
                grdList = stdList.Count - 1;
                DataGridViewRow row = dgvQuanLyDiem.Rows[grdList];
                lblID.Text = row.Cells[0].Value.ToString();
                txtTimMaSV.Text = row.Cells[1].Value.ToString();
                txtTiengAnh.Text = row.Cells[2].Value.ToString();
                txtTinHoc.Text = row.Cells[3].Value.ToString();
                txtGDTC.Text = row.Cells[4].Value.ToString();
                TinhDiem();
                dgvQuanLyDiem.CurrentCell = dgvQuanLyDiem.Rows[grdList].Cells[0];
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            using (Entities entity = new Entities())
            {
                var stdList = entity.GRADEs.ToList();
                if (grdList > 0)
                {
                    grdList--;
                    DataGridViewRow row = dgvQuanLyDiem.Rows[grdList];
                    lblID.Text = row.Cells[0].Value.ToString();
                    txtTimMaSV.Text = row.Cells[1].Value.ToString();
                    txtTiengAnh.Text = row.Cells[2].Value.ToString();
                    txtTinHoc.Text = row.Cells[3].Value.ToString();
                    txtGDTC.Text = row.Cells[4].Value.ToString();
                    TinhDiem();
                    dgvQuanLyDiem.CurrentCell = dgvQuanLyDiem.Rows[grdList].Cells[0];
                }
                else
                {
                    MessageBox.Show("Đầu danh sách!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
        }

        private void top_Click(object sender, EventArgs e)
        {
            using (Entities entity = new Entities())
            {
                grdList = 0;
                DataGridViewRow row = dgvQuanLyDiem.Rows[grdList];
                lblID.Text = row.Cells[0].Value.ToString();
                txtTimMaSV.Text = row.Cells[1].Value.ToString();
                txtTiengAnh.Text = row.Cells[2].Value.ToString();
                txtTinHoc.Text = row.Cells[3].Value.ToString();
                txtGDTC.Text = row.Cells[4].Value.ToString();
                TinhDiem();
                dgvQuanLyDiem.CurrentCell = dgvQuanLyDiem.Rows[grdList].Cells[0];
            }
        }
    }
}
