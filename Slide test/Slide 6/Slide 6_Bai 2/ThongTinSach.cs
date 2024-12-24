using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide_6_Bai_2
{
    class ThongTinSach
    {
        [Key] public string MaSach { get; set; }
        public string TieuDe { get; set; }
        public int Gia { get; set; }
        public int SoLuong { get; set; }
    }
}
