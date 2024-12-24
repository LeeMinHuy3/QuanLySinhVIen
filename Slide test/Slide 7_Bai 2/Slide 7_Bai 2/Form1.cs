using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactServices;

namespace Slide_7_Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ContactServices.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(AddEditContact frm = new AddEditContact(null))
            {
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.DataSource = Form1.GetAll();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(contactBindingSource.Current == null)
            {
                return;
            }
        }
    }
}
