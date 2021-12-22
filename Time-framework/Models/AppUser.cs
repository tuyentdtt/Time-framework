using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Time_framework.Models
{
    public class AppUser : ApplicationUser
    {
        public ICollection<LichModel> LichModel { get; set; }
        public ICollection<PhongBanModel> PhongBanModel { get; set; }
    }
}