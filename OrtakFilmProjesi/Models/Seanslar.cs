using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrtakFilmProjesi.Models
{
    public enum SeansTime
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

    public class Seanslar:BaseEntity
    {
        public Seanslar()
        {
            Filmler = new HashSet<Film>();
        }
        
        [DataType(DataType.Date)]
        [Required]
        [Display(Name ="Tarih")]
        public DateTime Date { get; set; }
        [Display(Name ="Seans")]
        public SeansTime seans { get; set; }
        public ICollection<Film> Filmler { get; set; }

    }
}
