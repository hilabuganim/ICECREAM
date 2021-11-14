using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using icecream.Models;

namespace icecream.Controllers
{
    public class SellersController : Controller
    {
        private readonly sellersContext _context;

        public SellersController(sellersContext context)
        {
            _context = context;
        }

        // GET: Sellers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Seller.ToListAsync());
        }

        // GET: Sellers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _context.Seller
                .FirstOrDefaultAsync(m => m.id == id);
            if (seller == null)
            {
                return NotFound();
            }

            return View(seller);
        }

        // GET: Sellers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sellers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,storeName,address,phoneNumber,fullName,password,userName")] Seller seller)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seller);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(seller);
        }

        // GET: Sellers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _context.Seller.FindAsync(id);
            if (seller == null)
            {
                return NotFound();
            }
            return View(seller);
        }

        // POST: Sellers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,storeName,address,phoneNumber,fullName,password,userName")] Seller seller)
        {
            if (id != seller.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seller);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SellerExists(seller.id))
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
            return View(seller);
        }

        // GET: Sellers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _context.Seller
                .FirstOrDefaultAsync(m => m.id == id);
            if (seller == null)
            {
                return NotFound();
            }

            return View(seller);
        }

        // POST: Sellers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seller = await _context.Seller.FindAsync(id);
            _context.Seller.Remove(seller);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SellerExists(int id)
        {
            return _context.Seller.Any(e => e.id == id);
        }
        public IActionResult predict2()
        {
            ViewBag.Message = "";
            return View("~/Views/Sellers/Predict.cshtml");
        }
        public IActionResult predict(string season,string day, double humidity,double temperature,string city)
        {
            var icecream=PredictIcecream(day, temperature, city);
            ViewBag.Message = icecream;
            return View();
        }
        	public static string PredictIcecream(string day, double? temperatura, string city)
        {
            if (temperatura == null)
	{
	return "Banana strawberry";
	}
	if (temperatura > 22)
            {
	if (city == null)
	{
	return "Banana strawberry";
	}
	if (city.Equals("Tel Aviv"))
                {
	if (temperatura > 30)
                    {
	return "Strawberry sorbet";
	}
	if (temperatura <= 30)
                    {
	return "Raffaello";
	}
	}
	if (!city.Equals("Tel Aviv"))
                {
	if (city.Equals("Ramat Gan"))
                    {
	if (day == null)
	{
	return "Kinder Bueno";
	}
	if (day.Equals("Monday"))
                        {
	return "Pistachio";
	}
	if (!day.Equals("Monday"))
                        {
	return "Kinder Bueno";
	}
	}
	if (!city.Equals("Ramat Gan"))
                    {
	if (city.Equals("Bnei Brak"))
                        {
	return "Pistachio";
	}
	if (!city.Equals("Bnei Brak"))
                        {
	if (day == null)
	{
	return "Banana strawberry";
	}
	if (day.Equals("Saturday"))
                            {
	return "Chocolate";
	}
	if (!day.Equals("Saturday"))
                            {
	return "Banana strawberry";
	}
	}
	}
	}
	}
	if (temperatura <= 22)
            {
	if (temperatura > 17)
                {
	if (temperatura > 19)
                    {
	return "Salted caramel";
	}
	if (temperatura <= 19)
                    {
	if (city == null)
	{
	return "Dark Chocolate";
	}
	if (city.Equals("Bnei Brak"))
                        {
	return "Dark Chocolate";
	}
	if (!city.Equals("Bnei Brak"))
                        {
	return "Mango Sorbet";
	}
	}
	}
	if (temperatura <= 17)
                {
	if (temperatura > 14)
                    {
	if (city == null)
	{
	return "Chocolate";
	}
	if (city.Equals("Jerusalem"))
                        {
	return "Strawberry sorbet";
	}
	if (!city.Equals("Jerusalem"))
                        {
	if (city.Equals("Elad"))
                            {
	return "Chocolate";
	}
	if (!city.Equals("Elad"))
                            {
	return "Passionflower sorbet";
	}
	}
	}
	if (temperatura <= 14)
                    {
	if (city == null)
	{
	return "Ferrero Rocher";
	}
	if (city.Equals("Tel Aviv"))
                        {
	return "Lotus cookies";
	}
	if (!city.Equals("Tel Aviv"))
                        {
	return "Ferrero Rocher";
	}
	}
	}
	}
	return null;
	}

    }

}
