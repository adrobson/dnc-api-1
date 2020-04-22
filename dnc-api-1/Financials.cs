using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

namespace dnc_api_1
{

    public class Country
    {
        public int CountryId { get; set; }

        public string CountryName { get; set; }
    }


    public class Stock
    {
        public int StockId { get; set; }

        public string StockName { get; set; }

        public int CountryId { get; set; }
    }

    public class Fund
    {
        public int FundId { get; set; }

        public string FundName { get; set; }

        public int CountryId { get; set; }

    }


    public class CountryList
    {
        public List<Country> Countries { get; set; }

        public CountryList()
        {
            Countries = new List<Country>();

            Countries.Add(new Country() { CountryId = 1, CountryName = "England" });

            Countries.Add(new Country() { CountryId = 2, CountryName = "France" });

            Countries.Add(new Country() { CountryId = 3, CountryName = "Germany" });

            Countries.Add(new Country() { CountryId = 4, CountryName = "Spain" });

            Countries.Add(new Country() { CountryId = 5, CountryName = "Wales" });

        }
    }
}