using Microsoft.EntityFrameworkCore;
using Model.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Config
{
    public class ContextBase : DbContext
    {


        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            // Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        public DbSet<ProdutoViewModel> ProdutoViewModel { get; set; }
        public DbSet<Model.Pessoa.PessoaViewModel> PessoaViewModel { get; set; }

        private string GetStringConectionConfig()
        {
            string strCon = "Server=(localdb)\\MSSQLLocalDB;Database=Henrique;Trusted_Connection=True;";

            return strCon;
        }
    }
}
