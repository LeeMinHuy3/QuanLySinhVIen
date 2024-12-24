
namespace Slide_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtChiSoCu = new System.Windows.Forms.TextBox();
            this.txtChiSoMoi = new System.Windows.Forms.TextBox();
            this.txtTieuThu = new System.Windows.Forms.TextBox();
            this.txtTrongDinhMuc = new System.Windows.Forms.TextBox();
            this.txtVuotDinhMuc = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(183, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bang tinh tien dien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ho ten khach hang :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chi so cu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chi so moi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "So kw tieu thu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "So kw trong dinh muc :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "So kw vuot dinh muc :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(252, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dinh muc la 50 kw";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(252, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Trong dinh muc la 500d/kw";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(252, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Vuot dinh muc la 1000d/kw";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nguyen Van A",
            "Nguyen Van B"});
            this.comboBox1.Location = new System.Drawing.Point(169, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tong tien phai tra :";
            // 
            // txtChiSoCu
            // 
            this.txtChiSoCu.Location = new System.Drawing.Point(145, 102);
            this.txtChiSoCu.Name = "txtChiSoCu";
            this.txtChiSoCu.Size = new System.Drawing.Size(55, 20);
            this.txtChiSoCu.TabIndex = 12;
            // 
            // txtChiSoMoi
            // 
            this.txtChiSoMoi.Location = new System.Drawing.Point(145, 128);
            this.txtChiSoMoi.Name = "txtChiSoMoi";
            this.txtChiSoMoi.Size = new System.Drawing.Size(55, 20);
            this.txtChiSoMoi.TabIndex = 13;
            // 
            // txtTieuThu
            // 
            this.txtTieuThu.Location = new System.Drawing.Point(145, 154);
            this.txtTieuThu.Name = "txtTieuThu";
            this.txtTieuThu.Size = new System.Drawing.Size(55, 20);
            this.txtTieuThu.TabIndex = 14;
            // 
            // txtTrongDinhMuc
            // 
            this.txtTrongDinhMuc.Location = new System.Drawing.Point(374, 102);
            this.txtTrongDinhMuc.Name = "txtTrongDinhMuc";
            this.txtTrongDinhMuc.Size = new System.Drawing.Size(55, 20);
            this.txtTrongDinhMuc.TabIndex = 15;
            // 
            // txtVuotDinhMuc
            // 
            this.txtVuotDinhMuc.Location = new System.Drawing.Point(374, 128);
            this.txtVuotDinhMuc.Name = "txtVuotDinhMuc";
            this.txtVuotDinhMuc.Size = new System.Drawing.Size(55, 20);
            this.txtVuotDinhMuc.TabIndex = 16;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(61, 223);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(139, 20);
            this.txtTongTien.TabIndex = 17;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(61, 249);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(62, 23);
            this.btnTinh.TabIndex = 18;
            this.btnTinh.Text = "Tinh";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(138, 249);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(62, 23);
            this.btnIn.TabIndex = 19;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(101, 278);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(62, 23);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtThongTin
            // 
            this.txtThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtThongTin.Location = new System.Drawing.Point(255, 223);
            this.txtThongTin.Multiline = true;
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(174, 71);
            this.txtThongTin.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 344);
            this.Controls.Add(this.txtThongTin);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtVuotDinhMuc);
            this.Controls.Add(this.txtTrongDinhMuc);
            this.Controls.Add(this.txtTieuThu);
            this.Controls.Add(this.txtChiSoMoi);
            this.Controls.Add(this.txtChiSoCu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtChiSoCu;
        private System.Windows.Forms.TextBox txtChiSoMoi;
        private System.Windows.Forms.TextBox txtTieuThu;
        private System.Windows.Forms.TextBox txtTrongDinhMuc;
        private System.Windows.Forms.TextBox txtVuotDinhMuc;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtThongTin;
    }
}

