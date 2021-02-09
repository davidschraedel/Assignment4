using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestProvoRestaurants.Models
{
    public class SuggestedRestaurantStorage
    {
        private static List<UserRestaurant> suggestedRests = new List<UserRestaurant>();

        public static IEnumerable<UserRestaurant> ConcatSuggestRestaurants => suggestedRests;

        public static void AddRestaurant(UserRestaurant Restaurant)
        {
            suggestedRests.Add(Restaurant);
        }
    }
}
