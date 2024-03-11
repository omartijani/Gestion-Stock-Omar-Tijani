using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    [Table("T_Produit")]

    public class Produit
    {
        [Key]
        
        public int Id { get; set; }
             
        
        public string Nom { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;



    }
}
