﻿namespace GUI
{
    partial class DangKiMonHoc
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
            labelNamHoc = new Label();
            cbNamHoc = new ComboBox();
            cbHocKy = new ComboBox();
            labelHocKy = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            colMaHocPhan = new ColumnHeader();
            colTenHocPhan = new ColumnHeader();
            colSoTinChi = new ColumnHeader();
            labelDanhSachMonHoc = new Label();
            cbDanhSachMonHoc = new ComboBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            listView2 = new ListView();
            colMaHocPhanDK = new ColumnHeader();
            colTenHocPhanDK = new ColumnHeader();
            colSoTinChiDK = new ColumnHeader();
            colGiangVien = new ColumnHeader();
            colGiangVienDK = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // labelNamHoc
            // 
            labelNamHoc.AutoSize = true;
            labelNamHoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNamHoc.Location = new Point(48, 27);
            labelNamHoc.Name = "labelNamHoc";
            labelNamHoc.Size = new Size(75, 20);
            labelNamHoc.TabIndex = 0;
            labelNamHoc.Text = "Năm học:";
            // 
            // cbNamHoc
            // 
            cbNamHoc.FormattingEnabled = true;
            cbNamHoc.Items.AddRange(new object[] { " 2024 - 2025" });
            cbNamHoc.Location = new Point(126, 24);
            cbNamHoc.Name = "cbNamHoc";
            cbNamHoc.Size = new Size(151, 28);
            cbNamHoc.TabIndex = 2;
            // 
            // cbHocKy
            // 
            cbHocKy.FormattingEnabled = true;
            cbHocKy.Items.AddRange(new object[] { "1", "2" });
            cbHocKy.Location = new Point(381, 24);
            cbHocKy.Name = "cbHocKy";
            cbHocKy.Size = new Size(59, 28);
            cbHocKy.TabIndex = 3;
            cbHocKy.SelectedIndexChanged += cbHocKy_SelectedIndexChanged;
            // 
            // labelHocKy
            // 
            labelHocKy.AutoSize = true;
            labelHocKy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHocKy.Location = new Point(315, 27);
            labelHocKy.Name = "labelHocKy";
            labelHocKy.Size = new Size(60, 20);
            labelHocKy.TabIndex = 4;
            labelHocKy.Text = "Học kỳ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(12, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(758, 190);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh học phần có thể đăng ký";
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { colMaHocPhan, colTenHocPhan, colSoTinChi, colGiangVien });
            listView1.Location = new Point(10, 29);
            listView1.Name = "listView1";
            listView1.Size = new Size(738, 156);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colMaHocPhan
            // 
            colMaHocPhan.Text = "Mã học phần";
            colMaHocPhan.Width = 150;
            // 
            // colTenHocPhan
            // 
            colTenHocPhan.Text = "Tên học phân";
            colTenHocPhan.Width = 150;
            // 
            // colSoTinChi
            // 
            colSoTinChi.Text = "Số tín chỉ";
            colSoTinChi.Width = 150;
            // 
            // labelDanhSachMonHoc
            // 
            labelDanhSachMonHoc.AutoSize = true;
            labelDanhSachMonHoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDanhSachMonHoc.Location = new Point(48, 72);
            labelDanhSachMonHoc.Name = "labelDanhSachMonHoc";
            labelDanhSachMonHoc.Size = new Size(148, 20);
            labelDanhSachMonHoc.TabIndex = 7;
            labelDanhSachMonHoc.Text = "Danh sách môn học:";
            // 
            // cbDanhSachMonHoc
            // 
            cbDanhSachMonHoc.FormattingEnabled = true;
            cbDanhSachMonHoc.Location = new Point(202, 69);
            cbDanhSachMonHoc.Name = "cbDanhSachMonHoc";
            cbDanhSachMonHoc.Size = new Size(238, 28);
            cbDanhSachMonHoc.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(346, 308);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView2);
            groupBox2.Location = new Point(12, 342);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(763, 189);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách môn học đã đăng ký";
            // 
            // listView2
            // 
            listView2.CheckBoxes = true;
            listView2.Columns.AddRange(new ColumnHeader[] { colMaHocPhanDK, colTenHocPhanDK, colSoTinChiDK, colGiangVienDK });
            listView2.Location = new Point(10, 26);
            listView2.Name = "listView2";
            listView2.Size = new Size(738, 157);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // colMaHocPhanDK
            // 
            colMaHocPhanDK.Text = "Mã học phần";
            colMaHocPhanDK.Width = 150;
            // 
            // colTenHocPhanDK
            // 
            colTenHocPhanDK.Text = "Tên học phân";
            colTenHocPhanDK.Width = 150;
            // 
            // colSoTinChiDK
            // 
            colSoTinChiDK.Text = "Số tín chỉ";
            colSoTinChiDK.Width = 150;
            // 
            // colGiangVien
            // 
            colGiangVien.Text = "Giảng viên";
            colGiangVien.Width = 150;
            // 
            // colGiangVienDK
            // 
            colGiangVienDK.Text = "Giảng viên";
            colGiangVienDK.Width = 150;
            // 
            // DangKiMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(cbDanhSachMonHoc);
            Controls.Add(labelDanhSachMonHoc);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(labelHocKy);
            Controls.Add(cbHocKy);
            Controls.Add(cbNamHoc);
            Controls.Add(labelNamHoc);
            Name = "DangKiMonHoc";
            Text = "Đăng kí môn học";
            Load += DangKiMonHoc_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNamHoc;
        private ComboBox cbNamHoc;
        private ComboBox cbHocKy;
        private Label labelHocKy;
        private Label label1;
        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader colMaHocPhan;
        private ColumnHeader colSoTinChi;
        private Label labelDanhSachMonHoc;
        private ComboBox cbDanhSachMonHoc;
        private Button button1;
        private GroupBox groupBox2;
        private ColumnHeader colTenHocPhan;
        private ListView listView2;
        private ColumnHeader colMaHocPhanDK;
        private ColumnHeader colTenHocPhanDK;
        private ColumnHeader colSoTinChiDK;
        private ColumnHeader colGiangVien;
        private ColumnHeader colGiangVienDK;
    }
}