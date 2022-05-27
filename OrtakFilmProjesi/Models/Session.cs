using OrtakFilmProjesi.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrtakFilmProjesi.Models
{  
    public class Session:BaseEntity
    {
        public Session()
        {
            Films = new HashSet<Film>();
        }
        
        [DataType(DataType.Date)]
        [Required]
        [Display(Name ="Tarih")]
        public DateTime Date { get; set; }
        public float Discount { get; set; }
        [Display(Name ="Seans")]
        [EnumDataType(typeof(SessionTimeEnum))]
        public SessionTimeEnum SessionTime { get; set; }
        public ICollection<Film> Films { get; set; }

    }
}
