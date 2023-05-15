using FilRougeBiblio.Core.Entities;
using FilRougeBiblio.Core.Seedwork;
using FilRougeBiblio.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace FilRougeBiblio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpruntsController : ControllerBase
    {
        private readonly IEmpruntRepository EmpruntRepository;
        private readonly ILecteurRepository LecteurRepository;
        private readonly IExemplaireRepository ExemplaireRepository;

        public EmpruntsController(IEmpruntRepository empruntRepository, ILecteurRepository lecteurRepository, IExemplaireRepository exemplaireRepository)
        {
            EmpruntRepository = empruntRepository;
            LecteurRepository = lecteurRepository;
            ExemplaireRepository = exemplaireRepository;
        }

        [HttpGet, Route("")]
        public async Task<IEnumerable<Emprunt>> Index()
        {
            return await EmpruntRepository.ListAll();
        }

        
        [HttpPut, Route("Rendre")]
        public async Task<ActionResult<Emprunt>> Rendre(int empruntId)
        {
            Emprunt e = await EmpruntRepository.GetById(empruntId);
            if(e == null) { return BadRequest("EmpruntId invalide"); }

            await EmpruntRepository.RemoveBookFromLecteur(e);
            return Ok();
        }

        [HttpPost, Route("Create")]
        public async Task<ActionResult<Emprunt>> Create(int lecteurId, int exemplaireId)
        {
            if (ModelState.IsValid)
            {
                Lecteur lecteur = await LecteurRepository.GetById(lecteurId);
                if (lecteur is null) { return BadRequest("LecteurId invalide"); }
                Exemplaire exemplaire = await ExemplaireRepository.GetById(exemplaireId);
                if (exemplaire is null) { return BadRequest("ExemplaireId invalide"); }

                Emprunt emprunt = new Emprunt() { Exemplaire = exemplaire, DateRetourReel = null, DateEmprunt = DateTime.Now, DateRetour = DateTime.Now.AddMonths(1), Lecteur = lecteur };
                try {
                    await EmpruntRepository.AddBookToLecteur(emprunt);
                    return emprunt;
                }
                catch (Exception ex)
                {
                    return Problem(ex.Message);
                }
                
            }
            return BadRequest();
        }
    }

}

