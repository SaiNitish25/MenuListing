using MenuListService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuListService.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        public ICollection<MenuItem> GetAllMenuItems()
        {
            var menuItems = (from p in MenuData.menuItems select p).ToList();
            return menuItems;
        }

        public MenuItem GetMenuItem(int id)
        {
            MenuItem menuItem = MenuData.menuItems.Where(m => m.Id == id).FirstOrDefault();
            return menuItem;
        }
    }
}
