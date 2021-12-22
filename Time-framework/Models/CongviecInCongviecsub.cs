using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Time_framework.Models
{
    public class CongviecInCongviecsub
    {
        [Key]
        [Column(Order = 1)]
        public string CongViecId { set; get; }

        [Key]
        [Column(Order = 2)]
        public string CongViecSubId { set; get; }
    }
}