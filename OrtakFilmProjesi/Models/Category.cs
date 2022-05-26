using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrtakFilmProjesi.Models
{
    public class Category
    {
        public Category()
        {
            Filmler = new HashSet<Film>();
        }
        [Display(Name="Kategori Kodu")]
        public int Id { get; set; }

        [Display(Name="Ad")]
        [Required]
        [MinLength(3, ErrorMessage = "Kategori Adı en az 3 karakter olmalıdır.")]
        public string Name { get; set; }
        public ICollection<Film> Filmler { get; set; }
    }
}
