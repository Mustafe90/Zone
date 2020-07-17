using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zone.Models
{
    public class Album
    {
        public string AlbumType { get; set; }
        public List<Artist> Artists { get; set; }
        public List<string> AvailableMarkets { get; set; }
        public List<Copyright> Copyrights { get; set; }
        public ExternalIds ExternalIds { get; set; }
        public ExternalUrls ExternalUrls { get; set; }
        public List<object> Genres { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public List<Image> Images { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
        public int Popularity { get; set; }
        public string ReleaseDate { get; set; }
        public string ReleaseDatePrecision { get; set; }
        public int TotalTracks { get; set; }
        public Tracks Tracks { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }

    }
}
