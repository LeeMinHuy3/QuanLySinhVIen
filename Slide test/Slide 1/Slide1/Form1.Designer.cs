
namespace Slide1
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
            this.txtSon = new System.Windows.Forms.TextBox();
            this.txtSom = new System.Windows.Forms.TextBox();
            this.btTru = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btCong = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap so n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ket qua";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSon
            // 
            this.txtSon.Location = new System.Drawing.Point(228, 71);
            this.txtSon.Name = "txtSon";
            this.txtSon.Size = new System.Drawing.Size(100, 20);
            this.txtSon.TabIndex = 2;
            this.txtSon.TextChanged += new System.EventHandler(this.txtSon_TextChanged);
            // 
            // txtSom
            // 
            this.txtSom.Location = new System.Drawing.Point(228, 98);
            this.txtSom.Name = "txtSom";
            this.txtSom.Size = new System.Drawing.Size(100, 20);
            this.txtSom.TabIndex = 3;
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(160, 185);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(75, 23);
            this.btTru.TabIndex = 4;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(241, 185);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(75, 23);
            this.btNhan.TabIndex = 5;
            this.btNhan.Text = "x";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(131, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thuc Hien Phep Tinh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.AcceptsReturn = true;
            this.txtKetQua.Location = new System.Drawing.Point(228, 129);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(100, 20);
            this.txtKetQua.TabIndex = 7;
            this.txtKetQua.TextChanged += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhap so m";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(241, 227);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(79, 185);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 23);
            this.btCong.TabIndex = 10;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btChia
            // 
            this.btChia.Location = new System.Drawing.Point(322, 185);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(75, 23);
            this.btChia.TabIndex = 11;
            this.btChia.Text = "/";
            this.btChia.UseVisualStyleBackColor = true;
            this.btChia.Click += new System.EventHandler(this.btChia_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(160, 227);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xoa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 320);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.txtSom);
            this.Controls.Add(this.txtSon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tinh Toan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSon;
        private System.Windows.Forms.TextBox txtSom;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.Button btXoa;
    }
}

