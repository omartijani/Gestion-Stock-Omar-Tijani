using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Sortie;

namespace App.Controllers
{
    [Authorize]

    public class SortieController : Controller
    {
        public IActionResult Index()
        {
            SortieSerivice sortie = new SortieSerivice();
            return View(sortie.ToList());
        }
        public IActionResult Detail(int id)
        {
            SortieSerivice sortie = new SortieSerivice();
            return View(sortie.GetDetailVM(id));
        }
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Create(SortieCreateVM model)
        {
            if (ModelState.IsValid)
            {
                
                SortieSerivice sortie = new SortieSerivice();

                sortie.CreateSortie(model);

                
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
