using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Book
    {
        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string PubYear { get; set; }
        public string Location { get; set; }

        //fields
        private bool _wasBookClubPick;

        //constructor
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Console.WriteLine($"{title} got instantiated!!");
        }

        //methods
        public void Published()
        {
            if(PubYear != "")
            {
                Console.WriteLine($"{Title} was published in {PubYear}.");
            }
            else
            {
                Console.WriteLine($"We don't know when {Title} was published.");
            }
        }

        public void BookClubRead(bool _wasBookClubPick)
        {
            if (_wasBookClubPick == true)
            {
                Console.WriteLine($"We did read {Title} in book club!");

            }
            else
            {
                Console.WriteLine($"We have not yet read {Title} in book club!");

            }
        }
    }
}
