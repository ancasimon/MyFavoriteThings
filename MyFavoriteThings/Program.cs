using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book("Beautiful Ruins", "Jess Walter");
            //{
            //    Title = "Beautiful Ruins",
            //    Author = "Jess Walter",
            //PubYear = "2012",
            //Location = "Hollywood, CA; Florence, Italy"
            //};
            var book2 = new Book("Gone Girl", "Gillian Flynn");
            //{
            //    Title = "Gone Girl", 
            //    Author = "Gillian Flynn",
            //    //PubYear = "2012",
            //    //Location = "Missouri"
            //};

            book1.BookClubRead(true);
            book2.BookClubRead(false);
        }
    }
}
