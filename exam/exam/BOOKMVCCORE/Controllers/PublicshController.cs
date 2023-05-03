using BOOKMVCCORE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace BOOKMVCCORE.Controllers
{
    public class PublicshController : Controller
    {
        // GET: PublicshController
        public async Task<IActionResult> Index()
        {
            List<Publicsh> publisherList = new List<Publicsh>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:37329/api/Publicshes"))
                {
                    String apiResponse = await response.Content.ReadAsStringAsync();
                    publisherList = JsonConvert.DeserializeObject<List<Publicsh>>(apiResponse);
                }
            }
            return View(publisherList);
        }

        // GET: PublicshController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            Publicsh publish = new Publicsh();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:37329/api/Authers" + "/" + id))
                {
                    String apiResponse = await response.Content.ReadAsStringAsync();
                    publish = JsonConvert.DeserializeObject<Publicsh>(apiResponse);
                }
            }
            return View(publish);
        }

        // GET: PublicshController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PublicshController/Create
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

        // GET: PublicshController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PublicshController/Edit/5
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

        // GET: PublicshController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PublicshController/Delete/5
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
