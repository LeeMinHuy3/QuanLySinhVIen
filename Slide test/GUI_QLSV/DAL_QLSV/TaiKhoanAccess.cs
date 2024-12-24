using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLSV
{
    public class TaiKhoanAccess : DatabaseAccess
    {
        public string CheckLogic(TaiKhoan taikhoan)
        {
            string info = CheckLogicDTO(taiKhoan);
            return info;
        }
    }
}
