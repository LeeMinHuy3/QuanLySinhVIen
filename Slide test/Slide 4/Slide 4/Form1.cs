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

namespace Slide_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            relations();
        }

        private static DataSet LoadData()
        {
            var db = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLy;Integrated Security=True");
            db.Open();

            var cmd = "Select * from Users";
            var dataAdapter = new SqlDataAdapter(cmd, db);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Users");
            dataAdapter.SelectCommand.CommandText = "Select * from Groups";
            dataAdapter.Fill(dataSet, "Groups");
            db.Close();
            return dataSet;
        }

        void relations()
        {
            DataSet dataSet = LoadData();
            DataTable userTable = dataSet.Tables["Users"];
            DataTable groupTable = dataSet.Tables["Groups"];
            DataRelation relation = new DataRelation("Group_User",
                    groupTable.Columns["GroupID"],
                    userTable.Columns["GroupID"]);
            dataSet.Relations.Add(relation);
            DataView dv = new DataView(userTable);
            dataGridView1.DataSource = dv;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string db = @"Data Source=.;Initial Catalog=QuanLy;Integrated Security=True";
            string query = "select * from Users";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db);
            DataSet set = new DataSet();

            adapter.Fill(set, "Users");
            DataView dv = set.Tables["Users"].DefaultView;
            dv.Sort = "UserName desc";
            dataGridView1.DataSource = dv;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string db = @"Data Source=.;Initial Catalog=QuanLy;Integrated Security=True";
            string query = "select * from Users";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db);
            DataSet set = new DataSet();

            adapter.Fill(set, "Users");
            DataView dv = set.Tables["Users"].DefaultView;
            dv.AllowNew = true;
            DataRowView newRow = dv.AddNew();
            newRow.BeginEdit();
            newRow["UserID"] = txtUserID.Text;
            newRow["UserName"] = txtUserName.Text;
            newRow["GroupID"] = txtGroupID.Text;
            newRow.EndEdit();
            dataGridView1.DataSource = dv;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string db = @"Data Source=.;Initial Catalog=QuanLy;Integrated Security=True";
            string query = "select * from Users";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db);
            DataSet set = new DataSet();

            adapter.Fill(set, "Users");
            DataView dv = set.Tables["Users"].DefaultView;
            dv.AllowDelete = true;
            dv.Table.Rows[9].Delete();
            dataGridView1.DataSource = dv;
        }
    }
}
