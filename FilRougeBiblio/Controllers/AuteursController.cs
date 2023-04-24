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
    public class AuteursController : Controller
    {
        private readonly IAuteurRepository Repository;

        public AuteursController(IAuteurRepository repository)
        {
            Repository = repository;
        }

        // GET: Auteurs
        public async Task<IActionResult> Index()
        {
              return !await Repository.IsEmpty() ? 
                          View(await Repository.ListAll()) :
                          Problem("Entity set 'FilRougeBiblioContext.Auteurs'  is null.");
        }

        // GET: Auteurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var auteur = await Repository.GetById(id.Value);
                
            if (auteur == null)
            {
                return NotFound();
            }

            return View(auteur);
        }

        // GET: Auteurs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Auteurs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Prenom,Nom,Id")] Auteur auteur)
        {
            if (ModelState.IsValid)
            {
                await Repository.Create(auteur);
                
                return RedirectToAction(nameof(Index));
            }
            return View(auteur);
        }

        // GET: Auteurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var auteur = await Repository.GetById(id.Value);
            if (auteur == null)
            {
                return NotFound();
            }
            return View(auteur);
        }

        // POST: Auteurs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Prenom,Nom,Id")] Auteur auteur)
        {
            if (id != auteur.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await Repository.Create(auteur);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await AuteurExists(auteur.Id))
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
            return View(auteur);
        }

        // GET: Auteurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var auteur = await Repository.GetById(id.Value);
                    
            if (auteur == null)
            {
                return NotFound();
            }

            return View(auteur);
        }

        // POST: Auteurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (await Repository.IsEmpty())
            {
                return Problem("Entity set 'FilRougeBiblioContext.Auteurs'  is null.");
            }
            var auteur = await Repository.GetById(id);
            if (auteur != null)
            {
                await Repository.Delete(auteur);
            }
            
            
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> AuteurExists(int id)
        {
            return await Repository.Exists(id);
        }
    }
}
