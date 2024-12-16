using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess tkAccess = new TaiKhoanAccess();

        public bool AuthenticateUser(string username, string password)
        {
            
            var taiKhoan = tkAccess.AuthenticateUser(username, password);
            return taiKhoan != null; // Nếu tài khoản hợp lệ, trả về true
        }

        public int KiemTraPhanQuyen(string username)
        {
            return tkAccess.KiemTraPhanQuyen(username);  
        }
    }
}
