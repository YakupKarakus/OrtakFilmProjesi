using OrtakFilmProjesi.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrtakFilmProjesi.Models.Repositories.Concrete
{
    public class SeansRepository: Genericrepository<Session>
    {
        private readonly ApplicationDbContext db;

        public SeansRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
