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
        private readonly IExemplaireRepository ExemplaireRepository;


        private async Task SetupViewBags()
        {
            if (!(await ExemplaireRepository.IsEmpty() && await LecteurRepository.IsEmpty()))
            {
                //ViewBag.Exemplaires = new SelectList(await ExemplaireRepository.ListAll(), nameof(Exemplaire.Id), nameof(Exemplaire.NumeroInventaire));
                ViewBag.Exemplaires = await ExemplaireRepository.ListAll();
                ViewBag.Lecteurs = new SelectList(await LecteurRepository.ListAll(), nameof(Lecteur.Id), nameof(Lecteur.Nom));
            }
        }

        public EmpruntsController(IEmpruntRepository empruntRepository, ILecteurRepository lecteurRepository, IExemplaireRepository exemplaireRepository)
        {
            EmpruntRepository = empruntRepository;
            LecteurRepository = lecteurRepository;
            ExemplaireRepository = exemplaireRepository;
        }

        // GET: Emprunts
        public async Task<IActionResult> Index()
        {
            //await SetupViewBags();
              return ! await LecteurRepository.IsEmpty() ? 
                          View(await EmpruntRepository.ListAll()) :
                          Problem("Entity set 'FilRougeBiblioContext.Emprunts'  is null.");
        }



        public async Task<IActionResult> Create()
        {
            await SetupViewBags();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int LecteurId, int ExemplaireId)
        {
            var e = new Emprunt()
            {
                Lecteur = await LecteurRepository.GetById(LecteurId),
                Exemplaire = await ExemplaireRepository.GetById(ExemplaireId),
                DateEmprunt = DateTime.Now,
                DateRetour = DateTime.Now.AddMonths(1)
            };

            await EmpruntRepository.Create(e);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Rendre(int? id)
        {
            Emprunt emprunt = await EmpruntRepository.GetById(id.Value);
            await EmpruntRepository.RemoveBookFromLecteur(emprunt);
            return RedirectToAction(nameof(Index));

        }





    }
}
