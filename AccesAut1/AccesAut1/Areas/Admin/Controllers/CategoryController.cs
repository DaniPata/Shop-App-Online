using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccesAut1.Database;
using AccesAut1.Models;
//using AutoAcces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AccesAut1.Areas.Admin.Controllers

{

    [Authorize(Roles = "Admin")]
    [Area("admin")]
    [Route("admin/category")]
    public class CategoryController : Controller

    {
       
        private Acsr3Context db = new Acsr3Context();

        public CategoryController( Acsr3Context _db)
        {
           
            db = _db;
        }



        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.categories = db.Categories.Where(c => c.Children != null).ToList();
            ViewBag.categories = db.Categories.Where(c => c.ParentCategory == null).ToList();
            return View();
        }






        //    [HttpGet]
        //    [Route("add")]
        //    public ActionResult Add( Category category)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            category.Parent = null;
        //            db.Categories.Add(category);
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }

        //        return View(category);
        //    }
        //}
        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            var category = new Category();

            return View("Add", category);
        }


        [HttpPost]
        [Route("add")]
        public IActionResult Add(Category category)
        {
            category.ParentCategory = null;
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index", "category", new { area = "admin" });
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Route("add")]
        //public async Task<IActionResult> Create([Bind("CategoryName, Description")] Category category)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        category.Parent = null;
        //        await _categoryService.CreateCategory(category);
        //        return RedirectToAction("Index");
        //    }
        //    return View(category);
        //}


        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index", "category", new { area = "admin" });
        }


        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var category = db.Categories.Find(id);

            return View("Edit", category);
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, Category category)
        {
            var currentCategory = db.Categories.Find(id);
            currentCategory.Name = category.Name;
        
            db.SaveChanges();
            return RedirectToAction("Index", "category", new { area = "admin" });
        }


        [HttpGet]
        [Route("addsubcategory/{id}")]
        public IActionResult AddSubcategory(int id)
        {
            var category = new Category()
            {

                ParentCategoryId = id
            };

            return View("AddSubcategory", category);
        }

        [HttpPost]
        [Route("addsubcategory/{id}")]
        public IActionResult AddSubcategory(int id, Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index", "category", new { area = "admin" });
        }


    }
}

