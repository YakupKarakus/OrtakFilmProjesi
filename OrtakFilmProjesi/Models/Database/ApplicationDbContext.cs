using Microsoft.EntityFrameworkCore;

namespace OrtakFilmProjesi.Models.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
    }
}
