using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide_2_Bai2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            DateTime tg = DateTime.Now;
            txtDay.Text = tg.ToString("dd/mm/yyyy");
            txtTime.Text = tg.ToString("hh:mm:ss");
        }


        private void lstDachon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {

        }
        private void lstCacmon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtKetqua_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = lstDachon.Items.Count - 1; i >= 0; i--)
            {
                lstCacmon.Items.Add(lstDachon.Items[i]);
            }
            cboTen.Text = "";
            lstDachon.Items.Clear();
            txtKetqua.Text = "";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string lstdachon = "";
            foreach (var item in lstDachon.Items)
            {
                lstdachon = item.ToString() + ", " + lstdachon;
            }
            if (cboTen.Text != "" && txtDay.Text != "" && txtTime.Text != "")
            {

                txtKetqua.Text = cboTen.Text + Environment.NewLine +
                                    txtDay.Text + " " + txtTime.Text + Environment.NewLine +
                                    "Mon chon:" + Environment.NewLine + lstdachon;
            }
            else
            {
                MessageBox.Show("Nhap thieu thong tin");
            }
        }

        private void btnChon2_Click(object sender, EventArgs e)
        {
            if (lstDachon.SelectedItem != null)
            {
                lstCacmon.Items.Add(lstDachon.SelectedItem);
                lstDachon.Items.RemoveAt(lstDachon.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Chon mon hoc can huy");
            }
        }

        private void btnChonnhieu2_Click(object sender, EventArgs e)
        {
            for (int i = lstDachon.Items.Count - 1; i >= 0; i--)
            {
                lstCacmon.Items.Add(lstDachon.Items[i]);
            }
            lstDachon.Items.Clear();
        }

        private void btnChonnhieu1_Click(object sender, EventArgs e)
        {
            for (int i = lstCacmon.Items.Count - 1; i >= 0; i--)
            {
                lstDachon.Items.Add(lstCacmon.Items[i]);
            }
            lstCacmon.Items.Clear();
        }

        private void btnChon1_Click(object sender, EventArgs e)
        {
            if (lstCacmon.SelectedItem != null)
            {
                lstDachon.Items.Add(lstCacmon.SelectedItem);
                lstCacmon.Items.RemoveAt(lstCacmon.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Chon mon hoc");
            }
        }
    }
}
