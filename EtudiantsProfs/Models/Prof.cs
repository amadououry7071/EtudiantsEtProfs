using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EtudiantsProfs.Models
{
    public class Prof
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Cour { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Veuillez entrer une adresse email valide")]
        public string Email { get; set; }

        [Required]
        public string MotDePasse { get; set; }
    }
}