using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zone.ViewModels
{
    public class TracksViewModel
    {
        public string Href { get; set; }
        [JsonPropertyName("Items")]
        public List<TrackViewModel> SongsList { get; set; }
        public int Limit { get; set; }
        public object Next { get; set; }
        public int Offset { get; set; }
        public object Previous { get; set; }
        public int Total { get; set; }

    }
}
