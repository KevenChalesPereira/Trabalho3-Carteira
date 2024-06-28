using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho3_carteira.Data;

namespace Trabalho3_carteira.Controller
{
    internal class CarteiraController 
    {
        public static string Mostra_SaldoTotal()
        {
            using (DataContext db = new DataContext())
            {
                return db.Carteira.ToList()[0].Saldo_total.ToString();
            }
        } 
    }
}
