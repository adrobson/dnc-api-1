using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dnc_api_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : ControllerBase
    {

        private readonly ILogger<CountryController> _logger;

        List<Stock> stockList = new List<Stock>();


        public StockController()
        {
            var countryList = new CountryList();

            var countries = countryList.Countries;

            stockList = new List<Stock>();

            for (int i = 1; i < 6; i++)
            {
                Country currentCountry = countries.Where(x => x.CountryId == i).First();

                for (int j = 1; j < 21; j++)
                {
                    stockList.Add(new Stock

                    {
                        CountryId = i,

                        StockId = i * j,

                        StockName = "Stock " + i * j + " - " + currentCountry.CountryName

                    });
                }
            }
        }


        [HttpGet]
        public IEnumerable<Stock> Get(int countryId)
        {
            return stockList.Where(x => x.CountryId == countryId);
        }
    }
}
