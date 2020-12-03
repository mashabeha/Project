using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Shoes;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ShoesController : Controller
    {
        private readonly IAllShoes _allShoes;
        private readonly IShoesCategory _allCategory;

        public ShoesController(IAllShoes iallShoes, IShoesCategory ishoesCat)
        {
            _allShoes = iallShoes;
            _allCategory = ishoesCat;
        }

        [Route("Shoes/List")]
        [Route("Shoes/List/{category}")]

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products = null;
            string shoesCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                products = _allShoes.Shoes.OrderBy(i => i.id);
            }
            else if (string.Equals("кросівки", category, StringComparison.OrdinalIgnoreCase))
            {
                products = _allShoes.Shoes.Where(i => i.Category.categoryName.Equals("Крoсівки")).OrderBy(i => i.id);
                shoesCategory = "Крoсівки";
            }
            else if (string.Equals("черевики", category, StringComparison.OrdinalIgnoreCase))
            {
                products = _allShoes.Shoes.Where(i => i.Category.categoryName.Equals("Черевики")).OrderBy(i => i.id);
                shoesCategory = "Черевики";
            }
       
            var shoesObj = new ShoesListviewModels
            {
                AllShoes = products,
                shoesCategory = shoesCategory,
            };


            ViewBag.Title = "Сторінка з брендами-";
            ShoesListviewModels obj = new ShoesListviewModels();
            obj.AllShoes = _allShoes.Shoes;
            obj.shoesCategory = "Бренди";

            return View(shoesObj);
        }


    }
}

