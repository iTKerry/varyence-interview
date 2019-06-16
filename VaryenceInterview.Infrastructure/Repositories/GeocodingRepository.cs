using System.Threading.Tasks;
using Microsoft.VisualBasic;
using VaryenceInterview.Domain.Constants;
using VaryenceInterview.Dto;
using VaryenceInterview.Infrastructure.Http;

namespace VaryenceInterview.Infrastructure.Repositories
{
    public class GeocodingRepository : IGeocodingRepository
    {
        private readonly string _googleMapsApiKey;
        private readonly IHttpFetcher _httpFetcher;

        public GeocodingRepository(string googleMapsApiKey, IHttpFetcher httpFetcher)
        {
            _googleMapsApiKey = googleMapsApiKey;
            _httpFetcher = httpFetcher;
        }

        public Task<Coordinates> GetCoordinates(string address)
        {
            var url = string.Format(GoogleApiUrls.GeocodeFromAddress, address, _googleMapsApiKey);
            var response = _httpFetcher.GetAsString(url);
            
            throw new System.NotImplementedException();
        }
    }
}