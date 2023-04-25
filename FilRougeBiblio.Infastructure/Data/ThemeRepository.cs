using FilRougeBiblio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilRougeBiblio.Core.Seedwork;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FilRougeBiblio.Infrastructure.Data
{
    public class ThemeRepository: IThemeRepository
    {
        private FilRougeBiblioContext Context { get; }
        public ThemeRepository(FilRougeBiblioContext context)
        {
            Context = context;
        }
        
        public async Task Create(Theme theme)
        {
            await Context.Themes.AddAsync(theme);
            await Context.SaveChangesAsync();
        }

        public async Task Update(Theme theme)
        {
            Context.Themes.Update(theme);
            await Context.SaveChangesAsync();
        }


        public async Task Delete(Theme theme)
        {
            Context.Themes.Remove(theme);
            await Context.SaveChangesAsync();
        }

       public async Task<List<Theme>> ListAll()
        {
            return await Context.Themes.ToListAsync();
        }

        public async Task<Theme> GetById(int id)
        {
            return await Context.Themes.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Exists(int id)
        {
            return await Context.Themes.AnyAsync(c => c.Id == id);
        }

        public async Task<bool> IsEmpty()
        {
            return Context.Themes == null;
        }
        public async Task<List<Theme>> GetList(Expression<Func<Theme, bool>> criteria)
        {
            return await Context.Themes.Where(criteria).ToListAsync();
        }
    }
}
