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
    public class ThemesController : ControllerBase
    {
        private readonly IThemeRepository Repository;

        public ThemesController(IThemeRepository repository)
        {
            Repository = repository;
        }

        // GET: Themes
        [HttpGet,Route("")]
        public async Task<ActionResult<List<Theme>>> Index()
        {
            return !await Repository.IsEmpty() ?
                          await Repository.ListAll() :
                          Problem("Entity set 'FilRougeBiblioContext.Themes'  is null.");
        }

        // GET: Themes/Details/5
        [HttpGet, Route("Details/{id}")]
        public async Task<ActionResult<Theme>> Details(int? id)
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

            return theme;
        }


        // POST: Themes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost,Route("Create")]
        public async Task<ActionResult<Theme>> Create(Theme theme)
        {
            if (ModelState.IsValid)
            {
                await Repository.Create(theme);

                return theme;
            }
            return NoContent();
        }


        // PUT: Themes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut,Route("Edit/{id}")]
        public async Task<ActionResult<Theme>> Edit(int id, Theme theme)
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
                return Ok();
            }
            return BadRequest();
        }



        // DELETE: Themes/Delete/5
        [HttpDelete,Route("Delete/{id}")]
        public async Task<ActionResult<Auteur>> DeleteConfirmed(int id)
        {
            if (await Repository.IsEmpty())
            {
                return Problem("Entity set 'FilRougeBiblioContext.Themes'  is null.");
            }
            var theme = await Repository.GetById(id);
            if (theme != null)
            {
                await Repository.Delete(theme);
                return Ok();
            }
            else
            {
                return Problem("Erreur effacement");
            }
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        private async Task<bool> ThemeExists(int id)
        {
            return await Repository.Exists(id);
        }

    }
}
