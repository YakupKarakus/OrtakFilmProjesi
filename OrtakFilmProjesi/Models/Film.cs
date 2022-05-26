using System.Collections.Generic;

namespace OrtakFilmProjesi.Models
{
    public class Film
    {
        public Film()
        {
            seanslars=new HashSet<Seanslar>();
            categories=new HashSet<Category>(); 
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoPath { get; set; }
        public ICollection<Seanslar> seanslars { get; set; }
        public ICollection<Category> categories { get; set; }
    }
}
