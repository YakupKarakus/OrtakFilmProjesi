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
        public DbSet<Session> Sessions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Mail = "admin@hotmail.com",
                Password = "12345"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                Mail = "user1@hotmail.com",
                Password = "12345"
            });
            modelBuilder.Entity<Film>().HasData(new Film
            {
                Id = 1,
                Name = "Dr.Strange",
                PhotoPath = "Dr.Strange.png",
                Description = "Fiziksel ve ruhsal bir şifa yolculuğundayken, parlak bir beyin cerrahı mistik sanatların dünyasına çekilir.",
                Price = 50
            });
            modelBuilder.Entity<Film>().HasData(new Film
            {
                Id = 2,
                Name = "Dune",
                PhotoPath = "Dune.png",
                Description = "Asil bir aile, galaksinin en değerli varlığı üzerinde kontrol için bir savaşa girerken, varisi karanlık bir geleceğin vizyonları tarafından rahatsız edilir.",
                Price = 50
            });
            modelBuilder.Entity<Film>().HasData(new Film
            {
                Id = 3,
                Name = "Interstellar",
                PhotoPath = "Interstellar.png",
                Description = "Bir kaşif ekibi, insanlığın hayatta kalmasını sağlamak için uzayda bir solucan deliğinden geçer.",
                Price = 50
            });
            modelBuilder.Entity<Film>().HasData(new Film
            {
                Id = 4,
                Name = "Thor",
                PhotoPath = "Thor.png",
                Description = "Thor, tanrıları yok etmeyi amaçlayan Tanrı Kasabı Gorr ile savaşmak için Valkyrie, Korg ve eski kız arkadaşı Jane Foster'dan yardım ister.",
                Price = 50
            });
            modelBuilder.Entity<Film>().HasData(new Film
            {
                Id = 5,
                Name = "TopGun",
                PhotoPath = "TopGun.png",
                Description = "Donanmanın en iyi havacılarından biri olarak otuz yıldan fazla hizmet verdikten sonra, Pete Mitchell ait olduğu yerdedir, cesur bir test pilotu olarak sınırları zorlar ve onu yere indirecek rütbedeki ilerlemeden kaçınır.",
                Price = 50
            });

        }
    }

    

    
}
