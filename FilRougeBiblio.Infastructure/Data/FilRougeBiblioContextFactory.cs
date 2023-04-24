using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBiblio.Infrastructure.Data
{
    public class FilRougeBiblioContextFactory : IDesignTimeDbContextFactory<FilRougeBiblioContext>
    {
        public FilRougeBiblioContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FilRougeBiblioContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FilRougeBiblio;Integrated Security=True");
            return new FilRougeBiblioContext(optionsBuilder.Options);
        }
    }
}
