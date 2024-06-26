using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho3_carteira.Model
{
    public class Movimentacoes
    {
        public int Id {  get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public short Tipo {  get; set; } // 0 - deposito, 1 - retiradas

        [Required]
        public double Valor { get; set; }

        [Required]
        public short Categoria { get; set; }

        [Required]
        public double Saldo_dia { get; set; }

        [Required]
        [MaxLength(200)]
        public string? Descricao { get; set; }



    }
}
