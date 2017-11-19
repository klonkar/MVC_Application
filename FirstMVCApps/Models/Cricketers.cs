using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMVCApps.Models
{
    public class Cricketers
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int ODI { get; set; }
        public int Test { get; set; }
    }
}