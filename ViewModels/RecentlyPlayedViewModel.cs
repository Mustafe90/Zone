using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zone.ViewModels
{
    public class RecentlyPlayedViewModel
    {
        [JsonProperty(PropertyName = "items")]
        public List<RecentlyPlayedTrackViewModel> RecentlyPlayedTracks { get; set; }
        public string Next { get; set; }
        public CursorsViewModel Cursors { get; set; }
        public int Limit { get; set; }
        public string Href { get; set; }
    }
}
