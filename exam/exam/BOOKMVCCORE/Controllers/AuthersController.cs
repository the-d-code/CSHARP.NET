using BOOKMVCCORE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Security.Policy;
using System.Text;

namespace BOOKMVCCORE.Controllers
{
    public class AuthersController : Controller
    {
        private string baseurl = "http://localhost:37329/api/Authers";

        // GET: AuthersController
        public async Task<IActionResult> Index()
        {
            List<Auther> authorList = new List<Auther>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:37329/api/Authers"))
                {
                    String apiResponse = await response.Content.ReadAsStringAsync();
                    authorList = JsonConvert.DeserializeObject<List<Auther>>(apiResponse);
                }
            }
            return View(authorList);
        }

        // GET: AuthersController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            Auther auther = new Auther();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:37329/api/Authers" + "/" + id))
                {
                    String apiResponse = await response.Content.ReadAsStringAsync();
                    auther = JsonConvert.DeserializeObject<Auther>(apiResponse);
                }
            }
            return View(auther);
        }

        // GET: AuthersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Auther newAuther)
        {
            try
            {
                StringContent content
                    = new StringContent(JsonConvert.SerializeObject(newAuther),
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

        // GET: AuthersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuthersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Auther AutherToUpdate)
        {
            try
            {
                StringContent content
                    = new StringContent(JsonConvert.SerializeObject(AutherToUpdate),
                    Encoding.UTF8, "application/json");

                using (var httpClient = new HttpClient())
                {
                    var Response = await httpClient.PutAsync("http://localhost:37329/api/Authers" + "/" + id, content);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthersController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Auther auther = new Auther();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:37329/api/Authers" + "/" + id))
                {
                    String apiResponse = await response.Content.ReadAsStringAsync();
                    auther = JsonConvert.DeserializeObject<Auther>(apiResponse);
                }
            }
            return View(auther);
        }

        // POST: AuthersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var Response = await httpClient.DeleteAsync("http://localhost:37329/api/Authers" + "/" + id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> SearchByName(Auther searchByName)
        {
            try
            {
                StringContent content
                    = new StringContent(JsonConvert.SerializeObject(searchByName),
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
    }
}
