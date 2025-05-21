using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DelegateReturn.Models
{
    class CompactDisk
    {

        public string Name { get; set; }
        public List<MusicSingle> Tracks { get; set; }
        public CompactDisk(string name, params MusicSingle[] tracks)
        {
            Name = name;
            Tracks = tracks.ToList();
        }
    }
}
