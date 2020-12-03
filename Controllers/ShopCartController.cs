using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Repository;
using Shop.Data.Shoes;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ShopCartController:Controller
    {
        private readonly IAllShoes _shoesRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(ShoesRepository shoesRep, ShopCart shopCart)
        {
            _shoesRep = shoesRep;
            _shopCart = shopCart;

        }
        public ViewResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(); 
        } 

        public RedirectToActionResult addTocart(int id)
        {
            var item = _shoesRep.Shoes.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }

    }
}
