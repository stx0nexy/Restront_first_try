using Coffein.Data.Interfaces;
using Coffein.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffein.Data.mocks
{
    public class MockCategory : IMenuCategories
    {
        public IEnumerable<Categories> AllCategories
        {
            get
            {
                return new List<Categories>
                {
                    new Categories { categoryName="Напитки", desc="Их вкусно пить"},
                    new Categories { categoryName = "Еда", desc = "Её вкусно есть" }
                };
            }
        }
    }
}
