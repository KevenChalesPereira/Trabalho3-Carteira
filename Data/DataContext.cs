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
            //optionsBuilder.UseSqlServer("Data Source=localhost,1401; Initial Catalog=DBCarteira; User ID=sa; Password=Senh@123 ; TrustServerCertificate=True");



        }

        public DbSet<Carteira> Carteira { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Movimentacoes> Movimentacoes { get; set; }

    }
}
