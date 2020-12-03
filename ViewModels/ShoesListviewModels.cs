using Shop.Data.Shoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class ShoesListviewModels
    {
        public IEnumerable<Product> AllShoes { get; set; }
        public string shoesCategory { get; set; }
    }
}
