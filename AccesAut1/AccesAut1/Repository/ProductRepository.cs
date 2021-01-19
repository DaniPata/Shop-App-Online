using AccesAut1.Database;
using AccesAut1.Models;
using AccesAut1.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccesAut1.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Acsr3Context _db;

        public ProductRepository(Acsr3Context db)
        {
            _db = db;
        }

        public IEnumerable<Product> Products => _db.Products.Include(p => p.Category); //include here

        public void Add(Product product)
        {
            _db.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return _db.Products.ToList();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _db.Products.ToListAsync();
        }

   

      

        public Product GetById(int? id)
        {
            return _db.Products.FirstOrDefault(p => p.ProductId == id);
        }

        public async Task<Product> GetByIdAsync(int? id)
        {
            return await _db.Products.FirstOrDefaultAsync(p => p.ProductId == id);
        }

  


        public bool Exists(int id)
        {
            return _db.Products.Any(p => p.ProductId == id);
        }

        public void Remove(Product product)
        {
            _db.Remove(product);
        }

        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public void Update(Product product)
        {
            _db.Update(product);
        }

    }
}
