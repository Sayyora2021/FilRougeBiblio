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
    public class LecteursController : ControllerBase
    {
        private readonly ILecteurRepository Repository;

        public LecteursController(ILecteurRepository repository)
        {
            Repository = repository;
        }

        // GET: Lecteurs
        [HttpGet,Route("")]
        public async Task<ActionResult<List<Lecteur>>> Index()
        {
            return !await Repository.IsEmpty() ?
                        await Repository.ListAll() :
                        Problem("Entity set 'FilRougeBiblioContext.Lecteurs'  is null.");
        }

        // GET: Lecteurs/Details/5
        [HttpGet, Route("Detail/{id}")]
        public async Task<ActionResult<Lecteur>> Details(int? id)
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

            return lecteur;
        }

        

        // POST: Lecteurs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost,Route("Create")]
        
        public async Task<ActionResult<Lecteur>> Create(Lecteur lecteur)
        {
            if (ModelState.IsValid)
            {
                await Repository.Create(lecteur);
                return lecteur;
            }
            return BadRequest();
        }

        // POST: Lecteurs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut,Route("Edit/{id}")]
        
        public async Task<ActionResult<Lecteur>> Edit(int id, Lecteur lecteur)
        {
            if (id != lecteur.Id)
            {
                return NotFound();
            }


            try
            {
                await Repository.Update(lecteur);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await LecteurExists(lecteur.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return lecteur;
        }

        // POST: Lecteurs/Delete/5
        [HttpDelete, Route("Delete/{id}")]
        
        public async Task<ActionResult<Lecteur>> DeleteConfirmed(int id)
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

            return lecteur;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        private async Task<bool> LecteurExists(int id)
        {
            return await Repository.Exists(id);
        }
    }
}
