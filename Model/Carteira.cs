using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho3_carteira.Model
{
    public class Carteira
    {
        [Key]//salvar
        public string Nome { get; set; }   
        public string Senha { get; set; } = "";
        public double Saldo_total { get; set; }

    }
}
