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

            //var DataCheck = context.BedrijfDetails.FirstOrDefault(x => x.BedrijfDetailsId == 1);
            //var bedrijfdetail = new BedrijfDetail();
            //var bedrijf = new Bedrijf();
            //var ruimte = new Ruimte();
            //var gebruiker = new Gebruiker();
            //var legenda = new Legenda();
            //var route = new Route();
            //var plattegrond = new Plattegrond();
            

            //BedrijfDetail bedrijfdetail1 = context.BedrijfDetails.Where(x => x.BedrijfDetailsId == 1).FirstOrDefault();
            //Ruimte ruimte1 = context.Ruimtes.Where(x => x.RuimteId == 1).FirstOrDefault();
            //Gebruiker gebruiker1 = context.Gebruikers.Where(x => x.GebruikerId == 1).FirstOrDefault();
            //Legenda legenda1 = context.Legendas.Where(x => x.LegendaId == 1).FirstOrDefault();
            //Route route1 = context.Routes.Where(x => x.RouteId == 1).FirstOrDefault();
            //Plattegrond plattegrond1 =  context.Plattegronden.Where(x => x.PlattegrondId == 1).FirstOrDefault();

            //BedrijfDetail bedrijfdetail2 = context.BedrijfDetails.Where(x => x.BedrijfDetailsId == 2).FirstOrDefault();
            //BedrijfDetail bedrijfdetail3 = context.BedrijfDetails.Where(x => x.BedrijfDetailsId == 3).FirstOrDefault();
            //BedrijfDetail bedrijfdetail4 = context.BedrijfDetails.Where(x => x.BedrijfDetailsId == 4).FirstOrDefault();
            //BedrijfDetail bedrijfdetail5 = context.BedrijfDetails.Where(x => x.BedrijfDetailsId == 5).FirstOrDefault();
            //BedrijfDetail bedrijfdetail6 = context.BedrijfDetails.Where(x => x.BedrijfDetailsId == 6).FirstOrDefault();
            //BedrijfDetail bedrijfdetail7 = context.BedrijfDetails.Where(x => x.BedrijfDetailsId == 7).FirstOrDefault();

            //if (bedrijfdetail1 != null)
            //{

            //}

            //else
            //{
            //    bedrijfdetail = new BedrijfDetail()
            //    {

            //        BedrijfNaam = "APG",
            //        BedrijfEigenaar = "Anette Mosman",
            //        BedrijfMedewerkers = 100,
            //        BedrijfDoelen = "Mensen een mooi pensien geven",
            //        BedrijfOpgerichtJaar = 2008,
            //        BedrijfBeschrijving = "Pensioenfondsregelaar"
            //    };
            //    context.Add(bedrijfdetail);
            //    context.SaveChanges();

            //    bedrijf = new Bedrijf() { BedrijfDetail = bedrijfdetail };
            //    context.Add(bedrijf);
            //    context.SaveChanges();
            //}

            //if (bedrijfdetail2 != null)
            //{
                
            //}

            //else
            //{
            //    bedrijfdetail = new BedrijfDetail()
            //    {
            //        BedrijfNaam = "Accenture",
            //        BedrijfEigenaar = "Julie Sweet",
            //        BedrijfMedewerkers = 10000,
            //        BedrijfDoelen = "Mensen in goede banen leiden met consultancy",
            //        BedrijfOpgerichtJaar = 1989,
            //        BedrijfBeschrijving = "Consultancybureau"
            //    };
            //    context.Add(bedrijfdetail);
            //    context.SaveChanges();

            //    bedrijf = new Bedrijf() { BedrijfDetail = bedrijfdetail };
            //    context.Add(bedrijf);
            //    context.SaveChanges();
            //}

            //if(bedrijfdetail3 != null)
            //{

            //}

            //else
            //{
            //    bedrijfdetail = new BedrijfDetail()
            //    {
            //        BedrijfNaam = "Block Materials",
            //        BedrijfEigenaar = "Simon Duindam",
            //        BedrijfMedewerkers = 10,
            //        BedrijfDoelen = "Eigendomsrechten toekennen aan materialen in vastgoed om een circulaire keten op te zetten",
            //        BedrijfOpgerichtJaar = 2017,
            //        BedrijfBeschrijving = "Bedrijf dat met blockchain eigendomsrechten vastlegt"

            //    };
            //    context.Add(bedrijfdetail);
            //    context.SaveChanges();
            //    bedrijf = new Bedrijf() { BedrijfDetail = bedrijfdetail };
            //    context.Add(bedrijf);
            //    context.SaveChanges();
            //}

            //if (bedrijfdetail4 != null)
            //{

            //}

            //else
            //{
            //    bedrijfdetail = new BedrijfDetail()
            //    {
            //        BedrijfNaam = "CBS",
            //        BedrijfEigenaar = "Angelique Berg",
            //        BedrijfMedewerkers = 2000,
            //        BedrijfDoelen = "Statistieken leveren over allerlei aspecten van het leven",
            //        BedrijfOpgerichtJaar = 1899,
            //        BedrijfBeschrijving = "Maakt statistieken over de nederlandse maatschappij"
            //    };
            //    context.Add(bedrijfdetail);
            //    context.SaveChanges();
            //    bedrijf = new Bedrijf() { BedrijfDetail = bedrijfdetail };
            //    context.Add(bedrijf);
            //    context.SaveChanges();
            //}

            //if(bedrijfdetail5 != null)
            //{

            //}

            //else
            //{
            //    bedrijfdetail = new BedrijfDetail()
            //    {
            //        BedrijfNaam = "Conclusion Zuyd",
            //        BedrijfEigenaar = "Marco Bosma",
            //        BedrijfMedewerkers = 75,
            //        BedrijfDoelen = "Bedrijfven helpen overstappen tot moderne, digitale methoden",
            //        BedrijfOpgerichtJaar = 1969,
            //        BedrijfBeschrijving = "Consultancy bedrijf"
            //    };
            //    context.Add(bedrijfdetail);
            //    context.SaveChanges();
            //    bedrijf = new Bedrijf() { BedrijfDetail = bedrijfdetail };
            //    context.Add(bedrijf);
            //    context.SaveChanges();
            //}

            //if(bedrijfdetail6 != null)
            //{

            //}

            //else
            //{
            //    bedrijfdetail = new BedrijfDetail()
            //    {
            //        BedrijfNaam = "De Volksbank",
            //        BedrijfEigenaar = "Martijn Gribnau",
            //        BedrijfMedewerkers = 3000,
            //        BedrijfDoelen = "Mensen een plek bieden om hun geld te bewaren en leningen te krijgen",
            //        BedrijfOpgerichtJaar = 1819,
            //        BedrijfBeschrijving = "Bank"
            //    };
            //    context.Add(bedrijfdetail);
            //    context.SaveChanges();
            //    bedrijf = new Bedrijf() { BedrijfDetail = bedrijfdetail };
            //    context.Add(bedrijf);
            //    context.SaveChanges();
            //}

            //if(bedrijfdetail7 != null)
            //{

            //}

            //else
            //{
            //    bedrijfdetail = new BedrijfDetail()
            //    {
            //        BedrijfNaam = "Etil",
            //        BedrijfEigenaar = "Luc Schrijnemakers",
            //        BedrijfMedewerkers = 21,
            //        BedrijfDoelen = "Inzicht leveren op verschillende onderzoeksniveaus om bedrijven helpen keuzes te maken",
            //        BedrijfOpgerichtJaar = 1932,
            //        BedrijfBeschrijving = "Consultancy bedrijf"
            //    };
            //    context.Add(bedrijfdetail);
            //    context.SaveChanges();
            //    bedrijf = new Bedrijf() { BedrijfDetail = bedrijfdetail };
            //    context.Add(bedrijf);
            //    context.SaveChanges();
            //}

            //if (ruimte1 != null)
            //{

            //}

            //else
            //{
            //    ruimte = new Ruimte()
            //    {

            //        RuimteBezet = true,
            //        RuimteBezoekers = 10,
            //        RuimteOppervlakte = 200,
            //    };
            //    context.Add(ruimte);
            //    context.SaveChanges();
            //}

            //if (gebruiker1 != null)
            //{

            //}

            //else
            //{
            //    gebruiker = new Gebruiker()
            //    {

            //        GebruikerNaam = "Jack Peters",
            //        Bedrijf = bedrijf,
            //        GebruikerLeeftijd = 52,
            //        GebruikerEmail = "J.Peters@Hotmail.com",
            //        GebruikerGeslacht = "Man",
            //        Ruimte = ruimte
            //    };
            //    context.Add(gebruiker);
            //    context.SaveChanges();
            //}

            //if (legenda1 != null)
            //{

            //}

            //else
            //{
            //    legenda = new Legenda()
            //    {

            //        LegendaBeschrijving = "Trap",
            //        LegendaItem = 1
            //    };
            //    context.Add(legenda);
            //    context.SaveChanges();
            //}

            //if (route1 != null)
            //{

            //}

            //else
            //{
            //    route = new Route()
            //    {

            //        RouteBeschrijving = "placeholder",
            //        LocatieId = 1
            //    };
            //    context.Add(route);
            //    context.SaveChanges();
            //}

            //if (plattegrond1 != null)
            //{

            //}

            //else
            //{
            //    plattegrond = new Plattegrond()
            //    {

            //        PlattegrondVerdieping = 1,
            //        Legenda = legenda,
            //        Route = route,
            //        Ruimte = ruimte,
            //        Bedrijf = bedrijf,
            //    };
            //    context.Add(plattegrond);
            //    context.SaveChanges();
            //}






            return View();
        }

        public IActionResult Plattegrond2()
        {
            var bedrijfdetail = new BedrijfDetail();
            var bedrijf = new Bedrijf();
            var ruimte = new Ruimte();
            var gebruiker = new Gebruiker();
            var legenda = new Legenda();
            var route = new Route();
            var plattegrond = new Plattegrond();


            BedrijfDetail bedrijfdetail1 = context.BedrijfDetails.Where(x => x.BedrijfDetailsId == 1).FirstOrDefault();
            Ruimte ruimte1 = context.Ruimtes.Where(x => x.RuimteId == 1).FirstOrDefault();
            Gebruiker gebruiker1 = context.Gebruikers.Where(x => x.GebruikerId == 1).FirstOrDefault();
            Legenda legenda1 = context.Legendas.Where(x => x.LegendaId == 1).FirstOrDefault();
            Route route1 = context.Routes.Where(x => x.RouteId == 1).FirstOrDefault();
            Plattegrond plattegrond1 = context.Plattegronden.Where(x => x.PlattegrondId == 1).FirstOrDefault();

            BedrijfDetail bedrijfdetail2 = context.BedrijfDetails.Where(x => x.BedrijfDetailsId == 2).FirstOrDefault();
            BedrijfDetail bedrijfdetail3 = context.BedrijfDetails.Where(x => x.BedrijfDetailsId == 3).FirstOrDefault();
            BedrijfDetail bedrijfdetail4 = context.BedrijfDetails.Where(x => x.BedrijfDetailsId == 4).FirstOrDefault();
            BedrijfDetail bedrijfdetail5 = context.BedrijfDetails.Where(x => x.BedrijfDetailsId == 5).FirstOrDefault();
            BedrijfDetail bedrijfdetail6 = context.BedrijfDetails.Where(x => x.BedrijfDetailsId == 6).FirstOrDefault();
            BedrijfDetail bedrijfdetail7 = context.BedrijfDetails.Where(x => x.BedrijfDetailsId == 7).FirstOrDefault();

            if (bedrijfdetail1 != null)
            {

            }

            else
            {
                bedrijfdetail = new BedrijfDetail()
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

                bedrijf = new Bedrijf() { BedrijfDetail = bedrijfdetail };
                context.Add(bedrijf);
                context.SaveChanges();
            }

            if (bedrijfdetail2 != null)
            {

            }

            else
            {
                bedrijfdetail = new BedrijfDetail()
                {
                    BedrijfNaam = "Accenture",
                    BedrijfEigenaar = "Julie Sweet",
                    BedrijfMedewerkers = 10000,
                    BedrijfDoelen = "Mensen in goede banen leiden met consultancy",
                    BedrijfOpgerichtJaar = 1989,
                    BedrijfBeschrijving = "Consultancybureau"
                };
                context.Add(bedrijfdetail);
                context.SaveChanges();

                bedrijf = new Bedrijf() { BedrijfDetail = bedrijfdetail };
                context.Add(bedrijf);
                context.SaveChanges();
            }

            if (bedrijfdetail3 != null)
            {

            }

            else
            {
                bedrijfdetail = new BedrijfDetail()
                {
                    BedrijfNaam = "Block Materials",
                    BedrijfEigenaar = "Simon Duindam",
                    BedrijfMedewerkers = 10,
                    BedrijfDoelen = "Eigendomsrechten toekennen aan materialen in vastgoed om een circulaire keten op te zetten",
                    BedrijfOpgerichtJaar = 2017,
                    BedrijfBeschrijving = "Bedrijf dat met blockchain eigendomsrechten vastlegt"

                };
                context.Add(bedrijfdetail);
                context.SaveChanges();
                bedrijf = new Bedrijf() { BedrijfDetail = bedrijfdetail };
                context.Add(bedrijf);
                context.SaveChanges();
            }

            if (bedrijfdetail4 != null)
            {

            }

            else
            {
                bedrijfdetail = new BedrijfDetail()
                {
                    BedrijfNaam = "CBS",
                    BedrijfEigenaar = "Angelique Berg",
                    BedrijfMedewerkers = 2000,
                    BedrijfDoelen = "Statistieken leveren over allerlei aspecten van het leven",
                    BedrijfOpgerichtJaar = 1899,
                    BedrijfBeschrijving = "Maakt statistieken over de nederlandse maatschappij"
                };
                context.Add(bedrijfdetail);
                context.SaveChanges();
                bedrijf = new Bedrijf() { BedrijfDetail = bedrijfdetail };
                context.Add(bedrijf);
                context.SaveChanges();
            }

            if (bedrijfdetail5 != null)
            {

            }

            else
            {
                bedrijfdetail = new BedrijfDetail()
                {
                    BedrijfNaam = "Conclusion Zuyd",
                    BedrijfEigenaar = "Marco Bosma",
                    BedrijfMedewerkers = 75,
                    BedrijfDoelen = "Bedrijfven helpen overstappen tot moderne, digitale methoden",
                    BedrijfOpgerichtJaar = 1969,
                    BedrijfBeschrijving = "Consultancy bedrijf"
                };
                context.Add(bedrijfdetail);
                context.SaveChanges();
                bedrijf = new Bedrijf() { BedrijfDetail = bedrijfdetail };
                context.Add(bedrijf);
                context.SaveChanges();
            }

            if (bedrijfdetail6 != null)
            {

            }

            else
            {
                bedrijfdetail = new BedrijfDetail()
                {
                    BedrijfNaam = "De Volksbank",
                    BedrijfEigenaar = "Martijn Gribnau",
                    BedrijfMedewerkers = 3000,
                    BedrijfDoelen = "Mensen een plek bieden om hun geld te bewaren en leningen te krijgen",
                    BedrijfOpgerichtJaar = 1819,
                    BedrijfBeschrijving = "Bank"
                };
                context.Add(bedrijfdetail);
                context.SaveChanges();
                bedrijf = new Bedrijf() { BedrijfDetail = bedrijfdetail };
                context.Add(bedrijf);
                context.SaveChanges();
            }

            if (bedrijfdetail7 != null)
            {

            }

            else
            {
                bedrijfdetail = new BedrijfDetail()
                {
                    BedrijfNaam = "Etil",
                    BedrijfEigenaar = "Luc Schrijnemakers",
                    BedrijfMedewerkers = 21,
                    BedrijfDoelen = "Inzicht leveren op verschillende onderzoeksniveaus om bedrijven helpen keuzes te maken",
                    BedrijfOpgerichtJaar = 1932,
                    BedrijfBeschrijving = "Consultancy bedrijf"
                };
                context.Add(bedrijfdetail);
                context.SaveChanges();
                bedrijf = new Bedrijf() { BedrijfDetail = bedrijfdetail };
                context.Add(bedrijf);
                context.SaveChanges();
            }

            if (ruimte1 != null)
            {

            }

            else
            {
                ruimte = new Ruimte()
                {

                    RuimteBezet = true,
                    RuimteBezoekers = 10,
                    RuimteOppervlakte = 200,
                };
                context.Add(ruimte);
                context.SaveChanges();
            }

            if (gebruiker1 != null)
            {

            }

            else
            {
                gebruiker = new Gebruiker()
                {

                    GebruikerNaam = "Jack Peters",
                    Bedrijf = bedrijf,
                    GebruikerLeeftijd = 52,
                    GebruikerEmail = "J.Peters@Hotmail.com",
                    GebruikerGeslacht = "Man",
                    Ruimte = ruimte
                };
                context.Add(gebruiker);
                context.SaveChanges();
            }

            if (legenda1 != null)
            {

            }

            else
            {
                legenda = new Legenda()
                {

                    LegendaBeschrijving = "Trap",
                    LegendaItem = 1
                };
                context.Add(legenda);
                context.SaveChanges();
            }

            if (route1 != null)
            {

            }

            else
            {
                route = new Route()
                {

                    RouteBeschrijving = "placeholder",
                    LocatieId = 1
                };
                context.Add(route);
                context.SaveChanges();
            }

            if (plattegrond1 != null)
            {

            }

            else
            {
                plattegrond = new Plattegrond()
                {

                    PlattegrondVerdieping = 1,
                    Legenda = legenda,
                    Route = route,
                    Ruimte = ruimte,
                    Bedrijf = bedrijf,
                };
                context.Add(plattegrond);
                context.SaveChanges();
            }






            return View();
            
        }

        public IActionResult Plattegrond3()
        {
            return View();
        }

    }
}
