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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        /*public void ListDaotao()
        {
            using (Entities entity = new Entities())
            {
                List<Roles> rl = new List<Roles>();
                rl = entity.USERLOGINs.Select(x => new Roles
                {
                    UserName = x.username,
                    PassWord = x.passwords,
                    Role = x.roles
                }).ToList();
            }
        }*/

        private void btnDangky_Click(object sender, EventArgs e)
        {
            USERLOGIN userLog = new USERLOGIN();
            userLog.username = txtUser.Text;
            userLog.passwords = txtPass.Text;
            userLog.roles = null;

            using (Entities entity = new Entities())
            {
                bool userExit = entity.USERLOGINs.Any(x => x.username == userLog.username);
                if(userExit == true)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    entity.USERLOGINs.Add(userLog);
                    entity.SaveChanges();
                    MessageBox.Show("Successfully!", "Add", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Hide();
                    DangNhap frmLogin = new DangNhap();
                    frmLogin.ShowDialog();
                    this.Close();
                }
            }
            
        }
    }
}
