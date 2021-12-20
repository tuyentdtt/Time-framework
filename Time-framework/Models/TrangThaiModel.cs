using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Time_framework.Models
{
    public class TrangThaiModel
    {
        [Key]
        public string MaTrangThai { get; set; }
        public string TenTrangThai { get; set; }
        public string MoTa { get; set; }
        public bool IsDelete { get; set;}
    }
}