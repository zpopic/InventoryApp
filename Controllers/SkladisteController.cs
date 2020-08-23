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
    public class SkladisteController : Controller
    {
        private readonly inventoryContext _context;

        public SkladisteController(inventoryContext context)
        {
            _context = context;
        }

        // GET: Skladiste
        public async Task<IActionResult> Index()
        {
            return View(await _context.Skladiste.ToListAsync());
        }

        // GET: Skladiste/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skladiste = await _context.Skladiste
                .FirstOrDefaultAsync(m => m.Id == id);
            if (skladiste == null)
            {
                return NotFound();
            }

            return View(skladiste);
        }

        // GET: Skladiste/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Skladiste/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naziv,Opis,UsrChanged")] Skladiste skladiste)
        {
            if (ModelState.IsValid)
            {
                _context.Add(skladiste);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(skladiste);
        }

        // GET: Skladiste/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skladiste = await _context.Skladiste.FindAsync(id);
            if (skladiste == null)
            {
                return NotFound();
            }
            return View(skladiste);
        }

        // POST: Skladiste/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv,Opis,UsrChanged")] Skladiste skladiste)
        {
            if (id != skladiste.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(skladiste);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkladisteExists(skladiste.Id))
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
            return View(skladiste);
        }

        // GET: Skladiste/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skladiste = await _context.Skladiste
                .FirstOrDefaultAsync(m => m.Id == id);
            if (skladiste == null)
            {
                return NotFound();
            }

            return View(skladiste);
        }

        // POST: Skladiste/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var skladiste = await _context.Skladiste.FindAsync(id);
            _context.Skladiste.Remove(skladiste);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkladisteExists(int id)
        {
            return _context.Skladiste.Any(e => e.Id == id);
        }
    }
}
