using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Spotify.OAuth;
using Zone.Services;

namespace Zone.Controllers
{
    [Authorize(AuthenticationSchemes = SpotifyDefaults.AuthenticationScheme)]
    public class SpotifyController : Controller
    {
        private readonly SpotifyHttpClientService _spotifyHttpClientService;

        public SpotifyController(SpotifyHttpClientService spotifyHttpClientService)
        {
            _spotifyHttpClientService = spotifyHttpClientService;
        }
        public async Task<IActionResult> Library()
        {
            //If you have multiple authentication provider please remember to specify the authentication scheme T-T
            string accessToken = await HttpContext.GetTokenAsync(SpotifyDefaults.AuthenticationScheme,"access_token");

            var albums = _spotifyHttpClientService.GetAlbums(accessToken);

            return View();
        }
    }

}
