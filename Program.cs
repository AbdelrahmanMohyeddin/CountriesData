using CountriesData.ViewModels;
using Newtonsoft.Json;

string path = @"C:\Users\AME\Desktop\CountriesData\Countries_Data\countries-with-regions-and-subregions-code.json";
string path2 = @"C:\Users\AME\Desktop\CountriesData\Countries_Data\countries.json";

string file = File.ReadAllText(path);
string file2 = File.ReadAllText(path2);

var countriesWithRegionCode = JsonConvert.DeserializeObject<List<CountriesWithRegionsCode_VM>>(file);
var countries = JsonConvert.DeserializeObject<List<Country_VM>>(file2);

var a = countriesWithRegionCode.OrderBy(a => a.alpha2).Select(a => a.alpha2).ToArray();
var b = countries.OrderBy(a => a.iso2).Select(a => a.iso2).ToArray();

Console.WriteLine(a.Count() + " " + b.Count());

for (int i = 0; i < b.Count(); i++)
{
    Console.WriteLine(a[i] + " " + b[i]);
    if (a[i] != b[i])
    {
        Console.WriteLine(a[i] + " " + b[i]);
    }
}