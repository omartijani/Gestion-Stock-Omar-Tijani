using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    [Table("T_Stock")]

    public class Stock
    {
        [Key]
        
        public int Id { get; set; }
        public int IdProduit { get; set; }
       
        public int Quantite { get; set; }
        public int Prix { get; set; }



    }
}
