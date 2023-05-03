using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleIntrestCalculate.Models;

namespace SimpleIntrestCalculate.Controllers
{
    public class SimpleIntrestController : Controller
    {
        // GET: SimpleIntrestController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SimpleIntrestController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SimpleIntrestController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SimpleIntrestController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Intrest model)
        {
            if (ModelState.IsValid)
            {
                decimal simpleInterest = model.CalculateSimpleInterest();
                ViewBag.SimpleInterest = simpleInterest;
                return View("Result");
            }
            else
            {
                return View();
            }
        }

        // GET: SimpleIntrestController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SimpleIntrestController/Edit/5
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

        // GET: SimpleIntrestController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SimpleIntrestController/Delete/5
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
