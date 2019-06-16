using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VaryenceInterview.Services;

namespace VaryenceInterview.SPA.Controllers
{
    [Route("api/[controller]")]
    public class GeocodingController : Controller
    {
        private readonly IGeolocationService _geolocationService;

        public GeocodingController(IGeolocationService geolocationService)
        {
            _geolocationService = geolocationService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetCoordinates([FromQuery] string address)
        {
            var coordinates = await _geolocationService.GetCoordinates(address);
            if (coordinates == null)
            {
                return NotFound();
            }

            return new OkObjectResult(coordinates);
        }
    }
}