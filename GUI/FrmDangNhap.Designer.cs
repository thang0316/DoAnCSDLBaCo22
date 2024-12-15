namespace GUI
{
    partial class FrmDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lableMaTaiKhoan = new Label();
            lable = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnThoat = new Button();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // lableMaTaiKhoan
            // 
            lableMaTaiKhoan.AutoSize = true;
            lableMaTaiKhoan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lableMaTaiKhoan.Location = new Point(68, 67);
            lableMaTaiKhoan.Name = "lableMaTaiKhoan";
            lableMaTaiKhoan.Size = new Size(128, 23);
            lableMaTaiKhoan.TabIndex = 0;
            lableMaTaiKhoan.Text = "Tên đăng nhập:";
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable.Location = new Point(108, 105);
            lable.Name = "lable";
            lable.Size = new Size(88, 23);
            lable.TabIndex = 1;
            lable.Text = "Mật khẩu:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(202, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(108, 179);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(295, 179);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(94, 29);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 252);
            Controls.Add(btnDangNhap);
            Controls.Add(btnThoat);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lable);
            Controls.Add(lableMaTaiKhoan);
            Name = "FrmDangNhap";
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lableMaTaiKhoan;
        private Label lable;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnThoat;
        private Button btnDangNhap;
    }
}
