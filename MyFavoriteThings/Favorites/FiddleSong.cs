using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Favorites
{
    class FiddleSong
    {

        //properties:
        //read-only property - to be set only in the constructor:
        public string Title { get; }

        //read-only property - to be set only in the constructor:
        public bool IsFolkSong { get;  }

        public DifficultyLevel Level { get; set; }

        //constructor:
        public FiddleSong(string title, bool folkSong)
        {
            Title = title;
            IsFolkSong = folkSong;
        }

        //methods:
        public void Listen()
        {
            if (IsFolkSong == true)
            {
                Console.WriteLine($"Fiddle songs are great and yes, most are folk songs. Just listen to {Title}!");
            }
            else
            {
                Console.WriteLine($"Fiddle songs are great - even when they are not traditional folk songs - take {Title}, for example.");
            }

        }

        public void StarterSong(DifficultyLevel level)
        {
            Level = level;
            if (level == DifficultyLevel.Low)
            {
                Console.WriteLine($"{Title} is a great beginner song!");
            }
            else
            {
                Console.WriteLine($"Some songs, such as {Title}, are for more advanced players.");
            }
        }

    }

    enum DifficultyLevel
    {
        Low,
        Medium,
        High
    }
}
