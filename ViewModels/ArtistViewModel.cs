using System.Text.Json.Serialization;

namespace Zone.ViewModels
{
    public class ArtistViewModel
    {
        [JsonPropertyName("external_urls")]
        public ExternalUrlsViewModel ExternalUrlsViewModel { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }

    }
}
