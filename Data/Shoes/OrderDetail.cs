using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Shoes
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int ShoesID { get; set; }
        public uint price { get; set; }
        public virtual Product product { get; set; }
        public virtual Order order { get; set; }
    
    }
}
