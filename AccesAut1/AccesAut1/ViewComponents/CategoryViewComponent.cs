using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccesAut1.Database;
using AccesAut1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccesAut1.ViewComponents
{

    [ViewComponent(Name = "Category")]
    public class CategoryViewComponent : ViewComponent
    {
        private Acsr3Context db = new Acsr3Context();
        public CategoryViewComponent(Acsr3Context _db)
        {
            db = _db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Category> categories = db.Categories.ToList();
         

            return View("Index", categories);
        }


    }
}
