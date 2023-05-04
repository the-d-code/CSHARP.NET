using BookManagerCoreCS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerCoreCS.Controllers
{
    public class BooksController : Controller
    {
        private string baseurl = "http://localhost:47348/api/Books";
        // GET: BooksController
        public async Task<IActionResult> Index()
        {
            List<Books> authorList = new List<Books>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:47348/api/Books"))
                {
                    String apiResponse = await response.Content.ReadAsStringAsync();
                    authorList = JsonConvert.DeserializeObject<List<Books>>(apiResponse);
                }
            }
            return View(authorList);
        }

        // GET: BooksController/Details/5
        public async Task<IActionResult> Details(int id)
        {

            Books books = new Books();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:47348/api/Books"))
                {
                    String apiResponse = await response.Content.ReadAsStringAsync();
                    books = JsonConvert.DeserializeObject<Books>(apiResponse);
                }
            }
            return View(books);

        }

        // GET: BooksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Books newBook)
        {
            try
            {
                StringContent content
                    = new StringContent(JsonConvert.SerializeObject(newBook),
                    Encoding.UTF8, "application/json");

                using (var httpClient = new HttpClient())
                {
                    var Response = await httpClient.PostAsync(baseurl, content);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BooksController/Edit/5
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

        // GET: BooksController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Books author = new Books();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:47348/api/Books" + "/" + id))
                {
                    String apiResponse = await response.Content.ReadAsStringAsync();
                    author = JsonConvert.DeserializeObject<Books>(apiResponse);
                }
            }
            return View(author);
        }

        // POST: BooksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var Response = await httpClient.DeleteAsync("http://localhost:47348/api/Books" + "/" + id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
