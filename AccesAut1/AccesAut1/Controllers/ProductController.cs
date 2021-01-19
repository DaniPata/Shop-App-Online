using AccesAut1.Database;
using AccesAut1.Models;
using MailChimp.Net.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccesAut1.Controllers
{
    public class ProductController : Controller
    { 

        private Acsr3Context db = new Acsr3Context();
        public ProductController(Acsr3Context _db)
        {
            db = _db;
        }

        public IActionResult Product()
        {
            return View();
        }


        [Route("details/{id}")]
        public IActionResult Details(int id)
        {
            var product = db.Products.Find(id);
            //var featuredPhoto = product.Photo.SingleOrDefault(product => product.Featured);
            ViewBag.Product = product;
            //ViewBag.FeaturedPhoto = featuredPhoto == null ? "no image.jpg" : featuredPhoto.Name;
            ViewBag.ProductImages = product.Photo.ToList();
            ViewBag.RelatedProducts = db.Products.Where(p => p.CategoryId == product.CategoryId && p.ProductId != id).ToList();
            return View("ProductDetails");
        }


        

        [Route("category/{id}")]
        public IActionResult Category(int id)
        {

            var category = db.Categories.Find(id);
            ViewBag.Category = category;
            ViewBag.CountProducts = category.Products.Count();
            ViewBag.Products = category.Products.ToList();
            return View("Category");
        }
    }
}
