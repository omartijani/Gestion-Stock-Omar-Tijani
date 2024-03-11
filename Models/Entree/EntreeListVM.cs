using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entree
{
    public class EntreeListVM
    {
        public int Id { get; set; }
        public int IdProduit { get; set; }
        public int PrixEntree { get; set; }
        public DateTime DateEntree { get; set; }
        public int Quantite { get; set; }
    }
}
