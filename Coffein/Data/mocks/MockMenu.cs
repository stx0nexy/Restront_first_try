using Coffein.Data.Interfaces;
using Coffein.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffein.Data.mocks
{
    public class MockMenu : IAllMenu
    {
        private readonly IMenuCategories _categoryMenu = new MockCategory();
        public IEnumerable<Menu> Menus 
        {
            get
            {
                return new List<Menu> { 
                new Menu{
                    name="Капучино",
                    shortDesc="Кофе с молоком", 
                    longDesc="Кофе в который добавили молоко", 
                    img="https://upload.wikimedia.org/wikipedia/commons/1/16/Classic_Cappuccino.jpg",
                    price = 50,
                    isFavourite = true,
                    available = true, 
                    Categories = _categoryMenu.AllCategories.First()},
                new Menu{
                    name="Латте",
                    shortDesc="Молоко с кофе",
                    longDesc="Молоко в которое добавили кофе",
                    img = "https://coffee61.ru/wa-data/public/photos/68/03/368/368.970.jpg",
                    price = 60,
                    isFavourite = false,
                    available = true,
                    Categories = _categoryMenu.AllCategories.First()},
                new Menu{
                    name="Сендвичь",
                    shortDesc="Хлеб с начинкой",
                    longDesc="Хлеб к которому добавили начинку",
                    img = "https://static.1000.menu/img/content-v2/af/5d/38399/sendvich-s-vetchinoi_1616239118_15_max.jpg",
                    price = 100,
                    isFavourite = true,
                    available = true,
                    Categories = _categoryMenu.AllCategories.Last()}
                };
            }
        }
        public IEnumerable<Menu> GetFavMenu { get; set ; }

        public Menu GetObgectMenu(int MenuId)
        {
            throw new NotImplementedException();
        }
    }
}
