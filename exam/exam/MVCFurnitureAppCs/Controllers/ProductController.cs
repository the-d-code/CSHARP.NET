using MVCFurnitureAppCs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFurnitureAppCs.Controllers
{
    public class ProductController : Controller
    {
        private FurnitureDbDataContext FDBDC = new FurnitureDbDataContext();
        // GET: Product
        public ActionResult Index()
        {
            return View(FDBDC.Products.ToList());
        }

        private Product GetProduct(int id)
        {
            return FDBDC.Products.SingleOrDefault(c => c.CategoryId == id);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(GetProduct(id));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            List<SelectListItem> catls = new List<SelectListItem>();
            foreach(var cat in FDBDC.Cats)
            {
                catls.Add(new SelectListItem
                {
                    Text = cat.CategoryName,
                    Value = cat.CategoryId.ToString()
                });
            }
            ViewBag.catls = catls;
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product pro)
        {
            try
            {
                Product pdc = new Product
                {
                    ProductId = FDBDC.Products.Max(c => c.ProductId) + 1,
                    ProductName = pro.ProductName,
                    CategoryId = pro.CategoryId,
                    ProductRate = pro.ProductRate,
                    ProductDescription = pro.ProductDescription
                };

                FDBDC.Products.InsertOnSubmit(pdc);
                FDBDC.SubmitChanges();

                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {

            List<SelectListItem> catls = new List<SelectListItem>();
            foreach (var cat in FDBDC.Cats)
            {
                catls.Add(new SelectListItem
                {
                    Text = cat.CategoryName,
                    Value = cat.CategoryId.ToString()
                });
            }
            ViewBag.catls = catls;
            return View(GetProduct(id));
            
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product editpro)
        {
            try
            {
                // TODO: Add update logic here
                Product prodt = GetProduct(id);
                prodt.ProductName = editpro.ProductName;
                prodt.CategoryId= editpro.CategoryId;
                prodt.ProductRate = editpro.ProductRate;
                prodt.ProductDescription = editpro.ProductDescription;
                FDBDC.Products.Append(prodt);
                FDBDC.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(GetProduct(id));
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                
                FDBDC.Products.DeleteOnSubmit(GetProduct(id));
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
