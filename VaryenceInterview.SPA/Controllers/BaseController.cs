using Microsoft.AspNetCore.Mvc;
using VaryenceInterview.Services;

namespace VaryenceInterview.SPA.Controllers
{
    [Produces("application/json")]
    public class BaseController : Controller
    {
        protected IGeolocationService GeolocationService { get; }
        //TODO: Add logging service here

        public BaseController(IGeolocationService geolocationService)
        {
            GeolocationService = geolocationService;
        }
    }
}