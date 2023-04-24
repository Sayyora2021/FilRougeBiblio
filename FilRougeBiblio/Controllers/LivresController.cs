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
    public class LivresController : Controller
    {
        private readonly ILivreRepository LivreRepository;
        private readonly IAuteurRepository AuteurRepository;
        private readonly IThemeRepository ThemeRepository;
        private readonly IExemplaireRepository ExemplaireRepository;
        private readonly IMotClefRepository MotClefRepository;


        public LivresController(ILivreRepository livreRepository, IAuteurRepository auteurRepository, IThemeRepository themeRepository, IExemplaireRepository exemplaireRepository, IMotClefRepository motClefRepository)
        {
            LivreRepository = livreRepository;
            AuteurRepository = auteurRepository;
            ThemeRepository = themeRepository;
            ExemplaireRepository = exemplaireRepository;
            MotClefRepository = motClefRepository;
        }

        private async Task SetupViewBags()
        {
            if(!(await AuteurRepository.IsEmpty() && await ThemeRepository.IsEmpty() && await ExemplaireRepository.IsEmpty() && await MotClefRepository.IsEmpty()))
            {
                ViewBag.Auteurs = new SelectList(await AuteurRepository.ListAll(), nameof(Auteur.Id), nameof(Auteur.Nom));
                ViewBag.Themes = new SelectList(await ThemeRepository.ListAll(), nameof(Theme.Id), nameof(Theme.Nom));
                ViewBag.Exemplaires = new SelectList(await ExemplaireRepository.ListAll(), nameof(Exemplaire.Id), nameof(Exemplaire.NumeroInventaire));
                ViewBag.Tags = new SelectList(await MotClefRepository.ListAll(),nameof(MotClef.Id), nameof(MotClef.Tag));
            }
        }

        // GET: Livres
        public async Task<IActionResult> Index()
        {
              return ! await LivreRepository.IsEmpty() ? 
                          View(await LivreRepository.ListAll()) :
                          Problem("Entity set 'FilRougeBiblioContext.Livres'  is null.");
        }

        // GET: Livres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || await LivreRepository.IsEmpty())
            {
                return NotFound();
            }

            var livre = await LivreRepository.ListAll();
                
            if (livre == null)
            {
                return NotFound();
            }

            return View(livre);
        }

        // GET: Livres/Create
        public async Task<IActionResult> Create()
        {
            await SetupViewBags();
            return View();
        }

        // POST: Livres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Livre livre,List<MotClef> tags,List<Auteur> auteurs,List<Theme> themes)
        {
            await SetupViewBags();
            livre.Themes = themes;
            livre.Tags = tags;
            livre.Auteurs = auteurs;
            if (ModelState.IsValid)
            {
                await LivreRepository.Create(livre);
                
                return RedirectToAction(nameof(Index));
            }
            return View(livre);
        }

        // GET: Livres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || await LivreRepository.IsEmpty())
            {
                return NotFound();
            }

            var livre = await LivreRepository.GetById(id.Value);
            if (livre == null)
            {
                return NotFound();
            }
            return View(livre);
        }

        // POST: Livres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ISBN,Titre,Id")] Livre livre)
        {
            if (id != livre.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await LivreRepository.Update(livre);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await LivreExists(livre.Id))
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
            return View(livre);
        }

        // GET: Livres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || await LivreRepository.IsEmpty())
            {
                return NotFound();
            }

            var livre = await LivreRepository.GetById(id.Value);
                
            if (livre == null)
            {
                return NotFound();
            }

            return View(livre);
        }

        // POST: Livres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (await LivreRepository.IsEmpty())
            {
                return Problem("Entity set 'FilRougeBiblioContext.Livres'  is null.");
            }
            var livre = await LivreRepository.GetById(id) ;
            if (livre != null)
            {
                await LivreRepository.Delete(livre);
            }
            
            
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> LivreExists(int id)
        {
            return await LivreRepository.Exists(id);
        }
    }
}
