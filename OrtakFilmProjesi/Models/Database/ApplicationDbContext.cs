using Microsoft.EntityFrameworkCore;

namespace OrtakFilmProjesi.Models.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Seanslar> Seanslars { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                                                new User
                                                {
                                                    Id=1,
                                                    Mail= "admin@hotmail.com",
                                                    Password= "12345"
                                                }
                                                );
        }
    }

    

    
}
