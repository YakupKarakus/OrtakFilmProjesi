using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrtakFilmProjesi.Models
{
    public class Film:BaseEntity
    {
        public Film()
        {
            Sessions=new HashSet<Session>();
            Categories=new HashSet<Category>(); 
        }
       
        [Display(Name = "Ad")]
        [Required]
        [MinLength(5, ErrorMessage = "Film Adı en az 5 karakter olmalıdır.")]
        public string Name { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
        [Display(Name= "Fotoğraf Yolu")]
        public string PhotoPath { get; set; }
        [MinLength (50,ErrorMessage = "Açıklama en az 50 karaketer olmalıdır.")]
        [Display(Name = "Açıklamalar")]
        public string Description { get; set; }
        [Display(Name = "Fiyat")]
        [Required]
        public decimal Price { get; set; }
        [Display(Name= "Seanslar")]
        public ICollection<Session> Sessions { get; set; }
        [Display(Name= "Kategoriler")]
        public ICollection<Category> Categories { get; set; }
    }
}
