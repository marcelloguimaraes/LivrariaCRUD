using LivrariaCRUD.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LivrariaCRUD.Contexto
{
    public class LivrariaContext : DbContext
    {
        public LivrariaContext()
            : base("LivrariaContext")
        {

        }

        public DbSet<Livro> Livro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}