using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Time_framework.Models
{
    public class CongViecModel
    {
        [Key]
        public string Id { get; set; }
        public string MaCongViec { get; set; }
        public string MaTrangThai { get; set; }
        [ForeignKey("MaTrangThai")]
        public TrangThaiModel TrangThaiModel { get; set; }
        public string MaDuAn { get; set; }
        
        public string MaPhong { get; set; }

        public string NguoiThucHien { get; set; }
        public int SoGioThucHien { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public bool IsDelete { get; set; }
        public bool IsView { get; set; }
        public DateTime NgayKetThucCV { get; set; }


        public ICollection<CommentModel> CommentModel { get; set; }
        public ICollection<LichModel> LichModel { get; set; }

    }

}