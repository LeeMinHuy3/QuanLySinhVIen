using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide_6_Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Company objCompany = new Company();
            objCompany.CompanyId = txtId.Text;
            objCompany.Name = txtName.Text;

            CodeFirstContext objContext = new CodeFirstContext();
            objContext.Companies.Add(objCompany);
            objContext.SaveChanges();
        }
    }
}
