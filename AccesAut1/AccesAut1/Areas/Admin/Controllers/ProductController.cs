using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AccesAut1.Database;
using Microsoft.EntityFrameworkCore;
using AccesAut1.Areas.Admin.Models.ViewModels;
using AccesAut1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AutoAcces.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("admin")]
    [Route("admin/product")]
    public class ProductController : Controller
    {
        private Acsr3Context db = new Acsr3Context();

        public ProductController(Acsr3Context _db)
        {
            db = _db;
        }


        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.Products = db.Products.ToList();
            return View();

        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {

            var productViewModel = new ProductViewModel();
            productViewModel.Product = new Product();
            productViewModel.Categories = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();
            var categories = db.Categories.ToList();
            foreach (var category in categories)
            {
                var group = new SelectListGroup { Name = category.Name };
                if (category.Children != null && category.Children.Count > 0)
                {
                    foreach (var subCategory in category.Children)
                    {
                        var selectListItem = new SelectListItem
                        {
                            Text = subCategory.Name,
                            Value = subCategory.CategoryId.ToString(),
                            Group = group
                        };
                        productViewModel.Categories.Add(selectListItem);
                    }
                }
            }

            productViewModel.Suppliers = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();
            var suppliers = db.Suppliers.ToList();
            foreach (var suplier in suppliers)
            {


                var selectListItem = new SelectListItem
                {
                    Text = suplier.CompanyName,
                    Value = suplier.SupplierId.ToString(),

                };


                productViewModel.Suppliers.Add(selectListItem);

            }

            return View("Add", productViewModel);
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Add(ProductViewModel productViewModel)
        {
            db.Products.Add(productViewModel.Product);
            db.SaveChanges();

            //Create default photo for new product

            return RedirectToAction("index", "product", new { area = "admin" });
        }


        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {

            var product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();


            return RedirectToAction("index", "product", new { area = "admin" });
        }



       

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var productViewModel = new ProductViewModel();
            productViewModel.Product = db.Products.Find(id);
            productViewModel.Categories = new List<SelectListItem>();
            var categories = db.Categories.ToList();
            foreach (var category in categories)
            {
                var group = new SelectListGroup { Name = category.Name };
                if (category.Children != null && category.Children.Count > 0)
                {
                    foreach (var subCategory in category.Children)
                    {
                        var selectListItem = new SelectListItem
                        {
                            Text = subCategory.Name,
                            Value = subCategory.CategoryId.ToString(),
                            Group = group
                        };
                        productViewModel.Categories.Add(selectListItem);
                    }

              

                }
            }
            productViewModel.Suppliers = new List<SelectListItem>();
            var suppliers = db.Suppliers.ToList();
            foreach (var suplier in suppliers)
            {


                var selectListItem = new SelectListItem
                {
                    Text = suplier.CompanyName,
                    Value = suplier.SupplierId.ToString(),

                };


                productViewModel.Suppliers.Add(selectListItem);

            }
            return View("Edit", productViewModel);
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, ProductViewModel productViewModel)
        {
            db.Entry(productViewModel.Product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index", "product", new { area = "admin" });
        }
    }
}
