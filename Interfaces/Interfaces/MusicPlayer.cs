using System;

namespace Interfaces
{
    internal class MusicPlayer : IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("Music paused...");
        }

        public void Play()
        {
            Console.WriteLine("Playing music...");
        }
    }
}
