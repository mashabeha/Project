using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Shoes
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;
        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string ShoCartId { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();

            session.SetString("cartId", shopCartId);

            return new ShopCart(context)
            {
                ShoCartId = shopCartId
            };

         }
        public void AddToCart(Product product)
        {
            appDBContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId=ShoCartId,
                product = product,
                price = product.price
            }) ;
            appDBContent.SaveChanges();
        }
        public List<ShopCartItem> GetShopItems() {
            return appDBContent.ShopCartItem.Where(c => c.ShopCartId == ShoCartId).Include(s => s.product).ToList();
                }
    }
}
