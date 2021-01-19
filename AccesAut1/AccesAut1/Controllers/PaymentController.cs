using AccesAut1.Database;
using AccesAut1.Models;
using AccesAut1.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccesAut1.Controllers
{
    [Route("payment")]
    public class PaymentController : Controller
    {
        private Acsr3Context db = new Acsr3Context();
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
    
        private readonly UserManager<User> _userManager;

        public PaymentController(IOrderRepository orderRepository,
            ShoppingCart shoppingCart, Acsr3Context _db, UserManager<User> userManager)
        {
            db = _db;
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
            _userManager = userManager;
        }

        //[Route("")]
        //[Route("index")]
        //public IActionResult Index()
        //{
        //    return View();
        //}


        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        [Authorize]
        //[HttpPost]
        [Route("checkout")]
        public async Task<IActionResult> Checkout(Order order)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            order.UserId = userId;

            var items = await _shoppingCart.GetShoppingCartItemsAsync();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some pizzas first");
            }

            if (ModelState.IsValid)
            {
                await _orderRepository.CreateOrderAsync(order);
                await _shoppingCart.ClearCartAsync();

                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        [Authorize]
        [Route("checkoutcomplete")]
        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = $"Thanks for your order, We'll deliver your pizzas soon!";
            return View();
        }
       



        // GET: Orders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("index")]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

     
       


     
    }
}
