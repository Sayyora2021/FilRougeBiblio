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
using System.Text.Json.Serialization;
using NuGet.ProjectModel;
using NuGet.LibraryModel;
using System.Drawing.Text;

namespace FilRougeBiblio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivresController : ControllerBase
    {

        private readonly ILivreRepository LivreRepository;
        private readonly IAuteurRepository AuteurRepository;
        private readonly IThemeRepository ThemeRepository;
        private readonly IMotClefRepository MotClefRepository;

        public LivresController(ILivreRepository livreRepository, IMotClefRepository motClefRepository, IAuteurRepository auteurRepository, IThemeRepository themeRepository)
        {
            LivreRepository = livreRepository;
            AuteurRepository = auteurRepository;
            ThemeRepository = themeRepository;
            MotClefRepository = motClefRepository;
       
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
        [HttpPost, Route("Create")]
        public async Task<ActionResult<Livre>> Create([FromBody] ApiLivre apiLivre)
        {
            Livre livre = new Livre();
            livre.Titre = apiLivre.Titre;
            livre.ISBN = apiLivre.Isbn;

            livre.Auteurs = new List<Auteur>();
            livre.Tags = new List<MotClef>();
            livre.Themes = new List<Theme>();

            await PopulateAuteursThemesTags(livre, apiLivre.auteursIds, apiLivre.themesIds, apiLivre.tagsIds);

            try
            {
                await LivreRepository.Create(livre);
                return Ok();
            } 
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        

        // POST: Livres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut,Route("Edit/{id}")]
        public async Task<ActionResult<Livre>> Edit(int id, [FromBody] ApiLivre apiLivre)
        {
            try
            {
                Livre livre = await LivreRepository.GetById(id);
                livre.Titre = apiLivre.Titre;
                livre.ISBN = apiLivre.Isbn;
                livre.Auteurs.Clear();
                livre.Tags.Clear();
                livre.Themes.Clear();
                await PopulateAuteursThemesTags(livre, apiLivre.auteursIds, apiLivre.themesIds, apiLivre.tagsIds);

                await LivreRepository.Update(livre);
                return Ok();
            }
            catch (Exception ex) { return Problem(ex.Message); }
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

        [ApiExplorerSettings(IgnoreApi = true)]
        private async Task PopulateAuteursThemesTags(Livre livre, int[] auteursIds, int[] themesIds, int[] tagsIds)
        {
            foreach (int auteurId in auteursIds)
            {
                Auteur auteur = await AuteurRepository.GetById(auteurId);
                livre.Auteurs.Add(auteur);
            }

            foreach (int themeId in themesIds)
            {
                Theme theme = await ThemeRepository.GetById(themeId);
                livre.Themes.Add(theme);
            }

            foreach (int tagId in tagsIds)
            {
                MotClef tag = await MotClefRepository.GetById(tagId);
                livre.Tags.Add(tag);
            }
        }
    }
}

public class ApiLivre  {
    public string? Titre { get; set; }
    public string? Isbn { get; set; }

    public int[] auteursIds { get; set; }
    public int[] themesIds { get; set; }
    public int[] tagsIds { get; set; }
}

