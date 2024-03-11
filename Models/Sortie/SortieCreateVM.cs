using Models.Produit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Sortie
{
    public class SortieCreateVM
    {
        [Required(ErrorMessage = "Produit ID is required.")]
        public int IdProduit { get; set; }

        [Required(ErrorMessage = "Utilisateur ID is required.")]
        public int IdUtilisateur { get; set; }

        [Required(ErrorMessage = "Prix Sortie is required.")]
        public int PrixSortie { get; set; }

        [Required(ErrorMessage = "Date Sortie is required.")]
        [DataType(DataType.DateTime)]
        public DateTime DateSortie { get; set; }

        [Required(ErrorMessage = "Quantite is required.")]
        public int Quantite { get; set; }
       
    }
}
