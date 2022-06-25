using Coffein.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffein.ViewModels
{
    public class MenuListViewModel
    {
        public IEnumerable<Menu> allMenu { get; set; }
        public string currCategory { get; set; }
    }
}
