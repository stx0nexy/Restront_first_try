using Coffein.Data.Interfaces;
using Coffein.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffein.Controllers
{
    public class MenuController : Controller
    {
        private readonly IAllMenu _allMenu;
        private readonly IMenuCategories _allCategories;
        public MenuController(IAllMenu iallMenu, IMenuCategories imenuCat)
        {
            _allMenu = iallMenu;
            _allCategories = imenuCat;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Cтраница с меню";
            MenuListViewModel obj = new MenuListViewModel();
            obj.allMenu = _allMenu.Menus;
            obj.currCategory = "Меню";
            return View(obj);
        }
    }
}
