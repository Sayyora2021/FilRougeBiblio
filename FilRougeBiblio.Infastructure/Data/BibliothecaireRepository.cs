using FilRougeBiblio.Core.Entities;
using FilRougeBiblio.Core.Seedwork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBiblio.Infrastructure.Data
{
    public class BibliothecaireRepository : IBibliothecaireRepository
    {

        private FilRougeBiblioContext Context { get; }
        public BibliothecaireRepository(FilRougeBiblioContext context)
        {
            Context = context;
        }
        public async Task Create(Bibliothecaire bibliothecaire)
        {
            await Context.Bibliothecaires.AddAsync(bibliothecaire);
            await Context.SaveChangesAsync();
        }
        public async Task Update(Bibliothecaire bibliothecaire)
        {
            Context.Bibliothecaires.Update(bibliothecaire);
            await Context.SaveChangesAsync();

        }
        public async Task Delete(Bibliothecaire bibliothecaire)
        {
            Context.Bibliothecaires.Remove(bibliothecaire);
            await Context.SaveChangesAsync();

        }
        public async Task<List<Bibliothecaire>> ListAll()
        {
            return await Context.Bibliothecaires.ToListAsync();
        }
        public async Task<Bibliothecaire> GetById(int id)
        {
            return await Context.Bibliothecaires.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Exists(int id)
        {
            return await Context.Bibliothecaires.AnyAsync(c => c.Id == id);
        }
        public async Task<bool> IsEmpty()
        {
            return Context.Bibliothecaires == null;
        }

    }
}
