using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Stock
{
    public class StockDetailVM
    {
        public int Id { get; set; }
        public string Img { get; set; } = string.Empty;
        public int IdProduit { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<int> IdEntrees { get; set; }
        public List<int> IdSorties { get; set; }
        public int Quantite { get; set; }
        public int Prix { get; set; }
        

    }
   
}
