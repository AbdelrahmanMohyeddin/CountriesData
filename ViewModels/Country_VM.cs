using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesData.ViewModels
{
    public class Country_VM
    {
        public int id {  get; set; } 
        public string name { get; set; }
        public string iso3 {  get; set; }
        public string iso2 { get; set; }
        public string numeric_code { get; set; }
        public string phone_code { get; set; }
        public string capital {  get; set; }
        public string currency { get; set; }
        public string currency_name { get; set; }
        public string currency_symbol { get; set; }
        public string tld { get; set; }
        public string native { get; set; }
        public string region { get; set; }
        public string region_id { get; set; }
        public string subregion { get; set; }
        public string subregion_id { get; set; }
        public string nationality { get; set; }
        public ICollection<TimeZoneInfo_VM> timezones { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string emoji { get; set; }
        public string emojiU { get; set; }

    }
}
