namespace QLSV
{
    partial class TrangChuSV
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
            Btn_ = new Button();
            Btn_dkmh = new Button();
            Btn_lh = new Button();
            Btn_Diem = new Button();
            panel1 = new Panel();
            txt_Tk = new TextBox();
            lb_tk = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_
            // 
            Btn_.BackColor = SystemColors.AppWorkspace;
            Btn_.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Btn_.Location = new Point(12, 24);
            Btn_.Name = "Btn_";
            Btn_.Size = new Size(94, 29);
            Btn_.TabIndex = 0;
            Btn_.Text = "Thông tin ";
            Btn_.UseVisualStyleBackColor = false;
            // 
            // Btn_dkmh
            // 
            Btn_dkmh.BackColor = SystemColors.AppWorkspace;
            Btn_dkmh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Btn_dkmh.Location = new Point(112, 24);
            Btn_dkmh.Name = "Btn_dkmh";
            Btn_dkmh.Size = new Size(136, 29);
            Btn_dkmh.TabIndex = 1;
            Btn_dkmh.Text = "Đăng kí môn học ";
            Btn_dkmh.UseVisualStyleBackColor = false;
            // 
            // Btn_lh
            // 
            Btn_lh.BackColor = SystemColors.AppWorkspace;
            Btn_lh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Btn_lh.Location = new Point(254, 24);
            Btn_lh.Name = "Btn_lh";
            Btn_lh.Size = new Size(131, 29);
            Btn_lh.TabIndex = 2;
            Btn_lh.Text = "Xem lịch học";
            Btn_lh.UseVisualStyleBackColor = false;
            // 
            // Btn_Diem
            // 
            Btn_Diem.BackColor = SystemColors.AppWorkspace;
            Btn_Diem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Btn_Diem.Location = new Point(391, 24);
            Btn_Diem.Name = "Btn_Diem";
            Btn_Diem.Size = new Size(94, 29);
            Btn_Diem.TabIndex = 3;
            Btn_Diem.Text = "Xem điểm ";
            Btn_Diem.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_Tk);
            panel1.Controls.Add(lb_tk);
            panel1.Location = new Point(535, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 188);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // txt_Tk
            // 
            txt_Tk.BorderStyle = BorderStyle.FixedSingle;
            txt_Tk.Enabled = false;
            txt_Tk.ImeMode = ImeMode.NoControl;
            txt_Tk.Location = new Point(105, 85);
            txt_Tk.Name = "txt_Tk";
            txt_Tk.Size = new Size(140, 27);
            txt_Tk.TabIndex = 6;
            txt_Tk.Text = "3122411064";
            // 
            // lb_tk
            // 
            lb_tk.AutoSize = true;
            lb_tk.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            lb_tk.Location = new Point(3, 85);
            lb_tk.Name = "lb_tk";
            lb_tk.Size = new Size(96, 23);
            lb_tk.TabIndex = 5;
            lb_tk.Text = "Tài Khoản:";
            // 
            // TrangChuSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 450);
            Controls.Add(panel1);
            Controls.Add(Btn_Diem);
            Controls.Add(Btn_lh);
            Controls.Add(Btn_dkmh);
            Controls.Add(Btn_);
            Name = "TrangChuSV";
            Text = "Trang chủ của SV";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_;
        private Button Btn_dkmh;
        private Button Btn_lh;
        private Button Btn_Diem;
        private Panel panel1;
        private TextBox txt_Tk;
        private Label lb_tk;
    }
}
