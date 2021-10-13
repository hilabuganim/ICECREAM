﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace icecream.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }

        public DateTime date { get; set; }
        public int address { get; set; }
        public double temp { get; set; }
        public string clientFullName { get; set; }
        public string phoneNumber { get; set; }
        public double humidity { get; set; }
        public double airPollution { get; set; }
        public string status { get; set; }
    }
}
