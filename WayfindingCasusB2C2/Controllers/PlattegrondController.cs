using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;
using WayfindingCasusB2C2.Data;
using WayfindingCasusB2C2.Models;

namespace WayfindingCasusB2C2.Controllers
{
    public class PlattegrondController : Controller
    {
        private readonly ConnectionStringClass _cc;

        public PlattegrondController( ConnectionStringClass cc)
        {
            _cc = cc;
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
        public IActionResult Add(Gebruiker gebruiker)
        {
            _cc.Add(gebruiker);
            _cc.SaveChanges();
            ViewBag.message= "De data" +gebruiker.GebruikerNaam + "Is opgeslagen";
            return View();
        }

    }

}
    
  
      