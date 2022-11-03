using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using WayfindingCasusB2C2.Data;
using WayfindingCasusB2C2.Models;

namespace WayfindingCasusB2C2.Controllers
{
   
    public class BedrijfController : Controller
    {
      
        private AppDbContext context { get; }
        public BedrijfController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
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

        //public IActionResult Edit(int? edit)
        //{
        //    if (edit == null || edit == 0)
        //    {
        //        return NotFound();
        //    }
        //    var data = context.BedrijfDetails.FirstOrDefault(x => x.BedrijfDetailsId == edit);

        //    if (data == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(data);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]

        //public IActionResult Edit(BedrijfDetail data)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        context.BedrijfDetails.Update(data);
        //        context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}



    }


}
