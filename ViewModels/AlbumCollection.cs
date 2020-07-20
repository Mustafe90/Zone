using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zone.ViewModels
{
    public class AlbumCollection
    {
        public string Href { get; set; }

        [JsonPropertyName("items")]
        public List<AlbumContainer> Albums { get; set; }

        public int Limit { get; set; }

        public object Next { get; set; }

        public int Offset { get; set; }

        public string Previous { get; set; }

        public int Total { get; set; }
    }

}
