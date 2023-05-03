using MVCFurnitureAppCs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFurnitureAppCs.Controllers
{
    public class CategoryController : Controller
    {

        private FurnitureDbDataContext FDBDC = new FurnitureDbDataContext();
        // GET: Category
        public ActionResult Index()
        {
            return View(FDBDC.Cats.ToList());
        }

        private Cat GetCatByID(int id)
        {
            return FDBDC.Cats.SingleOrDefault(c => c.CategoryId == id);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View(GetCatByID(id));
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Cat newcat)
        {
            try
            {
                // TODO: Add insert logic here
                newcat.CategoryId = FDBDC.Cats.Max(C => C.CategoryId) + 1;
                FDBDC.Cats.InsertOnSubmit(newcat);
                FDBDC.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            Cat categoryToUpdate = FDBDC.Cats.SingleOrDefault(c => c.CategoryId == id);
            return View(categoryToUpdate);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cat cate)
        {
            try
            {
                // TODO: Add update logic here
                Cat categoryToUpdate = FDBDC.Cats.SingleOrDefault(c => c.CategoryId == id);
                categoryToUpdate.CategoryName = cate.CategoryName;
                FDBDC.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View(GetCatByID(id));
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                FDBDC.Cats.DeleteOnSubmit(GetCatByID(id));
                FDBDC.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
