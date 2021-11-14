using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using icecream.Models;

    public class IceContext : DbContext
    {
        public IceContext (DbContextOptions<IceContext> options)
            : base(options)
        {
        }

        public DbSet<icecream.Models.Order> Orders { get; set; }
        public DbSet<icecream.Models.Addresses> Addresses { get; set; }
        public DbSet<icecream.Models.Seller> Seller { get; set; }
        public DbSet<icecream.Models.Icecream> Icecream { get; set; }



}
