using System;
using System.Collections.Generic;

namespace InheritanceAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPlayable> playlist = new List<IPlayable>();
            List<Media> library = new List<Media>();
            var book = new Book("Ender's Game");
            library.Add(book);
            var movie = new Movie("Inception");
            library.Add(movie);
            playlist.Add(movie);
            var music = new Music("Where the Streets Have No Name");
            library.Add(music);
            playlist.Add(music);

            Console.WriteLine("My Library has these titles in it:");
            library.ForEach(i => Console.WriteLine(i.Title));

            Console.WriteLine("My playlist has these media entries queued:");
            playlist.ForEach(i => i.Play());
        }
    }

    interface IPlayable
    {
        void Play();
    }

    class Media
    {
        public Media(string title)
        {
            Title = title;
        }
        public string Title { get; set; }
    }

    class Movie : Media, IPlayable
    {
        public Movie(string title) : base(title) {}
        public void Play() { 
            Console.WriteLine(Title);
        }
    }

    class Book : Media {
        public Book(string title) : base(title) {}
    }

    // this will error, can't have two base classes
    // class BookAdaptation : Movie, Book, IPlay
    // {

    // }

    class Music : Media, IPlayable
    {
        public Music (string title) : base(title) {}

        public void Play() { Console.WriteLine(Title); }
    }
}
