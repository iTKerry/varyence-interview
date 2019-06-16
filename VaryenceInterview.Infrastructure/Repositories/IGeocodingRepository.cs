using System.Threading.Tasks;
using VaryenceInterview.Domain.Responses;

namespace VaryenceInterview.Infrastructure.Repositories
{
    public interface IGeocodingRepository
    {
        Task<GeocodeResponse> GetGeocode(string address);
    }
}