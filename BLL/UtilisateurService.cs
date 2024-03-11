using DAL.Entity;
using DAL.Repos;
using Models.Auth;
using Models.Utilisateur;


namespace BLL
{
    public class UtilisateurService
    {
        public void CreateUtilisateur(UtilisateurCreateVM utilisateurvm)
        {
            Utilisateur utilisateur = new Utilisateur
            {
                Adress = utilisateurvm.Adress, Telephone = utilisateurvm.Telephone, Email = utilisateurvm.Email, Nom = utilisateurvm.Nom, Prenom = utilisateurvm.Prenom, Admin = utilisateurvm.Admin, Password = utilisateurvm.Password
            };

            UtilisateurRepo usr =  new UtilisateurRepo();
            usr.Create(utilisateur);


        }
        public List<UtilisateurListVM> ToList()
        {
            var usr = new UtilisateurRepo();

            var list = new List<UtilisateurListVM>();
            foreach (var item in usr.All())
            {
                UtilisateurListVM utilisateurListVM = new UtilisateurListVM()
                {
                    Id = item.Id,
                    Nom = item.Nom,
                    Prenom = item.Prenom,
                    Admin = item.Admin

                };
                list.Add(utilisateurListVM);

            }
            return list;
        }
        public UtilisateurDetailVM GetDetailVM(int Id)
        {
            var utilisateurrepo = new UtilisateurRepo();
            var item = utilisateurrepo.Read(Id);
            var detail = new UtilisateurDetailVM
            {
                Id = item.Id,
                Adress = item.Adress,
                Telephone = item.Telephone,
                Email = item.Email,
                Nom = item.Nom,
                Prenom = item.Prenom,
                Admin = item.Admin

            };
            return detail;

        }
        public void Delete(int Id)
        {
            var utilisateurrepo = new UtilisateurRepo();
            utilisateurrepo.Delete(Id);
            

        }
        public UserSession? VerifierCompte(UserAuthVM obj)
        {
            UtilisateurRepo utilisateurRepos = new UtilisateurRepo();
            var result = utilisateurRepos.All()
                        .FirstOrDefault(a => a.Password  == obj.MotPasse && a.Email == obj.Email);
            if (result != null)
            {
                UserSession userSession = new UserSession();
                userSession.AdresseMail = result.Email;
                userSession.Id = result.Id;
                userSession.Nom = result.Nom;
                userSession.Adress = result.Adress;
                userSession.Telephone = result.Telephone;
                userSession.Prenom = result.Prenom;
                userSession.Admin = result.Admin;

                return userSession;
            }
            return null;
        }
        public UserSession? VerifierCompteAdmin(UserAuthVM obj)
        {
            UtilisateurRepo utilisateurRepos = new UtilisateurRepo();
            var result = utilisateurRepos.All()
                        .FirstOrDefault(a => a.Password == obj.MotPasse && a.Email == obj.Email);
            if (result != null && result.Admin == true)
            {
                
                    UserSession userSession = new UserSession();
                    userSession.AdresseMail = result.Email;
                    userSession.Id = result.Id;
                    userSession.Nom = result.Nom;
                    userSession.Adress = result.Adress;
                    userSession.Telephone = result.Telephone;
                    userSession.Prenom = result.Prenom;
                    userSession.Admin = result.Admin;

                    return userSession;
                
            }
            return null;
        }
        public void UpdateProfile(UtilisateurUpdateProfileVM utilisateurUpdateProfileVM)
        {
            UtilisateurRepo utilisateurRepo = new UtilisateurRepo();
            var usr = utilisateurRepo.Read(utilisateurUpdateProfileVM.Id);
            
            {
                
                usr.Nom = utilisateurUpdateProfileVM.Nom;
                usr.Password = utilisateurUpdateProfileVM.Password;
                usr.Prenom = utilisateurUpdateProfileVM.Prenom;
                usr.Email = utilisateurUpdateProfileVM.Email;

                usr.Adress = utilisateurUpdateProfileVM.Adress;
                usr.Telephone = utilisateurUpdateProfileVM.Telephone;
                usr.Admin = utilisateurUpdateProfileVM.Admin;

            };
            utilisateurRepo.Update(usr);
            
        }
        public UtilisateurUpdateProfileVM Edit(int Id)
        {
            var utilisateurrepo = new UtilisateurRepo();
            var item = utilisateurrepo.Read(Id);
            var profile = new UtilisateurUpdateProfileVM
            {
                Id = item.Id,
                Adress = item.Adress,
                Telephone = item.Telephone,
                Email = item.Email,
                Nom = item.Nom,
                Prenom = item.Prenom,
                Password = item.Password,
                Admin = item.Admin
                

            };
            return profile;

        }

    }
}
