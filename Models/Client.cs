using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalTrainerProject.Models
{
    public class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]

        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Introduceti un nume valid.")]
        public string Nume { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Introduceti un prenume valid.")]
        [Required]
        public string Prenume { get; set; }
        [Required]
        [Range(14, 120)]

        public int Varsta { get; set; }
        [Display(Name = "Greutate (Kg)")]
        [Required]
        public int Greutate { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        public int ProdusID { get; set; }
        [Display(Name = "Produs Achizitionat")]
        public Produs Produs { get; set; }
    }
}
