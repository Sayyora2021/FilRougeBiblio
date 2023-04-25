using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBiblio.Core.Entities
{
    public class Bibliothecaire : Entity
    {
        public string Email { get; set; } = null!;
        [DataType(DataType.Password)]
        public string MotDePasse { get; set; } = null!;
    }
}
