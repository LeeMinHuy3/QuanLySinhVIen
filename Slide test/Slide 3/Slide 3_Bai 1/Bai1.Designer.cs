
namespace Slide_3_Bai_1
{
    partial class Bai1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.grpHS = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnXoaHS = new System.Windows.Forms.Button();
            this.btnLuuHS = new System.Windows.Forms.Button();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.grpLop = new System.Windows.Forms.GroupBox();
            this.btnXoaLH = new System.Windows.Forms.Button();
            this.btnLuuLH = new System.Windows.Forms.Button();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radLop = new System.Windows.Forms.RadioButton();
            this.radHS = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHOCSINHDataSet = new Slide_3_Bai_1.QLHOCSINHDataSet();
            this.lOPTableAdapter = new Slide_3_Bai_1.QLHOCSINHDataSetTableAdapters.LOPTableAdapter();
            this.qLHOCSINHDataSet1 = new Slide_3_Bai_1.QLHOCSINHDataSet1();
            this.lOPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter1 = new Slide_3_Bai_1.QLHOCSINHDataSet1TableAdapters.LOPTableAdapter();
            this.grpHS.SuspendLayout();
            this.grpLop.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHOCSINHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHOCSINHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Học Sinh";
            // 
            // grpHS
            // 
            this.grpHS.Controls.Add(this.dtpNgaySinh);
            this.grpHS.Controls.Add(this.btnXoaHS);
            this.grpHS.Controls.Add(this.btnLuuHS);
            this.grpHS.Controls.Add(this.txtDiemTB);
            this.grpHS.Controls.Add(this.txtDiaChi);
            this.grpHS.Controls.Add(this.cboLop);
            this.grpHS.Controls.Add(this.label7);
            this.grpHS.Controls.Add(this.label6);
            this.grpHS.Controls.Add(this.label5);
            this.grpHS.Controls.Add(this.txtTenHS);
            this.grpHS.Controls.Add(this.txtMaHS);
            this.grpHS.Controls.Add(this.label4);
            this.grpHS.Controls.Add(this.label3);
            this.grpHS.Controls.Add(this.label2);
            this.grpHS.Location = new System.Drawing.Point(12, 48);
            this.grpHS.Name = "grpHS";
            this.grpHS.Size = new System.Drawing.Size(570, 147);
            this.grpHS.TabIndex = 1;
            this.grpHS.TabStop = false;
            this.grpHS.Text = "Thông tin học sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(89, 97);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(121, 20);
            this.dtpNgaySinh.TabIndex = 13;
            // 
            // btnXoaHS
            // 
            this.btnXoaHS.Location = new System.Drawing.Point(475, 58);
            this.btnXoaHS.Name = "btnXoaHS";
            this.btnXoaHS.Size = new System.Drawing.Size(75, 23);
            this.btnXoaHS.TabIndex = 12;
            this.btnXoaHS.Text = "Xóa";
            this.btnXoaHS.UseVisualStyleBackColor = true;
            this.btnXoaHS.Click += new System.EventHandler(this.btnXoaHS_Click);
            // 
            // btnLuuHS
            // 
            this.btnLuuHS.Location = new System.Drawing.Point(475, 21);
            this.btnLuuHS.Name = "btnLuuHS";
            this.btnLuuHS.Size = new System.Drawing.Size(75, 23);
            this.btnLuuHS.TabIndex = 0;
            this.btnLuuHS.Text = "Lưu";
            this.btnLuuHS.UseVisualStyleBackColor = true;
            this.btnLuuHS.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(333, 96);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(121, 20);
            this.txtDiemTB.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(333, 24);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(121, 20);
            this.txtDiaChi.TabIndex = 10;
            // 
            // cboLop
            // 
            this.cboLop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lOPBindingSource1, "MaLop", true));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(333, 60);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(121, 21);
            this.cboLop.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Điểm TB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ma Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ";
            // 
            // txtTenHS
            // 
            this.txtTenHS.Location = new System.Drawing.Point(89, 60);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(121, 20);
            this.txtTenHS.TabIndex = 4;
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(89, 24);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(121, 20);
            this.txtMaHS.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã học sinh";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(25, 94);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(199, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nhập Lớp Học";
            // 
            // grpLop
            // 
            this.grpLop.Controls.Add(this.btnXoaLH);
            this.grpLop.Controls.Add(this.btnLuuLH);
            this.grpLop.Controls.Add(this.txtSiSo);
            this.grpLop.Controls.Add(this.txtLop);
            this.grpLop.Controls.Add(this.txtMaLop);
            this.grpLop.Controls.Add(this.label11);
            this.grpLop.Controls.Add(this.label10);
            this.grpLop.Controls.Add(this.label9);
            this.grpLop.Location = new System.Drawing.Point(12, 240);
            this.grpLop.Name = "grpLop";
            this.grpLop.Size = new System.Drawing.Size(471, 89);
            this.grpLop.TabIndex = 3;
            this.grpLop.TabStop = false;
            this.grpLop.Text = "Thông tin lớp học";
            // 
            // btnXoaLH
            // 
            this.btnXoaLH.Location = new System.Drawing.Point(379, 52);
            this.btnXoaLH.Name = "btnXoaLH";
            this.btnXoaLH.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLH.TabIndex = 7;
            this.btnXoaLH.Text = "Xóa";
            this.btnXoaLH.UseVisualStyleBackColor = true;
            this.btnXoaLH.Click += new System.EventHandler(this.btnXoaLH_Click);
            // 
            // btnLuuLH
            // 
            this.btnLuuLH.Location = new System.Drawing.Point(274, 52);
            this.btnLuuLH.Name = "btnLuuLH";
            this.btnLuuLH.Size = new System.Drawing.Size(75, 23);
            this.btnLuuLH.TabIndex = 6;
            this.btnLuuLH.Text = "Lưu";
            this.btnLuuLH.UseVisualStyleBackColor = true;
            this.btnLuuLH.Click += new System.EventHandler(this.btnLuuLH_Click);
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(333, 24);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(121, 20);
            this.txtSiSo.TabIndex = 5;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(89, 54);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(121, 20);
            this.txtLop.TabIndex = 4;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(89, 24);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(121, 20);
            this.txtMaLop.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Sỉ số";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã lớp học";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.radLop);
            this.groupBox3.Controls.Add(this.radHS);
            this.groupBox3.Location = new System.Drawing.Point(591, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 147);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn nhập thông tin";
            // 
            // radLop
            // 
            this.radLop.AutoSize = true;
            this.radLop.Location = new System.Drawing.Point(25, 61);
            this.radLop.Name = "radLop";
            this.radLop.Size = new System.Drawing.Size(68, 17);
            this.radLop.TabIndex = 1;
            this.radLop.TabStop = true;
            this.radLop.Text = "Nhap lop";
            this.radLop.UseVisualStyleBackColor = true;
            this.radLop.CheckedChanged += new System.EventHandler(this.radLop_CheckedChanged);
            // 
            // radHS
            // 
            this.radHS.AutoSize = true;
            this.radHS.Checked = true;
            this.radHS.Location = new System.Drawing.Point(25, 25);
            this.radHS.Name = "radHS";
            this.radHS.Size = new System.Drawing.Size(94, 17);
            this.radHS.TabIndex = 0;
            this.radHS.TabStop = true;
            this.radHS.Text = "Nhap hoc sinh";
            this.radHS.UseVisualStyleBackColor = true;
            this.radHS.CheckedChanged += new System.EventHandler(this.radHS_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(499, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 89);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(46, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Danh sách lớp học";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Danh sách học sinh";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLHOCSINHDataSet;
            // 
            // qLHOCSINHDataSet
            // 
            this.qLHOCSINHDataSet.DataSetName = "QLHOCSINHDataSet";
            this.qLHOCSINHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // qLHOCSINHDataSet1
            // 
            this.qLHOCSINHDataSet1.DataSetName = "QLHOCSINHDataSet1";
            this.qLHOCSINHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource1
            // 
            this.lOPBindingSource1.DataMember = "LOP";
            this.lOPBindingSource1.DataSource = this.qLHOCSINHDataSet1;
            // 
            // lOPTableAdapter1
            // 
            this.lOPTableAdapter1.ClearBeforeFill = true;
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 341);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpLop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grpHS);
            this.Controls.Add(this.label1);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.Load += new System.EventHandler(this.Bai1_Load);
            this.grpHS.ResumeLayout(false);
            this.grpHS.PerformLayout();
            this.grpLop.ResumeLayout(false);
            this.grpLop.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHOCSINHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHOCSINHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpHS;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaHS;
        private System.Windows.Forms.Button btnLuuHS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpLop;
        private System.Windows.Forms.Button btnXoaLH;
        private System.Windows.Forms.Button btnLuuLH;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radLop;
        private System.Windows.Forms.RadioButton radHS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private QLHOCSINHDataSet qLHOCSINHDataSet;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLHOCSINHDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLHOCSINHDataSet1 qLHOCSINHDataSet1;
        private System.Windows.Forms.BindingSource lOPBindingSource1;
        private QLHOCSINHDataSet1TableAdapters.LOPTableAdapter lOPTableAdapter1;
    }
}

