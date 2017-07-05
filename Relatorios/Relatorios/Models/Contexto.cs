using System.Data.Entity;

namespace Relatorios.Models
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {
            //Database.SetInitializer<Contexto>(new CreateDatabaseIfNotExists<Contexto>());
            Database.SetInitializer<Contexto>(new DropCreateDatabaseIfModelChanges<Contexto>());
            //Database.SetInitializer<Contexto>(new DropCreateDatabaseAlways<Contexto>());
        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

    }
}