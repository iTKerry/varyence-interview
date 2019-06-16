using System.Threading.Tasks;
using VaryenceInterview.Dto;
using VaryenceInterview.Infrastructure;
using VaryenceInterview.Infrastructure.Repositories;

namespace VaryenceInterview.Services
{
    public class GeolocationService : IGeolocationService
    {
        private readonly IGeocodingRepository _geocodingRepository;

        public GeolocationService(IGeocodingRepository geocodingRepository)
        {
            _geocodingRepository = geocodingRepository;
        }

        public Task<Coordinates> GetCoordinates(string address)
        {
            throw new System.NotImplementedException();
        }
    }
}