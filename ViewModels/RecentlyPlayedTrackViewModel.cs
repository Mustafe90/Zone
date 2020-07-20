using System;

namespace Zone.ViewModels
{
    public class RecentlyPlayedTrackViewModel
    {
        public UserTrackViewModelViewModel Track { get; set; }
        public DateTime PlayedAt { get; set; }
        public Context Context { get; set; }
    }
}
