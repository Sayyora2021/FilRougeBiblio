using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FilRougeBiblio.Core.Entities;
using FilRougeBiblio.Infrastructure.Data;
using FilRougeBiblio.Core.Seedwork;

namespace FilRougeBiblio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExemplairesController : ControllerBase
    {
        private readonly IExemplaireRepository Repository;
        private readonly ILivreRepository LivreRepository;

        public ExemplairesController(IExemplaireRepository repository, ILivreRepository livreRepository)
        {
            Repository = repository;
            LivreRepository = livreRepository;
        }

        // GET: Exemplaires
        [HttpGet, Route("")]
        public async Task<ActionResult<List<Exemplaire>>> Index()
        {
            return !await Repository.IsEmpty() ?
                          await Repository.ListAll() :
                          Problem("Entity set 'FilRougeBiblioContext.Themes'  is null.");
        }

        // GET: Exemplaires/Details/5
        [HttpGet, Route("Details/{id}")]
        public async Task<ActionResult<Exemplaire>> Details(int? id)
        {
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var exemplaire = await Repository.GetById(id.Value);

            if (exemplaire == null)
            {
                return NotFound();
            }

            return exemplaire;
        }


        // POST: Exemplaires/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, Route("Create")]
        public async Task<ActionResult<Exemplaire>> Create(string numero, int livreId)
        {
            if (numero != "" && livreId != 0)
            {
                Exemplaire exemplaire = new Exemplaire()
                {
                    NumeroInventaire = numero,
                    MiseEnService = DateTime.Now,
                    Livre = await LivreRepository.GetById(livreId)
                };

                await Repository.Create(exemplaire);

                return exemplaire;
            }
            return BadRequest();
        }


        // PUT: Exemplaires/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut,Route("Edit/{id}")]
        public async Task<ActionResult<Exemplaire>> Edit(int id, Exemplaire exemplaire)
        {
            if (id != exemplaire.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await Repository.Create(exemplaire);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await ExemplaireExists(exemplaire.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Ok();
            }
            return BadRequest();
        }



        // DELETE: Exemplaires/Delete/5
        [HttpDelete,Route("Delete/{id}")]
        public async Task<ActionResult<Exemplaire>> DeleteConfirmed(int id)
        {
            if (await Repository.IsEmpty())
            {
                return Problem("Entity set 'FilRougeBiblioContext.Exemplaires'  is null.");
            }
            var exemplaire = await Repository.GetById(id);
            if (exemplaire != null)
            {
                await Repository.Delete(exemplaire);
                return Ok();
            }
            else
            {
                return Problem("Erreur effacement");
            }
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        private async Task<bool> ExemplaireExists(int id)
        {
            return await Repository.Exists(id);
        }

    }
}
