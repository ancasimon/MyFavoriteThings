using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Favorites
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
        public Book(string title, string author, bool bookClubPick)
        {
            Title = title;
            Author = author;
            _wasBookClubPick = bookClubPick;
            Console.WriteLine($"{title} got instantiated!!");
        }

        //methods
        public void Published(string publicationYear, string location)
        {
            PubYear = publicationYear;
            Location = location;

            if(publicationYear != "")
            {
                Console.WriteLine($"{Title} was published in {PubYear} and it is set in {Location}.");
            }
            else
            {
                Console.WriteLine($"We don't know when {Title} was published but we know it is set in {Location}.");
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
