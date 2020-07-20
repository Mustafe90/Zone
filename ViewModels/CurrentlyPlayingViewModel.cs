using System.Text.Json.Serialization;

namespace Zone.ViewModels
{
    public class CurrentlyPlayingViewModel
    {
        public long Timestamp { get; set; }

        [JsonPropertyName("context")]

        public ContextViewModel ContextViewModel { get; set; }

        [JsonPropertyName("progress_ms")]

        public int ProgressMs { get; set; }
        [JsonPropertyName("item")]
        public UserTrackViewModelViewModel Track { get; set; }

        [JsonPropertyName("currently_playing_type")]
        public string CurrentlyPlayingType { get; set; }

        [JsonPropertyName("actions")]
        public ActionsViewModel Actions { get; set; }

        [JsonPropertyName("is_playing")]
        public bool IsPlaying { get; set; }
    }
}
