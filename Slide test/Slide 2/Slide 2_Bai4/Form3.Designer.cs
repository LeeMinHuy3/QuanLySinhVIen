
namespace Slide_2_Bai2
{
    partial class Bai2
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
            this.cboTen = new System.Windows.Forms.ComboBox();
            this.btnChon2 = new System.Windows.Forms.Button();
            this.btnChonnhieu2 = new System.Windows.Forms.Button();
            this.btnChon1 = new System.Windows.Forms.Button();
            this.btnChonnhieu1 = new System.Windows.Forms.Button();
            this.lstDachon = new System.Windows.Forms.ListBox();
            this.lstCacmon = new System.Windows.Forms.ListBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboTen
            // 
            this.cboTen.FormattingEnabled = true;
            this.cboTen.Items.AddRange(new object[] {
            "Nguyen Van A",
            "Nguyen Van B",
            "Nguyen Van C"});
            this.cboTen.Location = new System.Drawing.Point(138, 86);
            this.cboTen.Name = "cboTen";
            this.cboTen.Size = new System.Drawing.Size(121, 21);
            this.cboTen.TabIndex = 40;
            // 
            // btnChon2
            // 
            this.btnChon2.Location = new System.Drawing.Point(223, 254);
            this.btnChon2.Name = "btnChon2";
            this.btnChon2.Size = new System.Drawing.Size(36, 23);
            this.btnChon2.TabIndex = 39;
            this.btnChon2.Text = "<";
            this.btnChon2.UseVisualStyleBackColor = true;
            this.btnChon2.Click += new System.EventHandler(this.btnChon2_Click);
            // 
            // btnChonnhieu2
            // 
            this.btnChonnhieu2.Location = new System.Drawing.Point(223, 225);
            this.btnChonnhieu2.Name = "btnChonnhieu2";
            this.btnChonnhieu2.Size = new System.Drawing.Size(36, 23);
            this.btnChonnhieu2.TabIndex = 38;
            this.btnChonnhieu2.Text = "<<";
            this.btnChonnhieu2.UseVisualStyleBackColor = true;
            this.btnChonnhieu2.Click += new System.EventHandler(this.btnChonnhieu2_Click);
            // 
            // btnChon1
            // 
            this.btnChon1.Location = new System.Drawing.Point(223, 196);
            this.btnChon1.Name = "btnChon1";
            this.btnChon1.Size = new System.Drawing.Size(36, 23);
            this.btnChon1.TabIndex = 37;
            this.btnChon1.Text = ">";
            this.btnChon1.UseVisualStyleBackColor = true;
            this.btnChon1.Click += new System.EventHandler(this.btnChon1_Click);
            // 
            // btnChonnhieu1
            // 
            this.btnChonnhieu1.Location = new System.Drawing.Point(223, 167);
            this.btnChonnhieu1.Name = "btnChonnhieu1";
            this.btnChonnhieu1.Size = new System.Drawing.Size(36, 23);
            this.btnChonnhieu1.TabIndex = 36;
            this.btnChonnhieu1.Text = ">>";
            this.btnChonnhieu1.UseVisualStyleBackColor = true;
            this.btnChonnhieu1.Click += new System.EventHandler(this.btnChonnhieu1_Click);
            // 
            // lstDachon
            // 
            this.lstDachon.FormattingEnabled = true;
            this.lstDachon.Location = new System.Drawing.Point(283, 167);
            this.lstDachon.Name = "lstDachon";
            this.lstDachon.Size = new System.Drawing.Size(133, 108);
            this.lstDachon.TabIndex = 35;
            // 
            // lstCacmon
            // 
            this.lstCacmon.FormattingEnabled = true;
            this.lstCacmon.Items.AddRange(new object[] {
            "Bong da",
            "Bong ban",
            "Bong chuyen",
            "Cau long",
            "Nhay xa",
            "Chay viet da"});
            this.lstCacmon.Location = new System.Drawing.Point(64, 167);
            this.lstCacmon.MultiColumn = true;
            this.lstCacmon.Name = "lstCacmon";
            this.lstCacmon.Size = new System.Drawing.Size(138, 108);
            this.lstCacmon.TabIndex = 34;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(476, 148);
            this.txtKetqua.Multiline = true;
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(118, 127);
            this.txtKetqua.TabIndex = 33;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(316, 114);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 32;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(97, 114);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(100, 20);
            this.txtDay.TabIndex = 31;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(600, 225);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(600, 196);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(600, 167);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 28;
            this.btnNhap.Text = "Nhap";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ket qua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Danh sach da chon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Danh sach cac mon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Chon ho ten :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(278, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Danh sach the thao";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 310);
            this.Controls.Add(this.cboTen);
            this.Controls.Add(this.btnChon2);
            this.Controls.Add(this.btnChonnhieu2);
            this.Controls.Add(this.btnChon1);
            this.Controls.Add(this.btnChonnhieu1);
            this.Controls.Add(this.lstDachon);
            this.Controls.Add(this.lstCacmon);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai2";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTen;
        private System.Windows.Forms.Button btnChon2;
        private System.Windows.Forms.Button btnChonnhieu2;
        private System.Windows.Forms.Button btnChon1;
        private System.Windows.Forms.Button btnChonnhieu1;
        private System.Windows.Forms.ListBox lstDachon;
        private System.Windows.Forms.ListBox lstCacmon;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}