using DAL.Entity;
using DAL.Repos;
using Models.Entree;
using Models.Sortie;

namespace BLL
{
    public class SortieSerivice
    {
        public void CreateSortie(SortieCreateVM sort)
        {
            
            Sortie sortie = new Sortie();
            sortie.IdUtilisateur = sort.IdUtilisateur;
            sortie.Quantite = sort.Quantite;
            sortie.PrixSortie = sort.PrixSortie;
            sortie.IdProduit =  sort.IdProduit;
            sortie.DateSortie = sort.DateSortie;
            
            SortieRepo sor = new SortieRepo();
            sor.Create(sortie);
            StockService stckService = new StockService();
            stckService.Update(sort.IdProduit);


        }
        public List<SortieListVM> ToList()
        {
            var sor = new SortieRepo();

            var list = new List<SortieListVM>();
            foreach(var item in sor.All())
            {
                SortieListVM sortieListVM = new SortieListVM()
                {
                    Id = item.Id,
                    DateSortie = item.DateSortie,
                    IdProduit = item.IdProduit,
                    
                    PrixSortie = item.PrixSortie,
                    Quantite = item.Quantite
                };
                list.Add(sortieListVM);
                
            }
            return list;
        }

        public SortieDetailVM GetDetailVM(int Id)
        {
            var sortieRepo = new SortieRepo();
            var ent = sortieRepo.Read(Id);
            var detail = new SortieDetailVM
            {
                Id = Id,
                IdProduit = ent.IdProduit,
                IdUtilisateur = ent.IdUtilisateur,
                DateSortie = ent.DateSortie,
                PrixSortie = ent.PrixSortie,
                Quantite = ent.Quantite

            };
            return detail;

        }

    }
}