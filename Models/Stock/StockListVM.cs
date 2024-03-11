using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Stock
{
    public class StockListVM
    {
        public int Id { get; set; }
        public int IdProduit { get; set; }
        public string Name { get; set; } = string.Empty;
       public string Img { get; set; } = string.Empty;
        public int Quantite { get; set; }
        public int Prix { get; set; }
    }
}
