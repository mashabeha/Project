using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Shoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class ShoesRepository : IAllShoes
    {
        private readonly AppDBContent appDBContent;
        public ShoesRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Product> Shoes => appDBContent.Product.Include(c=> c.Category);

        public IEnumerable<Product> getFavGoods => appDBContent.Product.Where(p => p.isFavorite).Include(c => c.Category);

        public Product getObjectShoes(int GoodsId) => appDBContent.Product.FirstOrDefault(p => p.id == GoodsId);
    }
}
