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
    public class EmpruntsController : Controller
    {
        private readonly IEmpruntRepository EmpruntRepository;
        private readonly ILecteurRepository LecteurRepository;

        public EmpruntsController(IEmpruntRepository empruntRepository, ILecteurRepository lecteurRepository)
        {
            EmpruntRepository = empruntRepository;
            LecteurRepository = lecteurRepository;
        }

        // GET: Emprunts
        public async Task<IActionResult> Index()
        {
              return ! await LecteurRepository.IsEmpty() ? 
                          View(await LecteurRepository.ListAll()) :
                          Problem("Entity set 'FilRougeBiblioContext.Emprunts'  is null.");
        }




        // GET: Emprunts/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || await LecteurRepository.IsEmpty())
        //    {
        //        return NotFound();
        //    }

        //    var emprunt = await _context.Emprunts
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (emprunt == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(emprunt);
        //}

        //// GET: Emprunts/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Emprunts/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("DateEmprunt,DateRetour,Id")] Emprunt emprunt)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(emprunt);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(emprunt);
        //}

        //// GET: Emprunts/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || await LecteurRepository.IsEmpty())
        //    {
        //        return NotFound();
        //    }

        //    var emprunt = await _context.Emprunts.FindAsync(id);
        //    if (emprunt == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(emprunt);
        //}

        //// POST: Emprunts/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("DateEmprunt,DateRetour,Id")] Emprunt emprunt)
        //{
        //    if (id != emprunt.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(emprunt);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!EmpruntExists(emprunt.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(emprunt);
        //}

        //// GET: Emprunts/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || await LecteurRepository.IsEmpty())
        //    {
        //        return NotFound();
        //    }

        //    var emprunt = await _context.Emprunts
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (emprunt == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(emprunt);
        //}

        //// POST: Emprunts/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (await LecteurRepository.IsEmpty())
        //    {
        //        return Problem("Entity set 'FilRougeBiblioContext.Emprunts'  is null.");
        //    }
        //    var emprunt = await _context.Emprunts.FindAsync(id);
        //    if (emprunt != null)
        //    {
        //        _context.Emprunts.Remove(emprunt);
        //    }
            
        //    return RedirectToAction(nameof(Index));
        //}

        //private async Task<bool> EmpruntExists(int id)
        //{
        //  return await LecteurRepository.Exists(id);
        //}
    }
}
