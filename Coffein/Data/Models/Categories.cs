using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffein.Data.Models
{
    public class Categories
    {
        public int id { set; get; }

        public string categoryName { set; get; }

        public string desc { set; get; }

       public List<Menu> menus { set; get; }

    }
}
