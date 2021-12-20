using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Time_framework.Models
{
    public class FileDinhKemModel
    {
        [Key]
        public string Id { get; set; }
        public string MaFile { get; set; }
        public string TenFile { get; set; }
        //public CongViecModel MaCongViec_Fk { get; set; }
        public string MaCongViec { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string DuongDanFile { get; set; }
        public bool IsDelete { get; set; }
    }
}