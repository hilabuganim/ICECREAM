using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace icecream.Models
{
    public class Seller
    {
        [Key]
        public int id { get; set; }

        public string storeName { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int houseNumber { get; set; }
        public string phoneNumber { get; set; }
        public string fullName { get; set; }
        public string password { get; set; }
        public string userName { get; set; }
    }
}
