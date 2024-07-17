using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho3_carteira.Data;
using Trabalho3_carteira.Model;

namespace Trabalho3_carteira.Controller
{
    internal class CarteiraController
    {


        public static List<Carteira>? vercarteira()
        {
            using (DataContext db = new DataContext())
            {
                return db.Carteira.ToList();
            }
        }


        public static void Salvar(Carteira carteirauser)
        {
            using (DataContext db = new DataContext())
            {
                db.Add(carteirauser);
                db.SaveChanges();
            }
        }
    }
}
