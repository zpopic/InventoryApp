using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventoryApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Http;

namespace InventoryApp.Controllers
{
    public class TipController : Controller
    {
        private readonly inventoryContext _context;

        public TipController(inventoryContext context)
        {
            _context = context;
        }

        // GET: Tip
        public async Task<IActionResult> Index(int pageNum=1, int pageSize=3)
        {
            var excludeRec = (pageSize * pageNum) - pageSize;

            var inventoryContext = _context.Tip.Include(t => t.Kategorija).Include(t => t.Vrsta).Skip(excludeRec).Take(pageSize);

            return View(await inventoryContext.ToListAsync());
        }

        // GET: Tip/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tip = await _context.Tip
                .Include(t => t.Kategorija)
                .Include(t => t.Vrsta)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tip == null)
            {
                return NotFound();
            }

            return View(tip);
        }


        // GET: Tip/Create
        public IActionResult Create()
        {
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv");
            //ViewData["VrstaId"] = new SelectList(_context.Vrsta, "Id", "Naziv"); ---- ovo je po defaultu, ali ne treba jer se kategorija postavlja dinamično po malo drugačijim pravilima skripte pa je zakomentirano, u runtimeu s pomoću ajaxa i jquerija postavit će se opcije dropdown liste ovisno o kategoriji... 

            return View();
        }


        public JsonResult GetSub(int select)
        {
            var subcategories = _context.Vrsta.Where(c => c.KategorijaId == select).ToList(); // filtriranje Vrste po ID-u kategorije i spremanje u listu pa u polje
            return Json(subcategories); // izbacivanje liste u json formatu za prihvat i parsanje u jquery-u
        }


        // POST: Tip/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naziv,Opis,UsrChanged,VrstaId,KategorijaId")] Tip tip)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tip);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv", tip.KategorijaId);
            ViewData["VrstaId"] = new SelectList(_context.Vrsta, "Id", "Naziv", tip.VrstaId);
            return View(tip);
        }



        // GET: Tip/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tip = await _context.Tip.FindAsync(id);
            if (tip == null)
            {
                return NotFound();
            }
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv", tip.KategorijaId);
            ViewData["VrstaId"] = new SelectList(_context.Vrsta, "Id", "Naziv", tip.VrstaId);
            return View(tip);
        }

        // POST: Tip/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv,Opis,UsrChanged,VrstaId,KategorijaId")] Tip tip)
        {
            if (id != tip.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tip);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipExists(tip.Id))
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
            ViewData["KategorijaId"] = new SelectList(_context.Kategorija, "Id", "Naziv", tip.KategorijaId);
            ViewData["VrstaId"] = new SelectList(_context.Vrsta, "Id", "Naziv", tip.VrstaId);
            return View(tip);
        }

        // GET: Tip/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tip = await _context.Tip
                .Include(t => t.Kategorija)
                .Include(t => t.Vrsta)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tip == null)
            {
                return NotFound();
            }

            return View(tip);
        }

        // POST: Tip/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tip = await _context.Tip.FindAsync(id);
            _context.Tip.Remove(tip);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipExists(int id)
        {
            return _context.Tip.Any(e => e.Id == id);
        }
    }
}


/*
 * 
 *             igranje oko DROPDOWN-a
 *             
 *             //var nese = _context.Vrsta.Where(c => c.KategorijaId == c.Id);
            //ViewData["VrstaId"] = new SelectList(nese, "Id", "Naziv");

            //var nese1 = new SelectList(_context.Vrsta, "Id", "Naziv");
            //ViewData["VrstaId"] = nese1;

            //ViewData["VrstaId"] = new SelectList(_context.Vrsta.Where(c => c.KategorijaId == select).ToList(), "Id", "Naziv");

        //public JsonResult OnGetSubCategories(int select)
        //{
        //    var subcategories = _context.Vrsta.Where(c => c.Id == select).ToList();
        //    //return new JsonResult(new SelectList(subcategories, "Id", "Name"));

        //    return Json(subcategories);
        //}

            //ViewData["VrstaId"] = new SelectList(_context.Vrsta, "Id", "Naziv");
            //var subcategories = _context.Vrsta.Where(c => c.KategorijaId == select).ToList();

            //var nese = new SelectList(_context.Vrsta.Where(c => c.KategorijaId == select).ToList(), "Id", "Naziv");
            //ViewData["VrstaId"] = nese;
            //var subcategories = _context.Vrsta.Where(c => c.KategorijaId == select).ToList();

*
*/