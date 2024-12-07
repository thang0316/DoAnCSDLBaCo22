using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVien
    {
        public string MaGiangVien { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public char? GioiTinh { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string MaBoMon { get; set; }
        public string MaTaiKhoan { get; set; }
    }
}
