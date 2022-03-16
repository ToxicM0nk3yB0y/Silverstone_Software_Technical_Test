using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Silverstone_Software_Technical_Test.Models
{
    public class forecastdayDTO

    {
        public DayDTO Day { get; set; }
        public AstroDTO Astro { get; set; }
        public List<HourDTO> Hour { get; set; }




    }
}