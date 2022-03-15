using Microsoft.VisualStudio.TestTools.UnitTesting;
using a_la_Express_Shop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_la_Express_Shop.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void ReadTest()
        {
            decimal id = 2;
            decimal expected = 777;
            HomeController hc = new();
            var actual = hc.Read(id);
            //Assert.IsTrue();
            //Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            HomeController hc = new();
            hc.Update(new Models.Product { Product_Id = 2, Description = "sdfsdfs", Name = "product_2", Price = 45 });
            Assert.Fail();
        }
    }
}