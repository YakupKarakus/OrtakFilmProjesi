using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrtakFilmProjesi.Models
{
    public class Category:BaseEntity
    {
        public Category()
        {
            Films = new HashSet<Film>();
        }
        

        [Display(Name="Ad")]
        [Required]
        [MinLength(3, ErrorMessage = "Kategori Adı en az 3 karakter olmalıdır.")]
        public string Name { get; set; }
        public ICollection<Film> Films { get; set; }
    }
}
