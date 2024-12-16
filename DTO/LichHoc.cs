using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichHoc
    {
        public string Ngay { get; set; }  // Ví dụ: "Thu 2"
        public string ThoiGian { get; set; }  // Ví dụ: "08:00 - 10:00"

        public string MaPhong { get; set; }    // Mã phòng học, ví dụ: "A101"a

        public string MaHocPhan {  get; set; }

        // Constructor
        public LichHoc(string ngay, string thoiGian, string maPhong, string maHocPhan)
        {
            Ngay = ngay;
            ThoiGian = thoiGian;
            MaPhong = maPhong;
            MaHocPhan = maHocPhan;
        }
    }
}
