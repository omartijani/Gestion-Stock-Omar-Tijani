using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity

{
    [Table("T_Utilisateur")]

    public class Utilisateur
    {
        [Key]
        
        public int Id { get; set; }
        

        public string Nom { get; set; } = string.Empty;
        [MaxLength(200)]

        public string Prenom { get; set; } = string.Empty;


        public string Adress { get; set; } = string.Empty;
        [MinLength(10)]


        public long Telephone { get; set; }

        public string Email { get; set; } = string.Empty;
        public string Password {get; set; } = string.Empty;
        public bool Admin { get; set; }

    }
}
