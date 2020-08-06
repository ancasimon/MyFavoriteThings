using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MyFavoriteThings.Favorites
{
    class SummerActivity
    {
        //properties:
        public string Name { get; }
        public bool IsKidFriendly { get; set; }
        public string Materials { get; set; }
        public string Location { get; set; }

        //constructor:
        public SummerActivity(string name)
        {
            Name = name;
        }

        //methods:

        public void ChooseKidFriendly(bool isKidFriendly)
        {
            IsKidFriendly = isKidFriendly;
            if (IsKidFriendly == true)
            {
                Console.WriteLine($"{Name}: Sure, take your kids along.");
            }
            else
            {
                Console.WriteLine($"{Name}: Maybe save this idea for post-pandemic days!");
            }
        }

        public void Describe(string location)
        {
            Location = location;

            if (Name == "Geocaching")
            {
                RequireMaterials("GPS, pen, and a treasure to pass on!");
            }
            else if (Name == "Gardening")
            {
                RequireMaterials("gloves and a rake");
            }

        }

        private void RequireMaterials(string materials)
        {
            Materials = materials;
            Console.WriteLine($"For this activity, {Name}, you will need the following materials: {Materials}.");
        }




    }
}
