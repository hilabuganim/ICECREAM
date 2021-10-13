using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace icecream.Models
{
    public class OrderContent
    {
        [Key]
        public int id { get; set; }

        public int orderId { get; set; }
        public int icecreamId { get; set; }
        public double amount { get; set; }
    }
}
