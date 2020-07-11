using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Http;

namespace Spotify.OAuth
{
    /// <summary>
    /// Configuration options for <see cref="SpotifyHandler"/>
    /// </summary>
    public class SpotifyOptions : OAuthOptions
    {
        /// <summary>
        /// Constructs a new <see cref="SpotifyOptions"/>
        /// </summary>
        public SpotifyOptions()
        {
            CallbackPath = new PathString("/signin-spotify");
            AuthorizationEndpoint = SpotifyDefaults.AuthorizationEndpoint;
            TokenEndpoint = SpotifyDefaults.TokenEndpoint;
            UserInformationEndpoint = SpotifyDefaults.UserInformationEndpoint;

            Scope.Add("openid"); //This makes it an open id connection  authentication shake
            
            Scope.Add("user-library-read"); 
            Scope.Add("user-top-read");
            Scope.Add("user-read-recently-played");
            Scope.Add("user-read-currently-playing");

            //Since I don't know what the claims are lets just loop through em when we get it back D:
        }
    }
}
