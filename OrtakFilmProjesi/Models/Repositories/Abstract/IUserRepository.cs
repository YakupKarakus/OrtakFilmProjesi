namespace OrtakFilmProjesi.Models.Repositories.Abstract
{
    public interface IUserRepository:IRepository<User>
    {
        User GetByMailAndPassword(string mail, string password);
    }
}
