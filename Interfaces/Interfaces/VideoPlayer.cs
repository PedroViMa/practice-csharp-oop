using System;

namespace Interfaces
{
    internal class VideoPlayer : IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("Video paused...");
        }

        public void Play()
        {
            Console.WriteLine("Playing video...");
        }
    }
}
