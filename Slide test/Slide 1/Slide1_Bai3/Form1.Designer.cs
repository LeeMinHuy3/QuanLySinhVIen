
namespace Slide1_Bai3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPTB1 = new System.Windows.Forms.RadioButton();
            this.radPTB2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giai Phuong Trinh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPTB2);
            this.groupBox1.Controls.Add(this.radPTB1);
            this.groupBox1.Location = new System.Drawing.Point(144, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ban vui long chon";
            // 
            // radPTB1
            // 
            this.radPTB1.AutoSize = true;
            this.radPTB1.Location = new System.Drawing.Point(7, 20);
            this.radPTB1.Name = "radPTB1";
            this.radPTB1.Size = new System.Drawing.Size(73, 17);
            this.radPTB1.TabIndex = 0;
            this.radPTB1.TabStop = true;
            this.radPTB1.Text = "Giai PTB1";
            this.radPTB1.UseVisualStyleBackColor = true;
            this.radPTB1.CheckedChanged += new System.EventHandler(this.radPTB1_CheckedChanged);
            // 
            // radPTB2
            // 
            this.radPTB2.AutoSize = true;
            this.radPTB2.Location = new System.Drawing.Point(7, 44);
            this.radPTB2.Name = "radPTB2";
            this.radPTB2.Size = new System.Drawing.Size(73, 17);
            this.radPTB2.TabIndex = 1;
            this.radPTB2.TabStop = true;
            this.radPTB2.Text = "Giai PTB2";
            this.radPTB2.UseVisualStyleBackColor = true;
            this.radPTB2.CheckedChanged += new System.EventHandler(this.radPTB2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhap a:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhap b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhap c:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ket qua:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(183, 176);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(77, 20);
            this.txtA.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(183, 199);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(77, 20);
            this.txtB.TabIndex = 7;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(183, 224);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(77, 20);
            this.txtC.TabIndex = 8;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(183, 251);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.ReadOnly = true;
            this.txtKetqua.Size = new System.Drawing.Size(168, 20);
            this.txtKetqua.TabIndex = 9;
            // 
            // btnGiai
            // 
            this.btnGiai.Location = new System.Drawing.Point(276, 176);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(75, 43);
            this.btnGiai.TabIndex = 10;
            this.btnGiai.Text = "Giai";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(276, 222);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 315);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bai 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radPTB2;
        private System.Windows.Forms.RadioButton radPTB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnThoat;
    }
}

