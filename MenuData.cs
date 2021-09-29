using MenuListService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuListService
{
    public static class MenuData
    {
        public static List<MenuItem> menuItems = new List<MenuItem>()
        {
            new MenuItem()
            {
                Id = 1,
                Name = "Biryani",
                freeDelivery = true,
                Price =200,
                dateOfLaunch =new DateTime(2021, 9, 15),
                Active = true
            },
            new MenuItem()
            {
                Id = 2,
                Name = "Panner Manchuria",
                freeDelivery = true,
                Price =150,
                dateOfLaunch =new DateTime(2021, 9, 15),
                Active = true
            }

         };

    }
}
