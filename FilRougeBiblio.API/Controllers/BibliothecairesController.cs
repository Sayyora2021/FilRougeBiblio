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
    public class BibliothecairesController : ControllerBase
    {
        private readonly IBibliothecaireRepository Repository;

        public BibliothecairesController(IBibliothecaireRepository repository)
        {
            Repository = repository;
        }
        
        // GET: api/Bibliothecaires
        [HttpGet, Route ("")]
        public async Task<ActionResult<List<Bibliothecaire>>> Index()
        {
            return !await Repository.IsEmpty() ?
                  await Repository.ListAll() :
                  Problem("Entity set 'FilRougeBiblioContext.Bibliothecaire' is null.");
          
        }
        

        // GET: api/Bibliothecaires/5
        [HttpGet, Route("Detail/{id}")]
        public async Task<ActionResult<Bibliothecaire>> Details(int? id)
        {
          if (id == null || await Repository.IsEmpty())
          {
              return NotFound();
          }
            var bibliothecaire = await Repository.GetById(id.Value);

            if (bibliothecaire == null)
            {
                return NotFound();
            }

            return bibliothecaire;
        }

        // POST: Bibliothecaire/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, Route("Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<Bibliothecaire>> Create(Bibliothecaire bibliothecaire)
        {
            if (ModelState.IsValid)
            {
                await Repository.Create(bibliothecaire);

                return bibliothecaire;
            }
            return BadRequest();
        }


        
        // POST: Bibliothecaire/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut, Route("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<Bibliothecaire>> Edit(int id, [Bind("Email,Password,Id")] Bibliothecaire bibliothecaire)
        {
            if (id != bibliothecaire.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await Repository.Create(bibliothecaire);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await BibliothecaireExists(bibliothecaire.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return bibliothecaire;
            }
            return BadRequest();
        }
       

        // POST: Bibliothecaire/Delete/5
        [HttpDelete, Route("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<Bibliothecaire>> Delete(int id)
        {
            if (await Repository.IsEmpty())
            {
                return Problem("Entity set 'FilRougeBiblioContext.Auteurs'  is null.");
            }
            var bibliothecaire = await Repository.GetById(id);
            if (bibliothecaire != null)
            {
                await Repository.Delete(bibliothecaire);
            }

            return bibliothecaire;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        private async Task<bool> BibliothecaireExists(int id)
        {
            return await Repository.Exists(id);
        }
    }
}
