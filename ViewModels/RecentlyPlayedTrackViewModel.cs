using System;
using System.Text.Json.Serialization;

namespace Zone.ViewModels
{
    public class RecentlyPlayedTrackViewModel
    {
        public UserTrackViewModelViewModel Track { get; set; }
        [JsonPropertyName("played_at")]
        public DateTime PlayedAt { get; set; }
        public ContextViewModel Context { get; set; }
    }
}
