using AccesAut1.Database;
using AccesAut1.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccesAut1.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly Acsr3Context _db;
        private readonly ShoppingCart _shoppingCart;


        public OrderRepository(Acsr3Context db, ShoppingCart shoppingCart)
        {
            _db = db;
            _shoppingCart = shoppingCart;
        }

        public async Task CreateOrderAsync(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            decimal totalPrice = 0M;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    ProductId = shoppingCartItem.Product.ProductId,
                    Order = order,
                    Price = (decimal)shoppingCartItem.Product.Price,
                    
                };
                totalPrice += orderDetail.Price * orderDetail.Amount;
                _db.OrderDetails.Add(orderDetail);
            }

            order.OrderTotal = totalPrice;
            _db.Orders.Add(order);

            await _db.SaveChangesAsync();
        }

        
    }
}
