

using AccesAut1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AccesAut1.Repositories
{
    public interface IOrderRepository
    {
        Task CreateOrderAsync(Order order);

    }
}
