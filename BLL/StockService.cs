using DAL.Entity;
using DAL.Repos;
using Models.Entree;
using Models.Sortie;
using Models.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StockService
    {
        public List<StockListVM> ToList()
        {
            var list = new List<StockListVM>();
            var stockrepo = new StockRepo(); 
            var prorepo = new ProduitRepo();


            foreach (var item in stockrepo.All())
            {
                var pro = prorepo.Read(item.IdProduit);

                StockListVM stockList = new StockListVM
                {
                    

                    Id = item.Id,
                    Img = pro.Image,
                    Name = pro.Nom,
                    IdProduit = item.IdProduit,
                    Quantite = item.Quantite,
                    Prix = item.Prix
                };
                list.Add(stockList);
            }
            
            return list;
        }
        public StockDetailVM GetDetailVM(int Id)
        {
            var stockrepo = new StockRepo();
            var sor = new SortieRepo();
            var ent = new EntreeRepo();
            var stk = stockrepo.Read(Id);
            List<Entree> entrees = ent.All().ToList();
            List<Sortie> sorties = sor.All().ToList();
            var prorepo = new ProduitRepo();
            var pro = prorepo.Read(stk.IdProduit);
            var detail = new StockDetailVM
            {   
                Id = stk.Id,
                Img = pro.Image,
                Name = pro.Nom,
                IdProduit = stk.IdProduit,
                IdEntrees = entrees.Where(e => e.IdProduit == stk.IdProduit).Select(e => e.Id).ToList(),
                IdSorties = sorties.Where(s => s.IdProduit == stk.IdProduit).Select(s => s.Id).ToList(),
                Quantite = stk.Quantite,
                Prix = stk.Prix
            };
            return detail;
            
        }
        public void Create (EntreeCreateVM entree)
        {
            var stockrepo = new StockRepo();
            Stock stock = new Stock
            {
                Prix = entree.PrixEntree,
                Quantite=entree.Quantite,
                IdProduit=entree.IdProduit
            };
            stockrepo.Create(stock);
        }
        

        public void Delete(int id)
        {
            StockRepo stockrepo = new StockRepo();
            stockrepo.Delete(id);
        }
        public void Update (int IdProduit)
        {
            var stockrepo = new StockRepo();
            var sortierepo = new SortieRepo();
            var entreerepo = new EntreeRepo();
            Stock stock = new Stock();
            var totalQE = 0;
            var prixT = 0;
            var prixU = 0;
            foreach (var item in entreerepo.All().Where(e => e.IdProduit == IdProduit))
            {
                totalQE += item.Quantite;
                var prixtt = item.Quantite * item.PrixEntree;
                
                prixT += prixtt;
                prixU = prixT / totalQE;
                
            }
            var totalQS = 0;
            
            foreach (var item in sortierepo.All().Where(e => e.IdProduit == IdProduit))
            {
                totalQS += item.Quantite;
                
            }
           
            var stk = stockrepo.GetAllStocksByProduitId(IdProduit);
            foreach (var item in stk)
            {
                stockrepo.Delete(item.Id);

            }

            stock.Quantite = totalQE - totalQS;
            stock.Prix=prixU;
            stock.IdProduit = IdProduit;
            stockrepo.Create(stock);
            if (stock.Quantite <= 0) {
            stockrepo.Delete(stock.Id);
                    }

        }
        
        
    }
}
