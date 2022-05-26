using System.ComponentModel.DataAnnotations;

namespace OrtakFilmProjesi.Models
{
    public class User
    {
        [Display(Name ="Kullanıcı Kodu")]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
