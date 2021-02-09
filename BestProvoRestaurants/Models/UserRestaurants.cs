using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BestProvoRestaurants.Models
{
    public class UserRestaurant
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        public string FavoriteDish { get; set; } = "It's all tasty!";
        [Required]
        [Phone]
        public string Phone { get; set; }

    }
}
