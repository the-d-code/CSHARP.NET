using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FurnitureMVCCoreDB.Models;

namespace FurnitureMVCCoreDB.Controllers
{
    public class FurnituresController : Controller
    {
    
        private readonly FurnitureDBContext _context;

        public FurnituresController(FurnitureDBContext context)
        {
            _context = context;
        }

        // GET: Furnitures
        public async Task<IActionResult> Index()
        {
            var furnitureDBContext = _context.Furniture.Include(f => f.Category);

                return View(await furnitureDBContext.ToListAsync());
            
        }

        // GET: Furnitures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var furniture = await _context.Furniture
                .FirstOrDefaultAsync(m => m.FurnitureId == id);
            if (furniture == null)
            {
                return NotFound();
            }

            return View(furniture);
        }

        // GET: Furnitures/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName");
            return View();
        }

        // POST: Furnitures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FurnitureId,FurnitureName,Rate,Description,CategoryId")] Furniture furniture)
        {
            if (ModelState.IsValid)
            {
                _context.Add(furniture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(furniture);
        }

        // GET: Furnitures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var furniture = await _context.Furniture.FindAsync(id);
            if (furniture == null)
            {
                return NotFound();
            }
            return View(furniture);
        }

        // POST: Furnitures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FurnitureId,FurnitureName,Rate,Description,CategoryId")] Furniture furniture)
        {
            if (id != furniture.FurnitureId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(furniture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FurnitureExists(furniture.FurnitureId))
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
            return View(furniture);
        }

        // GET: Furnitures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var furniture = await _context.Furniture
                .FirstOrDefaultAsync(m => m.FurnitureId == id);
            if (furniture == null)
            {
                return NotFound();
            }

            return View(furniture);
        }

        // POST: Furnitures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var furniture = await _context.Furniture.FindAsync(id);
            _context.Furniture.Remove(furniture);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }




        //GET: Products/Create
        public IActionResult SearchByName()
        {
            return View();
        }

        // POST: Furnitures/SearchByName
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SearchByName(string furnitureName)
        {
            var searchResult = await _context.Furniture.Where(f => f.FurnitureName.Contains(furnitureName)).ToListAsync();

            return View("Index", searchResult);
        }

        // GET: Furnitures/SearchByRateRange
        public IActionResult SearchByRateRange()
        {

            return View();
        }

        // POST: Furnitures/SearchByRateRange
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SearchByRateRange(int minRate, int maxRate)
        {
            var searchResult = await _context.Furniture
                .Where(f => f.Rate >= minRate).Where(f => f.Rate <= maxRate).
                ToListAsync();

            return View("Index", searchResult);
        }


        private bool FurnitureExists(int id)
        {
            return _context.Furniture.Any(e => e.FurnitureId == id);
        }
    }
}
