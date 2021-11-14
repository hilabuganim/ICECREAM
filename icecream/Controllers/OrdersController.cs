using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using icecream.Models;
using System.IO;

namespace icecream.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IceContext _context;

        public OrdersController(IceContext context)
        {
            _context = context;
            //AddressesController controller = new AddressesController();
        }
        // GET: Orders
        public IActionResult Index(int icecreamId)
        {
            //using (var reader = new StreamReader(@"C:\Users\hilab\Downloads\addresses.csv"))
            //{
            //    List<Addresses> allAddresses = new List<Addresses>();
            //    var line = reader.ReadLine();
            //    while (!reader.EndOfStream)
            //    {
            //        line = reader.ReadLine();
            //        var values = line.Split(',');
            //        Addresses address = new Addresses() { city = values[1].ToString(), street = values[3] };
            //        _context.Addresses.Add(address);
            //    }
            //}
            //_context.SaveChanges();
            Order order = new Order();
            order.icecreamId = icecreamId;
            order.date = DateTime.Now;
            return View("~/Views/Orders/Create.cshtml",order);
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            return View(new Order());
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,date,city,street,houseNumber,temp,clientFullName,phoneNumber,humidity,airPollution,status")] Order order)
        {
            if (ModelState.IsValid)
            {
                if (!_context.Addresses.Any(a => a.city.ToLower() == order.city.ToLower() && a.street.ToLower() == order.street.ToLower()))
                    return View(order);
                // insert the weather of this day - API

                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,date,address,temp,clientFullName,phoneNumber,humidity,airPollution,status")] Order order)
        {
            if (id != order.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.id == id);
        }
        public IActionResult showgraph()
        {
            if (RouteConfig.user == null)
                return View("Home");
            int counter = 1;
            List<Temperature> temps = new List<Temperature>();
            for (int i = 1; i <= 12; i++)
            {
                Temperature t = new Temperature { Id = counter++, Month = i, TempValue = 0 };

                foreach (var item in _context.Orders.Where(o => _context.Icecream.Select(i => i.id == o.icecreamId && i.sellerId == RouteConfig.user.id).Count() != 0))
                {
                    if (item.date.Month == i)
                        t.TempValue++;
                }
                temps.Add(t);

            }
            return View(temps);
        }
    }
}
