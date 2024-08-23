using System.Collections.Generic;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPlayable> playables = new List<IPlayable>()
            {
                new MusicPlayer(),
                new VideoPlayer()
            };

            foreach (IPlayable playable in playables)
            {
                playable.Play();
                playable.Pause();
            }
        }
    }
}
