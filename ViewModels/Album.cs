using System.Collections.Generic;

namespace Zone.ViewModels
{
    public class Album : BasicAlbum
    {
        public List<Artist> Artists { get; set; }
        public List<CopyrightViewModel> Copyrights { get; set; }
        public ExternalIdsViewModel ExternalIdsViewModel { get; set; }
        public List<object> Genres { get; set; }
        public string Label { get; set; }
        public int Popularity { get; set; }
        public TracksViewModel TracksViewModel { get; set; }

    }
    public abstract class BasicAlbum
    {
        public string AlbumType { get; set; }
        public List<Artist> Artists { get; set; }
        public List<string> AvailableMarkets { get; set; }
        public ExternalUrlsViewModel ExternalUrlsViewModel { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public List<ImageViewModel> Images { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public string ReleaseDatePrecision { get; set; }
        public int TotalTracks { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }

    }
}
