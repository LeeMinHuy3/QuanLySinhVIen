
namespace Slide1_Bai2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radUCLN = new System.Windows.Forms.RadioButton();
            this.radBCNN = new System.Windows.Forms.RadioButton();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "B:";
            // 
            // radUCLN
            // 
            this.radUCLN.AutoSize = true;
            this.radUCLN.Location = new System.Drawing.Point(12, 26);
            this.radUCLN.Name = "radUCLN";
            this.radUCLN.Size = new System.Drawing.Size(61, 17);
            this.radUCLN.TabIndex = 5;
            this.radUCLN.TabStop = true;
            this.radUCLN.Text = "USCLN";
            this.radUCLN.UseVisualStyleBackColor = true;
            // 
            // radBCNN
            // 
            this.radBCNN.AutoSize = true;
            this.radBCNN.Location = new System.Drawing.Point(12, 49);
            this.radBCNN.Name = "radBCNN";
            this.radBCNN.Size = new System.Drawing.Size(62, 17);
            this.radBCNN.TabIndex = 6;
            this.radBCNN.TabStop = true;
            this.radBCNN.Text = "BSCNN";
            this.radBCNN.UseVisualStyleBackColor = true;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(50, 19);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(229, 20);
            this.txtA.TabIndex = 7;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(50, 44);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(229, 20);
            this.txtB.TabIndex = 8;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(62, 30);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.ReadOnly = true;
            this.txtKetqua.Size = new System.Drawing.Size(217, 20);
            this.txtKetqua.TabIndex = 9;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(62, 56);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(143, 56);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tim";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(224, 56);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 12;
            this.btnBoqua.Text = "Bo qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBCNN);
            this.groupBox1.Controls.Add(this.radUCLN);
            this.groupBox1.Location = new System.Drawing.Point(303, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chon tim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtA);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtB);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhap";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtKetqua);
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Controls.Add(this.btnBoqua);
            this.groupBox3.Location = new System.Drawing.Point(12, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ket qua";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 262);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bai 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radUCLN;
        private System.Windows.Forms.RadioButton radBCNN;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

