using a_la_Express_Shop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a_la_Express_Shop
{
    public class MSSQLProductRepository : IRepository<Product>
    {
        private Context db;
        private bool disposed = false;

        public MSSQLProductRepository()
        {
            db = new Context();
        }
        public IEnumerable<Product> GetProductList()
        {
            return db.Products;
        }

        public void Create(Product product)
        {
            db.Products.Add(product);
        }        
        public Product Read(decimal id)
        {
            return db.Products.Find(id);
        }
        public void Update(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Product product = db.Products.Find(id);
            if (product != null) db.Products.Remove(product);
        }
        public void Save()
        {
            db.SaveChanges();
        }


        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

