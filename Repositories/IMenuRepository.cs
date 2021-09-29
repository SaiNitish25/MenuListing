using MenuListService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuListService.Repositories
{
    public interface IMenuRepository
    {
        public ICollection<MenuItem> GetAllMenuItems();
        public MenuItem GetMenuItem(int id);
    }
}
