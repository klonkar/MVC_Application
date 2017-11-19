using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCApps.Models
{
    public class UserInfo
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userLocation { get; set; }
        public string userPassword { get; set; }
    }
}