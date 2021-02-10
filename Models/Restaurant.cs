using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Restaurant
    {
        [Required]
        public int RestRanking { get; set; }
        [Required]
        public string RestName { get; set; }
        public string? FavDish { get; set; }
        [Required]
        public string RestAddress { get; set; }
        public string? RestPhone { get; set; }
        public string? RestWebsite { get; set; } 


        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant()
            {
                RestRanking = 1,
                RestName = "Tepanyaki's",
                FavDish = "Filet Mignon with Noodles",
                RestAddress = " 72 N 850 E, Lehi, UT 84043",
                RestPhone = "(801) 653-2988",
                RestWebsite = "www.google.com"

            };

            Restaurant r2 = new Restaurant()
            {
                RestRanking = 2,
                RestName = "The Mandarin",
                FavDish = "Beef and Brocoli with Noodles",
                RestAddress = "348 900 N, Bountiful, UT 84010",
                RestPhone = "(801) 298-2406",
                RestWebsite = "https://mandarinutah.com/"
            };

            Restaurant r3 = new Restaurant()
            {
                RestRanking = 3,
                RestName = "In-N-Out Burger",
                FavDish = "Double Double Combo",
                RestAddress = "350 E University Pkwy, Orem, UT 84058",
                RestPhone = "(800) 786-1000",
                RestWebsite = "https://www.in-n-out.com/menu"
            };

            Restaurant r4 = new Restaurant()
            {
                RestRanking = 4,
                RestName = "Wendy's",
                FavDish = "4 for $4",
                RestAddress = "1066 S. University Ave, Provo, UT 84601",
                RestPhone = "(801) 377-1413",
                RestWebsite = "https://locations.wendys.com/united-states/ut/provo/1066-s.-university-ave."
            };

            Restaurant r5 = new Restaurant()
            {
                RestRanking = 5,
                RestName = "Zao's",
                FavDish = "Fried Chicken and Noodles",
                RestAddress = "1352 State St, Orem, UT 84097",
                RestPhone = "(801) 224-0030",
                RestWebsite = "https://www.zaoasiancafe.com/location/orem/"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
