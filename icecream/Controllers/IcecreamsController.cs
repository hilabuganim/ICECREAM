using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using icecream.Models;
using Firebase;
using System.IO;
using System.Web;
using Microsoft.AspNetCore.Http;
using Firebase.Storage;
using RestSharp;
using Newtonsoft.Json;
using static icecream.Models.ImaggaHelper;

namespace icecream.Controllers
{
    public class IcecreamsController : Controller
    {
        private readonly icecreamContext _context;

        public IcecreamsController(icecreamContext context)
        {
            _context = context;
        }

        // GET: Icecreams
        public async Task<IActionResult> Index()
        {
            return View(await _context.Icecream.ToListAsync());
        }

        // GET: Icecreams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var icecream = await _context.Icecream
                .FirstOrDefaultAsync(m => m.id == id);
            if (icecream == null)
            {
                return NotFound();
            }

            return View(icecream);
        }

        // GET: Icecreams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Icecreams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,icecreamName,icecreamDescription,price,image")] Icecream icecream)
        {
            if (ModelState.IsValid)
            {
                if (!checkImage(icecream.image))
                {
                    return View(icecream);
                }
                var stream = System.IO.File.Open(icecream.image, FileMode.Open);

                // Construct FirebaseStorage with path to where you want to upload the file and put it there
                var task = new FirebaseStorage("icecream-ea970.appspot.com")
                 .Child(icecream.icecreamName + ".jpg")
                 .PutAsync(stream);



                // Await the task to wait until upload is completed and get the download url
                var downloadUrl = await task;
                icecream.image = downloadUrl;
                _context.Add(icecream);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


           

            return View(icecream);

        }
        private static async Task<string> uploadPicture(string path, string name)
        {

            var stream = System.IO.File.Open(path, FileMode.Open);

            // Construct FirebaseStorage with path to where you want to upload the file and put it there
            var task = new FirebaseStorage("icecream-ea970.appspot.com")
             .Child(name + ".jpg")
             .PutAsync(stream);



            // Await the task to wait until upload is completed and get the download url
            var downloadUrl = await task;

            return downloadUrl;
        }



 



        // GET: Icecreams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var icecream = await _context.Icecream.FindAsync(id);
            if (icecream == null)
            {
                return NotFound();
            }
            return View(icecream);
        }

        // POST: Icecreams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,icecreamName,icecreamDescription,price,image")] Icecream icecream)
        {
            if (id != icecream.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(icecream);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IcecreamExists(icecream.id))
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
            return View(icecream);
        }

        // GET: Icecreams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var icecream = await _context.Icecream
                .FirstOrDefaultAsync(m => m.id == id);
            if (icecream == null)
            {
                return NotFound();
            }

            return View(icecream);
        }

        // POST: Icecreams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var icecream = await _context.Icecream.FindAsync(id);
            _context.Icecream.Remove(icecream);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IcecreamExists(int id)
        {
            return _context.Icecream.Any(e => e.id == id);
        }
        
        public bool checkImage(string url)
        {
            List<string> namesOfDrugs = new List<string> { "ice cream"};


            bool Result = false;

                List<string> descriptions = new List<string>();
                ImageContent img = new ImageContent(url);
                double confidence = 50.0;
                img.ImageDetails = new Dictionary<string, double>();
                GetDescribtions(img);
                //check the confidence
                foreach (var item in img.ImageDetails)
                {
                    if (item.Value > confidence)
                        descriptions.Add(item.Key);
                }
                //check if the image is suitable
                foreach (var item in descriptions)
                {
                    //if item exist in our list
                    foreach (var name in namesOfDrugs)
                    {
                        if (name == item)
                            return true;
                    }

                }

                return Result;
            }
        public void GetDescribtions(ImageContent current)
        {
            string apiKey = "acc_cafa34220a7c0ca";
            string apiSecret = "da50c5da2e0622eeb3bc097afd99f08d";
            string image = current.imagePath;

            string basicAuthValue = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(String.Format("{0}:{1}", apiKey, apiSecret)));
            var client = new RestClient("https://api.imagga.com/v2/tags");
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", String.Format("Basic {0}", basicAuthValue));
            request.AddFile("image", image);

            IRestResponse response = client.Execute(request);

            Root DetailsTree = JsonConvert.DeserializeObject<Root>(response.Content);

            foreach (var item in DetailsTree.result.tags)
            {
                current.ImageDetails.Add(item.tag.en, item.confidence);
            }


        }


    }
}

