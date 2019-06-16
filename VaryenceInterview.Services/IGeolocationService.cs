using System.Threading.Tasks;
using VaryenceInterview.Dto;

namespace VaryenceInterview.Services
{
    public interface IGeolocationService
    {
        Task<Coordinates> GetCoordinates(string address);
    }
}