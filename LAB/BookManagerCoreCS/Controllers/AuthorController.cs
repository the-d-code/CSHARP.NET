using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using BookManagerCoreCS.Models;
using Newtonsoft.Json;

namespace BookManagerCoreCS.Controllers
{
    public class AuthorController : Controller
    {
        private string baseurl = "http://localhost:47348/api/Authors";


        // GET: AuthorController
        public async Task<IActionResult> Index()
        {
            List<Author> authorList = new List<Author>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:47348/api/Authors"))
                {
                    String apiResponse = await response.Content.ReadAsStringAsync();
                    authorList = JsonConvert.DeserializeObject<List<Author>>(apiResponse);
                }
            }
            return View(authorList);
        }

        // GET: AuthorController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            Author author = new Author();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:47348/api/Authors"))
                {
                    String apiResponse = await response.Content.ReadAsStringAsync();
                    author = JsonConvert.DeserializeObject<Author>(apiResponse);
                }
            }
            return View(author);
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorController/Create
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

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuthorController/Edit/5
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

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuthorController/Delete/5
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
