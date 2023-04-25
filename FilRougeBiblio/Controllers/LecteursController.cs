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
    public class LecteursController : Controller
    {
        private readonly ILecteurRepository Repository;

        public LecteursController(ILecteurRepository repository)
        {
            Repository = repository;
        }

        // GET: Lecteurs
        public async Task<IActionResult> Index()
        {
              return ! await Repository.IsEmpty() ? 
                          View(await Repository.ListAll()) :
                          Problem("Entity set 'FilRougeBiblioContext.Lecteurs'  is null.");
        }

        // GET: Lecteurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var lecteur = await Repository.GetById(id.Value);
            if (lecteur == null)
            {
                return NotFound();
            }
                        
            return View(lecteur);
        }

        // GET: Lecteurs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lecteurs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Lecteur lecteur)
        {
            if (ModelState.IsValid)
            {
                await Repository.Create(lecteur);
                return RedirectToAction(nameof(Index));
            }
            return View(lecteur);
        }

        // GET: Lecteurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var lecteur = await Repository.GetById(id.Value);
            if (lecteur == null)
            {
                return NotFound();
            }
            return View(lecteur);
        }

        // POST: Lecteurs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nom,Prenom,Email,Telephone,Adresse,Cotisation,Id")] Lecteur lecteur)
        {
            if (id != lecteur.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await Repository.Update(lecteur);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await LecteurExists(lecteur.Id))
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
            return View(lecteur);
        }

        // GET: Lecteurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var lecteur = await Repository.GetById(id.Value);
            if (lecteur == null)
            {
                return NotFound();
            }

            return View(lecteur);
        }

        // POST: Lecteurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (await Repository.IsEmpty())
            {
                return Problem("Entity set 'FilRougeBiblioContext.Lecteurs'  is null.");
            }
            var lecteur = await Repository.GetById(id);
            if (lecteur != null)
            {
                await Repository.Delete(lecteur);
            }
            
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> LecteurExists(int id)
        {
          return await Repository.Exists(id);
        }
        

    }
}
