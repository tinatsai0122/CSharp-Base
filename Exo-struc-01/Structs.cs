using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_struc_01
{
    public struct PisteAudio
    {
        public string artist, title, category;
        public int lengthSong;
    }

    public struct Album
    {
        public string albumTitle;
        public List<PisteAudio> tracks;
        public DateOnly releaseDate;
    }
}
