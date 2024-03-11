using DAL.Entity;
using DAL.Repos;
using Models.Produit;
using Models.Sortie;
using Models.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProduitService
    {
        public void CreateProduit(ProduitCreateVM model)
        {
            Produit produit = new Produit
            {
                Nom = model.Nom,
                Image = model.Image,
               

            };

            ProduitRepo pro = new ProduitRepo();
            pro.Create(produit);


        }
        public List<ProduitListVM> ToList()
        {
            var pro = new ProduitRepo();

            var list = new List<ProduitListVM>();
            foreach (var item in pro.All())
            {
                ProduitListVM produitListVM = new ProduitListVM()
                {
                    Nom = item.Nom,
                    Image = item.Image,
                    Id = item.Id
                };
                list.Add(produitListVM);

            }
            return list;
        }
        public ProduitDetailVM GetDetailVM(int Id)
        {
            var Stockrepo = new StockRepo();
            var prod = Stockrepo.GetStockByProduitId(Id);
            var Produitrepo = new ProduitRepo();
            var pro = Produitrepo.Read(Id);
            var detail = new ProduitDetailVM
            {   Id = Id,
                Price= prod.Prix,
                Quantite = prod.Quantite,
                Nom = pro.Nom,
                Image = pro.Image
            };
            return detail;

        }
        public void Delete(int Id)
        {
            var Produitrepo = new ProduitRepo();
            var stockrepo = new StockRepo();
            var stockservice = new StockService();
            var entreerepo = new EntreeRepo();
            var sortierepo = new SortieRepo();
           var stk= stockrepo.GetStockByProduitId(Id);
            if (stk != null)
            {
                var detail = stockservice.GetDetailVM(stk.Id);
                var ent = detail.IdEntrees;
                var srt = detail.IdSorties;

                foreach (var s in srt)
                {
                    sortierepo.Delete(s);
                }
                foreach (var s in ent)
                {
                    entreerepo.Delete(s);
                }
                stockrepo.Delete(stk.Id);
            }
            Produitrepo.Delete(Id);

        }


    }
}
