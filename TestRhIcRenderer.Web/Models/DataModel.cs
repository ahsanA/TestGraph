using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestRhIcRenderer.Web.Models
{
    public class DataModel
    {
        public string Date { get; set; }
        public string Countryname { get; set; }
        public double Open { get; set; }
        public double LowRate { get; set; }
        public double Close { get; set; }
        public double HighRate { get; set; }
    }
}