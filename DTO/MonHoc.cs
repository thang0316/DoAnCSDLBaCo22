using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc
    {
        public string MaMonHoc { get; set; }  // Mã môn học, ví dụ: "MH001"
        public string TenMonHoc { get; set; } // Tên môn học, ví dụ: "Cơ sở dữ liệu nâng cao"
        public int SoTinChi { get; set; }     // Số tín chỉ, ví dụ: 4
        public int Ky { get; set; }           // Kỳ học, ví dụ: 1
        public string NamHoc { get; set; }    // Năm học, ví dụ: "2024 - 2025"

        // Constructor
        public MonHoc(string maMonHoc, string tenMonHoc, int soTinChi, int ky, string namHoc)
        {
            MaMonHoc = maMonHoc;
            TenMonHoc = tenMonHoc;
            SoTinChi = soTinChi;
            Ky = ky;
            NamHoc = namHoc;
        }
    }
}
