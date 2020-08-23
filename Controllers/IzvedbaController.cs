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
    public class IzvedbaController : Controller
    {
        private readonly inventoryContext _context;

        public IzvedbaController(inventoryContext context)
        {
            _context = context;
        }

        // GET: Izvedba
        public async Task<IActionResult> Index()
        {
            var inventoryContext = _context.Izvedba.Include(i => i.Kategorija).Include(i => i.Tip).Include(i => i.Vrsta);
            return View(await inventoryContext.ToListAsync());
        }

        // GET: Izvedba/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var izvedba = await _context.Izvedba
                .Include(i => i.Kategorija)
                .Include(i => i.Tip)
                .Include(i => i.Vrsta)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (izvedba == null)
            {
                return NotFound();
            }

            return View(izvedba);
        }

        // GET: Izvedba/Create
        public IActionResult Create()
        {
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv");
            ViewData["TipId"] = new SelectList(_context.Tip, "Id", "Naziv");
            ViewData["VrstaId"] = new SelectList(_context.Vrsta, "Id", "Naziv");
            return View();
        }

        // POST: Izvedba/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naziv,Opis,UsrChanged,TipId,VrstaId,KategorijaId")] Izvedba izvedba)
        {
            if (ModelState.IsValid)
            {
                _context.Add(izvedba);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv", izvedba.KategorijaId);
            ViewData["TipId"] = new SelectList(_context.Tip, "Id", "Naziv", izvedba.TipId);
            ViewData["VrstaId"] = new SelectList(_context.Vrsta, "Id", "Naziv", izvedba.VrstaId);
            return View(izvedba);
        }

        // GET: Izvedba/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var izvedba = await _context.Izvedba.FindAsync(id);
            if (izvedba == null)
            {
                return NotFound();
            }
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv", izvedba.KategorijaId);
            ViewData["TipId"] = new SelectList(_context.Tip, "Id", "Naziv", izvedba.TipId);
            ViewData["VrstaId"] = new SelectList(_context.Vrsta, "Id", "Naziv", izvedba.VrstaId);
            return View(izvedba);
        }

        // POST: Izvedba/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv,Opis,UsrChanged,TipId,VrstaId,KategorijaId")] Izvedba izvedba)
        {
            if (id != izvedba.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(izvedba);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IzvedbaExists(izvedba.Id))
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
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv", izvedba.KategorijaId);
            ViewData["TipId"] = new SelectList(_context.Tip, "Id", "Naziv", izvedba.TipId);
            ViewData["VrstaId"] = new SelectList(_context.Vrsta, "Id", "Naziv", izvedba.VrstaId);
            return View(izvedba);
        }

        // GET: Izvedba/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var izvedba = await _context.Izvedba
                .Include(i => i.Kategorija)
                .Include(i => i.Tip)
                .Include(i => i.Vrsta)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (izvedba == null)
            {
                return NotFound();
            }

            return View(izvedba);
        }

        // POST: Izvedba/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var izvedba = await _context.Izvedba.FindAsync(id);
            _context.Izvedba.Remove(izvedba);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IzvedbaExists(int id)
        {
            return _context.Izvedba.Any(e => e.Id == id);
        }
    }
}
