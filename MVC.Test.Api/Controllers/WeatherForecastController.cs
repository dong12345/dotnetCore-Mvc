using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Test.IService;

namespace MVC.Test.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IAdvertisementServices _advertisementServices;
        private readonly IExhibitorDBService _exhibitorDBService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IAdvertisementServices advertisementServices,IExhibitorDBService exhibitorDBService)
        {
            _logger = logger;
            _advertisementServices = advertisementServices;
            _exhibitorDBService = exhibitorDBService;
        }

        ///// <summary>
        ///// 获取接口数据
        ///// </summary>
        ///// <returns></returns>
        [HttpGet]
        public string[] Get()
        {
            var ads = _advertisementServices.Test();
            return Summaries;
        }

        [HttpGet(Name =nameof(GetHaha))]
        public async Task<string> GetHaha()
        {
            var a= _exhibitorDBService.GetHAHA();
            var list=await _exhibitorDBService.Query();
            return a;
        }
    }
}
