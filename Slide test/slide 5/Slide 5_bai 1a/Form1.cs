using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide_5_bai_1a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            Display();
        }

        public void Display()
        {
            using(Entities _entity = new Entities())
            {
                List<StudentInformation> stdList = new List<StudentInformation>();
                stdList = _entity.StudentDetails.Select(x => new StudentInformation
                {
                    Id = x.Id,
                    Name = x.NameStd,
                    Age = x.Age,
                    City = x.City,
                    Gender = x.Gender
                }).ToList();
                dataGridView1.DataSource = stdList;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentDetail std = new StudentDetail();
            std.NameStd = txtName.Text;
            std.Age = int.Parse(txtAge.Text);
            std.City = txtCity.Text;
            std.Gender = cboGender.SelectedItem.ToString();

            using (Entities entity = new Entities())
            {
                entity.StudentDetails.Add(std);
                entity.SaveChanges();
            }

            MessageBox.Show("Saved Successfully!", "Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            ClearField();
            Display();
        }

        public void ClearField()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtCity.Text = "";
            cboGender.SelectedIndex = -1;
        }
        //-------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentDetail std = new StudentDetail();
            std.Id = int.Parse(lblID.Text);
            std.NameStd = txtName.Text;
            std.Age = int.Parse(txtAge.Text);
            std.City = txtCity.Text;
            std.Gender = cboGender.SelectedItem.ToString();

            using (Entities entity = new Entities())
            {
                StudentDetail stdDetail = entity.StudentDetails.Where(x => x.Id == std.Id).
                    Select(x => x).FirstOrDefault();
                stdDetail.NameStd = std.NameStd;
                stdDetail.Age = std.Age;
                stdDetail.City = std.City;
                stdDetail.Gender = std.Gender;
                entity.SaveChanges();
            }
            MessageBox.Show("Updated Successfully!", "Update", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            ClearField();
            Display();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StudentDetail std = new StudentDetail();
            std.Id = int.Parse(lblID.Text);
            std.NameStd = txtName.Text;
            std.Age = int.Parse(txtAge.Text);
            std.City = txtCity.Text;
            std.Gender = cboGender.SelectedItem.ToString();

            using (Entities entity = new Entities())
            {
                StudentDetail stdDetail = entity.StudentDetails.Where(x => x.Id == std.Id).
                    Select(x => x).FirstOrDefault();
                entity.StudentDetails.Remove(stdDetail);
                entity.SaveChanges();
            }
            MessageBox.Show("Successfully!", "Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            ClearField();
            Display();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                lblID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAge.Text = row.Cells[2].Value.ToString();
                txtCity.Text = row.Cells[3].Value.ToString();
                cboGender.SelectedItem = row.Cells[4].Value.ToString();
            }   
        }
    }
}
