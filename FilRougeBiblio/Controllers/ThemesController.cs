using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FilRougeBiblio.Core.Entities;
using FilRougeBiblio.Infrastructure.Data;
using NuGet.Protocol.Core.Types;
using FilRougeBiblio.Core.Seedwork;

namespace FilRougeBiblio.Controllers
{
    public class ThemesController : Controller
    {
        private readonly IThemeRepository Repository;

        public ThemesController(IThemeRepository repository)
        {
            Repository = repository;
        }

        // GET: Themes
        public async Task<IActionResult> Index()
        {
              return ! await Repository.IsEmpty() ? 
                          View(await Repository.ListAll()) :
                          Problem("Entity set 'FilRougeBiblioContext.Themes'  is null.");
        }

        // GET: Themes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var theme = await Repository.GetById(id.Value);
            if (theme == null)
            {
                return NotFound();
            }

            return View(theme);
        }

        // GET: Themes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Themes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Theme theme)
        {
            if (ModelState.IsValid)
            {
                await Repository.Create(theme);
                
                return RedirectToAction(nameof(Index));
            }
            return View(theme);
        }

        // GET: Themes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var theme = await Repository.GetById(id.Value);
            if (theme == null)
            {
                return NotFound();
            }
            return View(theme);
        }

        // POST: Themes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nom,Description,Id")] Theme theme)
        {
            if (id != theme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await Repository.Update(theme);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await ThemeExists(theme.Id))
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
            return View(theme);
        }

        // GET: Themes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var theme = await Repository.GetById(id.Value);
                
            if (theme == null)
            {
                return NotFound();
            }

            return View(theme);
        }

        // POST: Themes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (await Repository.IsEmpty())
            {
                return Problem("Entity set 'FilRougeBiblioContext.Themes'  is null.");
            }
            var theme = await Repository.GetById(id);
            if (theme != null)
            {
                await Repository.Delete(theme);
            }
            
            
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ThemeExists(int id)
        {
            return await Repository.Exists(id);
        }
    }
}
