using AccesAut1.Database;
using AccesAut1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccesAut1.ViewComponents
{
    [ViewComponent(Name = "ProductDetails")]
    public class ProductDetailsViewComponent : ViewComponent
    {
        private Acsr3Context db = new Acsr3Context();
        public ProductDetailsViewComponent(Acsr3Context _db)
        {
            db = _db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Product> products = db.Products.ToList();


            return View("Index", products);
        }
    }
}
