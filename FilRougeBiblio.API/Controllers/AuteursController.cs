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
    public class AuteursController : ControllerBase
    {
        private readonly IAuteurRepository Repository;

        public AuteursController(IAuteurRepository repository)
        {
            Repository = repository;
        }

        // GET: Auteurs
        [HttpGet,Route("")]
        public async Task<ActionResult<List<Auteur>>> Index()
        {
            return !await Repository.IsEmpty() ?
                          await Repository.ListAll() :
                          Problem("Entity set 'FilRougeBiblioContext.Auteurs'  is null.");
        }

        // GET: Auteurs/Details/5
        [HttpGet, Route("Details/{id}")]
        public async Task<ActionResult<Auteur>> Details(int? id)
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

            return auteur;
        }


        // POST: Auteurs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost,Route("Create")]
        
        public async Task<ActionResult<Auteur>> Create(Auteur auteur)
        {
            if (ModelState.IsValid)
            {
                await Repository.Create(auteur);

                return auteur;
            }
            return BadRequest();
        }


        // POST: Auteurs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut,Route("Edit/{id}")]
        
        public async Task<ActionResult<Auteur>> Edit(int id, [Bind("Prenom,Nom,Id")] Auteur auteur)
        {
            if (id != auteur.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await Repository.Update(auteur);

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
                return auteur;
            }
            return BadRequest();
        }

        // POST: Auteurs/Delete/5
        [HttpDelete,Route("Delete/{id}")]
        
        public async Task<ActionResult<Auteur>> DeleteConfirmed(int id)
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


            return auteur;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        private async Task<bool> AuteurExists(int id)
        {
            return await Repository.Exists(id);
        }

    }
}
