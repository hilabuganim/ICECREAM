using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace icecream.Models
{
    public class Icecream
    {
        [Key]
        public int id { get; set; }

        public string icecreamName { get; set; }
        public string icecreamDescription { get; set; }
        public double price { get; set; }
        public string image { get; set; }
        
    }
}
