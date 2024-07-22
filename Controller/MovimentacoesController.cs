using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho3_carteira.Data;
using Trabalho3_carteira.Model;

namespace Trabalho3_carteira.Controller
{
    internal class MovimentacoesController
    {
        public static List<Movimentacoes> Mostra_Movimentacoes(DateTime data)
        {
            using (DataContext db = new DataContext())
            {
                return db.Movimentacoes.Where(x => x.Data == data).ToList();

            }
        }
        public static double Mostra_Saldo_Dia(DateTime data)
        {
            using (DataContext db = new DataContext())
            {
                double soma = 0;
                double subt = 0;

                soma = db.Movimentacoes.Where(x => x.Data == data && x.Tipo == 0).Sum(x => x.Valor); // valores inseridos
                subt = db.Movimentacoes.Where(x => x.Data == data && x.Tipo == 1).Sum(x => x.Valor); // valores retirados


                return soma + (-subt);

            }
        }

        public static double Mostra_Saldo_Total()
        {
            using (DataContext db = new DataContext())
            {
                double soma = 0;
                double subt = 0;

                soma = db.Movimentacoes.Where(x => x.Tipo == 0).Sum(x => x.Valor); // valores inseridos
                subt = db.Movimentacoes.Where(x => x.Tipo == 1).Sum(x => x.Valor); // valores retirados


                return soma + (-subt);

            }
        }
        public static void Editar(Movimentacoes mov)
        {
            using (DataContext db = new DataContext())
            {
                db.Movimentacoes.Update(mov);
                db.SaveChanges();
            }
        }
        public static void Excluir (Movimentacoes movimentacoes)
        {
            using (DataContext db = new DataContext()) 
            {
                if (db.Movimentacoes.Any(x => x.Id == movimentacoes.Id))
                {
                    db.Movimentacoes.Remove(movimentacoes);                  
                    db.SaveChanges();   
                }
            }  
        }
        
    }
}
