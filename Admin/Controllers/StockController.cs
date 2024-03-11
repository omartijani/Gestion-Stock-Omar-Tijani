using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Admin.Controllers
{
    [Authorize]

    public class StockController : Controller
    {
        public IActionResult Index()
        {
            StockService stockService = new StockService(); 
            return View(stockService.ToList());
        }
        public IActionResult Detail(int id) { 
            StockService stockService = new StockService();
            
            return View(stockService.GetDetailVM(id));
        }
        
    }
    
}
