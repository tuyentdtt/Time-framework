using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Time_framework.Models
{
    public class CommentModel
    {
        [Key]
        public string Id { get; set; }

        
        public string MaCongViec { get; set; }
        [ForeignKey("MaCongViec")]
        public CongViecModel CongViecModel { get; set; }

        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string MoTap { get; set; }
        public bool IsDelete { get; set; }
        public bool IsModifile { get; set; }
    }
}