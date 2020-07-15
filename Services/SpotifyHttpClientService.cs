using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Zone.Services
{
    public class SpotifyHttpClientService
    {
        private readonly HttpClient _client;

        public SpotifyHttpClientService(HttpClient client)
        {

            _client = client;
        }

        public async Task<string> GetAlbums(string bearerToken)
        {
            var data = string.Empty;
            var request = new HttpRequestMessage(HttpMethod.Get, "/v1/me/albums");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer",bearerToken);

            var response = await _client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                //parse it 
                var content = await response.Content.ReadAsStringAsync();
            }

            return data;
        }
    }
}
