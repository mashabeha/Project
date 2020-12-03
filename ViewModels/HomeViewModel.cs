using Shop.Data.Shoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> favGoods { get; set; }
    }
}
