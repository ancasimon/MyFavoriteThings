using MyFavoriteThings.Favorites;
using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            //About books:
            var book1 = new Book("Beautiful Ruins", "Jess Walter", true)
            {
                PubYear = "2012", 
                Location = "Hollywood, CA, and Florence, Italy"
            };
            var book2 = new Book("Gone Girl", "Gillian Flynn", false)
            {
                PubYear = "2012",
                Location = "Missouri"
            };

            book1.BookClubRead(true);
            book2.BookClubRead(false);
            book1.Published("2012", "Hollywood, CA, and Florence, Italy");
            book2.Published("2012", "Missouri");

            //About campsites:
            var campsite1 = new CampSite();
            var campsite2 = new CampSite();

            campsite1.Favorite("Virgin Falls", StateList.TN);
            campsite2.Backpacking("Savage Gulf", false);


            //About fiddle songs:
            var song1 = new FiddleSong("Buffalo Girls", true);
            var song2 = new FiddleSong("Boil 'em Cabbage Down", true);
            var song3 = new FiddleSong("The Devil Went Down to Georgia", false);

            song1.Listen();
            song3.Listen();
            song2.StarterSong(DifficultyLevel.Low);
            song3.StarterSong(DifficultyLevel.Medium);


            //About summer activities:

            var activity1 = new SummerActivity("Geocaching");
            var activity2 = new SummerActivity("Gardening");
            var activity3 = new SummerActivity("Dinner at Mangia");

            activity1.Describe("around home");
            activity2.Describe("at home");
            activity1.ChooseKidFriendly(true);
            activity3.ChooseKidFriendly(false);

        }
    }
}
