using System.Collections.Generic;

namespace OrtakFilmProjesi.Models
{
    public class Category
    {
        public Category()
        {
            Filmler = new HashSet<Film>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Film> Filmler { get; set; }
    }
}
