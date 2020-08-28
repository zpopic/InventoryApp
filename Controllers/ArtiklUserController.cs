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
    public class ArtiklUserController : Controller
    {
        private readonly inventoryContext _context;

        public ArtiklUserController(inventoryContext context)
        {
            _context = context;
        }

        // GET: ArtiklUser
        public async Task<IActionResult> Index()
        {
            var inventoryContext = _context.Artikl.Include(a => a.Izvedba).Include(a => a.Kategorija).Include(a => a.Tip).Include(a => a.Vrsta);
            return View(await inventoryContext.ToListAsync());
        }

        // GET: ArtiklUser/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artikl = await _context.Artikl
                .Include(a => a.Izvedba)
                .Include(a => a.Kategorija)
                .Include(a => a.Tip)
                .Include(a => a.Vrsta)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (artikl == null)
            {
                return NotFound();
            }

            return View(artikl);
        }

        // GET: ArtiklUser/Create
        public IActionResult Create()
        {
            ViewData["IzvedbaId"] = new SelectList(_context.Izvedba, "Id", "Naziv");
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv");
            ViewData["TipId"] = new SelectList(_context.Tip, "Id", "Naziv");
            ViewData["VrstaId"] = new SelectList(_context.Vrsta, "Id", "Naziv");
            return View();
        }

        // POST: ArtiklUser/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ident,PocetnoStanje,Ulaz,Izlaz,AktualnoStanje,ZavrsnoStanje,UsrChanged,IzvedbaId,TipId,VrstaId,KategorijaId,Napomena")] Artikl artikl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artikl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IzvedbaId"] = new SelectList(_context.Izvedba, "Id", "Naziv", artikl.IzvedbaId);
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv", artikl.KategorijaId);
            ViewData["TipId"] = new SelectList(_context.Tip, "Id", "Naziv", artikl.TipId);
            ViewData["VrstaId"] = new SelectList(_context.Vrsta, "Id", "Naziv", artikl.VrstaId);
            return View(artikl);
        }

        // GET: ArtiklUser/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artikl = await _context.Artikl.FindAsync(id);
            if (artikl == null)
            {
                return NotFound();
            }
            ViewData["IzvedbaId"] = new SelectList(_context.Izvedba, "Id", "Naziv", artikl.IzvedbaId);
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv", artikl.KategorijaId);
            ViewData["TipId"] = new SelectList(_context.Tip, "Id", "Naziv", artikl.TipId);
            ViewData["VrstaId"] = new SelectList(_context.Vrsta, "Id", "Naziv", artikl.VrstaId);
            return View(artikl);
        }

        // POST: ArtiklUser/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ident,PocetnoStanje,Ulaz,Izlaz,AktualnoStanje,ZavrsnoStanje,UsrChanged,IzvedbaId,TipId,VrstaId,KategorijaId,Napomena")] Artikl artikl)
        {
            if (id != artikl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artikl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtiklExists(artikl.Id))
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
            ViewData["IzvedbaId"] = new SelectList(_context.Izvedba, "Id", "Naziv", artikl.IzvedbaId);
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv", artikl.KategorijaId);
            ViewData["TipId"] = new SelectList(_context.Tip, "Id", "Naziv", artikl.TipId);
            ViewData["VrstaId"] = new SelectList(_context.Vrsta, "Id", "Naziv", artikl.VrstaId);
            return View(artikl);
        }

        // GET: ArtiklUser/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artikl = await _context.Artikl
                .Include(a => a.Izvedba)
                .Include(a => a.Kategorija)
                .Include(a => a.Tip)
                .Include(a => a.Vrsta)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (artikl == null)
            {
                return NotFound();
            }

            return View(artikl);
        }

        // POST: ArtiklUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artikl = await _context.Artikl.FindAsync(id);
            _context.Artikl.Remove(artikl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtiklExists(int id)
        {
            return _context.Artikl.Any(e => e.Id == id);
        }
    }
}
