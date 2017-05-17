using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WingtipToysMVC.Models
{
    public class WingtipToysMVCContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WingtipToysMVCContext() : base("name=WingtipToysMVCContext")
        {
            DropCreateDatabaseIfModelChanges<WingtipToysMVCContext> initializer =
                new DropCreateDatabaseIfModelChanges<WingtipToysMVCContext>();
            Database.SetInitializer<WingtipToysMVCContext>(initializer);
        }

        public System.Data.Entity.DbSet<WingtipToysMVC.Models.Produto> Produtoes { get; set; }

        public System.Data.Entity.DbSet<WingtipToysMVC.Models.Categoria> Categorias { get; set; }
    }
}
