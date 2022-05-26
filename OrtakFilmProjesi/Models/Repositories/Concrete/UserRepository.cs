using OrtakFilmProjesi.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrtakFilmProjesi.Models.Repositories.Concrete
{
    public class UserRepository : Genericrepository<User>
    {
        private readonly ApplicationDbContext db;

        public UserRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
