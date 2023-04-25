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
    public class MotClefRepository : IMotClefRepository
    {
        private FilRougeBiblioContext Context { get; }
        public MotClefRepository(FilRougeBiblioContext context)
        {
            Context = context;
        }
        public async Task Create(MotClef motclef)
        {
            await Context.MotClefs.AddAsync(motclef);
            await Context.SaveChangesAsync();
        }
        public async Task Update(MotClef motclef)
        {
            Context.MotClefs.Update(motclef);
            await Context.SaveChangesAsync();

        }
        public async Task Delete(MotClef motclef)
        {
            Context.MotClefs.Remove(motclef);
            await Context.SaveChangesAsync();

        }
        public async Task<List<MotClef>> ListAll()
        {
            return await Context.MotClefs.Include(t=> t.Livres).ToListAsync();
         
        }

        public async Task<MotClef> GetById(int id)
        {
            return await Context.MotClefs.Include(c => c.Livres).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Exists(int id)
        {
            return await Context.MotClefs.AnyAsync(c => c.Id == id);
        }
        public async Task<bool> IsEmpty()
        {
            return Context.MotClefs == null;
        }

        //public async Task<List<MotClef>> GetBookTags(int[] tags)
        //{
        //    return await Context.MotClefs.Where(m => tags.Contains(m.Id)).ToListAsync();
        //}
        public async Task<List<MotClef>> GetList(Expression<Func<MotClef, bool>> criteria)
        {
            return await Context.MotClefs.Include(t=>t.Livres).Where(criteria).ToListAsync();
           
        }
    }
}
