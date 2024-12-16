using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien
    {
        public string MaTaiKhoan { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string Khoa { get; set; }
        public string Nganh { get; set; }
        public string SoDienThoai { get; set; }

        public SinhVien(string maTaiKhoan, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string email, string khoa, string nganh, string soDienThoai)
        {
            MaTaiKhoan = maTaiKhoan;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            Email = email;
            Khoa = khoa;
            Nganh = nganh;
            SoDienThoai = soDienThoai;
        }
    }
}
