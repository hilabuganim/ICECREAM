using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using icecream.Models;

public class OrdersContext : DbContext
{
    public OrdersContext()

    {
    }

    public DbSet<icecream.Models.Addresses> Addresses { get; set; }
    public DbSet<icecream.Models.Order> Orders { get; set; }
}
