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
    public class BibliothecairesController : Controller
    {
        private readonly IBibliothecaireRepository Repository;

        public BibliothecairesController(IBibliothecaireRepository repository)
        {
            Repository = repository;
        }

        // GET: Bibliothecaires
        public async Task<IActionResult> Index()
        {
              return ! await Repository.IsEmpty() ? 
                          View(await Repository.ListAll()) :
                          Problem("Entity set 'FilRougeBiblioContext.Bibliothecaires'  is null.");
        }

        // GET: Bibliothecaires/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var bibliothecaire = await Repository.GetById(id.Value);
            if (bibliothecaire == null)
            {
                return NotFound();
            }

            return View(bibliothecaire);
        }

        // GET: Bibliothecaires/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bibliothecaires/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Email,MotDePasse,Id")] Bibliothecaire bibliothecaire)
        {
            if (ModelState.IsValid)
            {
                await Repository.Create(bibliothecaire);
                return RedirectToAction(nameof(Index));
            }
            return View(bibliothecaire);
        }

        // GET: Bibliothecaires/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var bibliothecaire = await Repository.GetById(id.Value);
            if (bibliothecaire == null)
            {
                return NotFound();
            }
            return View(bibliothecaire);
        }

        // POST: Bibliothecaires/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Email,MotDePasse,Id")] Bibliothecaire bibliothecaire)
        {
            if (id != bibliothecaire.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await Repository.Update(bibliothecaire);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await BibliothecaireExists(bibliothecaire.Id))
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
            return View(bibliothecaire);
        }

        // GET: Bibliothecaires/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var bibliothecaire = await Repository.GetById(id.Value);
            if (bibliothecaire == null)
            {
                return NotFound();
            }

            return View(bibliothecaire);
        }

        // POST: Bibliothecaires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (await Repository.IsEmpty())
            {
                return Problem("Entity set 'FilRougeBiblioContext.Bibliothecaires'  is null.");
            }
            var bibliothecaire = await Repository.GetById(id);
            if (bibliothecaire != null)
            {
                await Repository.Delete(bibliothecaire);
            }
            
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> BibliothecaireExists(int id)
        {
          return await Repository.Exists(id);
        }
    }
}
