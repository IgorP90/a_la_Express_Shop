using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace a_la_Express_Shop.Models
{
    public class Order
    {
        [Key]
        public decimal Order_Id { get; set; }

        public DateTime Date { get; set; }

        [ForeignKey("Product")]
        public decimal Product_Id { get; set; }
    }
}
