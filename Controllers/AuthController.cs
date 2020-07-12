using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;
using Spotify.OAuth;

namespace Zone.Controllers
{
    public class AuthController : Controller
    {
        public async Task<IActionResult> Login(string returnUrl)
        {
            if (User.Identity.IsAuthenticated)
            {
                var x = User.Identity.Name;
            }

            var p = User.Identity.Name;

            return Challenge(new AuthenticationProperties
            {
                RedirectUri = returnUrl
            }, OpenIdConnectDefaults.AuthenticationScheme);
        }

        public async Task Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme);
            }
        }

        public async Task<IActionResult> Spotify(string returnUrl)
        {
            return Challenge(new AuthenticationProperties
            {
                RedirectUri = "/"
            }, SpotifyDefaults.AuthenticationScheme);
        }

        [Route("/spotify-callback")]
        public async Task<IActionResult> spotifyCallback(string returnUrl)
        {
            return null;
        }
    }
}
