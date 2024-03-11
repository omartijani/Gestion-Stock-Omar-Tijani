using BLL;
using Microsoft.AspNetCore.Mvc;
using Models.Utilisateur;

namespace App.Controllers
{
    public class UtilisateurController : Controller
    {
        public IActionResult Detail(int id)
        {
            UtilisateurService UtilisateurService = new UtilisateurService();
            return View(UtilisateurService.GetDetailVM(id));
        }
        [HttpGet]
        public IActionResult Edit(int id) { 
            UtilisateurService utilisateurService = new UtilisateurService();
            return View(utilisateurService.Edit(id));
        }
        [HttpPost]
        public IActionResult UpdateProfile(UtilisateurUpdateProfileVM model)
        {
            if (model !=null)
            {

                UtilisateurService utilisateurService = new UtilisateurService();
                utilisateurService.UpdateProfile(model);

                return RedirectToAction("Detail", new {Id=model.Id});
            }


            return View(model);
        }

    }
}
