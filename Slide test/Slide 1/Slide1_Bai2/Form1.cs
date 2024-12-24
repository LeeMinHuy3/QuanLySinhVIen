using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide1_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radUCLN.Checked = true;
            radBCNN.Checked = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            if (radUCLN.Checked)
            {
                while(a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
                txtKetqua.Text = a.ToString();
            }

            if (radBCNN.Checked)
            {
                int c = a * b;
                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
                int bcnn = c / a;
                txtKetqua.Text = bcnn.ToString();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKetqua.Text = "";
        }
    }
}
