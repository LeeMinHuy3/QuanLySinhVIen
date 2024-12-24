using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide1_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radPTB1.Checked = true;
            radPTB2.Checked = true;
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            

            if (radPTB1.Checked)
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                
                float d;
                if (a != 0)
                {
                    d = -b / a;
                    txtKetqua.Text = "PT co 1 nghiem la "+d.ToString();
                }
                else
                {
                    if(b != 0)
                    {
                        txtKetqua.Text = "PT vo nghiem";
                    }
                    else
                    {
                        txtKetqua.Text = "PT vo so nghiem";
                    }
                }
            }

            if (radPTB2.Checked)
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int c = int.Parse(txtC.Text);
                float d;
                if (a != 0)
                {
                    d = b * b - 4 * a * c;
                    float nghiem1;
                    float nghiem2;
                    if(d > 0)
                    {
                        nghiem1 = (float)((-b + Math.Sqrt(d)) / (2 * a));
                        nghiem2 = (float)((-b - Math.Sqrt(d)) / (2 * a));
                        txtKetqua.Text = nghiem1.ToString() + " " + nghiem2.ToString();
                    }else if(d == 0)
                    {
                        nghiem1 = -b / (2 * a);
                        txtKetqua.Text = nghiem1.ToString();
                    }
                    else
                    {
                        txtKetqua.Text = "PT vo nghiem";
                    }
                }
                else
                {
                    if (b != 0)
                    {
                        d = -c / b;
                        txtKetqua.Text = "PT co 1 nghiem la " + d.ToString();
                    }
                    else
                    {
                        if (c != 0)
                        {
                            txtKetqua.Text = "PT vo nghiem";
                        }
                        else
                        {
                            txtKetqua.Text = "PT vo so nghiem";
                        }
                    }
                }
            }
        }

        private void radPTB1_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Enabled = false;
        }

        private void radPTB2_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Enabled = true;
        }
    }
}
