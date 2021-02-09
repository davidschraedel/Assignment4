using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestProvoRestaurants.Models
{
    public class TopRestaurant
    {
        [Required]
        public int Rank { get; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public string FavoriteDish { get; set; } = "It's all tasty!";
        public string Phone { get; set; }
        public string Website { get; set; } = "Coming soon";


        public TopRestaurant(int rankInput)
        {
            Rank = rankInput;
        }


        public static TopRestaurant[] GetTopRestaurants()
        {
            TopRestaurant r1 = new TopRestaurant(1)
            {
                Name = "El Salvador Restaurant",
                FavoriteDish = "Pupusas Revueltas",
                Address = "332 W Center St, Provo, UT 84601",
                Phone = "801 373 5377",
                
            };
            TopRestaurant r2 = new TopRestaurant(2)
            {
                Name = "Don Joaquin Street Tacos",
                FavoriteDish = "Al Pastor Burritos",
                Address = "150 W 1230 N St, Provo, UT 84604",
                Phone = "801 400 2894",
                Website = "https://stdonjoaquin.com/"
            };
            TopRestaurant r3 = new TopRestaurant(3)
            {
                Name = "Hruska's Kolaches",
                FavoriteDish = "Ranchero",
                Address = "434 W Center St, Provo, UT 84601",
                Phone = "801 623 3578",
                Website = "http://hruskaskolaches.com/"
            };
            TopRestaurant r4 = new TopRestaurant(4)
            {
                Name = "Koko Lunchbox",
                Address = "1175 N Canyon Rd #3420, Provo, UT 84604",
                Phone = "801 850 4358",
                Website = "https://m.facebook.com/kokobobox/"
            };
            TopRestaurant r5 = new TopRestaurant(5)
            {
                Name = "Cubby's",
                FavoriteDish = "Rosemary Fries",
                Address = "1258 N State St, Provo, UT 84604",
                Phone = "801 919 3023",
                Website = "http://cubbys.co/"
            };

            return new TopRestaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
