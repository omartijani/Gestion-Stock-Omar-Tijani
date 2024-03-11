using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    [Table("T_Entree")]

    public class Entree
    {
        [Key]
       
        public int Id { get; set; }
        public int IdProduit { get; set; }
        public int IdStock { get; set; }
        public int IdUtilisateur { get; set; }
        public int PrixEntree { get; set; }
        public DateTime DateEntree { get; set; }
        public int Quantite { get; set; }



    }
}
