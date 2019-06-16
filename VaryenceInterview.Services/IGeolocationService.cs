using System.Collections.Generic;
using System.Threading.Tasks;
using VaryenceInterview.Domain.Dto;

namespace VaryenceInterview.Services
{
    public interface IGeolocationService
    {
        Task<Coordinates> GetCoordinates(string address);
        Task<List<Restraunts>> GetRestraunts(double lat, double lng, int range);
    }
}