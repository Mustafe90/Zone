using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Spotify.OAuth;

namespace Zone.Controllers
{
    [Authorize(AuthenticationSchemes = SpotifyDefaults.AuthenticationScheme)]
    public class SpotifyController : Controller
    {
        public async Task<IActionResult> Library()
        {
            //If you have multiple authentication provider please remember to specify the authentication scheme T-T
            string accessToken = await HttpContext.GetTokenAsync(SpotifyDefaults.AuthenticationScheme,"access_token");

            return View();
        }
    }
}
