using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Slide_2;
using Slide_2_Bai2;
using Slide_2_Bai3;

namespace Slide_2_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bai1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void bai2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.Show();
        }

        private void bai3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            bai3.Show();
        }

        private void bai1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void bai2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
