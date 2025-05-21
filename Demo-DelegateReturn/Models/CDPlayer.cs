using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DelegateReturn.Models
{
    delegate void DelegateProgram();

    class CDPlayer
    {
        private DelegateProgram _program;
        public CompactDisk CurrentCD { get; set; }

        public void PlayCD()
        {
            if(_program is not null)
            {
                _program();
            }
            else
            {
                int trackNumber = 1;
                int timer = 0;
                foreach(MusicSingle music in CurrentCD.Tracks)
                {
                    PlayMusic(trackNumber, music, timer);
                    timer += music.Duration;
                    trackNumber++;
                }
            }
        }

        private DelegateProgram GenerateProgram(int trackNumber)
        {
            int timer = 0;
            for (int i = 0; i < trackNumber; i++)
            {
                timer += CurrentCD.Tracks[i].Duration;
            }
            MusicSingle currentMusic = CurrentCD.Tracks[trackNumber - 1];
            return delegate () { PlayMusic(trackNumber, currentMusic, timer); };
        }

        public void SetProgram(int trackNumber)
        {
            _program += GenerateProgram(trackNumber);
        }

        public void PlayMusic(int trackNumber, MusicSingle music, int timer)
        {
            //joue musique
            Console.WriteLine($"Lecture de la piste {trackNumber} : {music.Title} de {music.Artist} ({timer}ms)");
        }
    }
}
