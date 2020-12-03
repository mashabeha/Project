using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Shop.Data.Shoes
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Product product { get; set; }
        public int price { get; set; }
        public string ShopCartId { get; set; }

    }
}
