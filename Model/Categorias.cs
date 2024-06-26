using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho3_carteira.Model
{
    public class Categorias
    {
       public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set;}
    }
}
