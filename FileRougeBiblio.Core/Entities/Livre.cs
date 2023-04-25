using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FilRougeBiblio.Core.Entities
{
    public class Livre : Entity
    {
        [Required]
        [MaxLength(100)]
        public string ISBN { get; set; } = null!;
        [Required]
        [MaxLength(100)]
        public string Titre { get; set; } = null!;
        public virtual List<Theme> Themes { get; set; } = null!;

        public virtual List<MotClef> Tags { get; set; } = null!;

        public virtual List<Auteur> Auteurs { get; set; } = null!;

        public virtual List<Exemplaire> Exemplaires { get; set; } = null!;
    }
}
