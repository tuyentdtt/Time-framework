using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Time_framework.Models
{
    public class LichSuModel
    {
        [Key]
        public string Id { get; set; }
        //public CongViecModel MaCongViec_Fk { get; set; }
        public string MaCongViec { get; set; }
        public string TieuDe { get; set; }
        public string NoDung { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public bool IsDelete { get; set; }
    }
}