using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Utilisateur
{
    public class UtilisateurDetailVM
    {
        public int Id { get; set; }
        

        public string Nom { get; set; } = string.Empty;
       

        public string Prenom { get; set; } = string.Empty;


        public string Adress { get; set; } = string.Empty;


        public long Telephone { get; set; }

        public string Email { get; set; } = string.Empty;
        public bool Admin { get; set; } = false;


    }
}
