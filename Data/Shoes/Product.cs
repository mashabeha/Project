using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Shoes
{
    public class Product
    {
        public int id { set; get; }
        public string name { set; get; }
        public string shortDesc { set; get; }
        public string longDesc { set; get; }
        public string ing { set; get; }
        public ushort price { set; get; }
        public bool isFavorite { set; get; }
        public bool available { set; get; }
        public int categoryID { set; get; }

        public virtual Category Category { set; get; }
    }
}
