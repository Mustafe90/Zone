using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zone.ViewModels;

namespace Zone.ViewModels
{
    public class CurrentlyPlayingViewModel
    {
        public long Timestamp { get; set; }
        public Context Context { get; set; }
        public int ProgressMs { get; set; }
        public UserTrackViewModelViewModel Track { get; set; }
        public string CurrentlyPlayingType { get; set; }
        public Actions Actions { get; set; }
        public bool IsPlaying { get; set; }
    }
}
