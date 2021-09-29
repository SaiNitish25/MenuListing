using MenuListService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuListService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private IMenuRepository _menuRepo;
        public MenuItemController(IMenuRepository menuRepository)
        {
            _menuRepo = menuRepository;
        }

        [HttpGet]

        public IActionResult GetAllMenuItems()
        {
            var list = _menuRepo.GetAllMenuItems();
            return Ok(list);
        }
        [HttpGet("{Id:int}", Name = "GetMenuItem")]
        public  IActionResult GetMenuItem(int id)
        {
            var item = _menuRepo.GetMenuItem(id);
            return Ok(item);
        }
    }
}
