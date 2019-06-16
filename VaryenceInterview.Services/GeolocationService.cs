using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaryenceInterview.Domain.Dto;
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

        public async Task<Coordinates> GetCoordinates(string address)
        {
            var geocoding = await _geocodingRepository.GetGeocode(address);

            // Get first available location from API response
            var location = geocoding.Results.FirstOrDefault(result => result.Geometry.Location != null)?.Geometry
                .Location;
            
            //TODO: should be replaced with Mapper service (AutoMapper, etc.)
            var coordination = new Coordinates
            {
                Latitude = location?.Lat,
                Longitude = location?.Lng
            };
            
            return coordination;
        }

        //TODO: Restraunst should be replaces with IPlace
        public Task<List<Restraunts>> GetRestraunts(double lat, double lng, int range)
        {
            //TODO: This can be implemented later
            throw new System.NotImplementedException();
        }
    }
}