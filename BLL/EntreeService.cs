using DAL.Entity;
using DAL.Repos;
using Models.Entree;


namespace BLL
{
    public class EntreeService
    {
        public void CreateEntree(EntreeCreateVM entr)
        {
            Entree Entree = new Entree();
            Entree.IdUtilisateur = entr.IdUtilisateur;
            Entree.Quantite = entr.Quantite;
            Entree.PrixEntree = entr.PrixEntree;
            Entree.IdProduit = entr.IdProduit;
            Entree.DateEntree = entr.DateEntree;


            EntreeRepo sor = new EntreeRepo();
            sor.Create(Entree);
            StockService st = new StockService();
            st.Update(entr.IdProduit);


        }
        public List<EntreeListVM> ToList()
        {
            var sor = new EntreeRepo();

            var list = new List<EntreeListVM>();
            foreach (var item in sor.All())
            {
                EntreeListVM EntreeListVM = new EntreeListVM()
                {
                    Id = item.Id,
                    DateEntree = item.DateEntree,
                    IdProduit = item.IdProduit,
                    
                    PrixEntree = item.PrixEntree,
                    Quantite = item.Quantite
                };
                list.Add(EntreeListVM);

            }
            return list;
        }

        public EntreeDetailVm GetDetailVM(int Id)
        {
            var entreeRepo = new EntreeRepo();
            var ent = entreeRepo.Read(Id);
            var detail = new EntreeDetailVm
            {
                Id = Id,
                IdProduit = ent.IdProduit,
                IdUtilisateur = ent.IdUtilisateur,
                DateEntree = ent.DateEntree,
                PrixEntree= ent.PrixEntree,
                Quantite = ent.Quantite

            };
            return detail;

        }
    }
}
