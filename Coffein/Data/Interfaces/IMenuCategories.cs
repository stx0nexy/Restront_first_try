using Coffein.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffein.Data.Interfaces
{
    public interface IMenuCategories
    {
        IEnumerable<Categories> AllCategories { get; }

    }
}
