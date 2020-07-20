using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zone.ViewModels
{
    public class TrackViewModel
    {
        public List<Artist> Artists { get; set; }
        public List<string> AvailableMarkets { get; set; }
        public int DiscNumber { get; set; }
        public int DurationMs { get; set; }
        //Convert them to json = this on is explicit
        [JsonPropertyName("explicit")]
        public bool HasExplicitEnabled { get; set; }
        public ExternalIdsViewModel ExternalIdsViewModel { get; set; }

        public ExternalUrlsViewModel ExternalUrlsViewModel { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public bool IsLocal { get; set; }
        public string Name { get; set; }
        public string PreviewUrl { get; set; }
        public int TrackNumber { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }

    }
}
