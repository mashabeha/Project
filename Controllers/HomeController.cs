using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController: Controller
    {
        private readonly IAllShoes _shoesRep;
        
        public HomeController(IAllShoes shoesRep)
        {
            _shoesRep = shoesRep;

        }
        public ViewResult Index()
        {
            var homeProducts = new HomeViewModel
            {
                favGoods = _shoesRep.getFavGoods
            };
            return View(homeProducts);
        }
    }
}
