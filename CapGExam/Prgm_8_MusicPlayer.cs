using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    interface IPlayable
    {
        void Play();
        
    }
    class Prgm_8_MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing Music");
        }
    }
    class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing Video");
        }
    }
    
}
