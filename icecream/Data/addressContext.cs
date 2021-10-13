using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using icecream.Models;

    public class addressContext : DbContext
    {
        public addressContext (DbContextOptions<addressContext> options)
            : base(options)
        {
        }

        public DbSet<icecream.Models.Addresses> Addresses { get; set; }
    }
