using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesData.ViewModels
{
    public class TimeZoneInfo_VM
    {
        public string zoneName {  get; set; }
        public string gmtOffset { get; set; }
        public string gmtOffsetName { get; set; }
        public string abbreviation { get; set; }
        public string tzName { get; set; }
    }
}
