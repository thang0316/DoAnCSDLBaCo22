using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class SinhVienBLL
    {
        SinhVienAccess svAccess = new SinhVienAccess();

        public SinhVien GetSinhVienByMaTaiKhoan(string maTaiKhoan)
        {
            
            return svAccess.GetSinhVienByMaTaiKhoan(maTaiKhoan);
        }
    }
}
