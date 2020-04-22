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
    public class CountryController : ControllerBase
    {

        private readonly ILogger<CountryController> _logger;

        public CountryController(ILogger<CountryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public IEnumerable<Country> Get()
        {
            var countryList = new CountryList();

            return countryList.Countries;

        }
    }
}
