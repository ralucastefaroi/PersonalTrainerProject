using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalTrainerProject.Models
{
    public class Supliment
    {
        public int ID { get; set; }
        [Required]
        public string Denumire { get; set; }
        [Required]
        [Display(Name = "Cantitate (KG)")]
        public int Cantitate { get; set; }
        [Display(Name = "Pret (RON)")]
        [Range(50, 500)]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public Produs Produs { get; set; }
    }
}
