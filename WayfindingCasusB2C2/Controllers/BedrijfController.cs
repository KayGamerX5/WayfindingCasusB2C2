using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using WayfindingCasusB2C2.Data;
using WayfindingCasusB2C2.Models;
using Microsoft.AspNetCore.Http;

namespace WayfindingCasusB2C2.Controllers
{
   
    public class BedrijfController : Controller
    {
      
        private AppDbContext context { get; }
        public BedrijfController(AppDbContext context)
        {
            this.context = context;
        }

      
        
        public IActionResult Bedrijf1()
        {
                var detail = context.BedrijfDetails.FirstOrDefault(x => x.BedrijfDetailsId == 1);
                return View(detail);
            
        }

        public IActionResult Bedrijf2()
        {
            var detail = context.BedrijfDetails.FirstOrDefault(x => x.BedrijfDetailsId == 2);
            return View(detail);

        }
        public IActionResult Bedrijf3()
        {
            var detail = context.BedrijfDetails.FirstOrDefault(x => x.BedrijfDetailsId == 3);
            return View(detail);

        }
        public IActionResult Bedrijf4()
        {
            var detail = context.BedrijfDetails.FirstOrDefault(x => x.BedrijfDetailsId == 4);
            return View(detail);

        }
        public IActionResult Bedrijf5()
        {
            var detail = context.BedrijfDetails.FirstOrDefault(x => x.BedrijfDetailsId == 5);
            return View(detail);

        }
        public IActionResult Bedrijf6()
        {
            var detail = context.BedrijfDetails.FirstOrDefault(x => x.BedrijfDetailsId == 6);
            return View(detail);

        }
        public IActionResult Bedrijf7()
        {
            var detail = context.BedrijfDetails.FirstOrDefault(x => x.BedrijfDetailsId == 7);
            return View(detail);

        }
        public IActionResult Bedrijf8()
        {
            var detail = context.BedrijfDetails.FirstOrDefault(x => x.BedrijfDetailsId == 8);
            return View(detail);

        }
        public IActionResult Bedrijf9()
        {
            var detail = context.BedrijfDetails.FirstOrDefault(x => x.BedrijfDetailsId == 9);
            return View(detail);

        }

       public IActionResult Edit(int id)
        {
            var detail = context.BedrijfDetails.Where(y => y.BedrijfDetailsId == id).FirstOrDefault();
      
            return View(detail);
        }

        [HttpPost]
        public IActionResult Edit(BedrijfDetail details, string returnUrl)

        {
         
           
                var detail = context.BedrijfDetails.Where(y => y.BedrijfDetailsId == details.BedrijfDetailsId).FirstOrDefault();
                context.Remove(detail);
                context.Add(details);
                context.SaveChanges();

             
            
             
                return RedirectToAction("Plattegrond2", "Plattegrond");
        }
            

    }


}
