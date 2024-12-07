using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien
    {
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public char? GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string Khoa { get; set; }
        public string Nganh { get; set; }
        public string SoDienThoai { get; set; }
        public string MaTaiKhoan { get; set; }
    }
}
