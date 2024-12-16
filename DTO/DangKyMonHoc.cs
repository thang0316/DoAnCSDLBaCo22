using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangKyMonHoc
    {
        public string MaSinhVien { get; set; }
        public string MaHocPhan { get; set; }
        public double? Diem { get; set; }

        // Constructor
        public DangKyMonHoc(string maSinhVien, string maHocPhan, double? diem)
        {
            // Sử dụng từ khóa "this" để tham chiếu tới các thuộc tính của lớp
            MaSinhVien = maSinhVien;
            MaHocPhan = maHocPhan;
            Diem = diem;
        }
    }
}
