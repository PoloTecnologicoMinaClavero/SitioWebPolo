using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PoloSitioWeb.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoloSitioWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeApiController : ControllerBase
    {

        //private readonly ContadoresConfig _contadoresConfig;

        //public HomeApiController(IOptions<ContadoresConfig> contadoresConfig)
        //{
        //    _contadoresConfig = contadoresConfig.Value;
        //}

        //[HttpGet("/api/Home/GetCounters")]
        //public IActionResult GetCounters()
        //{
        //    return Ok(_contadoresConfig);
        //}
    }
}
