using System.Collections.Generic;

namespace Zone.ViewModels
{
    public class AlbumViewModel : BasicAlbumViewModel
    {
        public List<ArtistViewModel> Artists { get; set; }
        public List<CopyrightViewModel> Copyrights { get; set; }
        public ExternalIdsViewModel ExternalIdsViewModel { get; set; }
        public List<object> Genres { get; set; }
        public string Label { get; set; }
        public int Popularity { get; set; }
        public TracksViewModel TracksViewModel { get; set; }

    }
}
