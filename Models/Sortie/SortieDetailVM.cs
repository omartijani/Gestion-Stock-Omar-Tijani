using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Sortie
{
    public class SortieDetailVM
    {
        public int Id { get; set; }
        public int IdProduit { get; set; }
       
        public int IdUtilisateur { get; set; }
        public int PrixSortie { get; set; }
        public DateTime DateSortie { get; set; }
        public int Quantite { get; set; }
    }
}
