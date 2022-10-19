using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Headers;
using WayfindingCasusB2C2.Data;
using WayfindingCasusB2C2.Models;
using Route = WayfindingCasusB2C2.Models.Route;

namespace WayfindingCasusB2C2.Controllers
{
    public class PlattegrondController : Controller
    {

        private AppDbContext context { get; }
        public PlattegrondController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            

            var bedrijfdetail = new BedrijfDetail()
            {
                
                BedrijfNaam = "APG",
                BedrijfEigenaar = "Anette Mosman",
                BedrijfMedewerkers = 100,
                BedrijfDoelen = "Mensen een mooi pensien geven",
                BedrijfOpgerichtJaar = 2008,
                BedrijfBeschrijving = "Pensioenfondsregelaar"
            };
            context.Add(bedrijfdetail);
            context.SaveChanges();

            var bedrijf = new Bedrijf() { BedrijfDetail = bedrijfdetail };
            context.Add(bedrijf);
            context.SaveChanges();

            var ruimte = new Ruimte()
            {
                
                RuimteBezet = true,
                RuimteBezoekers = 10,
                RuimteOppervlakte = 200,
            };
            context.Add(ruimte);
            context.SaveChanges();

            var gebruiker = new Gebruiker() { 
                
                GebruikerNaam = "Jack Peters",
                Bedrijf = bedrijf,
                GebruikerLeeftijd = 52,
                GebruikerEmail = "J.Peters@Hotmail.com",
                GebruikerGeslacht = "Man",
                Ruimte = ruimte
            };
            context.Add(gebruiker);
            context.SaveChanges();

            var legenda = new Legenda()
            {
                
                LegendaBeschrijving = "Trap",
                LegendaItem = 1
            };
            context.Add(legenda);
            context.SaveChanges();

            var route = new Route()
            {
                
                RouteBeschrijving = "placeholder",
                LocatieId = 1
            };
            context.Add(route);
            context.SaveChanges();

            var plattegrond = new Plattegrond()
            {

                PlattegrondVerdieping = 1,
                Legenda = legenda,
                Route = route,
                Ruimte = ruimte,
                Bedrijf = bedrijf,
            };
            context.Add(plattegrond);
            context.SaveChanges();

            return View();
        }

        
        
    }
}
