using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace gamarr.Services
{
    public class IgdbService
    {
        private readonly HttpClient _httpClient;

        public IgdbService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetGameCubeGames()
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.igdb.com/v4/games");
            request.Headers.Add("Client-ID", "YOUR_CLIENT_ID");
            request.Headers.Add("Authorization", "Bearer YOUR_ACCESS_TOKEN");
            request.Content = new StringContent("fields name,platforms,genres,release_dates,cover; where platforms = (23); limit 50;");

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}