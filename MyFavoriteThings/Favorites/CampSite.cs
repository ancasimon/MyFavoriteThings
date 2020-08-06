using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace MyFavoriteThings.Favorites
{
    class CampSite
    {
        //properties:
        public string Location { get; set; }
        public StateList State { get; set; }
        public bool IsCarCamping { get; set; }
        
        //methods:
        public void Favorite(string location, StateList state)
        {
            Location = location;
            State = state;
            Console.WriteLine($"{Location} in {State} is a favorite camping site.");
        }

        public void Backpacking(string location, bool isCarCamping)
        {
            Location = location;
            IsCarCamping = isCarCamping;
            if(isCarCamping == true)
            {
                Console.WriteLine($"{Location} is a car camping site. Yes, you can take the kitchen sink!");
            }
            else
            {
                Console.WriteLine($"Be careful; you have to hike to your campsite in {Location} so yes, you have to carry everything you are packing!");
            }
        }

    }

    enum StateList
    {
        NotSet,
        TN, 
        GA,
        AL,
        NC, 
        VA
    }
}
