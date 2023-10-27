using Microsoft.EntityFrameworkCore;

namespace TODO.WebApi.Models
{
    public class TODOAppDbContext : DbContext
    {
        public TODOAppDbContext(DbContextOptions<TODOAppDbContext> options) : base(options) { }//inyección de dependencias?????

        //Mapiamos nuestras tablas en el DbContext
        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }

        //no entendí para qué son estas líneas, creo que es para manejar los nombres que apareen en las tablas inicialmente
        //protected override void onmodelcreating(modelbuilder modelbuilder)
        //{
        //    modelBuilder.Entity<User>().ToTable("User");//modelBuilder.Entity<User>().ToTable("TodoAppUsers");
        //    
        //    modelBuilder.Entity<TodoItem>().ToTable("TodoItems");
        //}
    }
}
