using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanThuoc.Models
{
    public class CommonAbstract
    {
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiSua { get; set; }
    }
}