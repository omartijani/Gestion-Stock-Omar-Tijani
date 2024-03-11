using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Produit
{
    public class ProduitDetailVM
    {
        public int Id { get; set; }
       public int Quantite {  get; set; }
        public int Price { get; set; }
        public string Nom { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
    }
}
