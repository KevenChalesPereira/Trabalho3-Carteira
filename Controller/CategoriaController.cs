using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho3_carteira.Data;
using Trabalho3_carteira.Model;

namespace Trabalho3_carteira.Controller
{
    internal class CategoriaController
    {
        public static List<Categorias> Busca_Cat()
        {
            using (DataContext db = new DataContext())
            {
                return db.Categorias.ToList();
            }
        }
    }
}
