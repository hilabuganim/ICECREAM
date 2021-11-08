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
        private readonly sellersContext _context;

        public Account(sellersContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            
            return View();
        }
        public async Task<ActionResult> SignUp(Seller seller)
        {
            if (!SellersExists(seller.userName))
            // Sends him to his personal page
            {
                //check mail
                if (!IsEmail(seller.userName))
                    return View("SignUp");
                _context.Add(seller);
                await _context.SaveChangesAsync();
                //sends to his personal page
                return View();
            }
            else
                return View("SignUp");
        }
        private bool IsEmail(string s)
        {
            if (s == null || s == "")
                return false;
            if (s[0] == '@')
                return false;
            if (s.Contains('@') != true || s.Substring(s.IndexOf("@") + 1).Contains(".") != true)
                return false;
            foreach (var item in s)
            {
                if (item != '@' && item != '.' && item != '_' && !char.IsLetter(item) && char.IsWhiteSpace(item))
                    return false;
            }
            return true;
        }
        public ActionResult Login(string userName, string password)
        {
            if (SellersExists(userName, password))
            {
                // Sends him to his personal page
                RouteConfig.user = _context.Seller.Where(e => e.userName == userName && e.password == password).Select(e => e).FirstOrDefault();
                return View("Login");
            }
            else
                return View("Login");
        }
        public ActionResult Logout()
        {
                RouteConfig.user = null;
                return View("Home");
        }
        private bool SellersExists(string userName)
        {
            return _context.Seller.Any(e => e.userName == userName);
        }
        private bool SellersExists(string userName, string password)
        {
            return _context.Seller.Any(e => e.userName == userName && e.password == password);
        }
        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Account/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Account/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
