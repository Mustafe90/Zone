using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Zone.ViewModels
{
    public class BasicAlbumViewModel 
    {
        public  BasicAlbumViewModel()  { }

        [JsonPropertyName("album_type")]
        public string AlbumType { get; set; }

        public List<ArtistViewModel> Artists { get; set; }

        [JsonPropertyName("available_markets")]
        public List<string> AvailableMarkets { get; set; }

        [JsonPropertyName("external_urls")]

        public ExternalUrlsViewModel ExternalUrlsViewModel { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public List<ImageViewModel> Images { get; set; }
        public string Name { get; set; }

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }

        [JsonPropertyName("release_date_precision")]
        public string ReleaseDatePrecision { get; set; }

        [JsonPropertyName("total_tracks")]
        public int TotalTracks { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }
}
