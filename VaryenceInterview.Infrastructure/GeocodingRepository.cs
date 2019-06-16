using System.Threading.Tasks;
using VaryenceInterview.Dto;

namespace VaryenceInterview.Infrastructure
{
    public class GeocodingRepository : IGeocodingRepository
    {
        public Task<Coordinates> GetCoordinates(string address)
        {
            throw new System.NotImplementedException();
        }
    }
}