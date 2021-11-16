using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using icecream.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace icecream.Controllers
{
    public class Account : Controller
    {
        // GET: Account
        private readonly IceContext _context;

        public Account(IceContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Login(string userName, string password)
        {
            if (SellersExists(userName, password))
            {
                // Sends him to his personal page
                RouteConfig.user = _context.Seller.Where(e => e.userName == userName && e.password == password).Select(e => e).FirstOrDefault();
                return RedirectToAction("Index", "Icecreams");
            }
            else
                return View("Login");
        }
        public ActionResult Logout()
        {
                RouteConfig.user = null;
                return View("~/Views/Home/Index.cshtml");
        }
        private bool SellersExists(string userName, string password)
        {
            return _context.Seller.Any(e => e.userName == userName && e.password == password);
        }

    }
}
