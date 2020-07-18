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

        public SpotifyHttpClientService(HttpClient client, ILogger<SpotifyHttpClientService> logger)
        {
            _client = client;
            _logger = logger;
        }

        //Todo: Allow user to get next albums since this returns paginated list
        public async Task<AlbumPagination> GetAlbums(string bearerToken)
        {
            AlbumPagination data = new AlbumPagination();

            var request = new HttpRequestMessage(HttpMethod.Get, "/v1/me/albums");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            var response = await _client.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                _logger.LogError("Unable to retrieve user albums {0}, {1}", response.StatusCode, response.ReasonPhrase);

                return data;
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

        public async Task<string> GetTracks(string bearerToken)
        {
            var data = string.Empty;

            var request = new HttpRequestMessage(HttpMethod.Get, "v1/tracks");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            var response = await _client.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                _logger.LogError("Unable to get user tracks");
                return data;
            }

            //process the data
            data = await response.Content.ReadAsStringAsync();

            return data;
        }

        public async Task<string> RecentlyPlayedTracks(string bearerToken)
        {
            var data = string.Empty;

            var request = new HttpRequestMessage(HttpMethod.Get, "/v1/me/player/recently-played");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer",bearerToken);

            var response =  await _client.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                _logger.LogError("Unable to retrieve recently played tracks");
                return data;
            }

            data = await response.Content.ReadAsStringAsync();

            //parse it

            return data;
        }

        public async Task<string> CurrentlyPlayingTrack(string bearerToken)
        {
            var data = string.Empty;

            var request = new HttpRequestMessage(HttpMethod.Get, "v1/me/player/currently-playing");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            var response = await _client.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                _logger.LogError("Unable to retrieve user currently playing tracks");
                return data;
            }

            data = await response.Content.ReadAsStringAsync();

            //Parse the data

            return data;
        }
    }
}
