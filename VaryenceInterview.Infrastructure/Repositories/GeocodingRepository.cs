using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using VaryenceInterview.Domain.Constants;
using VaryenceInterview.Domain.Responses;
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

        public async Task<GeocodeResponse> GetGeocode(string address)
        {
            var url = string.Format(GoogleApiUrls.GeocodeFromAddress, address, _googleMapsApiKey);
            var jsonResponse = await _httpFetcher.GetAsString(url);
            var result = JsonConvert.DeserializeObject<GeocodeResponse>(jsonResponse);
            return result;
        }

        public Task<NearBySearchResponse> GetNearBySearch(double lat, double lng, string searchFilter, int radius)
        {
            //TODO: Can be implemented later
            throw new System.NotImplementedException();
        }
    }
}