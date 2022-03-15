using a_la_Express_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a_la_Express_Shop
{
    interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetProductList();

        void Create(Product product);
        T Read(decimal id);
        void Update(Product product);
        void Delete(int id);
        void Save();
    }
}
