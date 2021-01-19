using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccesAut1.Areas.Admin.Models
{
    public class ProductWishlistRequest
    {
        public int ProductId { get; set; }

        public string UserId { get; set; }
    }
}
