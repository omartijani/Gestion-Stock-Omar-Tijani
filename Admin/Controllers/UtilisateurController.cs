using BLL;
using Microsoft.AspNetCore.Mvc;
using Models.Produit;
using Models.Utilisateur;

namespace Admin.Controllers
{
    public class UtilisateurController : Controller
    {
        public IActionResult Index()
        {
            UtilisateurService service = new UtilisateurService();
            return View(service.ToList());
        }
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
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(UtilisateurCreateVM model)
        {
            if (ModelState.IsValid)
            {

                var pro = new UtilisateurService();
                pro.CreateUtilisateur(model);

                return RedirectToAction("Index");
            }


            return View(model);
        }
        public IActionResult Delete(int id)
        {
            UtilisateurService service = new UtilisateurService();
            service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
