using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Silverstone_Software_Technical_Test.Models
{
    public class LocationDTO
    {
        [Display(Name = "Location Name")]
        public string name { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }


    }
}