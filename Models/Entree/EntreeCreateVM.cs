using Models.Produit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entree
{
    public class EntreeCreateVM
    {
        [Required(ErrorMessage = "Produit ID is required.")]
        public int IdProduit { get; set; }

        [Required(ErrorMessage = "Utilisateur ID is required.")]
        public int IdUtilisateur { get; set; }

        [Required(ErrorMessage = "Prix Entree is required.")]
        public int PrixEntree { get; set; }

        [Required(ErrorMessage = "Date Entree is required.")]
        [DataType(DataType.Date)]
        public DateTime DateEntree { get; set; }

        [Required(ErrorMessage = "Quantite is required.")]
        public int Quantite { get; set; }
        


    }
}
