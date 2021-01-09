using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalTrainerProject.Models
{
    public class Produs
    {
        public int ID { get; set; }
        [Required]
        public string Denumire { get; set; }
        [Required]
        [Range(50, 500)]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }
        public ICollection<Client> Clienti { get; set; }
        public int SuplimentID { get; set; }
        [Display(Name = "Supliment Recomandat")]
        public Supliment Supliment { get; set; }
    }
}
