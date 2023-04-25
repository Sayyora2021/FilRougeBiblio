using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBiblio.Core.Entities
{
    public class Exemplaire: Entity
    {
        public Livre Livre { get; set; } = null!;
        [Required]
        [MaxLength(100)]
        public string NumeroInventaire { get; set; } = null!;

        public DateTime? MiseEnService { get; set; }
    }
}
