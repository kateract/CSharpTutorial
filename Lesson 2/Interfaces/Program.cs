using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPlayable> playlist = new List<IPlayable>();
            playlist.Add(new Music());
            playlist.Add(new Video());

            playlist.ForEach(i => i.Play());

            Music song = new Music();
            song.Play();

            Video movie = new Video();
            movie.Play();
        }
    }

    interface IPlayable
    {
        void Play();
    }

    class Music : IPlayable
    {
        // Explicit implementation - no access modifier needed because the interface method must be public
        // Not accessible from a Music reference
        void IPlayable.Play()
        {
            Console.WriteLine("Now Playing: Darude - Sandstorm");
        }
    }

    class Video : IPlayable
    {
        // Implicit implementation - Access modifier required to be public, but still works for interface.
        public void Play() 
        {
            Console.WriteLine("Now Playing: Rick Astley - Never Gonna Give You Up");
        }
    }

}
