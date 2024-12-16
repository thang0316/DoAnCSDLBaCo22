using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongHoc
    {
        public string MaPhongHoc { get; set; } // Mã phòng học, ví dụ: "A101"

        public PhongHoc(string maPhongHoc)
        {
            MaPhongHoc = maPhongHoc;
        }
    }
}
