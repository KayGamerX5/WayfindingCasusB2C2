using Microsoft.AspNetCore.Mvc;
using WayfindingCasusB2C2.Data;
using WayfindingCasusB2C2.Models;

namespace WayfindingCasusB2C2.Controllers
{
    public class RuimteController : Controller
    {

        private AppDbContext context { get; }
        public RuimteController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ruimte ruimte)
        {
            context.Add(ruimte);
            context.SaveChanges();
            ViewBag.message = "De data is opgeslagen";
            return View();
        }

    }
}
