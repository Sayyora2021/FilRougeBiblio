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
    public class MotClefsController : ControllerBase
    {

        private readonly IMotClefRepository Repository;

        public MotClefsController(IMotClefRepository repository)
        {
            Repository = repository;
        }

        // GET: MotClefs
        [HttpGet, Route("")]
        public async Task<ActionResult<List<MotClef>>> Index()
        {
            return !await Repository.IsEmpty() ?
                        await Repository.ListAll() :
                        Problem("Entity set 'FilRougeBiblioContext.MotClef'  is null.");
        }

        // GET: MotClefs/Details/5
        [HttpGet, Route("Details/{id}")]
        public async Task<ActionResult<MotClef>> Details(int? id)
        {
            if (id == null || await Repository.IsEmpty())
            {
                return NotFound();
            }

            var motClef = await Repository.GetById(id.Value);
            if (motClef == null)
            {
                return NotFound();
            }

            return motClef;
        }

        // POST: MotClefs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost,Route("Create")]
        
        public async Task<ActionResult<MotClef>> Create(MotClef motClef)
        {
            if (ModelState.IsValid)
            {
                await Repository.Create(motClef);
                return motClef;
            }
            return NoContent();
        }

        

        // POST: MotClefs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut,Route("Edit")]
        
        public async Task<ActionResult<MotClef>> Edit(int id,string tag)
        {
            MotClef motClef = new MotClef()
            {
                Id = id,
                Tag = tag,
                Livres = new List<Livre>()
            };

            if (id != 0)
            {
                try
                {
                    await Repository.Update(motClef);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await MotClefExists(motClef.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return motClef;
            }
            return BadRequest();
        }

       

        // POST: MotClefs/Delete/5
        [HttpDelete, Route("Delete/{id}")]
        
        public async Task<ActionResult<MotClef>> DeleteConfirmed(int id)
        {
            if (await Repository.IsEmpty())
            {
                return Problem("Entity set 'FilRougeBiblioContext.MotClef'  is null.");
            }
            var motClef = await Repository.GetById(id);
            if (motClef != null)
            {
                await Repository.Delete(motClef);
            }


            return motClef;
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        private async Task<bool> MotClefExists(int id)
        {
            return await Repository.Exists(id);
        }

    }
}
