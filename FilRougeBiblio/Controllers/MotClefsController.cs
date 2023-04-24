using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FilRougeBiblio.Core.Entities;
using FilRougeBiblio.Infrastructure.Data;
using FilRougeBiblio.Core.Seedwork;

namespace FilRougeBiblio.Controllers
{
    
    public class MotClefsController : Controller
    {
        
        private readonly IMotClefRepository Repository;

        public MotClefsController(IMotClefRepository repository)
        {
            Repository = repository;
        }

        // GET: MotClefs
        public async Task<IActionResult> Index()
        {
              return ! await Repository.IsEmpty() ? 
                          View(await Repository.ListAll()):
                          Problem("Entity set 'FilRougeBiblioContext.MotClef'  is null.");
        }

        // GET: MotClefs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var motClef = await Repository.GetById(id.Value);
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
               await Repository.Create(motClef);
               return RedirectToAction(nameof(Index));
            }
            return View(motClef);
        }

        // GET: MotClefs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null ||await Repository.IsEmpty())
            {
                return NotFound();
            }

            var motClef = await Repository.GetById(id.Value);
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
                    await Repository.Update(motClef);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await MotClefExists(motClef.Id))
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
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var motClef = await Repository.GetById(id.Value);
                
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
            if (await Repository.IsEmpty())
            {
                return Problem("Entity set 'FilRougeBiblioContext.MotClef'  is null.");
            }
            var motClef = await Repository.GetById(id);
            if (motClef != null)
            {
                await Repository.Delete(motClef);
            }
            
           
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> MotClefExists(int id)
        {
            return await Repository.Exists(id);
        }
    }
}
