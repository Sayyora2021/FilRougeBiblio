using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBiblio.Infrastructure.Data
{
    public class EntityRepository
    {
        private  FilRougeBiblioContext Context {get;}

        public EntityRepository(FilRougeBiblioContext context)
        {
            Context = context;
        }
    }
}
