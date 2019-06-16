using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VaryenceInterview.Services;

namespace VaryenceInterview.SPA.Controllers
{
    [Route("api/geolocation")]
    public class GeolocationController : BaseController
    {
        public GeolocationController(IGeolocationService geolocationService) : base(geolocationService)
        {
        }
        
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCoordinates([FromQuery] string address)
        {
            var coordinates = await GeolocationService.GetCoordinates(address);
            if (coordinates == null)
            {
                return NotFound();
            }

            return new OkObjectResult(coordinates);
        }
    }
}