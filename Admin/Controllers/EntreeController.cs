using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Entree;

namespace   Admin.Controllers
{
    [Authorize]

    public class EntreeController : Controller
    {
        public IActionResult Index()
        {
            EntreeService entreeService = new EntreeService();
            return View(entreeService.ToList());
        }
        public IActionResult Detail(int id)
        {
            EntreeService entreeService = new EntreeService();
            return View(entreeService.GetDetailVM(id));
        }
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Create(EntreeCreateVM model)
        {
            if (ModelState.IsValid)
            {
                
                var entreeService = new EntreeService();
                entreeService.CreateEntree(model);

                return RedirectToAction("Index");
            }

            
            return View(model);
        }
    }
}
