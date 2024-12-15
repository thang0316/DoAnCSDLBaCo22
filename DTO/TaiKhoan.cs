using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        string MaTaiKhoan {  get; set; }
        string MatKhau { get; set; }
        int PhanQuyen { get; set; }

        public TaiKhoan(string maTaiKhoan, string matKhau, int phanQuyen)
        {
            MaTaiKhoan = maTaiKhoan;
            MatKhau = matKhau;
            PhanQuyen = phanQuyen;
        }
    }
}
