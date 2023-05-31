using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanThuoc.Models
{
    public class KhachHangViewModel
    {
        public string TenKhachHang { get; set; }
        public string Phone { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int Payment { get; set; }
    }
}