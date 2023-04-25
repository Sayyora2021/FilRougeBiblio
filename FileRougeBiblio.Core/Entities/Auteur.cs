using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBiblio.Core.Entities
{
    public class Auteur : Entity
    {
        [Required]
        [MaxLength(50)]
        public string Prenom { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        public string Nom { get; set; } = null!;

        public virtual List<Livre> Livres { get; set; } = null!;
    }
}
