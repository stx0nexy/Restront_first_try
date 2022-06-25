using Coffein.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffein.Data.Interfaces
{
    public interface IAllMenu
    {
        IEnumerable<Menu> Menus { get;  }
        IEnumerable<Menu> GetFavMenu { get; set; }
        Menu GetObgectMenu(int MenuId);
    }
}
