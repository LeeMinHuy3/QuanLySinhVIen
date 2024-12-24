using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = (float.Parse(txtSon.Text) * float.Parse(txtSom.Text)) + "";
        }

        private void txtSon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = (float.Parse(txtSon.Text) + float.Parse(txtSom.Text)) + "";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            txtSon.Text = "";
            txtSom.Text = "";
            txtKetQua.Text = "";
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = (float.Parse(txtSon.Text) - float.Parse(txtSom.Text)) + "";
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = (float.Parse(txtSon.Text) / float.Parse(txtSom.Text)) + "";
        }
    }
}
