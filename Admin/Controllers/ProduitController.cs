using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Entree;
using Models.Produit;

namespace Admin.Controllers
{
    [Authorize]

    public class ProduitController : Controller
    {
        public IActionResult Index()
        {
            ProduitService service = new ProduitService();
            return View(service.ToList());
        }
        public IActionResult Detail(int id)
        {   
            ProduitService produitService = new ProduitService();
            return View(produitService.GetDetailVM(id));
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(ProduitCreateVM model)
        {
            if (ModelState.IsValid)
            {

                var pro = new ProduitService();
                pro.CreateProduit(model);

                return RedirectToAction("Index");
            }


            return View(model);
        }
        public IActionResult Delete(int id)
        {
            ProduitService service = new ProduitService();
            service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
