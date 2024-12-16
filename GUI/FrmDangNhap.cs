using BLL;
using DAL;
using QLSV;

namespace GUI
{
    public partial class FrmDangNhap : Form
    {
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;

            bool taikhoan =  tkBLL.AuthenticateUser(username, password);
            int phanquyen = tkBLL.KiemTraPhanQuyen(username);
            if (taikhoan)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(phanquyen == 1)
                {
                    TrangChuSV frm = new TrangChuSV(username);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
