using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Zone.Models;

namespace Zone.Services
{
    public class SpotifyHttpClientService
    {
        private readonly HttpClient _client;
        private readonly ILogger<SpotifyHttpClientService> _logger;

        public SpotifyHttpClientService(HttpClient client,ILogger<SpotifyHttpClientService> logger)
        {
            _client = client;
            _logger = logger;
        }

        //Todo: Allow user to get next albums since this returns paginated list
        public async Task<AlbumPagination> GetAlbums(string bearerToken)
        {
            AlbumPagination data = null;

            var request = new HttpRequestMessage(HttpMethod.Get, "/v1/me/albums");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer",bearerToken);

            var response = await _client.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                _logger.LogError("Unable to retrieve user albums {0}, {1}",response.StatusCode,response.ReasonPhrase);
            };
            //parse it 
            var content = await response.Content.ReadAsStringAsync(); 

            //Todo Write Custom converter    
            data = JsonSerializer.Deserialize<AlbumPagination>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });

            return data;
        }
    }
}
