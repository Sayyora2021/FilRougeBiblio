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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FilRougeBiblio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivresController : ControllerBase
    {

        private readonly ILivreRepository LivreRepository;

        public LivresController(ILivreRepository livreRepository)
        {
            LivreRepository = livreRepository;
            
        }

        // GET: Livres
        [HttpGet,Route("")]
        public async Task<ActionResult<List<Livre>>> Index()
        {
            return !await LivreRepository.IsEmpty() ?
                        await LivreRepository.ListAll() :
                        Problem("Entity set 'FilRougeBiblioContext.Livres'  is null.");
        }
        [HttpGet, Route("Details/{id}")]
        // GET: Livres/Details/5
        public async Task<ActionResult<Livre>> Details(int? id)
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

            return livre;
        }

        // POST: Livres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost,Route("Create")]
        public async Task<ActionResult<Livre>> Create(Livre livre)
        {
            if (ModelState.IsValid)
            {
                await LivreRepository.Create(livre);
                return livre;
            }
            return BadRequest();
        }

        

        // POST: Livres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut,Route("Edit/{id}")]
        public async Task<ActionResult<Livre>> Edit(int id, Livre livre)
        {
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
                return livre;
            }
            return BadRequest();
        }

        // POST: Livres/Delete/5
        [HttpDelete, Route("Delete/{id}")]
        public async Task<ActionResult<Livre>> DeleteConfirmed(int id)
        {
            if (await LivreRepository.IsEmpty())
            {
                return Problem("Entity set 'FilRougeBiblioContext.Livres'  is null.");
            }
            var livre = await LivreRepository.GetById(id);
            if (livre != null)
            {
                await LivreRepository.Delete(livre);
            }


            return livre;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        private async Task<bool> LivreExists(int id)
        {
            return await LivreRepository.Exists(id);
        }


    }
}
