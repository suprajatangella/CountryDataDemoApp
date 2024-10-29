using CountryData.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryDataDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var helper = new CountryHelper();

            //Get list of Countries
            var countries = helper.GetCountries();
            Console.WriteLine("List of Available Countries");
            foreach (var country in countries)
                Console.WriteLine(country);

            //Get list of Regions in a Country by Country Code
       var regions = helper.GetRegionByCountryCode("GH");
            Console.WriteLine("List of Available Regions based on the Country Code");
            foreach (var region in regions)
                Console.WriteLine(region.Name);

            //Get All the countries along with their respective regions 
            var data = helper.GetCountryData();

            //Get the regions for the Country "US"

            data.Where(x => x.CountryShortCode == "US")
                              .Select(r => r.Regions).FirstOrDefault()
                              .ToList();

            //Get Country Details based on the Phone Code
            var countriesWithPhoneCode = helper.GetCountryByPhoneCode("+233");
            Console.WriteLine("List of Available Countires based on the Phone Code");
            foreach (var country in countriesWithPhoneCode)
            {
                Console.WriteLine(country.CountryName);
            }

            Console.ReadLine();

        }
    }
}
