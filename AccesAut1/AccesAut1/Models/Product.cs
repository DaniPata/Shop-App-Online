﻿using AccesAut1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AccesAut1.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Photo { get; set; }

        public int Quantity { get; set; }
        public string Brand { get; set; }



        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; }



        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
 


    }
}
