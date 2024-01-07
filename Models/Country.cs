using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesData.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Iso3 { get; set; }
        public string Iso2 { get; set; }
        public string NumericCode { get; set; }
        public string PhoneCode { get; set; }
        public string Capital { get; set; }

        public string CurrencyCode { get; set; }
        public string TLD { get; set; }
        public string Native { get; set; }
        public Region Region { get; set; }
        public string RegionCode { get; set; }
        public SubRegion SubRegion { get; set; }
        public string SubregionCode { get; set; }
        public string Nationality { get; set; }
        public ICollection<TimeZoneInfo> TimeZones { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public ICollection<State> States { get; set; }
    }
}
