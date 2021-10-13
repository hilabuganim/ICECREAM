using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace icecream.Models
{
    public class Addresses
    {
        [Key]
        public int id { get; set; }

        public string city { get; set; }
        public string street { get; set; }
        public int houseNumber { get; set; }
    }
}
