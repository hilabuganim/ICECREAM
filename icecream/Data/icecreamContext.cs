using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using icecream.Models;

    public class icecreamContext : DbContext
    {
        public icecreamContext (DbContextOptions<icecreamContext> options)
            : base(options)
        {
        }

        public DbSet<icecream.Models.Icecream> Icecream { get; set; }

        public DbSet<icecream.Models.Seller> Seller { get; set; }
    }
