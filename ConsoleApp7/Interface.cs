using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal interface IPlayable
    {
        public void Play();
    }
    class videoplayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("playing video");
        }
    }
    class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("playing music");
        }
    }
    class interfaceassignment
    {
        static void Main()
        {
            videoplayer p = new videoplayer();
            p.Play();
            MusicPlayer m = new MusicPlayer();
            m.Play();

            Console.Read();
        }
    }
}
