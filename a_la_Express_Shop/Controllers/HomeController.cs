using a_la_Express_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a_la_Express_Shop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private IRepository db;

        public HomeController(IRepository ms)
        {
            db = ms;
        }

        [HttpPost("post/{product}")]
        public void Create([FromBody] Product product)
        {
            db.Create(product);
        }
        [HttpGet("get/{id}")]
        public Product Read(decimal id)
        {
            return db.Read(id);
        }
        [HttpPut]
        public void Update(Product product)
        {
            return;
        }
        [HttpDelete]
        public void Delete()
        { }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
