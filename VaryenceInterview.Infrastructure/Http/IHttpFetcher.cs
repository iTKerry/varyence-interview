using System.Net.Http;
using System.Threading.Tasks;

namespace VaryenceInterview.Infrastructure.Http
{
    public interface IHttpFetcher
    {
        Task<HttpResponseMessage> Get(string url);
        Task<string> GetAsString(string url);
    }
}