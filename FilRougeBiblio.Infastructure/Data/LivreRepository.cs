using FilRougeBiblio.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilRougeBiblio.Core.Seedwork;
using System.Linq.Expressions;

namespace FilRougeBiblio.Infrastructure.Data 
{
    public class LivreRepository : ILivreRepository
    {
        private FilRougeBiblioContext Context { get; }
        private IMotClefRepository MotClefRepository { get; }
        private IAuteurRepository AuteurRepository { get;  }
        private IThemeRepository ThemeRepository { get; }

        public LivreRepository(FilRougeBiblioContext context, IMotClefRepository motClefRepository, IThemeRepository themeRepository, IAuteurRepository auteurRepository)
        {
            Context = context;
            MotClefRepository = motClefRepository;
            AuteurRepository = auteurRepository;
            ThemeRepository = themeRepository;
        }
        public async Task Create(Livre livre)
        {
            await Context.Livres.AddAsync(livre);
            await Context.SaveChangesAsync();
        }

        //public async Task Update(Livre livre, List<MotClef> motsClefs, List<Auteur> auteurs, List<Theme> themes)
        public async Task Update(Livre livre, int[] tags, int[] auteurs, int[] themes)
        {
            /*var _tags = await MotClefRepository.GetList(m => tags.Contains(m.Id));
            var _auteurs = await AuteurRepository.GetList(m => auteurs.Contains(m.Id));
            var _themes = await ThemeRepository.GetList(m => themes.Contains(m.Id));*/
            /*foreach(var Auteur in auteurs) { Auteur.Livres.Remove(livre); Context.Update(Auteur); }
            foreach (var Theme in themes) { Theme.Livres.Remove(livre); Context.Update(Theme);  }
            foreach (var MotClef in motsClefs) { MotClef.Livres.Remove(livre); Context.Update(MotClef); }*/
            livre.Auteurs.Clear();
            livre.Tags.Clear();
            livre.Themes.Clear();
            Context.Update(livre);
            await Context.SaveChangesAsync();


            Context.Livres.Update(livre);
            await Context.SaveChangesAsync();

        }
        public async Task Delete(Livre livre)
        {
            Context.Livres.Remove(livre);
            await Context.SaveChangesAsync();

        }
        public async Task<List<Livre>> ListAll()
        {
            return await Context.Livres.Include(c => c.Auteurs).Include(c => c.Themes).Include(c => c.Tags).ToListAsync();
        }
        public async Task<Livre> GetById(int id)
        {
            return await Context.Livres.Include(c => c.Auteurs).Include(c => c.Themes).Include(c => c.Tags).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Exists(int id)
        {
            return await Context.Livres.AnyAsync(c => c.Id == id);
        }
        public async Task<bool> IsEmpty()
        {
            return Context.Livres == null;
        }
        public async Task<List<Livre>> GetList(Expression<Func<Livre, bool>> criteria)
        {
            return await Context.Livres.Include(c => c.Auteurs).Include(c => c.Themes).Include(c => c.Tags).Where(criteria).ToListAsync();
        }
    }
}
