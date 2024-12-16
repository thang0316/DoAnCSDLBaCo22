using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class HocPhanBLL
    {
        HocPhanAccess hocPhanAccess = new HocPhanAccess();
        public List<HocPhan> GetHocPhan()
        {
            return hocPhanAccess.GetHocPhan();
        }
    }
}
