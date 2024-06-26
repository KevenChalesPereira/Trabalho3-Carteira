using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho3_carteira.Model;

namespace Trabalho3_carteira.Data
{
    public class DataContext : DbContext    
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLSERVER2014ECE; Initial Catalog=DBCarteira; Integrated Security=SSPI; Trust Server Certificate=True");
            //Data Source=localhost,1401; Initial Catalog=DBCarteira; User=sa; password=Senh@123 Trust Server Certificate=True
        }

        public DbSet<Carteira> Carteira { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Movimentacoes> Movimentacoes { get; set; }

    }
}
