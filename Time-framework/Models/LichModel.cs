using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Time_framework.Models
{
    public class LichModel
    {
        [Key]
        public string Id { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public AppUser AppUser { set; get; }

        public string Slot { get; set; }

        public string CongViecId { get; set; }
        [ForeignKey("CongViecId")]
        public CongViecModel CongViecModel { set; get; }

        public string DayInWeeks { get; set; }
        public bool IsDelete { get; set; }

    }
}