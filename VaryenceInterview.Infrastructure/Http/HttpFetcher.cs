using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace VaryenceInterview.Infrastructure.Http
{
    public class HttpFetcher : IHttpFetcher, IDisposable
    {
        private readonly HttpClient _httpClient;

        public HttpFetcher()
        {
            _httpClient = new HttpClient();
        }

        public Task<HttpResponseMessage> Get(string url)
        {
            return _httpClient.GetAsync(url);
        }

        public Task<string> GetAsString(string url)
        {
            return _httpClient.GetStringAsync(url);
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}