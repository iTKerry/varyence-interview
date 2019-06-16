using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VaryenceInterview.SPA.Controllers
{
    [Route("api/[controller]")]
    public class GeocodingController : Controller
    {
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCoordinates([FromQuery] string address)
        {
            throw new NotImplementedException();
        }
    }
}