using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho3_carteira.Controller;

namespace Trabalho3_carteira.Model
{
    public class Movimentacoes
    {
        public int Id {  get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Required]
        public short Tipo {  get; set; } // 0 - deposito, 1 - retiradas

        [Required]
        public double Valor { get; set; }

        [Required]
        public int Categoria { get; set; }


        [MaxLength(200)]
        public string? Descricao { get; set; }
        
        
        [NotMapped]
        public string Nome_Tipo
        {
           
            get
            {
                if(Tipo == 0)
                {
                    return "Depósito";
                }
                else {
                    return "Retirada";
                }
            }

        }

        [NotMapped]
        public string Nome_Categoria
        {
            get
            {
              List<Categorias>  cat = CategoriaController.Busca_Cat();
               string nome = "";

                for(int i = 0; i < cat.Count; i++)
                {
                    if(Categoria == cat[i].Id)
                    {
                        nome =  cat[i].Nome;
                    }
                   
                
                }
                return nome;
            }
        }

        public void Editar(int id, DateTime data, short tipo, short cat, double v, string desc)
        {
            //TO DO função para editar as movimentações!!!!
        }

    }
}
