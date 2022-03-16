using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Silverstone_Software_Technical_Test.Models
{
    public class CurrentDTO
    {
        [Display(Name = "Currernt Temperature")]
        public double Temp_c { get; set; }
        public double Humidity { get; set; }
        public int MyProperty { get; set; }

    }
}