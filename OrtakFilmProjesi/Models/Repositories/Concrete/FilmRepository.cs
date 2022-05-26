using OrtakFilmProjesi.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrtakFilmProjesi.Models.Repositories.Concrete
{
    public class FilmRepository : Genericrepository<Film>
    {
        private readonly ApplicationDbContext db;

        public FilmRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
