using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Time_framework.Models
{
    public class LichModel
    {
        [Key]
        public string Id { get; set; }

        //public AppUsersModel AppUser_Fk { get; set; }
        public string UserId { get; set; }
        public string Slot { get; set; }

        //public CongViecModel CongViec_Fk { get; set; }
        public string CongViecId { get; set; }
    }
}