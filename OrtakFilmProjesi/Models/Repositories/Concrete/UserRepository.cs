using OrtakFilmProjesi.Models.Database;
using OrtakFilmProjesi.Models.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrtakFilmProjesi.Models.Repositories.Concrete
{
    public class UserRepository : Genericrepository<User>,IUserRepository
    {
        private readonly ApplicationDbContext db;

        public UserRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public User GetByMailAndPassword(string mail, string password)
        {
            return db.Users.FirstOrDefault(x => x.Mail == mail && x.Password == password);
        }



    }
}
