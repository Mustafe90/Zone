using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Spotify.OAuth
{
    public class SpotifyHandler : OAuthHandler<SpotifyOptions>
    {
        public SpotifyHandler(
            IOptionsMonitor<SpotifyOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock) : base(options, logger, encoder, clock)
        {
        }

        protected override async Task<AuthenticationTicket> CreateTicketAsync
            (ClaimsIdentity identity,
            AuthenticationProperties properties,
            OAuthTokenResponse tokens)
        {
            // Get the Spotify user
            var request = new HttpRequestMessage(HttpMethod.Get, Options.UserInformationEndpoint);

            request.Headers.Authorization = new AuthenticationHeaderValue
                ("Bearer", tokens.AccessToken);

            var response = await Backchannel.SendAsync(request, Context.RequestAborted);

            if (!response.IsSuccessStatusCode)
            {
                Logger.LogError("An error occured in trying to a retrieve user data from spotify." +
                                $"Code status {response.StatusCode} Headers: {response.Headers} " +
                                $"Payload {await response.Content.ReadAsStringAsync()}");
                throw new HttpRequestException
                    ($"Unable to retrieve user info ({response.StatusCode})");
            }


            var payload = JObject.Parse(await response.Content.ReadAsStringAsync());

            //user session + claimIdentity
            var context = new OAuthCreatingTicketContext
                (new ClaimsPrincipal(identity), properties, Context, Scheme, Options, Backchannel, tokens, payload);

            context.RunClaimActions();
            await Events.CreatingTicket(context);

            //return identity info and authentication state
            return new AuthenticationTicket(context.Principal, context.Properties, Scheme.Name);
        }

        protected override string BuildChallengeUrl(AuthenticationProperties properties, string redirectUri)
        {
            return base.BuildChallengeUrl(properties, redirectUri);
        }
    }
}
