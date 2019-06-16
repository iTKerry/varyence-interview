using System.Threading.Tasks;
using VaryenceInterview.Dto;

namespace VaryenceInterview.Infrastructure.Repositories
{
    public interface IGeocodingRepository
    {
        Task<Coordinates> GetCoordinates(string address);
    }
}