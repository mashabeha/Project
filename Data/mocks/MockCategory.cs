using Shop.Data.Interfaces;
using Shop.Data.Shoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : IShoesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> {
                    new Category { categoryName= "Черевики", desc= "Сезонне взуття"},
                    new Category { categoryName= "Кросівки", desc= "Розпродаж"},
                };
            }
        }
    }
}
    