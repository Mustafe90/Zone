using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.Extensions.Options;

namespace Spotify.OAuth
{
    public class SpotifyChallengeProperties : OAuthChallengeProperties
    {
        public SpotifyChallengeProperties() { }
        public SpotifyChallengeProperties(IDictionary<string, string> items) : base(items)
        {
        }

        public SpotifyChallengeProperties(IDictionary<string, string> items, IDictionary<string, object> parameter)
            : base(items, parameter) { }

        /// <summary>
        /// If True (false by default) forces user to re-authorize client 
        /// </summary>
        public static readonly string ShowDialogKey = "show_dialog";

        public string ShowDialog
        {
            get => GetParameter<string>(ShowDialogKey);
            set => SetParameter(ShowDialogKey, value);
        }

        public static readonly string ResponseTypeKey = "response_type";

        public string ResponseType => "code";

        public static readonly string StateKey = "state";
    }
}
