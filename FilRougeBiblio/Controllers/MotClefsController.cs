using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FilRougeBiblio.Core.Entities;
using FilRougeBiblio.Infrastructure.Data;

namespace FilRougeBiblio.Controllers
{
    public class MotClefsController : Controller
    {
        private readonly FilRougeBiblioContext _context;

        public MotClefsController(FilRougeBiblioContext context)
        {
            _context = context;
        }

        // GET: MotClefs
        public async Task<IActionResult> Index()
        {
              return _context.MotClef != null ? 
                          View(await _context.MotClef.ToListAsync()) :
                          Problem("Entity set 'FilRougeBiblioContext.MotClef'  is null.");
        }

        // GET: MotClefs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MotClef == null)
            {
                return NotFound();
            }

            var motClef = await _context.MotClef
                .FirstOrDefaultAsync(m => m.Id == id);
            if (motClef == null)
            {
                return NotFound();
            }

            return View(motClef);
        }

        // GET: MotClefs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MotClefs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Tag,Id")] MotClef motClef)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motClef);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(motClef);
        }

        // GET: MotClefs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MotClef == null)
            {
                return NotFound();
            }

            var motClef = await _context.MotClef.FindAsync(id);
            if (motClef == null)
            {
                return NotFound();
            }
            return View(motClef);
        }

        // POST: MotClefs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Tag,Id")] MotClef motClef)
        {
            if (id != motClef.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motClef);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotClefExists(motClef.Id))
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
            return View(motClef);
        }

        // GET: MotClefs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MotClef == null)
            {
                return NotFound();
            }

            var motClef = await _context.MotClef
                .FirstOrDefaultAsync(m => m.Id == id);
            if (motClef == null)
            {
                return NotFound();
            }

            return View(motClef);
        }

        // POST: MotClefs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MotClef == null)
            {
                return Problem("Entity set 'FilRougeBiblioContext.MotClef'  is null.");
            }
            var motClef = await _context.MotClef.FindAsync(id);
            if (motClef != null)
            {
                _context.MotClef.Remove(motClef);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotClefExists(int id)
        {
          return (_context.MotClef?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
