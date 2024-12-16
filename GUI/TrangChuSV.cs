using BLL;
using DTO;

namespace QLSV
{
    public partial class TrangChuSV : Form
    {
        SinhVienBLL svBLL = new SinhVienBLL();

        private string username;
        public TrangChuSV(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void TrangChuSV_Load(object sender, EventArgs e)
        {
            SinhVien sinhVien = svBLL.GetSinhVienByMaTaiKhoan(username);
            labelHoTen.Text = sinhVien.HoTen;
            labelMSSV.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
