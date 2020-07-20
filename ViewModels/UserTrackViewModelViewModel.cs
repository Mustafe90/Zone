using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zone.ViewModels
{
    public class UserTrackViewModelViewModel : TrackViewModel
    {
        public BasicAlbum Album { get; set; }

        public int Popularity { get; set; }

    }
}
