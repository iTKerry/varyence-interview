using System.Threading.Tasks;
using VaryenceInterview.Dto;

namespace VaryenceInterview.Infrastructure
{
    public class GeocodingRepository : IGeocodingRepository
    {
        private readonly string _googleMapsApiKey;

        public GeocodingRepository(string googleMapsApiKey)
        {
            this._googleMapsApiKey = googleMapsApiKey;
        }

        public Task<Coordinates> GetCoordinates(string address)
        {
            throw new System.NotImplementedException();
        }
    }
}