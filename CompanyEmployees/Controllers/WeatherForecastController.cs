

using Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CompanyEmployees.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public WeatherForecastController(IRepositoryManager repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
           
            return new string[] { "value1", "value2" };
        }
    }
}
