using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrtakFilmProjesi.Models
{
    public class Film:BaseEntity
    {
        public Film()
        {
            seanslars=new HashSet<Seanslar>();
            categories=new HashSet<Category>(); 
        }
       
        [Display(Name = "Ad")]
        [Required]
        [MinLength(5, ErrorMessage = "Film Adı en az 5 karakter olmalıdır.")]
        public string Name { get; set; }
        [Display(Name="Fotoğraf Yolu")]
        public string PhotoPath { get; set; }
        [Display(Name="Seanslar")]
        public ICollection<Seanslar> seanslars { get; set; }
        [Display(Name="Kategoriler")]
        public ICollection<Category> categories { get; set; }
    }
}
