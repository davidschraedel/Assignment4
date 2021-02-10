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
        public string FavoriteDish { get; set; }
        [Required]
        //[DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\([\d]{3}\) [\d]{3}-[\d]{4}$", ErrorMessage = "Phone # must be in correct format: (###) ###-####")]
        public string Phone { get; set; }

    }
}
