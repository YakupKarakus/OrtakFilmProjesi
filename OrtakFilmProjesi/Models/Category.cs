using System.Collections.Generic;

namespace OrtakFilmProjesi.Models
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Filmler = new HashSet<Film>();
        }
        public string Name { get; set; }
        public ICollection<Film> Filmler { get; set; }
    }
}
