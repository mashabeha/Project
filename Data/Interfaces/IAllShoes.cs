using System;
using Shop.Data.Shoes;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
  public  interface IAllShoes
    {
        IEnumerable<Product> Shoes { get; }
        IEnumerable<Product> getFavGoods { get; }
        Product getObjectShoes(int GoodsId);
    }
}
