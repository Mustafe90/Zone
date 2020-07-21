using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zone.ViewModels
{
    public class RecentlyPlayedTrackViewModel
    {
        public UserTrackViewModelViewModel Track { get; set; }
        [JsonPropertyName("played_at")]
        public DateTime PlayedAt { get; set; }
        public ContextViewModel Context { get; set; }
    }
    public class CompareTracks : IEqualityComparer<RecentlyPlayedTrackViewModel>
    {
        public bool Equals(RecentlyPlayedTrackViewModel x, RecentlyPlayedTrackViewModel y)
        {
            if (x == null || y == null)
            {
                return false;
            }
            return x.Track == y.Track;
        }

        public int GetHashCode(RecentlyPlayedTrackViewModel obj)
        {
            return obj.Track.GetHashCode();
        }
    }
}
