using AccesAut1.Areas.Admin.Models;
using AccesAut1.Database;
using AccesAut1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccesAut1.Controllers
{
    public class ProductWishlistController : Controller
    {
        private Acsr3Context db = new Acsr3Context();

        public ProductWishlistController(Acsr3Context _db)
        {
            db = _db;
        }

        public async Task<IActionResult> AddProduct(ProductWishlistRequest productWishlistRquest)
        {
            string userId = "87f25e2c-1469-421c-9d03-d59cf103c8ed";
            ProductWishlist productWishlist = new ProductWishlist()
            {
                ProductId = productWishlistRquest.ProductId,
                UserId = userId
            };

            await db.ProductWishlist.AddAsync(productWishlist);
            db.SaveChanges();

            return Ok();
        }

        public IActionResult DeleteProduct(ProductWishlistRequest productWishlistRquest)
        {
            string userId = "87f25e2c-1469-421c-9d03-d59cf103c8ed";
            ProductWishlist productWishlist = db.ProductWishlist.Where(c => c.UserId == userId && c.ProductId == productWishlistRquest.ProductId).FirstOrDefault();

            db.ProductWishlist.Remove(productWishlist);
            db.SaveChanges();

            return Ok();
        }

        public IActionResult GetProductWishlist(string userId)
        {
            List<ProductWishlist> productWishlist = new List<ProductWishlist>();
            productWishlist = db.ProductWishlist.Where(c => c.UserId == userId).ToList();
            //s-ar putea sa avem ceva de genul asta, mai asteptam ViewBag.categories iltimen aici La 50 sa ma lasi sa bag pagina de meet la lab, ok

            return Ok(productWishlist);
        }
    }
}
