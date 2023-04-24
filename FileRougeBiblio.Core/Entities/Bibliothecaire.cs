using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBiblio.Core.Entities
{
    public class Bibliothecaire : Entity
    {
        public string Email { get; set; } = null!;

        public string MotDePasse { get; set; } = null!;
    }
}
