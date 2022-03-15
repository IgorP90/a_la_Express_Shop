using a_la_Express_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a_la_Express_Shop
{
    interface IRepository : IDisposable
    {
        IEnumerable<Product> GetProductList();

        void Create(Product product);
        Product Read(decimal id);
        void Update(Product product);
        void Delete(int id);
        void Save();
    }
}
