using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DelegateReturn.Models
{
    class MusicSingle
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }

        public MusicSingle(string artist, string title, int duration)
        {
            Artist = artist;
            Title = title;
            Duration = duration;
        }
    }
}
