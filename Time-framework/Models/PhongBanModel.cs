using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Time_framework.Models
{
    public class PhongBanModel
    {
        [Key]
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgaySua { get; set; }
        
        public string NguoiTao { get; set; }
        [ForeignKey("NguoiTao")]
        public AppUser AppUser { get; set; }
        public string NguoiSua { get; set; }
        public bool IsDelete { get; set; }




    }
}