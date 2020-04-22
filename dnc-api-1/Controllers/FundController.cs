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
    public class FundController : ControllerBase
    {

        private readonly ILogger<CountryController> _logger;

        List<Fund> fundList = new List<Fund>();


        public FundController()
        {
            var countryList = new CountryList();

            var countries = countryList.Countries;

            fundList = new List<Fund>();

            for (int i = 1; i < 6; i++)
            {
                Country currentCountry = countries.Where(x => x.CountryId == i).First();

                for (int j = 1; j < 21; j++)
                {
                    fundList.Add(new Fund

                    {
                        CountryId = i,

                        FundId = i * j,

                        FundName = "Fund " + i * j + " - " + currentCountry.CountryName

                    });
                }
            }
        }


        [HttpGet]
        public IEnumerable<Fund> Get(int countryId)
        {
            return fundList.Where(x => x.CountryId == countryId);
        }
    }
}
