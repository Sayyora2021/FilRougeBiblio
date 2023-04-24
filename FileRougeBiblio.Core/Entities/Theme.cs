using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBiblio.Core.Entities
{
    public class Theme : Entity
    {
        public string Nom { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
