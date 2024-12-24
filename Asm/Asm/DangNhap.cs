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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string passWord = txtPass.Text;

            using (Entities entity = new Entities())
            {
                var user = entity.USERLOGINs.FirstOrDefault(x => x.username == userName);
                if (user != null)
                {
                    if (user.passwords == passWord)
                    {
                        string role = UserRole(userName);
                        switch (role)
                        {
                            case "Admin":
                                QuanLyDiem frmDiem = new QuanLyDiem();
                                frmDiem.Show();
                                QuanLySinhVien frmStd1 = new QuanLySinhVien();
                                frmStd1.Show();
                                break;
                            default:
                                QuanLySinhVien frmStd = new QuanLySinhVien();
                                frmStd.Show();
                                break;
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không đúng!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không đúng!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                
            }
        }

        public string UserRole(string userName)
        {
            using(Entities entity = new Entities())
            {
                var user = entity.USERLOGINs.FirstOrDefault(x => x.username == userName);
                if(user != null)
                {
                    return user.roles;
                }
            }
            return null;
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            DangKy frmSignUp = new DangKy();
            frmSignUp.ShowDialog();
        }
    }
}
