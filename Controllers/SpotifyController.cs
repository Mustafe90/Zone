using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Spotify.OAuth;
using System;
using System.Threading.Tasks;
using Zone.Domain;
using Zone.Services;
using Zone.ViewModels;

namespace Zone.Controllers
{
    [Authorize(AuthenticationSchemes = SpotifyDefaults.AuthenticationScheme)]
    public class SpotifyController : Controller
    {
        private readonly SpotifyClientDomain _spotifyClient;

        public SpotifyController(SpotifyClientDomain spotifyHttpClientService)
        {
            _spotifyClient = spotifyHttpClientService;
        }
        public async Task<IActionResult> Library()
        {
            //If you have multiple authentication provider please remember to specify the authentication scheme T-T
            string accessToken = await HttpContext.GetTokenAsync(SpotifyDefaults.AuthenticationScheme, "access_token");

            var albums = await _spotifyClient.GetAlbums();

            //var recentTracks = await _spotifyHttpClientService.GetRecentlyPlayedTracks(accessToken);

            //var currentlyPlayingTracks = await _spotifyHttpClientService.GetCurrentlyPlayingTrack(accessToken);

            //var tuple = new Tuple<AlbumCollection, RecentlyPlayedViewModel, CurrentlyPlayingViewModel>(albums, recentTracks, currentlyPlayingTracks);

            return View(albums);
        }
        [HttpPost]
        public IActionResult Share([FromForm] string data)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }
            return null;
        }
    }

}
