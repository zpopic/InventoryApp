using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventoryApp.Models;

namespace InventoryApp.Controllers
{
    public class VrstaController : Controller
    {
        private readonly inventoryContext _context;

        public VrstaController(inventoryContext context)
        {
            _context = context;
        }

        // GET: Vrsta
        public async Task<IActionResult> Index()
        {
            var inventoryContext = _context.Vrsta.Include(v => v.Kategorija);
            return View(await inventoryContext.ToListAsync());
        }

        // GET: Vrsta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vrsta = await _context.Vrsta
                .Include(v => v.Kategorija)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vrsta == null)
            {
                return NotFound();
            }

            return View(vrsta);
        }

        // GET: Vrsta/Create
        public IActionResult Create()
        {
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv");
            return View();
        }

        // POST: Vrsta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naziv,Opis,UsrChanged,KategorijaId")] Vrsta vrsta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vrsta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv", vrsta.KategorijaId);
            return View(vrsta);
        }

        // GET: Vrsta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vrsta = await _context.Vrsta.FindAsync(id);
            if (vrsta == null)
            {
                return NotFound();
            }
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv", vrsta.KategorijaId);
            return View(vrsta);
        }

        // POST: Vrsta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv,Opis,UsrChanged,KategorijaId")] Vrsta vrsta)
        {
            if (id != vrsta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vrsta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VrstaExists(vrsta.Id))
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
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv", vrsta.KategorijaId);
            return View(vrsta);
        }

        // GET: Vrsta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vrsta = await _context.Vrsta
                .Include(v => v.Kategorija)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vrsta == null)
            {
                return NotFound();
            }

            return View(vrsta);
        }

        // POST: Vrsta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vrsta = await _context.Vrsta.FindAsync(id);
            _context.Vrsta.Remove(vrsta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VrstaExists(int id)
        {
            return _context.Vrsta.Any(e => e.Id == id);
        }
    }
}
