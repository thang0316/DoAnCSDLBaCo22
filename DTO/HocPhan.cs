using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocPhan
    {
        public string MaHocPhan { get; set; }  // Mã học phần, ví dụ: "HP001"
        public string MaMonHoc { get; set; }   // Mã môn học, ví dụ: "MH001"
        public string MaGiangVien { get; set; } // Mã giảng viên, ví dụ: "GV001"
        

        // Constructor
        public HocPhan(string maHocPhan, string maMonHoc, string maGiangVien, string maPhong, List<LichHoc> lichHoc)
        {
            MaHocPhan = maHocPhan;
            MaMonHoc = maMonHoc;
            MaGiangVien = maGiangVien;
        }
    }
}
