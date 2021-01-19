using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccesAut1.Database;
using AccesAut1.Helper;
using AccesAut1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccesAut1.ViewComponents
{

    [ViewComponent(Name = "CartTop")]
    public class CartTopViewComponent : ViewComponent
    {

        private readonly Acsr3Context _db = new Acsr3Context();

        public CartTopViewComponent(Acsr3Context db)
        {
            _db = db;
        }
  
        public async Task<IViewComponentResult> InvokeAsync()
        {

            //List<Item> cart = _db.Items.ToList();
            //ViewBag.cart = cart;
            //ViewBag.countItems = cart.Count;
            //ViewBag.Total = cart.Sum(it => it.Price * it.Quantity);
            return View("Index");
        }


    }
}
