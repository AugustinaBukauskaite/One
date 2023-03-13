using One.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Store.Models
{
    public class StoreEntities : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}