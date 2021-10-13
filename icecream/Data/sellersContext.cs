using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using icecream.Models;

    public class sellersContext : DbContext
    {
        public sellersContext (DbContextOptions<sellersContext> options)
            : base(options)
        {
        }

        public DbSet<icecream.Models.Seller> Seller { get; set; }
    }
