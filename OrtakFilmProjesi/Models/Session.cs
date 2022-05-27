using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrtakFilmProjesi.Models
{
    public enum SessionTimeEnum
    {
        
        A=11,
        B=12,
        C=13,
        D=14,
        E=15,
        F=16,
        G=17,
        H=18,
        I=19,
        J=20,
        K=21,
        L=22,
        M=23,
        N=24,
    }

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
        public SessionTimeEnum SessionTime { get; set; }
        public ICollection<Film> Films { get; set; }

    }
}
